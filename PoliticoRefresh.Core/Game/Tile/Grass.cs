#region Using Statements
using Microsoft.Xna.Framework; 
using Microsoft.Xna.Framework.Graphics;
#endregion

namespace PoliticoRefresh
{
    public class Grass : Tile
    {
        static Texture2D texture;
        public static Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }

        public Grass(Vector2 position) : base()
        {

        }
        public override bool CanBeReplaced()
        {
            return true; 
        }
        public override int TileNumber()
        {
            return 1;
        }
    }
}