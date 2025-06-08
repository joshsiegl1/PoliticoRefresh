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

        static Texture2D texture_night; 
        public static Texture2D TextureNight { get { return texture_night; } set { texture_night = value; }}

        public Grass(Vector2 position) : base(texture, position, texture_night)
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

        public override void DrawLights(SpriteBatch sbatch, int offsetx, int offsety)
        {
            
        }
    }
}