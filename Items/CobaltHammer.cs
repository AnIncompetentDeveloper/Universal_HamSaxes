using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UniversalHamSaxes.Items
{
    class CobaltHammer : ModItem
    {
        public override void SetStaticDefaults() // ToolTip for the tool
        {
            // base.SetStaticDefaults();

            Terraria.GameContent.Creative.CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults() // Basic Item Stats
        {
            base.SetDefaults();

            Item.DamageType = DamageClass.Melee;

            Item.damage = 34;

            Item.width = 32;
            Item.height = 32;
            Item.useTime = 9;
            Item.useAnimation = 20;
            Item.hammer = 75;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = 108000;
            Item.rare = ItemRarityID.LightRed;
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
