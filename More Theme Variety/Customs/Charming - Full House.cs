using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;

namespace KitchenThemesVarity.Customs
{


    public class FullHouse : CustomUnlockCard
    {
        public override string UniqueNameID => "Charming - Full House";
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
                    PatienceModifiers = new PatienceValues() { Seating = -0.6667f, Service = 1f, WaitForFood = 1f, GetFoodDelivered = 16f, DrinkDeliverBonus = 16f, FoodDeliverBonus = 16f, SkipWaitPhase = true }

                }
            },

            new GlobalEffect()
            {
                EffectCondition = new CEffectAlways(),
                EffectType = new CQueueModifier
                {
                    PatienceFactor = -.6667f,
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
                Name = "$charming$ Charming - Full House",
                Description = "Pro: Double $service$ and $waitforfood$ patience, combine $delivery$ phase into $waitforfood$, and boost patience per delivery",
                FlavourText = "Con: $queue$ and $seating$ patience reduced by 66%"
            })

        };

    }
}
