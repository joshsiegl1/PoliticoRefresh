#region Using Statements
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

namespace PoliticoRefresh
{
    public class Capitol : Tile
    {
        static Texture2D texture;
        public static Texture2D Texture { get { return texture; } set { texture = value; } }
        static Texture2D texture_night;
        public static Texture2D Texture_Night { get { return texture_night; } set { texture_night = value; } }
        public Capitol(Vector2 position) : base(texture, position, texture_night)
        {

        }
        public override int TileNumber()
        {
            return 2;
        }
        public override bool CanBeDestroyed()
        {
            return false; 
        }

        public override void DrawLights(SpriteBatch sbatch, int offsetx, int offsety)
        {
            
        }
    }
}