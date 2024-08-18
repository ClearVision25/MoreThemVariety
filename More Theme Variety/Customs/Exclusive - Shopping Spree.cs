using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;

namespace KitchenThemesVarity.Customs
{


    public class ShoppingSpree : CustomUnlockCard
    {
        public override string UniqueNameID => "Exclusive - Shopping Spree";
        public override List<UnlockEffect> Effects => new List<UnlockEffect>()
        {

            new ThemeAddEffect()
            {
                AddsTheme = DecorationType.Exclusive

            },

            new StatusEffect()
            {
                Status = RestaurantStatus.ClearMoneyAtStartOfDay
            },

            new ShopEffect
            {
                ExtraShopBlueprints = 1,
                UpgradedShopChance = 1f,
                BlueprintRefreshChance = 1f,
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
                Name = "$exclusive$ Exclusive - Shopping Spree",
                Description = "Pro: Shop offers 1 extra blueprints with improve odds of upgraded blueprints, and receive a new blueprint when purchasing",
                FlavourText = "Con: Desks can only be used once per day and leftover money is lost at the beginning of each day"
            })

        };

    }
}
