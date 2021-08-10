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
    class LeadHamSaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            Tooltip.SetDefault("The Lead tool to rule them all!");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.damage = 20;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 19;
            item.useAnimation = 19;
            item.pick = 43;
            item.axe = 10;
            item.hammer = 43;
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
            recipe.AddIngredient(ItemID.LeadAxe, 1);
            recipe.AddIngredient(ItemID.LeadHammer, 1);
            recipe.AddIngredient(ItemID.LeadPickaxe, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
