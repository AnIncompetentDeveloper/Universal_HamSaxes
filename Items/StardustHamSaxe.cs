using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace UniversalHamSaxes.Items
{
  class StardustHamSaxe : ModItem
  {
    public override void SetStaticDefaults()
    {
      base.SetStaticDefaults();
      Tooltip.SetDefault("The Dragons above made this over centuries, putting their very souls into this tool!");
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
      Item.damage = 65;
      Item.DamageType = DamageClass.Melee;
      Item.width = 40;
      Item.height = 40;
      Item.useTime = 12;
      Item.useAnimation = 11;
      Item.pick = 225;
      Item.axe = 30;
      Item.hammer = 100;
      Item.useStyle = ItemUseStyleID.Swing;
      Item.knockBack = 6;
      Item.value = 3000;
      Item.rare = ItemRarityID.Cyan;
      Item.UseSound = SoundID.Item1;
      Item.autoReuse = true;
    }

    public override void AddRecipes()
    {

      CreateRecipe()
        .AddIngredient(ItemID.LunarHamaxeNebula, 1)
        .AddIngredient(ItemID.StardustPickaxe, 1)
        .AddTile(TileID.LunarCraftingStation)
        .Register();
    }
  }
}
