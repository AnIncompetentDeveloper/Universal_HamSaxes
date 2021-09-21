using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UniversalHamSaxes.Items
{
    class SolarHamSaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            Tooltip.SetDefault("HamSaxe so bright it makes the sun jealous!");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.damage = 65;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 12;
            Item.useAnimation = 11;
            Item.pick = 225;
            Item.axe = 30;
            Item.hammer = 100;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = 3000;
            Item.rare = ItemRarityID.LightRed;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        public override void AddRecipes()
        {

            CreateRecipe()
                .AddIngredient(ItemID.LunarHamaxeSolar, 1)
                .AddIngredient(ItemID.SolarFlareAxe, 1)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }
}
