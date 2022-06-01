using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UniversalHamSaxes.Tiles;

namespace UniversalHamSaxes.Items
{
    class ThePenultimateHamSaxe : ModItem
    {
        public override void SetStaticDefaults() // ToolTip for the tool
        {
            base.SetStaticDefaults();
            Tooltip.SetDefault("THE BEST TOOL, SECOND TO ONE! | Rightclick to toggle Hammermode.");
        }

        public override void SetDefaults() // Basic Item Stats
        {
            base.SetDefaults();
            Item.damage = 90;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 5;
            Item.useAnimation = 10;
            Item.pick = 250;
            Item.axe = 38;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = 3000;
            Item.rare = ItemRarityID.Master;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.tileBoost = 6;
        }

        bool toggled = false;
        public override bool AltFunctionUse(Player player)
        {

            switch (toggled)
            {

                case true: // if hammerMode is true, it will disable hammer power on tools

                    Item.pick = 250;
                    Item.axe = 38;
                    Item.hammer = 0;


                    toggled = !toggled;

                    Main.NewText("Hammer Mode is now OFF.");

                    break;


                case false: // if hammerMode is false, it will enable hammer power on tools


                    Item.axe = 0;
                    Item.pick = 0;
                    Item.hammer = 170;

                    toggled = !toggled;

                    Main.NewText("Hammer Mode is now ON.");

                    break;


            }
            return base.AltFunctionUse(player);


        }
        public override void AddRecipes() // Recipie for the item
        {

            CreateRecipe()
                .AddIngredient(ModContent.ItemType<SolarHamSaxe>())
                .AddIngredient(ModContent.ItemType<StardustHamSaxe>())
                .AddIngredient(ModContent.ItemType<NebulaHamSaxe>())
                .AddIngredient(ModContent.ItemType<VortexHamSaxe>())
                .AddIngredient(ItemID.LunarBar, 20)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }
}
