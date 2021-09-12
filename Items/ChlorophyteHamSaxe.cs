using UniversalHamSaxes.Items;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace UniversalHamSaxes.Items
{
    class ChlorophyteHamSaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            Tooltip.SetDefault("The Chlorophyte tool to rule them all!");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.damage = 20;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 25;
            Item.useAnimation = 25;
            Item.pick = 200;
            Item.axe = 23;
            Item.hammer = 90;
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
                .AddRecipeGroup("UniversalHamSaxes:Chlorophyte Pickaxe or Drill")
                .AddRecipeGroup("UniversalHamSaxes:Chlorophyte Axe or Saw")
                .AddIngredient(ItemID.ChlorophyteWarhammer)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}
