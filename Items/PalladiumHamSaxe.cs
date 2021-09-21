using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UniversalHamSaxes.Tiles;

namespace UniversalHamSaxes.Items
{
    class PalladiumHamSaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            Tooltip.SetDefault("PalladiumHamSaxe");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.damage = 40;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 25;
            Item.useAnimation = 25;
            Item.pick = 130;
            Item.axe = 15;
            Item.hammer = 75;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = 3000;
            Item.rare = ItemRarityID.Red;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        public override void AddRecipes()
        {

            CreateRecipe()
                .AddRecipeGroup("UniversalHamSaxes:Palladium Pickaxe or Drill")
                .AddRecipeGroup("UniversalHamSaxes:Palladium Axe or Saw")
                .AddIngredient(ModContent.ItemType<PalladiumHammer>())
                .AddTile(ModContent.TileType<LateHamSaxeTable>())
                .Register();
        }
    }
}
