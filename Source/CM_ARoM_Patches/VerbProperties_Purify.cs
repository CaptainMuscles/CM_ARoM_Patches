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
    public class VerbProperties_Purify : AbilityUser.VerbProperties_Ability
    {
        public class HealableHediffParameters
        {
            public List<string> hediffs = new List<string>();
            public int minLevel = 0;
            public float baseAmount = 0.0f;
            public float amountPerLevel = 0.0f;
            public bool useArcaneDamage = false;
            public bool isRemovalChance = false;
            public string alsoRemoveOnFullHeal = "";
        }

        public List<HealableHediffParameters> healableHediffs = new List<HealableHediffParameters>();
    }
}
