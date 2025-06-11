#region Using Statements
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
#endregion

namespace PoliticoRefresh
{
    public class House : Tile
    {
        static Texture2D texture;
        public static Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }

        static Texture2D texture_night; 
        public static Texture2D TextureNight { get { return texture_night; } set { texture_night = value; }}
        public House(Vector2 position) : base(texture, position, texture_night)
        {
        }
        public House(Texture2D texture, Vector2 position, Texture2D texture_night) : base(texture, position, texture_night)
        {
        }

        public override void DrawLights(SpriteBatch sbatch, int offsetx, int offsety)
        {
            return; 
        }

        public override int TileNumber()
        {
            return 4; 
        }
    }
}