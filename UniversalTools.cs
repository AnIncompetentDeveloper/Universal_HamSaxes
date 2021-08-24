using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Terraria.Localization;

namespace UniversalTools
{
    public class UniversalTools : Mod
    {

        public UniversalTools()
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

            RecipeGroup.RegisterGroup("UniversalTools:Chlorophyte Axe or Saw", CAWgroup);

            

            RecipeGroup AASgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Adamantite Axe or Saw", new int[]
            {
                ItemID.AdamantiteChainsaw,
                ItemID.AdamantiteWaraxe

            });

            RecipeGroup.RegisterGroup("UniversalTools:Adamantite Axe or Saw", AASgroup);

            RecipeGroup ADPgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Adamantite Pickaxe or Drill", new int[]
            {
                ItemID.AdamantiteDrill,
                ItemID.AdamantitePickaxe

            });

            RecipeGroup.RegisterGroup("UniversalTools:Adamantite Pickaxe or Drill", ADPgroup);


            RecipeGroup CDPgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Chlorophyte Pickaxe or Drill", new int[]
            {
                ItemID.ChlorophyteDrill,
                ItemID.ChlorophytePickaxe

            });

            RecipeGroup.RegisterGroup("UniversalTools:Chlorophyte Pickaxe or Drill", CDPgroup);


            RecipeGroup MPDgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Mythril Pickaxe or Drill", new int[]
            {
                ItemID.MythrilDrill,
                ItemID.MythrilPickaxe

            });

            RecipeGroup.RegisterGroup("UniversalTools:Mythril Pickaxe or Drill", MPDgroup);


            RecipeGroup MCAgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Mythril Axe or Saw", new int[]
            {
                ItemID.MythrilWaraxe,
                ItemID.MythrilChainsaw

            });

            RecipeGroup.RegisterGroup("UniversalTools:Mythril Axe or Saw", MCAgroup);


            RecipeGroup OWCgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Orichalcum Axe or Saw", new int[]
            {
                ItemID.OrichalcumWaraxe,
                ItemID.OrichalcumChainsaw

            });

            RecipeGroup.RegisterGroup("UniversalTools:Orichalcum Axe or Saw", OWCgroup);


            RecipeGroup OPDAgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Orichalcum Pickaxe or Drill", new int[]
            {
                ItemID.OrichalcumPickaxe,
                ItemID.OrichalcumDrill

            });

            RecipeGroup.RegisterGroup("UniversalTools:Orichalcum Pickaxe or Drill", OPDAgroup);


            RecipeGroup PPDgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Palladium Pickaxe or Drill", new int[]
            {
                ItemID.PalladiumPickaxe,
                ItemID.PalladiumDrill

            });

            RecipeGroup.RegisterGroup("UniversalTools:Palladium Pickaxe or Drill", PPDgroup);


            RecipeGroup PASgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Palladium Axe or Saw", new int[]
            {
                ItemID.PalladiumWaraxe,
                ItemID.PalladiumChainsaw

            });

            RecipeGroup.RegisterGroup("UniversalTools:Palladium Axe or Saw", PASgroup);

            RecipeGroup TASgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Titanium Axe or Saw", new int[]
            {
                ItemID.TitaniumWaraxe,
                ItemID.TitaniumChainsaw

            });

            RecipeGroup.RegisterGroup("UniversalTools:Titanium Axe or Saw", TASgroup);

            RecipeGroup TPDgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Titanium Pickaxe or Drill", new int[]
            {
                ItemID.TitaniumPickaxe,
                ItemID.TitaniumDrill

            });

            RecipeGroup.RegisterGroup("UniversalTools:Titanium Pickaxe or Drill", TPDgroup);




        }



    }





    

}

