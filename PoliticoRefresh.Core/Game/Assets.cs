#region Using Statements
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
#endregion

namespace PoliticoRefresh
{
    public static class Assets
    {
        public static SpriteFont debugFont;
        public static Texture2D Base, BaseNight;

        private static void LoadNightContent(ContentManager Content)
        {
            BaseNight = Content.Load<Texture2D>("Game\\Graphics\\base_night"); 
        }

        public static void LoadContent(ContentManager Content)
        {
            LoadNightContent(Content); 
            Base = Content.Load<Texture2D>("Game\\Graphics\\base");
        }
    }
}