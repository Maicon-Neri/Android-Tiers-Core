using Verse;
using HarmonyLib;
using RimWorld;
using System;
using System.Reflection;

namespace MOARANDROIDS
{
    internal class Pregnancy_ChildGrowth_Patch
    {
        // Prevent androids from getting pregnant or fathering children.
        [HarmonyPatch(typeof(PregnancyUtility), "PregnancyChanceForPawn")]
        public class PregnancyChanceForPawn_Patch
        {
            public static bool Prepare()
            {
                return AccessTools.Method(typeof(PregnancyUtility), "PregnancyChanceForPawn", new Type[] { typeof(Pawn) }) != null;
            }

            [HarmonyPrefix]
            public static bool Listener(Pawn __0, ref float __result)
            {
                try
                {
                    if (__0 != null && __0.IsAndroidTier())
                    {
                        __result = 0f;
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Log.Error("[ATPP] PregnancyUtility.PregnancyChanceForPawn: " + e.Message);
                }
                return true;
            }
        }

        [HarmonyPatch(typeof(PregnancyUtility), "PregnancyChanceForWoman")]
        public class PregnancyChanceForWoman_Patch
        {
            public static bool Prepare()
            {
                return AccessTools.Method(typeof(PregnancyUtility), "PregnancyChanceForWoman", new Type[] { typeof(Pawn) }) != null;
            }

            [HarmonyPrefix]
            public static bool Listener(Pawn __0, ref float __result)
            {
                try
                {
                    if (__0 != null && __0.IsAndroidTier())
                    {
                        __result = 0f;
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Log.Error("[ATPP] PregnancyUtility.PregnancyChanceForWoman: " + e.Message);
                }
                return true;
            }
        }

        [HarmonyPatch(typeof(PregnancyUtility), "PregnancyChanceImplantEmbryo")]
        public class PregnancyChanceImplantEmbryo_Patch
        {
            public static bool Prepare()
            {
                return AccessTools.Method(typeof(PregnancyUtility), "PregnancyChanceImplantEmbryo", new Type[] { typeof(Pawn) }) != null;
            }

            [HarmonyPrefix]
            public static bool Listener(Pawn __0, ref float __result)
            {
                try
                {
                    if (__0 != null && __0.IsAndroidTier())
                    {
                        __result = 0f;
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Log.Error("[ATPP] PregnancyUtility.PregnancyChanceImplantEmbryo: " + e.Message);
                }
                return true;
            }
        }

        [HarmonyPatch(typeof(PregnancyUtility), "PregnancyChanceForPartners")]
        public class PregnancyChanceForPartners_Patch
        {
            public static bool Prepare()
            {
                return AccessTools.Method(typeof(PregnancyUtility), "PregnancyChanceForPartners", new Type[] { typeof(Pawn), typeof(Pawn) }) != null;
            }

            [HarmonyPrefix]
            public static bool Listener(Pawn __0, Pawn __1, ref float __result)
            {
                try
                {
                    if ((__0 != null && __0.IsAndroidTier()) ||
                        (__1 != null && __1.IsAndroidTier()))
                    {
                        __result = 0f;
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Log.Error("[ATPP] PregnancyUtility.PregnancyChanceForPartners: " + e.Message);
                }
                return true;
            }
        }

        [HarmonyPatch(typeof(PregnancyUtility), "PregnancyChanceForPartnersWithoutPregnancyApproach")]
        public class PregnancyChanceForPartnersWithoutPregnancyApproach_Patch
        {
            public static bool Prepare()
            {
                return AccessTools.Method(typeof(PregnancyUtility), "PregnancyChanceForPartnersWithoutPregnancyApproach", new Type[] { typeof(Pawn), typeof(Pawn) }) != null;
            }

            [HarmonyPrefix]
            public static bool Listener(Pawn __0, Pawn __1, ref float __result)
            {
                try
                {
                    if ((__0 != null && __0.IsAndroidTier()) ||
                        (__1 != null && __1.IsAndroidTier()))
                    {
                        __result = 0f;
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Log.Error("[ATPP] PregnancyUtility.PregnancyChanceForPartnersWithoutPregnancyApproach: " + e.Message);
                }
                return true;
            }
        }

        // Block the actual birth spawn if either parent is an android.
        [HarmonyPatch(typeof(PregnancyUtility), "DoBirthSpawn")]
        public class DoBirthSpawn_Patch
        {
            public static bool Prepare()
            {
                return typeof(PregnancyUtility).GetMethod("DoBirthSpawn",
                    BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic) != null;
            }

            [HarmonyPrefix]
            public static bool Listener(Pawn mother, Pawn father)
            {
                try
                {
                    if ((mother != null && mother.IsAndroidTier()) ||
                        (father != null && father.IsAndroidTier()))
                        return false;
                }
                catch (Exception e)
                {
                    Log.Error("[ATPP] PregnancyUtility.DoBirthSpawn: " + e.Message);
                }
                return true;
            }
        }

        // Prevent android children from triggering growth moments (ages 3, 7, 10, 13).
        [HarmonyPatch(typeof(GrowthUtility), "TryChildGrowthMoment")]
        public class TryChildGrowthMoment_Patch
        {
            public static bool Prepare()
            {
                return typeof(GrowthUtility).GetMethod("TryChildGrowthMoment",
                    BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic) != null;
            }

            [HarmonyPrefix]
            public static bool Listener(Pawn pawn)
            {
                try
                {
                    if (pawn != null && pawn.IsAndroidTier())
                        return false;
                }
                catch (Exception e)
                {
                    Log.Error("[ATPP] GrowthUtility.TryChildGrowthMoment: " + e.Message);
                }
                return true;
            }
        }

        // Prevent android children from gaining growth points.
        [HarmonyPatch(typeof(Pawn_AgeTracker), "get_canGainGrowthPoints")]
        public class CanGainGrowthPoints_Patch
        {
            public static bool Prepare()
            {
                return typeof(Pawn_AgeTracker).GetProperty("canGainGrowthPoints",
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic) != null;
            }

            [HarmonyPostfix]
            public static void Listener(Pawn_AgeTracker __instance, ref bool __result)
            {
                try
                {
                    if (!__result)
                        return;
                    Pawn pawn = Traverse.Create(__instance).Field("pawn").GetValue<Pawn>();
                    if (pawn != null && pawn.IsAndroidTier())
                        __result = false;
                }
                catch (Exception e)
                {
                    Log.Error("[ATPP] Pawn_AgeTracker.canGainGrowthPoints: " + e.Message);
                }
            }
        }
    }
}
