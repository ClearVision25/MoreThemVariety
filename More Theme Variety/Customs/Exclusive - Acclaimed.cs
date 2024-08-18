using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;

namespace KitchenThemesVarity.Customs
{


    public class Acclaimed : CustomUnlockCard
    {
        public override string UniqueNameID => "Exclusive - Acclaimed";
        public override List<UnlockEffect> Effects => new List<UnlockEffect>()
        {

            new ThemeAddEffect()
            {
                AddsTheme = DecorationType.Exclusive

            },

            new ParameterEffect()
            {
                Parameters = new KitchenParameters() { CustomersPerHour = 0.5f, CustomersPerHourReduction = 0, MaximumGroupSize = 0, MinimumGroupSize = 0, CurrentCourses = 0 }
            },


            new GlobalEffect()
            {
                EffectCondition = new CEffectAlways(),
                EffectType = new CQueueModifier()
                {
                    PatienceFactor = 1f,
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
                Name = "$exclusive$ Exclusive - Acclaimed",
                Description = "Pro: Doubles $queue$ queue patience",
                FlavourText = "Con: +50% more customers"
            })

        };

    }
}
