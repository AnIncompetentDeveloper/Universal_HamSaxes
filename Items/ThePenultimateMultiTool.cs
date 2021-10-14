using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UniversalMultiTools.Tiles;
using Terraria.GameContent.Creative;

namespace UniversalMultiTools.Items
{
  class ThePenultimateMultiTool : ModItem
  {
    public override void SetStaticDefaults()
    {
      base.SetStaticDefaults();
      Tooltip.SetDefault("THE BEST TOOL, SECOND TO ONE!");
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
      base.SetDefaults();
      Item.damage = 90;
      Item.DamageType = DamageClass.Melee;
      Item.width = 40;
      Item.height = 40;
      Item.useTime = 10;
      Item.useAnimation = 9;
      Item.pick = 250;
      Item.axe = 38;
      Item.hammer = 170;
      Item.useStyle = ItemUseStyleID.Swing;
      Item.knockBack = 6;
      Item.value = 3000;
      Item.rare = ItemRarityID.Master;
      Item.UseSound = SoundID.Item1;
      Item.autoReuse = true;
    }

    public override void AddRecipes()
    {

      CreateRecipe()
        .AddIngredient(ModContent.ItemType<SolarMultiTool>())
        .AddIngredient(ModContent.ItemType<StardustMultiTool>())
        .AddIngredient(ModContent.ItemType<NebulaMultiTool>())
        .AddIngredient(ItemID.LunarBar, 20)
        .AddTile(TileID.LunarCraftingStation)
        .Register();
    }
  }
}
