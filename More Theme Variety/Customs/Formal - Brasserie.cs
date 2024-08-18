using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;

namespace KitchenThemesVarity.Customs
{


    public class Brasserie : CustomUnlockCard
    {
        public override string UniqueNameID => "Formal - Brasserie";
        public override List<UnlockEffect> Effects => new List<UnlockEffect>()
        {

            new ThemeAddEffect()
            {
                AddsTheme = DecorationType.Formal

            },

            new StatusEffect()
            {
                Status = RestaurantStatus.HalloweenTrickSlowConveyors
            },

            new ParameterEffect()
            {
                Parameters = new KitchenParameters() { CustomersPerHour = 0f, CustomersPerHourReduction = 0, MaximumGroupSize = 2, MinimumGroupSize = 0, CurrentCourses = 0 }
            },

            new GlobalEffect()
            {
                EffectCondition = new CEffectAlways(),
                EffectType = new CTableModifier()
                {
                    PatienceModifiers = new PatienceValues() { SkipWaitPhase = true  },
                    OrderingModifiers = new OrderingValues() { ConsumableReuseChance = 0.5f }

                }
            },

            new GlobalEffect()
            {
                EffectCondition = new CEffectAlways(),
                EffectType = new CApplianceSpeedModifier()
                {
                    AffectsAllProcesses = true,
                    Speed = 2f,
                    BadSpeed = -0.5f,
                }
            },



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
                Name = "$formal$ Formal - Brasserie",
                Description = "Pro: Combine $delivery$ phase into $waitforfood$ and table consumables have a 50% to be reused",
                FlavourText = "Con: Maximum group size increased by 2 and converyors & grabbers transfer 50% slower"
            })

        };

    }
}
