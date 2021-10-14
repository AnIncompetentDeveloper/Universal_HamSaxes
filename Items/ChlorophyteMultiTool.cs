using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UniversalMultiTools.Tiles;
using Terraria.GameContent.Creative;

namespace UniversalMultiTools.Items
{
  class ChlorophyteMultiTool : ModItem
  {
    public override void SetStaticDefaults()
    {
      base.SetStaticDefaults();
      Tooltip.SetDefault("The Chlorophyte tool to rule them all!");
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
      base.SetDefaults();
      Item.damage = 75;
      Item.DamageType = DamageClass.Melee;
      Item.width = 40;
      Item.height = 40;
      Item.useTime = 25;
      Item.useAnimation = 25;
      Item.pick = 200;
      Item.axe = 23;
      Item.hammer = 90;
      Item.useStyle = ItemUseStyleID.Swing;
      Item.knockBack = 6;
      Item.value = 3000;
      Item.rare = ItemRarityID.Red;
      Item.UseSound = SoundID.Item1;
      Item.autoReuse = true;
    }

    public override void AddRecipes()
    {
      CreateRecipe()
        .AddRecipeGroup("UniversalMultiTools:Chlorophyte Pickaxe or Drill")
        .AddRecipeGroup("UniversalMultiTools:Chlorophyte Axe or Saw")
        .AddIngredient(ItemID.ChlorophyteWarhammer)
        .AddTile(ModContent.TileType<LateMultiToolTable>())
        .Register();
    }
  }
}
