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
    internal class StunHandler_Patch

    {

        [HarmonyPatch]
        public class get_AffectedByEMP_Patch
        {
            public static MethodBase TargetMethod()
            {
                return AccessTools.Method(typeof(StunHandler), "CanBeStunnedByDamage");
            }

            [HarmonyPostfix]
            public static void Listener(DamageDef def, ref bool __result, Thing ___parent)
            {
                if (def != DamageDefOf.EMP)
                    return;

                if (___parent is Pawn)
                {
                    Pawn pawn = (Pawn)___parent;
                    if ( Utils.ExceptionAndroidWithoutSkinList.Contains(pawn.def.defName) || pawn.IsCyberAnimal())
                    {
                        __result = true;
                    }
                }
            }
        }
    }
}
