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
            // base.SetStaticDefaults();

            Terraria.GameContent.Creative.CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults() // Basic Item Stats
        {
            base.SetDefaults();
            Item.damage = 110;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 3;
            Item.useAnimation = 3;
            Item.pick = 350;
            Item.axe = 45;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = 100000000;
            Item.rare = ItemRarityID.Master;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.tileBoost = 10;
        }

        bool toggled = false;
        public override bool AltFunctionUse(Player player)
        {

            switch (toggled)
            {

                case true: // if hammerMode is true, it will disable hammer power on tools

                    Item.pick = 350;
                    Item.axe = 45;
                    Item.hammer = 0;


                    toggled = !toggled;

                    Main.NewText("Hammer Mode is now [c/df0000:OFF].");

                    break;


                case false: // if hammerMode is false, it will enable hammer power on tools


                    Item.axe = 0;
                    Item.pick = 0;
                    Item.hammer = 200;

                    toggled = !toggled;

                    Main.NewText("Hammer Mode is now [c/1ddb04:ON].");

                    break;


            }
            return base.AltFunctionUse(player);


        }

        public override void AddRecipes() // Recipie for the item
        {
            CreateRecipe()
                .AddIngredient<SilverHamSaxe>()
                .AddIngredient<TinHamSaxe>()
                .AddIngredient<CopperHamSaxe>()
                .AddIngredient<AdamantiteHamSaxe>()
                .AddIngredient<ChlorophyteHamSaxe>()
                .AddIngredient<CobaltHamSaxe>()
                .AddIngredient<EndOfDawn>()
                .AddIngredient<FleshSeeker>()
                .AddIngredient<GoldHamSaxe>()
                .AddIngredient<IronHamSaxe>()
                .AddIngredient<LeadHamSaxe>()
                .AddIngredient<MoltenHamSaxe>()
                .AddIngredient<MythrilHamSaxe>()
                .AddIngredient<NebulaHamSaxe>()
                .AddIngredient<OrichalcumHamSaxe>()
                .AddIngredient<PalladiumHamSaxe>()
                .AddIngredient<PearlwoodHamSaxe>()
                .AddIngredient<PlatinumHamSaxe>()
                .AddIngredient<SolarHamSaxe>()
                .AddIngredient<SpectreHamSaxe>()
                .AddIngredient<TitaniumHamSaxe>()
                .AddIngredient<TungstenHamSaxe>()
                .AddIngredient<ThePenultimateHamSaxe>()
                .AddIngredient<PearlwoodHamSaxe>()
                .AddTile(ModContent.TileType<AncientHamsaxeTable>())
                .Register();
        }
    }
}
