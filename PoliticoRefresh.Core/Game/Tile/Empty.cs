
using Microsoft.Xna.Framework; 
using Microsoft.Xna.Framework.Graphics;

namespace PoliticoRefresh
{
    public class Empty : Tile
    {
                static Texture2D texture;
        public static Texture2D Texture { get { return texture; } set { texture = value; } }
        public Empty(Vector2 position) : base(texture, position)
        {

        }

        public override void DrawLights(SpriteBatch sbatch, int offsetx, int offsety)
        {
            
        }

        public override int TileNumber()
        {
            return 0;
        }
    }
}