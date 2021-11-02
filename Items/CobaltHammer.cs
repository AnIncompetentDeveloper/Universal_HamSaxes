using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UniversalHamSaxes.Items
{
    class CobaltHammer : ModItem
    {
        public override void SetStaticDefaults() // ToolTip for the tool
        {
            base.SetStaticDefaults();
            Tooltip.SetDefault("CobaltHammer");
        }

        public override void SetDefaults() // Basic Item Stats
        {
            base.SetDefaults();

            Item.DamageType = DamageClass.Melee;

            Item.damage = 34;

            Item.width = 40;
            Item.height = 40;
            Item.useTime = 9;
            Item.useAnimation = 20;
            Item.hammer = 75;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = 3000;
            Item.rare = ItemRarityID.Red;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        public override void AddRecipes() // Recipie for the item
        {
            CreateRecipe()
                .AddIngredient(ItemID.CobaltBar,16)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
