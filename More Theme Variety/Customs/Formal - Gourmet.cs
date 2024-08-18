using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using System.Collections.Generic;

namespace KitchenThemesVarity.Customs
{


    public class Gourmet : CustomUnlockCard
    {
        public override string UniqueNameID => "Formal - Gourmet";
        public override List<UnlockEffect> Effects => new List<UnlockEffect>()
        {

            new ThemeAddEffect()
            {
                AddsTheme = DecorationType.Formal

            },

            new GlobalEffect()
            {
                EffectCondition = new CEffectAlways(),
                EffectType = new CTableModifier()
                {
                    PatienceModifiers = new PatienceValues() { Eating = 3f  },
                    OrderingModifiers = new OrderingValues() { GroupOrdersSame = true, MinimumShare = 1, RepeatCourseModifier = .25f }
                }
            },

            new GlobalEffect()
            {
                EffectCondition = new CEffectAlways(),
                EffectType = new CApplianceSpeedModifier()
                {
                    AffectsAllProcesses = true,
                    Speed = -0.75f,
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
                Name = "$formal$ Formal - Gourmet",
                Description = "Pro: Customers within a group make the same order and can share with 1 other customer",
                FlavourText = "Con: Increase eating phase by 300%, customers can order courses twice, and all processes are 75% slower"
            })

        };

    }
}
