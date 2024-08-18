using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;

namespace KitchenThemesVarity.Customs
{


    public class HellsKitchen : CustomUnlockCard
    {
        public override string UniqueNameID => "Exclusive - Hell's Kitchen";
        public override List<UnlockEffect> Effects => new List<UnlockEffect>()
        {

            new ThemeAddEffect()
            {
                AddsTheme = DecorationType.Exclusive

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

            new StatusEffect()
            {
                Status = RestaurantStatus.HalloweenTrickRandomFires
            },

            new StatusEffect()
            {
                Status = RestaurantStatus.HalloweenTrickCustomersStartFiresWhenLeaving
            },


            new GlobalEffect()
            {
                EffectCondition = new CEffectAlways(),
                EffectType = new CApplianceSpeedModifier()
                {
                    AffectsAllProcesses = true,
                    Speed = 3f,
                    BadSpeed = -1f,
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
                Name = "$exclusive$ Exclusive - Hell's Kitchen",
                Description = "Pro: All processes are 300% faster and food can't burn",
                FlavourText = "Con: Customers set fire to tables when leaving and fire appear randomly,"
            })

        };

    }
}
