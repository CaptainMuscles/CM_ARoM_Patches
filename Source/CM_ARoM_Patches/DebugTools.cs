using System;
using System.Collections.Generic;
using System.Linq;
using RimWorld;
using AbilityUser;
using Verse;
using UnityEngine;

using TorannMagic;

namespace CM_ARoM_Patches
{
    public static class DebugTools
    {
        [DebugAction("CM_ARoM_Patches", "Grant 1000 XP", actionType = DebugActionType.ToolMapForPawns, allowedGameStates = AllowedGameStates.PlayingOnMap)]
        public static void Grant1000XP(Pawn pawn)
        {
            if (pawn == null)
                return;

            CompAbilityUserMagic compMagic = pawn.GetComp<CompAbilityUserMagic>();
            if (compMagic == null)
                return;

            compMagic.MagicUserXP += 1000;
        }
    }
}
