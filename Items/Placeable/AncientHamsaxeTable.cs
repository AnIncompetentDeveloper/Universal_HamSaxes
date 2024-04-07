using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace UniversalHamSaxes.Items.Placeable
{
	class AncientHamsaxeTable : ModItem
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
			Item.value = 15000;
			Item.createTile = ModContent.TileType<Tiles.AncientHamsaxeTable>();
		}

		public override void AddRecipes() // Recipie for the item
		{
			CreateRecipe()
				.AddIngredient(ModContent.ItemType<ImprovedHamsaxeTable>())
				.AddIngredient<SpectreHamSaxe>()
				.AddIngredient(ItemID.FragmentSolar, 3)
				.AddIngredient(ItemID.FragmentNebula, 3)
				.AddIngredient(ItemID.FragmentStardust, 3)
				.AddIngredient(ItemID.FragmentVortex, 3)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
		}

	}
}
