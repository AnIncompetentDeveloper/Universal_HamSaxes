using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using UniversalHamSaxes.Items;

namespace UniversalHamSaxes
{
    public class UniversalHamSaxes : Mod
    {
        public UniversalHamSaxes()
        {
        }
        public override void AddRecipeGroups()
        {
            base.AddRecipeGroups();


            RecipeGroup CAWgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Chlorophyte Axe or Saw", new int[]
            {
                ItemID.ChlorophyteGreataxe,
                ItemID.ChlorophyteChainsaw
            });
            RecipeGroup.RegisterGroup("UniversalHamSaxes:Chlorophyte Axe or Saw", CAWgroup);


            RecipeGroup AASgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Adamantite Axe or Saw", new int[]
            {
                ItemID.AdamantiteChainsaw,
                ItemID.AdamantiteWaraxe
            });
            RecipeGroup.RegisterGroup("UniversalHamSaxes:Adamantite Axe or Saw", AASgroup);


            RecipeGroup ADPgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Adamantite Pickaxe or Drill", new int[]
            {
                ItemID.AdamantiteDrill,
                ItemID.AdamantitePickaxe
            });
            RecipeGroup.RegisterGroup("UniversalHamSaxes:Adamantite Pickaxe or Drill", ADPgroup);


            RecipeGroup CDPgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Chlorophyte Pickaxe or Drill", new int[]
            {
                ItemID.ChlorophyteDrill,
                ItemID.ChlorophytePickaxe
            });
            RecipeGroup.RegisterGroup("UniversalHamSaxes:Chlorophyte Pickaxe or Drill", CDPgroup);


            RecipeGroup MPDgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Mythril Pickaxe or Drill", new int[]
            {
                ItemID.MythrilDrill,
                ItemID.MythrilPickaxe
            });
            RecipeGroup.RegisterGroup("UniversalHamSaxes:Mythril Pickaxe or Drill", MPDgroup);


            RecipeGroup MCAgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Mythril Axe or Saw", new int[]
            {
                ItemID.MythrilWaraxe,
                ItemID.MythrilChainsaw
            });
            RecipeGroup.RegisterGroup("UniversalHamSaxes:Mythril Axe or Saw", MCAgroup);


            RecipeGroup OWCgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Orichalcum Axe or Saw", new int[]
            {
                ItemID.OrichalcumWaraxe,
                ItemID.OrichalcumChainsaw
            });
            RecipeGroup.RegisterGroup("UniversalHamSaxes:Orichalcum Axe or Saw", OWCgroup);


            RecipeGroup OPDAgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Orichalcum Pickaxe or Drill", new int[]
            {
                ItemID.OrichalcumPickaxe,
                ItemID.OrichalcumDrill
            });
            RecipeGroup.RegisterGroup("UniversalHamSaxes:Orichalcum Pickaxe or Drill", OPDAgroup);


            RecipeGroup PPDgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Palladium Pickaxe or Drill", new int[]
            {
                ItemID.PalladiumPickaxe,
                ItemID.PalladiumDrill
            });
            RecipeGroup.RegisterGroup("UniversalHamSaxes:Palladium Pickaxe or Drill", PPDgroup);


            RecipeGroup PASgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Palladium Axe or Saw", new int[]
            {
                ItemID.PalladiumWaraxe,
                ItemID.PalladiumChainsaw
            });
            RecipeGroup.RegisterGroup("UniversalHamSaxes:Palladium Axe or Saw", PASgroup);


            RecipeGroup TASgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Titanium Axe or Saw", new int[]
            {
                ItemID.TitaniumWaraxe,
                ItemID.TitaniumChainsaw
            });
            RecipeGroup.RegisterGroup("UniversalHamSaxes:Titanium Axe or Saw", TASgroup);


            RecipeGroup TPDgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Titanium Pickaxe or Drill", new int[]
            {
                ItemID.TitaniumPickaxe,
                ItemID.TitaniumDrill
            });
            RecipeGroup.RegisterGroup("UniversalHamSaxes:Titanium Pickaxe or Drill", TPDgroup);


            RecipeGroup CPDgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Cobalt Pickaxe or Drill", new int[]
			{
				ItemID.CobaltPickaxe,
				ItemID.CobaltDrill
			});
			RecipeGroup.RegisterGroup("UniversalHamSaxes:Cobalt Pickaxe or Drill", CPDgroup);


			RecipeGroup CASgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Cobalt Axe or Saw", new int[]
			{
				ItemID.CobaltWaraxe,
				ItemID.CobaltChainsaw
			});
			RecipeGroup.RegisterGroup("UniversalHamSaxes:Cobalt Axe or Saw", CASgroup);


			RecipeGroup LMTgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Cobalt/Palladium Tool", new int[]
			{
				ItemID.CobaltWaraxe,
				ItemID.CobaltChainsaw,
				ItemID.CobaltDrill,
				ItemID.CobaltPickaxe,
				ModContent.ItemType<CobaltHammer>(),
				ModContent.ItemType<PalladiumHammer>(),
				ItemID.PalladiumWaraxe,
				ItemID.PalladiumChainsaw,
				ItemID.PalladiumDrill,
				ItemID.PalladiumPickaxe
			});
			RecipeGroup.RegisterGroup("UniversalHamSaxes:Cobalt/Palladium Tool", LMTgroup);


			RecipeGroup LMBgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Cobalt/Palladium Bar", new int[]
			{
				ItemID.CobaltBar,
				ItemID.PalladiumBar
			});
			RecipeGroup.RegisterGroup("UniversalHamSaxes:Cobalt/Palladium Bar", LMBgroup);


			RecipeGroup EMTgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Copper/Tin Tool", new int[]
			{
				ItemID.CopperAxe,
				ItemID.CopperPickaxe,
				ItemID.CopperHammer,
				ItemID.TinAxe,
				ItemID.TinPickaxe,
				ItemID.TinHammer
			});
			RecipeGroup.RegisterGroup("UniversalHamSaxes:Copper/Tin Tool", EMTgroup);


			RecipeGroup EMBgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Copper/Tin Bar", new int[]
			{
				ItemID.CopperBar,
				ItemID.TinBar
			});
			RecipeGroup.RegisterGroup("UniversalHamSaxes:Copper/Tin Bar", EMBgroup);


        }
    }
}