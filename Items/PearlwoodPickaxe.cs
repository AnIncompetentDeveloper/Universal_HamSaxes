using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

// Thanks to Misty for the Textures + Idea/Suggestion for a Pearlwood Pickaxe + Pearlwood Axe + Hamsaxe

namespace UniversalHamSaxes.Items
{
    class PearlwoodPickaxe : ModItem
    {
        public override void SetStaticDefaults() // ToolTip for the tool
        {
            // base.SetStaticDefaults();

            Terraria.GameContent.Creative.CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults() // Basic Item Stats
        {
            base.SetDefaults();
            Item.damage = 5;
            Item.DamageType = DamageClass.Melee;
            Item.width = 32;
            Item.height = 32;
            Item.useTime = 14;
            Item.useAnimation = 21;
            Item.pick = 35;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = 10;
            Item.rare = ItemRarityID.White;
            Item.UseSound = SoundID.Item126;
            Item.autoReuse = true;
        }

        public override void AddRecipes() // Recipie for the item
        {
            CreateRecipe()
                .AddIngredient(ItemID.Pearlwood, 16)
                .AddTile(TileID.WorkBenches)
                .Register();
        }

    }

}
