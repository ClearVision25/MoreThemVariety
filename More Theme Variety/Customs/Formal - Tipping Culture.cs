using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;

namespace KitchenThemesVarity.Customs
{


    public class TippingCulture : CustomUnlockCard
    {
        public override string UniqueNameID => "Formal - TippingCulture";
        public override List<UnlockEffect> Effects => new List<UnlockEffect>()
        {

            new ThemeAddEffect()
            {
                AddsTheme = DecorationType.Formal

            },

            new StatusEffect()
            {
                Status = RestaurantStatus.PayBasedOnPatience
            },


            new GlobalEffect()
            {
                EffectCondition = new CEffectAlways(),
                EffectType = new CTableModifier()
                {
                    PatienceModifiers = new PatienceValues() { Service = -.75f, WaitForFood = -.75f, BonusPatienceWhenNearby = true },
                    OrderingModifiers = new OrderingValues() { PriceModifier = 1f }

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
                Name = "$formal$ Formal - Tipping Culture",
                Description = "Pro: Bonus table patience while any player is near that table and customers pay 100% more money",
                FlavourText = "Con: Customers has 75% reduced table patience, pay based on their remaining $waitforfood$ patience, and desks can only be used once per day "
            })

        };

    }
}
