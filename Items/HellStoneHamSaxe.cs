using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UniversalHamSaxes.Tiles;

namespace UniversalHamSaxes.Items
{
    class HellStoneHamSaxe : ModItem
    {
        public override void SetStaticDefaults() // ToolTip for the tool
        {
            base.SetStaticDefaults();
            Tooltip.SetDefault("Satan Approved!");
        }

        public override void SetDefaults() // Basic Item Stats
        {
            base.SetDefaults();
            Item.damage = 25;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 18;
            Item.useAnimation = 23;
            Item.pick = 100;
            Item.axe = 14;
            Item.hammer = 70;
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

                    Item.pick = 100;
                    Item.axe = 14;
                    Item.hammer = 0;


                    toggled = !toggled;

                    Main.NewText("Hammer Mode is now OFF.");

                    break;


                case false: // if hammerMode is false, it will enable hammer power on tools


                    Item.axe = 0;
                    Item.pick = 0;
                    Item.hammer = 70;

                    toggled = !toggled;

                    Main.NewText("Hammer Mode is now ON.");

                    break;


            }
            return base.AltFunctionUse(player);


        }

        public override void AddRecipes() // Recipie for the item
        {

            CreateRecipe()
                .AddIngredient(ItemID.MoltenHamaxe)
                .AddIngredient(ItemID.MoltenPickaxe)
                .AddTile(ModContent.TileType<EarlyHamSaxeTable>())
                .Register();
        }
    }
}
