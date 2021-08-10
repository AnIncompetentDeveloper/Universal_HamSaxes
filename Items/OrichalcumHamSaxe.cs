using UniversalTools.Items;
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
using Terraria.World.Generation;

namespace UniversalTools.Items
{
    class OrichalcumHamSaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            Tooltip.SetDefault("OrichalcumHamSaxe!");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.damage = 20;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 25;
            item.useAnimation = 25;
            item.pick = 165;
            item.axe = 18;
            item.hammer = 80;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 6;
            item.value = 3000;
            item.rare = ItemRarityID.Red;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<OrichalcumHammer>());
            recipe.AddRecipeGroup("UniversalTools:Orichalcum Pickaxe or Drill");
            recipe.AddRecipeGroup("UniversalTools:Orichalcum Axe or Saw");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
