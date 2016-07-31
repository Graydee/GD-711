using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Auralite.Tiles
{
	public class SlimeMoss : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = false;
            soundType = 27;
            soundStyle = 2;
			AddMapEntry(new Color(200, 200, 200));
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.00f;
			g = 1.75f;
			b = 0.35f;
		}
        public override bool KillSound(int i, int j)
        {
            Main.PlaySound(2, i * 16, j * 16, 27);
            return false;
        }
		public override void RandomUpdate(int i, int j)
		{
                if (Main.rand.Next(2) == 1)
                {
                    WorldGen.PlaceObject(i, j - 1, mod.TileType("SlimeMushroom"));
                }
		}
    }
}