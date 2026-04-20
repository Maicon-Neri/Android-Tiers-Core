using Verse;
using Verse.AI;
using Verse.AI.Group;
using HarmonyLib;
using RimWorld;
using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine;

namespace MOARANDROIDS
{
    internal class FloatMenuMakerMap_Patch

    {
        [HarmonyPatch(typeof(FloatMenuMakerMap), "GetOptions")]
        public class AddHumanlikeOrders_Patch
        {
            [HarmonyPrefix]
            public static bool ListenerPrefix(List<Pawn> selectedPawns, Vector3 clickPos)
            {
                Utils.insideAddHumanlikeOrders = true;
                return true;
            }

            [HarmonyPostfix]
            public static void ListenerPostfix(List<Pawn> selectedPawns, Vector3 clickPos)
            {
                Utils.insideAddHumanlikeOrders = false;
            }
        }
    }
}