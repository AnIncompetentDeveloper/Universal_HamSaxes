using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UniversalHamSaxes.Tiles;

namespace UniversalHamSaxes.Items
{
    class PreeminentHamSaxe : ModItem
    {
        public override void SetStaticDefaults() // ToolTip for the tool
        {
            base.SetStaticDefaults();
            Tooltip.SetDefault("God wishes He could have this tool. . . Wait, how do you have this tool? | Rightclick to toggle Hammermode.");
        }

        public override void SetDefaults() // Basic Item Stats
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
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = 3;
            Item.rare = ItemRarityID.Red;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.tileBoost = -10;
        }

        bool toggled = false;
        public override bool AltFunctionUse(Player player)
        {

            switch (toggled)
            {

                case true: // if hammerMode is true, it will disable hammer power on tools

                    Item.pick = -350;
                    Item.axe = -45;
                    Item.hammer = 0;


                    toggled = !toggled;

                    Main.NewText("Hammer Mode is now OFF.");

                    break;


                case false: // if hammerMode is false, it will enable hammer power on tools


                    Item.axe = 0;
                    Item.pick = 0;
                    Item.hammer = -200;

                    toggled = !toggled;

                    Main.NewText("Hammer Mode is now ON.");

                    break;


            }
            return base.AltFunctionUse(player);


        }

        //public override void AddRecipes() // Recipie for the item
        //{
        // base.AddRecipes();
        //ModRecipe recipe = new ModRecipe(mod);
        //recipe.AddIngredient(ItemID.GoldAxe, 1);
        //recipe.AddIngredient(ItemID.GoldPickaxe, 1);
        //recipe.AddIngredient(ItemID.GoldHammer, 1);
        //recipe.AddTile(ModContent.TileType<EarlyHamSaxeTable>());
        // recipe.SetResult(this);
        // recipe.AddRecipe();
        //} 
    }
}
