using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using System.Collections.Generic;

namespace KitchenThemesVarity.Customs
{


    public class BargainShopping : CustomUnlockCard
    {
        public override string UniqueNameID => "Affordable - Bargain Shopping";
        public override List<UnlockEffect> Effects => new List<UnlockEffect>()
        {

            new ThemeAddEffect()
            {
                AddsTheme = DecorationType.Affordable

            },

            new StatusEffect()
            {
                Status = RestaurantStatus.HalloweenTrickSlowConveyors
            },


            new GlobalEffect()
            {
                EffectCondition = new CEffectAlways(),
                EffectType = new CApplianceSpeedModifier()
                {
                    AffectsAllProcesses = true,
                    Speed = -0.50f,
                }
            },

            new ShopEffect
            {
                ShopCostDecrease = 0.6f,
                ExtraShopBlueprints = 1,
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
                Name = "$affordable$ Affordable - Bargain Shopping",
                Description = "Pro: Shop offers 1 extra blueprint and blueprints cost 60% less",
                FlavourText = "Con: All processes are 50% slower, converyors & grabbers transfer 50% slower, and desks can only be used once per day"
            })

        };

    }
}
