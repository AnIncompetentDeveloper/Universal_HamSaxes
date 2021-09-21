using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UniversalHamSaxes.Items
{
    class VortexHamSaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            Tooltip.SetDefault("Space and Time warp around this tool, almost as if it's existed for as long as the universe... perhaps even longer...!");
        }

        public override void SetDefaults()
        {
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
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        public override void AddRecipes()
        {
          

            CreateRecipe()
                .AddIngredient(ItemID.VortexPickaxe, 1)
                .AddIngredient(ItemID.LunarHamaxeVortex, 1)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }
}
