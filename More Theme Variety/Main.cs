using KitchenData;
using KitchenLib;
using KitchenLib.Event;
using KitchenLib.References;
using KitchenLib.Utils;
using KitchenMods;
using UnityEngine;
using System.Reflection;
using KitchenThemesVarity.Customs;

// Namespace should have "Kitchen" in the beginning
namespace KitchenThemesVarity
{
    public class Mod : BaseMod, IModSystem
    {
        // GUID must be unique and is recommended to be in reverse domain name notation
        // Mod Name is displayed to the player and listed in the mods menu
        // Mod Version must follow semver notation e.g. "1.2.3"
        public const string MOD_GUID = "Clear.Plateup.ThemesVarity";
        public const string MOD_NAME = "More Themes Varity";
        public const string MOD_VERSION = "0.1.0";
        public const string MOD_AUTHOR = "Clear";
        public const string MOD_GAMEVERSION = ">=1.1.4";
        // Game version this mod is designed for in semver
        // e.g. ">=1.1.3" current and all future
        // e.g. ">=1.1.3 <=1.2.3" for all from/until

        // Boolean constant whose value depends on whether you built with DEBUG or RELEASE mode, useful for testing
#if DEBUG
        public const bool DEBUG_MODE = true;
#else
        public const bool DEBUG_MODE = false;
#endif

        public static AssetBundle Bundle;

        public Mod() : base(MOD_GUID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, MOD_GAMEVERSION, Assembly.GetExecutingAssembly()) { }

        protected override void OnInitialise()
        {
            LogWarning($"{MOD_GUID} v{MOD_VERSION} in use!");
            //Affordable
            UnlockCard Firesale = GDOUtils.GetCastedGDO<UnlockCard, Firesale>();
            UnlockCard Eatery = GDOUtils.GetCastedGDO<UnlockCard, Eatery>();
            UnlockCard Bargainshopping = GDOUtils.GetCastedGDO<UnlockCard, BargainShopping>();


            //Charming
            UnlockCard Sharingparty = GDOUtils.GetCastedGDO<UnlockCard, SharingParty>();
            UnlockCard Fullhouse = GDOUtils.GetCastedGDO<UnlockCard, FullHouse>();
            UnlockCard Beanery = GDOUtils.GetCastedGDO<UnlockCard, Beanery>();


            //Excuslive
            UnlockCard ShoppingSpree = GDOUtils.GetCastedGDO<UnlockCard, ShoppingSpree>();
            UnlockCard Acclaimed = GDOUtils.GetCastedGDO<UnlockCard, Acclaimed>();
            UnlockCard Hellskitchen = GDOUtils.GetCastedGDO<UnlockCard, HellsKitchen>();


            //Formal
            UnlockCard Brasserie = GDOUtils.GetCastedGDO<UnlockCard, Brasserie>();
            UnlockCard Gourmet = GDOUtils.GetCastedGDO<UnlockCard, Gourmet>();
            UnlockCard TippingCulture = GDOUtils.GetCastedGDO<UnlockCard, TippingCulture>();

        }

        private void AddGameData()
        {
            LogInfo("Attempting to register game data...");

            // AddGameDataObject<MyCustomGDO>();
            AddGameDataObject<Firesale>();
            AddGameDataObject<Eatery>();
            AddGameDataObject<BargainShopping>();

            AddGameDataObject<SharingParty>();
            AddGameDataObject<FullHouse>();
            AddGameDataObject<Beanery>();

            AddGameDataObject<ShoppingSpree>();
            AddGameDataObject<Acclaimed>();
            AddGameDataObject<HellsKitchen>();

            AddGameDataObject<Brasserie>();
            AddGameDataObject<Gourmet>();
            AddGameDataObject<TippingCulture>();


            LogInfo("Done loading game data.");
        }

        protected override void OnUpdate()
        {
        }

        protected override void OnPostActivate(KitchenMods.Mod mod)
        {
            // TODO: Uncomment the following if you have an asset bundle.
            // TODO: Also, make sure to set EnableAssetBundleDeploy to 'true' in your ModName.csproj

            // LogInfo("Attempting to load asset bundle...");
            // Bundle = mod.GetPacks<AssetBundleModPack>().SelectMany(e => e.AssetBundles).First();
            // LogInfo("Done loading asset bundle.");

            // Register custom GDOs
            AddGameData();

            // Perform actions when game data is built
            Events.BuildGameDataEvent += delegate (object s, BuildGameDataEventArgs args)
            {
            };
        }
        #region Logging
        public static void LogInfo(string _log) { Debug.Log($"[{MOD_NAME}] " + _log); }
        public static void LogWarning(string _log) { Debug.LogWarning($"[{MOD_NAME}] " + _log); }
        public static void LogError(string _log) { Debug.LogError($"[{MOD_NAME}] " + _log); }
        public static void LogInfo(object _log) { LogInfo(_log.ToString()); }
        public static void LogWarning(object _log) { LogWarning(_log.ToString()); }
        public static void LogError(object _log) { LogError(_log.ToString()); }
        #endregion
    }
}
