#region Using Statements
using System.Reflection;
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

        static Texture2D flag_texture; 
        public static Texture2D Flag_Texture { get { return flag_texture;  } set { flag_texture = value; } }
        private Animation flagAnimation; 
        public Capitol(Vector2 position) : base(texture, position, texture_night)
        {
            flagAnimation = new Animation(Vector2.Zero, 25, 40, 8, true, 16);
        }
        public override void Update(GameTime gametime)
        {
            flagAnimation.UpdateSpriteSheet(gametime); 
            base.Update(gametime);
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

        public override void Draw(SpriteBatch sbatch, int offsetX, int offsetY)
        {
            base.Draw(sbatch, offsetX, offsetY);

            sbatch.Draw(flag_texture, new Vector2(Position.X + 30 - offsetX, Position.Y - 28 - offsetY), flagAnimation.SourceRect, selectedTint * ChronoCycle.DayColor, 0f, Vector2.Zero, 1f, SpriteEffects.None, (Y * 0.01f) + 0.001f + ChronoCycle.DayAdditive);
        }
    }
}