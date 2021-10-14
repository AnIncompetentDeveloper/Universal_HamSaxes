using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace UniversalMultiTools.Items.Placeable
{
	class LateMultiToolTable : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This be the MultiTool Crafting Machine but now, new and improved!");
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
			Item.createTile = ModContent.TileType<Tiles.LateMultiToolTable>();
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ModContent.ItemType<EarlyMultiToolTable>())
				.AddRecipeGroup("UniversalMultiTools:Cobalt/Palladium Tool")
				.AddRecipeGroup("UniversalMultiTools:Cobalt/Palladium Bar", 10)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}

	}
}
