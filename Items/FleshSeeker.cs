using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UniversalHamSaxes.Tiles;

namespace UniversalHamSaxes.Items
{
    class FleshSeeker : ModItem
    {
        public override void SetStaticDefaults() // ToolTip for the tool
        {
            base.SetStaticDefaults();
            Tooltip.SetDefault("It is I, the Fleshiest Fry! | Rightclick while holding tool to toggle Hammermode.");
            Terraria.GameContent.Creative.CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults() // Basic Item Stats
        {
            base.SetDefaults();
            Item.damage = 25;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 14;
            Item.useAnimation = 22;
            Item.pick = 70;
            Item.axe = 15;
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

                    Item.pick = 70;
                    Item.axe = 15;
                    Item.hammer = 0;


                    toggled = !toggled;

                    Main.NewText("Hammer Mode is now [c/df0000:OFF].");

                    break;


                case false: // if hammerMode is false, it will enable hammer power on tools


                    Item.axe = 0;
                    Item.pick = 0;
                    Item.hammer = 55;

                    toggled = !toggled;

                    Main.NewText("Hammer Mode is now [c/1ddb04:ON].");

                    break;


            }
            return base.AltFunctionUse(player);


        }

        public override void AddRecipes() // Recipie for the item
        {
           
            CreateRecipe()
                .AddIngredient(ItemID.FleshGrinder)
                .AddIngredient(ItemID.DeathbringerPickaxe)
                .AddIngredient(ItemID.BloodLustCluster)
                .AddTile(ModContent.TileType<HamsaxeTable>())
                .Register();
            CreateRecipe()
                .AddIngredient(ItemID.FleshGrinder)
                .AddIngredient(ItemID.DeathbringerPickaxe)
                .AddIngredient(ItemID.BloodLustCluster)
                .AddTile(ModContent.TileType<ImprovedHamsaxeTable>())
                .Register();
        }
    }
}
