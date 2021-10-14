using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UniversalHamSaxes.Tiles;
using Terraria.GameContent.Creative;

namespace UniversalHamSaxes.Items
{
  class SilverHamSaxe : ModItem
  {
    public override void SetStaticDefaults()
    {
      base.SetStaticDefaults();
      Tooltip.SetDefault("The Copper tool to rule them all!");
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
      base.SetDefaults();
      Item.damage = 7;
      Item.DamageType = DamageClass.Melee;
      Item.width = 40;
      Item.height = 40;
      Item.useTime = 19;
      Item.useAnimation = 19;
      Item.pick = 35;
      Item.axe = 7;
      Item.hammer = 35;
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
        .AddIngredient(ItemID.SilverAxe, 1)
        .AddIngredient(ItemID.SilverHammer, 1)
        .AddIngredient(ItemID.SilverPickaxe, 1)
        .AddTile(ModContent.TileType<EarlyHamSaxeTable>());
    }
  }
}
