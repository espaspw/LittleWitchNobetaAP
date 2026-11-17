using HarmonyLib;
using Il2Cpp;
using LittleWitchNobetaAP.Utils;
using MelonLoader;
using Object = UnityEngine.Object;
using UnityEngine;
using Random = System.Random;

namespace LittleWitchNobetaAP.Patches;

public enum TrapType
{
    BonkTrap,
    ManaDrainTrap,
    DarknessTrap,
    ShrinkTrap,
}

// An ActiveEvent represents a game event that should only occur
// when the player has control and isn't in a cutscene or UI menu
internal abstract class ActiveEvent
{
    public abstract override string ToString();
}

internal class TrapEvent : ActiveEvent
{
    public TrapType TrapType { get; }
    public TrapEvent(TrapType type) => TrapType = type;
    public override string ToString() => $"TrapEvent ({TrapType})";
}

internal class GiveItemEvent : ActiveEvent
{
    public ItemSystem.ItemType ItemType { get; }
    public GiveItemEvent(ItemSystem.ItemType itemType) => ItemType = itemType;
    public override string ToString() => $"GiveItemEvent ({ItemType})";
}

// Represents an effect that runs over a period of time (where the timer only ticks when the player has control)
// Time is additive, meaning 3 of the same effect in a row will result in 3 * TrapTime
public abstract class TimedTrapEffect
{
    public float RemainingTime { get; private set; }
    public bool IsActive => RemainingTime > 0;
    public virtual float TrapTime => 30f;

    public void AddTime(float duration)
    {
        if (!IsActive)
        {
            OnApply();
        }

        RemainingTime += duration;
    }

    public void Tick(float deltaTime)
    {
        if (!IsActive) return;

        RemainingTime -= deltaTime;

        if (RemainingTime <= 0)
        {
            RemainingTime = 0;
            OnRevert();
        }
    }

    // Reapply effect if there is still time left but game state was changed/reset
    public void ForceApply()
    {
        if (!IsActive) return;
        OnApply();
    }

    public void ForceRevert()
    {
        if (!IsActive) return;
        RemainingTime = 0;
        OnRevert();
    }

    protected abstract void OnApply();
    protected abstract void OnRevert();
}

// Changes the fog to surround Nobeta in darkness.
// This stores the last fog values, and updates the stored values on any normal changes, to allow a smooth
// revert to the original fog once the trap expires.
public class DarknessTrapEffect : TimedTrapEffect
{
    public static DarknessTrapEffect? Instance { get; private set; }

    private Color _fogColor;
    private float _fogDistanceStart;
    private float _fogDistanceEnd;
    private float _changeFogSpeed;
    private float _changeFogTime;
    public bool IsModifyingFog = false;

    public override float TrapTime => 30f;

    public DarknessTrapEffect()
    {
        Instance = this;
    }

    public void UpdateStoredFog(Color color, float distanceStart, float distanceEnd, float changeSpeed,
        float changeTime)
    {
        // If fog data hasn't been updated in SEM yet, read values directly from RenderSettings.
        // This will happen on stage load before any fog changes.
        if (distanceStart == 0f && distanceEnd == 0f)
        {
            _fogColor = RenderSettings.fogColor;
            _fogDistanceStart = RenderSettings.fogStartDistance;
            _fogDistanceEnd = RenderSettings.fogEndDistance;
        }
        else
        {
            _fogColor = color;
            _fogDistanceStart = distanceStart;
            _fogDistanceEnd = distanceEnd;
            _changeFogSpeed = changeSpeed;
            _changeFogTime = changeTime;
        }
    }

    protected override void OnApply()
    {
        var sem = Singletons.SceneManager.SEM;
        if (sem == null) return;

        UpdateStoredFog(sem.g_FogColor, sem.g_fFogDistanceStart, sem.g_fFogDistanceEnd, sem.g_fChangeFogSpeed,
            sem.g_fChangeFogTime);

        Melon<LwnApMod>.Logger.Msg("Darkness Trap activated: Applying darkness fog and stored previous fog " +
                                   $"(({_fogColor.r}, {_fogColor.g}, {_fogColor.b}, {_fogColor.a}), " +
                                   $"{_fogDistanceStart}, {_fogDistanceEnd}, {_changeFogSpeed}, {_changeFogTime}).");

        IsModifyingFog = true;
        sem.SetChangeFog(new Color(0f, 0f, 0f, 1f), 1f, 10f, 1f, 15f);
        IsModifyingFog = false;
    }

    protected override void OnRevert()
    {
        var sem = Singletons.SceneManager.SEM;
        if (sem == null) return;
        Melon<LwnApMod>.Logger.Msg(
            $"Darkness Trap expired: Reverting fog values to " +
            $"(({_fogColor.r}, {_fogColor.g}, {_fogColor.b}, {_fogColor.a}), " +
            $"{_fogDistanceStart}, {_fogDistanceEnd}, {_changeFogSpeed}, {_changeFogTime})");

        IsModifyingFog = true;
        sem.SetChangeFog(_fogColor, _fogDistanceStart, _fogDistanceEnd, 1, 3);
        IsModifyingFog = false;
    }
}

// Shrinks Nobeta to a smaller scale. This doesn't change movement speed but does change
// jump height and her hitbox size, but it shouldn't be in any logic breaking way.
public class ShrinkTrapEffect : TimedTrapEffect
{
    public override float TrapTime => 30f;
    private const float ShrinkScale = 0.4f;

    protected override void OnApply()
    {
        if (Singletons.WizardGirl is null) return;
        Melon<LwnApMod>.Logger.Msg($"Shrink Trap activated: Setting Nobeta's scale to {ShrinkScale}");
        Singletons.WizardGirl.skinInstance.SlipSmoke();
        Singletons.WizardGirl.skinInstance.PlayVoiceDamagedFly();
        Singletons.WizardGirl.gameObject.transform.localScale = new Vector3(ShrinkScale, ShrinkScale, ShrinkScale);
    }

    protected override void OnRevert()
    {
        if (Singletons.WizardGirl is null) return;
        Melon<LwnApMod>.Logger.Msg($"Shrink Trap expired: Setting Nobeta's scale back to 1.");
        Singletons.WizardGirl.skinInstance.SlipSmoke();
        Singletons.WizardGirl.skinInstance.PlayVoiceDamaged();
        Singletons.WizardGirl.gameObject.transform.localScale = new Vector3(1, 1, 1);
    }
}

public static class FillerItemPatches
{
    private static readonly Random Random = new();
    private static readonly Queue<ActiveEvent> EventQueue = new();
    private static float _trapCooldown = 0;

    private static readonly Dictionary<TrapType, TimedTrapEffect> TimedEffectsRegistry = new()
    {
        { TrapType.DarknessTrap, new DarknessTrapEffect() },
        { TrapType.ShrinkTrap, new ShrinkTrapEffect() },
    };

    public static void QueueTrap(TrapType trapType)
    {
        EventQueue.Enqueue(new TrapEvent(trapType));
    }

    public static void QueueDropItem(ItemSystem.ItemType itemType)
    {
        EventQueue.Enqueue(new GiveItemEvent(itemType));
    }

    private static void GiveBonkTrap()
    {
        if (Singletons.WizardGirl is null) return;
        Melon<LwnApMod>.Logger.Msg("Executing Bonk Trap.");
        var trapWallDonor = Object.FindObjectOfType<Trap_Wall_Level01>(true);
        if (trapWallDonor == null)
        {
            Melon<LwnApMod>.Logger.Error("Could not find an TrapWall component in the current scene!");
            return;
        }

        Melon<LwnApMod>.Logger.Msg($"Using {UnityUtils.GetObjectPath(trapWallDonor.gameObject)} as bonk trap donor.");
        var attack = trapWallDonor.GetComponent<AttackData>();
        var originalDirection = attack.GetAttackDirection();
        var originalAttackElement = attack.GetAttackElement();
        var originalAttackType = attack.GetAttackType();
        var originalHitDirection = attack.GetHitDirection();
        var originalRepulseSpeed = attack.g_fRepulseMoveSpeed;

        MelonCoroutines.Start(LwnApMod.RunOnMainThread(() =>
        {
            var randomDirection = Random.Next(0, 5);
            // For some reason, "down" actually means up. A bonk trap could, with extreme luck, allow for
            // out-of-logic movement, so the up-bonk is made less powerful than other directions.
            var repulseStrength = (randomDirection == (int)AttackData.AttackDirection.Down)
                ? Random.Next(3, 7)
                : Random.Next(10, 20);
            Melon<LwnApMod>.Logger.Msg($"Bonking in direction: {(AttackData.AttackDirection)randomDirection}.");
            Melon<LwnApMod>.Logger.Msg($"Bonking with strength: {repulseStrength}.");
            attack.SetAttackDirection((AttackData.AttackDirection)randomDirection);
            attack.SetAttackElement(PlayerEffectPlay.Magic.Null);
            attack.SetAttackType(AttackData.AttackType.Fly);
            attack.SetHitDirection(new Vector3(Random.Next(-50, 50), 0, Random.Next(-50, 50)));
            attack.g_fRepulseMoveSpeed = repulseStrength;
            Singletons.WizardGirl.Hit(attack, true);
            attack.SetAttackDirection(originalDirection);
            attack.SetAttackElement(originalAttackElement);
            attack.SetAttackType(originalAttackType);
            attack.SetHitDirection(originalHitDirection);
            attack.g_fRepulseMoveSpeed = originalRepulseSpeed;
        }));
    }

    private static void GiveManaDrainTrap()
    {
        if (Singletons.WizardGirl is null) return;
        Melon<LwnApMod>.Logger.Msg("Executing Mana Drain Trap.");
        Singletons.WizardGirl.BaseData.SetMP(0);
    }

    private static void GiveItem(ItemSystem.ItemType itemType)
    {
        var wizardGirl = Singletons.WizardGirl;
        var items = wizardGirl?.g_PlayerItem;
        var itemSystem = Singletons.ItemSystem;
        if (wizardGirl == null || items == null || itemSystem == null) return;

        Melon<LwnApMod>.Logger.Msg($"Giving item {itemType}");

        MelonCoroutines.Start(LwnApMod.RunOnMainThread(() =>
        {
            // Find first empty slot if there's any
            for (var i = 0; i < items.g_iItemSize; i++)
            {
                if (items.g_HoldItem[i] != ItemSystem.ItemType.Null) continue;
                items.g_HoldItem[i] = itemType;
                Singletons.StageUi.itemBar.UpdateItemSprite(items.g_HoldItem);
                return;
            }

            // If no empty slots, drop on floor where player is standing
            itemSystem.NewItem(itemType, wizardGirl.transform.position, Quaternion.identity);
        }));
    }

    [HarmonyPatch(typeof(WizardGirlManage), nameof(WizardGirlManage.Update))]
    private static class OnWizardGirlUpdate
    {
        [HarmonyPostfix]
        // ReSharper disable InconsistentNaming UnusedMember.Local
        private static void TrySendActiveTrap(WizardGirlManage __instance)
            // ReSharper restore InconsistentNaming UnusedMember.Local
        {
            if (Singletons.SceneManager.stageId > 1 && __instance.PlayerController.CharacterControllable)
            {
                var deltaTime = __instance.PlayerController.DeltaTime;
                foreach (var effect in TimedEffectsRegistry.Values)
                {
                    effect.Tick(deltaTime);
                }
            }

            if (!EventQueue.Any()) return;
            if (Singletons.SceneManager.stageId <= 1) return;
            // This flag should be false during cutscenes or UI menus
            if (!__instance.PlayerController.CharacterControllable) return;
            if (_trapCooldown > 0)
            {
                _trapCooldown -= __instance.PlayerController.DeltaTime;
                return;
            }

            var first = EventQueue.Dequeue();
            Melon<LwnApMod>.Logger.Msg($"Executing active event: {first}");
            switch (first)
            {
                case TrapEvent trapEvent:
                    if (TimedEffectsRegistry.TryGetValue(trapEvent.TrapType, out var timedEffect))
                    {
                        timedEffect.AddTime(timedEffect.TrapTime);
                        Melon<LwnApMod>.Logger.Msg(
                            $"Adding {timedEffect.TrapTime}s to trap {trapEvent.TrapType}. {timedEffect.RemainingTime:F2}s remaining.");
                    }
                    else
                    {
                        switch (trapEvent.TrapType)
                        {
                            case TrapType.BonkTrap:
                                GiveBonkTrap();
                                break;
                            case TrapType.ManaDrainTrap:
                                GiveManaDrainTrap();
                                break;
                            default:
                                Melon<LwnApMod>.Logger.Error($"Unknown instant trap event detected.");
                                break;
                        }
                    }

                    break;
                case GiveItemEvent itemEvent:
                    GiveItem(itemEvent.ItemType);
                    break;
                default:
                    Melon<LwnApMod>.Logger.Error($"Unknown active event detected.");
                    break;
            }

            // Set a cooldown for 0.5 seconds between active traps
            _trapCooldown = 0.5f;
        }
    }

    [HarmonyPatch(typeof(SceneEventManager), nameof(SceneEventManager.SetChangeFog))]
    private static class SceneEventManagerSetChangeFogPatch
    {
        [HarmonyPrefix]
        // ReSharper disable InconsistentNaming UnusedMember.Local
        private static bool Prefix(SceneEventManager __instance, Color FogColor, float fFogDistanceStart,
                float fFogDistanceEnd, float fSpeed, float fChangeTime)
            // ReSharper restore InconsistentNaming UnusedMember.Local
        {
            Melon<LwnApMod>.Logger.Msg(
                $"Fog change detected with values " +
                $"(({FogColor.r}, {FogColor.g}, {FogColor.b}, {FogColor.a}), " +
                $"{fFogDistanceStart}, {fFogDistanceEnd}, {fSpeed}, {fChangeTime}).");
            var darknessTrap = DarknessTrapEffect.Instance;

            if (darknessTrap is not { IsActive: true }) return true;

            // Allow change fog if it is our own effect
            if (darknessTrap.IsModifyingFog) return true;

            Melon<LwnApMod>.Logger.Msg("Fog change happened during darkness trap. Saving stored fog values.");
            darknessTrap.UpdateStoredFog(FogColor, fFogDistanceStart, fFogDistanceEnd, fSpeed, fChangeTime);

            return false;
        }
    }

    [HarmonyPatch(typeof(SceneManager), nameof(SceneManager.OnSceneInitComplete))]
    private static class OnSceneInitComplete
    {
        [HarmonyPostfix]
        // ReSharper disable UnusedMember.Local
        private static void ResetTimedEffectsAfterStageLoad()
            // ReSharper restore UnusedMember.Local
        {
            foreach (var effect in TimedEffectsRegistry.Values)
            {
                effect.ForceApply();
            }
        }
    }
}