using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UniversalHamSaxes.Tiles;

namespace UniversalHamSaxes.Items
{
    class OrichalcumHamSaxe : ModItem
    {
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
            Item.useTime = 9;
            Item.useAnimation = 25;
            Item.pick = 165;
            Item.axe = 18;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = 594000;
            Item.rare = ItemRarityID.LightRed;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        bool toggled = false;
        public override bool AltFunctionUse(Player player)
        {

            switch (toggled)
            {

                case true: // if hammerMode is true, it will disable hammer power on tools

                    Item.pick = 165;
                    Item.axe = 18;
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
                .AddRecipeGroup("UniversalHamSaxes:Orichalcum Pickaxe or Drill")
                .AddRecipeGroup("UniversalHamSaxes:Orichalcum Axe or Saw")
                .AddIngredient(ModContent.ItemType<OrichalcumHammer>())
                .AddTile(ModContent.TileType<ImprovedHamsaxeTable>())
                .Register();
            CreateRecipe()
                .AddRecipeGroup("UniversalHamSaxes:Orichalcum Pickaxe or Drill")
                .AddRecipeGroup("UniversalHamSaxes:Orichalcum Axe or Saw")
                .AddIngredient(ModContent.ItemType<OrichalcumHammer>())
                .AddTile(ModContent.TileType<AncientHamsaxeTable>())
                .Register();
        }
    }
}
