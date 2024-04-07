using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace UniversalHamSaxes.Items.Placeable
{
    class HamsaxeTable : ModItem
    {
		public override void SetStaticDefaults() // ToolTip for the tool
		{

			Terraria.GameContent.Creative.CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() // Basic Item Stats
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
			Item.createTile = ModContent.TileType<Tiles.HamsaxeTable>();
		}

		public override void AddRecipes() // Recipie for the item
		{
			CreateRecipe()
				.AddIngredient(ItemID.WorkBench)
				.AddRecipeGroup("UniversalHamSaxes:Copper/Tin Tool")
				.AddRecipeGroup("UniversalHamSaxes:Copper/Tin Bar", 5)
				.AddTile(TileID.Anvils)
				.Register();
		}

	}
}
