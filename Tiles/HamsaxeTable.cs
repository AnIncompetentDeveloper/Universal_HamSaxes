using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ObjectData;
using System.Collections.Generic;
using UniversalHamSaxes;


namespace UniversalHamSaxes.Tiles
{
    public class HamsaxeTable : ModTile
    {

        public override void SetStaticDefaults() // Cheezits are good
		{

			base.SetStaticDefaults();

			Main.tileSolidTop[Type] = true; // Basic Peramaters for the certain Tile I want it to be
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileTable[Type] = false;
			Main.tileLavaDeath[Type] = true;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2); // How big; the dimensions of the tile
			TileObjectData.newTile.CoordinateHeights = new int[2] { 16, 18 };

			TileObjectData.addTile(Type);


			AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable); // Tile Type
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("HamSaxe Crafting Table");
			AddMapEntry(new Color(200, 200, 200), name);

			TileID.Sets.DisableSmartCursor[Type] = true;

		}


		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 16, ModContent.ItemType<Items.Placeable.HamsaxeTable>()); // Item
		}

	}
}
