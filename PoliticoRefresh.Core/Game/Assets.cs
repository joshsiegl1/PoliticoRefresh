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
            Capitol.Texture_Night = Content.Load<Texture2D>("Game\\Graphics\\Tiles\\Night\\capitol_night");
            Grass.TextureNight = Content.Load<Texture2D>("Game\\Graphics\\Tiles\\Night\\grass_night");
            House.TextureNight = Content.Load<Texture2D>("Game\\Graphics\\Tiles\\Night\\house_night"); 
        }

        public static void LoadContent(ContentManager Content)
        {
            LoadNightContent(Content);
            Base = Content.Load<Texture2D>("Game\\Graphics\\base");

            #region Statics
            Sun.Texture = Content.Load<Texture2D>("Game\\Graphics\\Particles\\sunparticle");
            ChronoCycle.Moon = Content.Load<Texture2D>("Game\\Graphics\\Moon");
            ChronoCycle.BackgroundTexture = Content.Load<Texture2D>("Game\\Graphics\\night-background");
            ChronoCycle.Star.Texture = Content.Load<Texture2D>("Game\\Graphics\\Particles\\star");
            #endregion

            #region Tiles
            Grass.Texture = Content.Load<Texture2D>("Game\\Graphics\\Tiles\\grass");
            Capitol.Texture = Content.Load<Texture2D>("Game\\Graphics\\Tiles\\capitol");
            House.Texture = Content.Load<Texture2D>("Game\\Graphics\\Tiles\\house");

            Empty.Texture = Grass.Texture;
            #endregion
            #region Vehicles
            #endregion
            #region Misc.
            Capitol.Flag_Texture = Content.Load<Texture2D>("Game\\Graphics\\Tiles\\flag_sheet"); 
            #endregion
        }
    }
}