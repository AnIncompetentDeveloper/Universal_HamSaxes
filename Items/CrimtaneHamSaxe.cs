using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UniversalHamSaxes.Tiles;

namespace UniversalHamSaxes.Items
{
    class CrimtaneHamSaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            Tooltip.SetDefault("It is I, the Fleshiest Fry!");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.damage = 25;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 22;
            Item.useAnimation = 22;
            Item.pick = 70;
            Item.axe = 15;
            Item.hammer = 55;
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
                .AddIngredient(ItemID.FleshGrinder)
                .AddIngredient(ItemID.DeathbringerPickaxe)
                .AddIngredient(ItemID.BloodLustCluster)
                .AddTile(ModContent.TileType<EarlyHamSaxeTable>())
                .Register();
        }
    }
}
