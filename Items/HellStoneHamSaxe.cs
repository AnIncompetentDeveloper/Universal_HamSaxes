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
    class HellStoneHamSaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            Tooltip.SetDefault("Satan Approved!");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.damage = 20;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 23;
            item.useAnimation = 23;
            item.pick = 100;
            item.axe = 30;
            item.hammer = 70;
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
            recipe.AddIngredient(ItemID.MoltenHamaxe, 1);
            recipe.AddIngredient(ItemID.MoltenPickaxe, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
