using Verse;
using Verse.AI;
using Verse.AI.Group;
using HarmonyLib;
using RimWorld;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Reflection;

namespace MOARANDROIDS
{
    internal class Need_Food_Patch

    {

        /*
         * Mise en place d'un Maxlevel raisonable car avec l'algo de base de RW il st demeusuré de part la taille des M7 et donc la batterie (food) met BC de temps a s'écouler
         */
        [HarmonyPatch]
        public class MaxLevel_Patch
        {
            public static bool Prepare()
            {
                return TargetMethod() != null;
            }

            public static MethodBase TargetMethod()
            {
                return AccessTools.PropertyGetter(typeof(Need_Food), nameof(Need_Food.FoodFallPerTick));
            }

            [HarmonyPostfix]
            public static void Listener(Pawn ___pawn, ref float __result)
            {
                if (___pawn?.def == Utils.M7Mech && ___pawn.IsSurrogateAndroid())
                {
                    __result = 1.5f / GenDate.TicksPerDay;
                }
            }
        }

        //Eviter que l'android se décharge pendant qu'il se recharge
        /*[HarmonyPatch(typeof(Need_Food), "get_FoodFallPerTick")]
        public class FoodFallPerTick_Patch
        {
            [HarmonyPostfix]
            public static void Listener(Pawn ___pawn, ref float __result)
            {
                //Log.Message("=>> "+___pawn.LabelCap);
                if (!___pawn.IsAndroidTier())
                    return;

                if (Utils.androidIsValidPodForCharging(___pawn) || Utils.androidReloadingAtChargingStation(___pawn))
                {
                    __result = 0f;
                }
            }
        }*/

        [HarmonyPatch]
        public class MaxLevelGetter_Patch
        {
            public static bool Prepare()
            {
                return TargetMethod() != null;
            }

            public static MethodBase TargetMethod()
            {
                return AccessTools.PropertyGetter(typeof(Need_Food), nameof(Need_Food.MaxLevel));
            }

            [HarmonyPrefix]
            public static bool Prefix(Pawn ___pawn, ref float __result)
            {
                if (___pawn == null || (!___pawn.IsAndroidTier() && !(___pawn.def == Utils.M7Mech && ___pawn.IsSurrogateAndroid())))
                    return true;

                __result = GetAndroidFoodMaxLevel(___pawn);
                return false;
            }

            private static float GetAndroidFoodMaxLevel(Pawn pawn)
            {
                if (pawn.def == Utils.M7Mech && pawn.IsSurrogateAndroid())
                    return 1.5f;

                return Math.Max(0.3f, Math.Min(pawn.RaceProps?.baseBodySize ?? 1f, 2.5f));
            }
        }

        /*[HarmonyPatch(typeof(Need_Food), "NeedInterval")]
        public class IsFrozen
        {
            [HarmonyPostfix]
            public static void Listener(float ___curLevelInt, Pawn ___pawn, Need_Food __instance)
            {
                if(___pawn.def.defName == "M7Mech")
                {
                    Log.Message("=>" + ___curLevelInt );
                }
            }
        }*/
    }
}
