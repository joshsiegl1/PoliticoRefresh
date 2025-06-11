namespace PoliticoRefresh
{
    public static class Global
    {
        #region Debug
        public static bool DrawDebug = false;
        #endregion
        #region Options
        public static bool Mute = false;
        #endregion
        #region Performance
        const int numStarsHigh = 500;
        const int numStarsMed = 250;
        const int numStarsLow = 100;
        public static int numStarCount = numStarsHigh;
        public static float SmokeParticleAddTimer = 300f;
        #endregion
        #region System Graphics
        //virtuals are the dimensions the sprites are targeting
        public static int VirtualWidth = 1920;
        public static int VirtualHeight = 1080;
        public static int ScreenWidth { get; set; }
        public static int ScreenHeight { get; set; } 
        #endregion
    }
}