using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;


namespace UniversalHamSaxes.Tiles
{
	public class AncientHamsaxeTable : ModTile
	{

		public override void SetStaticDefaults() // I_Love_Tiles_I_Love_Tiles_I_Love_Tiles_I_Love_Tiles_I_Love_Tiles_I_Love_Tiles_I_Love_Tiles_I_Love_Tiles_I_Love_Tiles_I_Love_Tiles_
        {

			// base.SetStaticDefaults();

			Main.tileSolidTop[Type] = false;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileTable[Type] = false;
			Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
			TileObjectData.newTile.DrawYOffset = 0;
            TileObjectData.addTile(Type);
			AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
			LocalizedText name = CreateMapEntryName();

			AddMapEntry(new Color(75, 15, 75), name);

			TileID.Sets.DisableSmartCursor[Type] = true;

			AnimationFrameHeight = 54;


		}

		public override void AnimateTile(ref int frame, ref int frameCounter)
		{

			if (++frameCounter >= 8)
			{
				frameCounter = 0;
				if (++frame >= 8)
				{
					frame = 0;
				}
			}


		}


		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 16, ModContent.ItemType<Items.Placeable.AncientHamsaxeTable>());
		}

	}
}
