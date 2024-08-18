using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;

namespace KitchenThemesVarity.Customs
{


    public class SharingParty : CustomUnlockCard
    {
        public override string UniqueNameID => "Charming - Sharing Party";
        public override List<UnlockEffect> Effects => new List<UnlockEffect>()
        {

            new ThemeAddEffect()
            {
                AddsTheme = DecorationType.Charming

            },

            new ParameterEffect()
            {
                Parameters = new KitchenParameters() { CustomersPerHour = 0.4f, CustomersPerHourReduction = 0, MaximumGroupSize = 2, MinimumGroupSize = 0, CurrentCourses = 0 }
            },

            new GlobalEffect()
            {
                EffectCondition = new CEffectAlways(),
                EffectType = new CApplianceSpeedModifier()
                {
                    AffectsAllProcesses = true,
                    Speed = -0.5f,
                }
            },

            new GlobalEffect()
            {
                EffectCondition = new CEffectAlways(),
                EffectType = new CTableModifier()
                {
                    OrderingModifiers = new OrderingValues() { ConsumableReuseChance = 0.75f, MinimumShare = 1 }
                }
            }



        };
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Large;
        public override bool IsUnlockable => true;
        public override UnlockGroup UnlockGroup => UnlockGroup.PrimaryTheme;
        public override CardType CardType => CardType.ThemeUnlock;
        public override bool IsSpecificFranchiseTier => false;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.None;
        public override List<(Locale, UnlockInfo)> InfoList => new List<(Locale, UnlockInfo)>()
        {
            (Locale.English, new UnlockInfo()
            {
                Locale = Locale.English,
                Name = "$charming$ Charming - Sharing Party",
                Description = "Pro: Customer can be share food to one other customer and table consumables have a 75% to be reused",
                FlavourText = "Con: All processes are 75% slower and maximum group size increase by 2"
            })

        };

    }
}
