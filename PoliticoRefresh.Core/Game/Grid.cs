#region Using Statements
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content; 
#endregion

namespace PoliticoRefresh
{
    public class Grid
    {
        public const int GridWidth = 32;
        public const int GridHeight = 70;
        Tile[,] Tiles = new Tile[GridWidth, GridHeight];
        private string MapData { get; set; }
        public Grid() { }
        public void LoadContent(ContentManager Content)
        {
            string LevelDataPath = Path.Combine(Content.RootDirectory,
                "levelData.txt");
            MapData = File.ReadAllText(LevelDataPath);
            int index = 0;

            for (int x = 0; x < GridWidth; x++)
            {
                for (int y = 0; y < GridHeight; y++)
                {
                    index++;
                    int rowOffset = 0;
                    if (y % 2 == 1)
                        rowOffset = Tile.OddRowXOffset;

                    int tileNumber = int.Parse(MapData[index - 1].ToString());
                    Vector2 position = new Vector2(
                        (x * Tile.TileStepX) + rowOffset,
                        y * Tile.TileStepY);
                    Tiles[x, y] = TileFactory.Get(tileNumber, position);
                }
            }
        }

        public void KillTile(int x, int y)
        {
            Tiles[x, y] = TileFactory.Get(1, Tiles[x, y].Position); 
        }

        public void SetTiles(Tile[,] tiles)
        {
            Array.Copy(tiles, Tiles, GridWidth * GridHeight); 
        }

        public void Draw(SpriteBatch sbatch)
        {

        }
    }
}