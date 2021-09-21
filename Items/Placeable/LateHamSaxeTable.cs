using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace UniversalHamSaxes.Items.Placeable
{
	class LateHamSaxeTable : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This be the HamSaxe Crafting Machine but now, new and improved!");
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
			Item.createTile = ModContent.TileType<Tiles.LateHamSaxeTable>();
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ModContent.ItemType<EarlyHamSaxeTable>())
				.AddRecipeGroup("UniversalHamSaxes:Cobalt/Palladium Tool")
				.AddRecipeGroup("UniversalHamSaxes:Cobalt/Palladium Bar", 10)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}

	}
}
