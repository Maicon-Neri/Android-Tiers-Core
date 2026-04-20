using Verse;
using Verse.AI;
using Verse.AI.Group;
using HarmonyLib;
using RimWorld;
using System.Collections.Generic;
using System.Linq;
using System;

namespace MOARANDROIDS
{
    internal class MemoryThoughtHandler_Patch
    {

        [HarmonyPatch]
        public class TryGainMemoryFast
        {
            public static System.Reflection.MethodBase TargetMethod()
            {
                return AccessTools.Method(typeof(MemoryThoughtHandler), nameof(MemoryThoughtHandler.TryGainMemoryFast), new Type[] { typeof(ThoughtDef), typeof(Precept) });
            }

            [HarmonyPrefix]
            public static bool Listener(ThoughtDef mem, MemoryThoughtHandler __instance)
            {
                try
                {
                    if (shouldSkipCurrentMemory(mem, __instance))
                        return false;
                    return true;
                }
                catch (Exception e)
                {
                    Log.Message("[ATPP] MemoryThoughtHandler.TryGainMemoryFast : " + e.Message + " - " + e.StackTrace);
                    return true;
                }
            }
        }

        [HarmonyPatch]
        public class TryGainMemoryFast2
        {
            public static System.Reflection.MethodBase TargetMethod()
            {
                return AccessTools.Method(typeof(MemoryThoughtHandler), nameof(MemoryThoughtHandler.TryGainMemoryFast), new Type[] { typeof(ThoughtDef), typeof(int), typeof(Precept) });
            }

            [HarmonyPrefix]
            public static bool Listener(ThoughtDef mem, MemoryThoughtHandler __instance)
            {
                try
                {
                    if (shouldSkipCurrentMemory(mem, __instance))
                        return false;
                    return true;
                }
                catch (Exception e)
                {
                    Log.Message("[ATPP] MemoryThoughtHandler.TryGainMemoryFast2 : " + e.Message + " - " + e.StackTrace);
                    return true;
                }
            }
        }

        /*
        * Postfix evitant que les droids est le debuff "Eat without table"
        */
        [HarmonyPatch(typeof(MemoryThoughtHandler), "TryGainMemory")]
        [HarmonyPatch(new Type[] { typeof(Thought_Memory), typeof(Pawn)}, new ArgumentType[] { ArgumentType.Normal, ArgumentType.Normal })]
        public class TryGainMemory_Patch
        {
            [HarmonyPrefix]
            public static bool Listener(Thought_Memory newThought, Pawn otherPawn, MemoryThoughtHandler __instance)
            {
                try
                {
                    //Log.Message(newThought.def.defName);
                    
                    //Si android (en général) alors squeeze de certains moods OU alors si android surrogate suppression de TOUT les moods (si pas controllé) DE MEME si controlleur avec connection en cours désaction des MOODS
                    if (shouldSkipCurrentMemory(newThought.def, __instance))
                    {
                        return false;
                    }
                    return true;
                }
                catch(Exception e)
                {
                    Log.Message("[ATPP] MemoryThoughtHandler.TryGainMemory : " + e.Message+" - "+e.StackTrace);
                    return true;
                }
            }
        }

        private static bool shouldSkipCurrentMemory(ThoughtDef memDef, MemoryThoughtHandler __instance)
        {
            Pawn pawn = __instance?.pawn;
            if (pawn == null || memDef == null)
                return false;

            CompAndroidState cas = Utils.getCachedCAS(pawn);
                return  ( pawn.IsAndroidTier() && Utils.IgnoredThoughtsByAllAndroids.Contains(memDef.defName))
                        || Utils.lastButcheredPawnIsAndroid
                        || (cas != null && cas.isSurrogate && cas.surrogateController == null)
                        || Utils.pawnCurrentlyControlRemoteSurrogate(pawn)
                        || ( (pawn.IsBasicAndroidTier() || pawn.story?.traits?.HasTrait(TraitDefOf.SimpleMindedAndroid) == true) && Utils.IgnoredThoughtsByBasicAndroids.Contains(memDef.defName));
        }
    }
}
