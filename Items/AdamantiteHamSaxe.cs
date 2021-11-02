using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UniversalHamSaxes.Tiles;
using UniversalHamSaxes;

namespace UniversalHamSaxes.Items
{
    class AdamantiteHamSaxe : ModItem
    {
        bool toggled = false;
        


        public override void SetStaticDefaults() // ToolTip for the tool 
        {
            base.SetStaticDefaults();
            Tooltip.SetDefault("The Adamantite tool to rule them all!");
        }

        public override void SetDefaults() // Basic Item Stats
        {

            //var toggled = new HammerToggle();


            base.SetDefaults();

            Item.damage = 45;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 8;
            Item.useAnimation = 25;



            

            Item.pick = 180;
            Item.axe = 20;


            


       

            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = 3000;
            Item.rare = ItemRarityID.Red;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;



        }

        public override bool AltFunctionUse(Player player)
        {

            switch (toggled)
            {

                case true: // if hammerMode is true, it will disable hammer power on tools

                    Item.pick = 180;
                    Item.axe = 20;
                    Item.hammer = 0;


                    toggled = !toggled;

                    Main.NewText("Hammer Mode is now OFF.");

                    break;


                case false: // if hammerMode is false, it will enable hammer power on tools


                    Item.axe = 0;
                    Item.pick = 0;
                    Item.hammer = 80;

                    toggled = !toggled;

                    Main.NewText("Hammer Mode is now ON.");

                    break;


            }

            
            
            return base.AltFunctionUse(player);
            

        }

        public override void AddRecipes() // Recipie for the item
        {


            CreateRecipe()
                .AddIngredient(ModContent.ItemType<AdamantiteHammer>(), 1)
                .AddRecipeGroup("UniversalHamSaxes:Adamantite Pickaxe or Drill")
                .AddRecipeGroup("UniversalHamSaxes:Adamantite Axe or Saw")
                .AddTile(ModContent.TileType<LateHamSaxeTable>())
                .Register();

        }
    }
}
