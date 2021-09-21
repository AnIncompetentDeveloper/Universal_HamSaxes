using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UniversalHamSaxes.Items
{
    class TitaniumHammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            Tooltip.SetDefault("TitaniumHammer");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.damage = 45;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.hammer = 80;
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
                .AddIngredient(ItemID.TitaniumBar, 16)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}
