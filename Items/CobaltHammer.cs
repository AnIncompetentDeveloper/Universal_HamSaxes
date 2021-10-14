using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace UniversalMultiTools.Items
{
  class CobaltHammer : ModItem
  {
    public override void SetStaticDefaults()
    {
      base.SetStaticDefaults();
      Tooltip.SetDefault("CobaltHammer");
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
      base.SetDefaults();
      Item.DamageType = DamageClass.Melee;
      Item.damage = 34;
      Item.width = 40;
      Item.height = 40;
      Item.useTime = 20;
      Item.useAnimation = 20;
      Item.hammer = 75;
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
        .AddIngredient(ItemID.CobaltBar,16)
        .AddTile(TileID.Anvils)
        .Register();
    }
  }
}
