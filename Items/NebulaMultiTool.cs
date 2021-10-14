using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace UniversalMultiTools.Items
{
  class NebulaMultiTool : ModItem
  {
    public override void SetStaticDefaults()
    {
      base.SetStaticDefaults();
      Tooltip.SetDefault("You feel magic energy pouring out of this tool, almost like it's trying to tell you something...");
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
      base.SetDefaults();
      Item.damage = 65;
      Item.DamageType = DamageClass.Melee;
      Item.width = 40;
      Item.height = 40;
      Item.useTime = 12;
      Item.useAnimation = 12;
      Item.pick = 225;
      Item.axe = 30;
      Item.hammer = 100;
      Item.useStyle = ItemUseStyleID.Swing;
      Item.knockBack = 6;
      Item.value = 3000;
      Item.rare = ItemRarityID.Purple;
      Item.UseSound = SoundID.Item1;
      Item.autoReuse = true;
    }

    public override void AddRecipes()
    {

      CreateRecipe()
        .AddIngredient(ItemID.NebulaPickaxe)
        .AddIngredient(ItemID.LunarHamaxeNebula)
        .AddTile(TileID.LunarCraftingStation)
        .Register();
    }
  }
}
