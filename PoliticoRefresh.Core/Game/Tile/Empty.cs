
using Microsoft.Xna.Framework; 
using Microsoft.Xna.Framework.Graphics;

namespace PoliticoRefresh
{
    public class Empty : Tile
    {
        public Empty(Vector2 position) : base()
        { 

        }

        public override int TileNumber()
        {
            return 0;
        }
    }
}