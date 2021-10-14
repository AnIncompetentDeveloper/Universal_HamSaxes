using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UniversalMultiTools.Tiles;
using Terraria.GameContent.Creative;

namespace UniversalMultiTools.Items
{
  class PreeminentMultiTool : ModItem
  {
    public override void SetStaticDefaults()
    {
      base.SetStaticDefaults();
      Tooltip.SetDefault("God wishes He could have this tool. . . Wait, how do you have this tool?");
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
      base.SetDefaults();
      Item.damage = 110;
      Item.DamageType = DamageClass.Melee;
      Item.width = 40;
      Item.height = 40;
      Item.useTime = 3000;
      Item.useAnimation = 3000;
      Item.pick = -350;
      Item.axe = -45;
      Item.hammer = -200;
      Item.useStyle = ItemUseStyleID.Swing;
      Item.knockBack = 6;
      Item.value = 3;
      Item.rare = ItemRarityID.Red;
      Item.UseSound = SoundID.Item1;
      Item.autoReuse = true;
    }

    //public override void AddRecipes()
    //{
       // base.AddRecipes();
      //ModRecipe recipe = new ModRecipe(mod);
      //recipe.AddIngredient(ItemID.GoldAxe, 1);
      //recipe.AddIngredient(ItemID.GoldPickaxe, 1);
      //recipe.AddIngredient(ItemID.GoldHammer, 1);
      //recipe.AddTile(ModContent.TileType<EarlyMultiToolTable>());
       // recipe.SetResult(this);
       // recipe.AddRecipe();
    //} 
  }
}
