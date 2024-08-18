using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;

namespace KitchenThemesVarity.Customs
{


    public class Firesale : CustomUnlockCard
    {
        public override string UniqueNameID => "Affordable - Firesale";
        public override List<UnlockEffect> Effects => new List<UnlockEffect>()
        {

            new ThemeAddEffect()
            {
                AddsTheme = DecorationType.Affordable

            },

            new ParameterEffect()
            {
                Parameters = new KitchenParameters() { CustomersPerHour = 0.5f, CustomersPerHourReduction = 0, MaximumGroupSize = 0, MinimumGroupSize = 0, CurrentCourses = 0 }
            },

            new GlobalEffect()
            {
                EffectCondition = new CEffectAlways(),
                EffectType = new CTableModifier()
                {
                    OrderingModifiers = new OrderingValues() { PriceModifier = -1f }

                }
            },

            new GlobalEffect()
            {
                EffectCondition = new CEffectAlways(),
                EffectType = new CApplianceSpeedModifier()
                {
                    AffectsAllProcesses = true,
                    Speed = 2f,
                }
            },

            new GlobalEffect()
            {
                EffectCondition = new CEffectAlways(),
                EffectType = new CCabinetModifier()
                {
                    DisablesDeskAfterImprovement = true,
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
                Name = "$affordable$ Affordable - Firesale",
                Description = "Pro: All processes are 200% faster",
                FlavourText = "Con: +50% more customers and customers don't pay for food"
            })

        };

    }
}
