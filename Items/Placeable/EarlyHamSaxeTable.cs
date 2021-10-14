using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace UniversalHamSaxes.Items.Placeable
{
    class EarlyHamSaxeTable : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This be the HamSaxe Crafting Machine.");
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
			Item.createTile = ModContent.TileType<Tiles.EarlyHamSaxeTable>();
		}

		public override void AddRecipes()
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
