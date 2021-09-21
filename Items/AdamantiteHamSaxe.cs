using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UniversalHamSaxes.Tiles;

namespace UniversalHamSaxes.Items
{
    class AdamantiteHamSaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            Tooltip.SetDefault("The Adamantite tool to rule them all!");
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
            Item.pick = 180;
            Item.axe = 20;
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
                .AddIngredient(ModContent.ItemType<AdamantiteHammer>(), 1)
                .AddRecipeGroup("UniversalHamSaxes:Adamantite Pickaxe or Drill")
                .AddRecipeGroup("UniversalHamSaxes:Adamantite Axe or Saw")
                .AddTile(ModContent.TileType<LateHamSaxeTable>())
                .Register();

        }
    }
}
