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

            RecipeGroup Cgroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Chlorophyte Axe or Saw", new int[]
            {
                ItemID.ChlorophyteGreataxe,
                ItemID.ChlorophyteChainsaw


            });

            RecipeGroup.RegisterGroup("UniversalTools:Chlorophyte Axe or Saw", Cgroup);

            

            RecipeGroup Agroup = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Adamantite Axe or Saw", new int[]
            {
                ItemID.AdamantiteChainsaw,
                ItemID.AdamantiteWaraxe

            });

            RecipeGroup.RegisterGroup("UniversalTools:Adamantite Axe or Saw", Agroup);

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

        }



    }





    

}

