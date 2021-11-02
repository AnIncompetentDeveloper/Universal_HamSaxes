using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UniversalHamSaxes.Tiles;

namespace UniversalHamSaxes.Items
{
    class MythrilHamSaxe : ModItem
    {
        public override void SetStaticDefaults() // ToolTip for the tool
        {
            base.SetStaticDefaults();
            Tooltip.SetDefault("MythrilHamSaxe");
        }

        public override void SetDefaults() // Basic Item Stats
        {
            base.SetDefaults();
            Item.damage = 45;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 10;
            Item.useAnimation = 25;
            Item.pick = 150;
            Item.axe = 17;
            Item.hammer = 75;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = 3000;
            Item.rare = ItemRarityID.Red;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        bool toggled = false;
        public override bool AltFunctionUse(Player player)
        {

            switch (toggled)
            {

                case true: // if hammerMode is true, it will disable hammer power on tools

                    Item.pick = 150;
                    Item.axe = 17;
                    Item.hammer = 0;


                    toggled = !toggled;

                    Main.NewText("Hammer Mode is now OFF.");

                    break;


                case false: // if hammerMode is false, it will enable hammer power on tools


                    Item.axe = 0;
                    Item.pick = 0;
                    Item.hammer = 75;

                    toggled = !toggled;

                    Main.NewText("Hammer Mode is now ON.");

                    break;


            }
            return base.AltFunctionUse(player);


        }
        public override void AddRecipes() // Recipie for the item
        {

            CreateRecipe()
                .AddRecipeGroup("UniversalHamSaxes:Mythril Pickaxe or Drill")
                .AddRecipeGroup("UniversalHamSaxes:Mythril Axe or Saw")
                .AddIngredient(ModContent.ItemType<MythrilHammer>())
                .AddTile(ModContent.TileType<LateHamSaxeTable>())
                .Register();
        }
    }
}
