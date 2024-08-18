using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;

namespace KitchenThemesVarity.Customs
{


    public class Beanery : CustomUnlockCard
    {
        public override string UniqueNameID => "Charming - Beanery";
        public override List<UnlockEffect> Effects => new List<UnlockEffect>()
        {

            new ThemeAddEffect()
            {
                AddsTheme = DecorationType.Charming

            },

            new GlobalEffect()
            {
                EffectCondition = new CEffectAlways(),
                EffectType = new CTableModifier()
                {
                    PatienceModifiers = new PatienceValues() { GetFoodDelivered = 3f, FoodDeliverBonus = 6f, DrinkDeliverBonus = 6f, ItemDeliverBonus = 6f },
                    OrderingModifiers = new OrderingValues() { PriceModifier = -0.40f }

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
                Name = "$charming$ Charming - Beanery",
                Description = "Pro: Increase $delivery$ patience by 300%",
                FlavourText = "Con: Desks can only be used once per day and customers pay 40% less"
            })

        };

    }
}
