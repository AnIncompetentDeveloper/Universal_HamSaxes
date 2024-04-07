using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UniversalHamSaxes.Items
{
    class AdamantiteHammer : ModItem
    {
        public override void SetStaticDefaults() // ToolTip for the tool
        {
            // base.SetStaticDefaults();

            Terraria.GameContent.Creative.CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults() // Basic Item Stats
        {
            base.SetDefaults();
            Item.damage = 40;
            Item.DamageType = DamageClass.Melee;
            Item.width = 42;
            Item.height = 42;
            Item.useTime = 20;
            Item.useAnimation = 8;
            Item.hammer = 80;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = 216000;
            Item.rare = ItemRarityID.LightRed;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        public override void AddRecipes() // Recipie for the item
        {
            CreateRecipe()
                .AddIngredient(ItemID.AdamantiteBar, 16)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }

    }   

}
