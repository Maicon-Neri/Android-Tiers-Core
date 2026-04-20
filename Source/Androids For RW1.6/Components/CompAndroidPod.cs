using System;
using Verse;
using RimWorld;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Text.RegularExpressions;

namespace MOARANDROIDS
{
    public class CompAndroidPod : ThingComp
    {
        public override void CompTick()
        {
            if (!this.parent.Spawned)
            {
                return;
            }

            int CGT = Find.TickManager.TicksGame;
            if (CGT % 60 == 0)
            {
                // Atualiza a quantidade de energia consumida
                refreshPowerConsumed();
            }
        }

        public float getPowerConsumed()
        {
            CompPowerTrader cpt = Utils.getCachedCPT(this.parent);

            if (cpt == null)
                return 0;
            else
                return getCurrentAndroidPowerConsumed() + cpt.Props.PowerConsumption;
        }


        public void refreshPowerConsumed()
        {
            CompPowerTrader cpt = Utils.getCachedCPT(this.parent);
            cpt.powerOutputInt = -(getPowerConsumed());
        }

        public int getCurrentAndroidPowerConsumed()
        {
            int ret = 0;

            Building_Bed bed = (Building_Bed)parent;

            foreach (var cp in bed.CurOccupants)
            {
                // Verifica se é android
                if (cp != null && cp.IsAndroidTier())
                {
                    ret += Utils.getConsumedPowerByAndroid(cp.def.defName);
                }
            }
            // Retorna a quantidade de energia consumida pelos androids
            return ret;
        }
    }
}