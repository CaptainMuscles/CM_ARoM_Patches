# CM_ARoM_Patches
Some patches for A RimWorld of Magic

## Configurable Purify
Patches/ARimworldOfMagic_Configurable_Purify.xml replaces the existing Priest > Purify ability with a configurable version

**Note that the parameters included serve to reproduce the exact behavior of the purity spell at the time of this patches creation**

Hediffs to purify can be located within the `<healableHediffs>` tag. There you will find the existing healables as examples:
```
<li>
  <hediffs>
    <li>Cataract</li>
    <li>HearingLoss</li>
    <li>ToxicBuildup</li>
  </hediffs>
  <minLevel>0</minLevel>
  <baseAmount>0.4</baseAmount>
  <amountPerLevel>0.3</amountPerLevel>
</li>
```
The above entry specifies rules for the 'Cataract', 'HearingLoss' and 'ToxicBuildup' hediffs.

`<minLevel>` is the minimum required level for the **Comprehensive Purity** skill to affect the hediff.

`<baseAmount>` is the base amount that will be healed (0.4 = 40%)

`<amountPerLevel>` is the additional amount that will be healed per level of the **Burning Purity** skill.

```
<li>
  <hediffs>
    <li>LuciferiumAddiction</li>
  </hediffs>
  <minLevel>3</minLevel>
  <baseAmount>0.15</baseAmount>
  <amountPerLevel>0.15</amountPerLevel>
  <useArcaneDamage>true</useArcaneDamage>
  <alsoRemoveOnFullHeal>LuciferiumHigh</alsoRemoveOnFullHeal>
</li>
```
`<useArcaneDamage>` determines if we should multiply the effectiveness of the heal by the casters arcane damage multiplier (determined by caster's psychic sensitivity)

`<alsoRemoveOnFullHeal>` specifies the name of another hediff that should be removed if the heal is complete. This is used when the hediff does not go away on its own at 0 severity (Asthma) or if a different hediff should be removed along with the original (LuciferiumAddiction -> LuciferiumHigh)
