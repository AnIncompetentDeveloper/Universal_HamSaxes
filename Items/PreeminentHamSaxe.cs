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
    class PreeminentHamSaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            Tooltip.SetDefault("God wishes He could have this tool. . . Wait, how do you have this tool?");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.damage = 20;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 3000;
            item.useAnimation = 3000;
            item.pick = -350;
            item.axe = -45;
            item.hammer = -200;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 6;
            item.value = 3;
            item.rare = ItemRarityID.Red;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        //public override void AddRecipes()
        //{
           // base.AddRecipes();
            //ModRecipe recipe = new ModRecipe(mod);
            //recipe.AddIngredient(ItemID.GoldAxe, 1);
            //recipe.AddIngredient(ItemID.GoldPickaxe, 1);
            //recipe.AddIngredient(ItemID.GoldHammer, 1);
            //recipe.AddTile(TileID.Anvils);
           // recipe.SetResult(this);
           // recipe.AddRecipe();
        //} fuckfuckfuckfuckfuck
    }
}
