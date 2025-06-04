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
        public static int numStarCount = numStarsLow; 
        public static float SmokeParticleAddTimer = 300f; 
        #endregion
    }
}