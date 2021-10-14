using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace UniversalMultiTools.Items.Placeable
{
    class EarlyMultiToolTable : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This be the MultiTool Crafting Machine.");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 14;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
			Item.value = 150;
			Item.createTile = ModContent.TileType<Tiles.EarlyMultiToolTable>();
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.WorkBench)
				.AddRecipeGroup("UniversalMultiTools:Copper/Tin Tool")
				.AddRecipeGroup("UniversalMultiTools:Copper/Tin Bar", 5)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}
