using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UniversalHamSaxes.Tiles;
using Terraria.GameContent.Creative;

namespace UniversalHamSaxes.Items
{
  class OrichalcumHamSaxe : ModItem
  {
    public override void SetStaticDefaults()
    {
      base.SetStaticDefaults();
      Tooltip.SetDefault("OrichalcumHamSaxe!");
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
      base.SetDefaults();
      Item.damage = 45;
      Item.DamageType = DamageClass.Melee;
      Item.width = 40;
      Item.height = 40;
      Item.useTime = 25;
      Item.useAnimation = 25;
      Item.pick = 165;
      Item.axe = 18;
      Item.hammer = 80;
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
        .AddRecipeGroup("UniversalHamSaxes:Orichalcum Pickaxe or Drill")
        .AddRecipeGroup("UniversalHamSaxes:Orichalcum Axe or Saw")
        .AddIngredient(ModContent.ItemType<OrichalcumHammer>())
        .AddTile(ModContent.TileType<LateHamSaxeTable>())
        .Register();
    }
  }
}
