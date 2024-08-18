using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;

namespace KitchenThemesVarity.Customs
{


    public class Eatery : CustomUnlockCard
    {
        public override string UniqueNameID => "Affordable - Eatery";
        public override List<UnlockEffect> Effects => new List<UnlockEffect>()
        {

            new ThemeAddEffect()
            {
                AddsTheme = DecorationType.Affordable

            },

            new StatusEffect()
            {
                Status = RestaurantStatus.HalloweenTrickConstantMess
            },

            new StatusEffect()
            {
                Status = RestaurantStatus.HalloweenTrickAllPlayersWearSlippers
            },

            new GlobalEffect()
            {
                EffectCondition = new CEffectAlways(),
                EffectType = new CTableModifier()
                {
                    OrderingModifiers = new OrderingValues() { SidesOptional = true, RepeatCourseModifier = 0.25f, SeatWithoutClear = true }

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
                Name = "$affordable$ Affordable - Eatery",
                Description = "Pro: Customers will sit at tables before they are cleared and all sides are optional",
                FlavourText = "Con: Customers can order courses twice, messes will appear randomly, and players have slippers"
            })

        };

    }
}
