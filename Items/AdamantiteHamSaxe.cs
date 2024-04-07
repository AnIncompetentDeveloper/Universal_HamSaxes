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
            // base.SetStaticDefaults();

            Terraria.GameContent.Creative.CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults() // Basic Item Stats
        {



            base.SetDefaults();

            Item.damage = 45;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 36;
            Item.useTime = 8;
            Item.useAnimation = 25;
            Item.pick = 180;
            Item.axe = 20;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = 648000;
            Item.rare = ItemRarityID.LightRed;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;



        }

        public override bool AltFunctionUse(Player player)
        {

            switch (toggled)
            {

                case true: // if hammerMode is true, it will disable hammer power on
                           // 






                    Item.pick = 180;
                    Item.axe = 20;
                    Item.hammer = 0;


                    toggled = !toggled;

                    Main.NewText("Hammer Mode is now [c/df0000:OFF].");

                    break;


                case false: // if hammerMode is false, it will enable hammer power on tools


                    Item.axe = 0;
                    Item.pick = 0;
                    Item.hammer = 80;

                    toggled = !toggled;

                    Main.NewText("Hammer Mode is now [c/1ddb04:ON].");

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
                .AddTile(ModContent.TileType<ImprovedHamsaxeTable>())
                .Register();
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<AdamantiteHammer>(), 1)
                .AddRecipeGroup("UniversalHamSaxes:Adamantite Pickaxe or Drill")
                .AddRecipeGroup("UniversalHamSaxes:Adamantite Axe or Saw")
                .AddTile(ModContent.TileType<AncientHamsaxeTable>())
                .Register();

        }
    }
}
