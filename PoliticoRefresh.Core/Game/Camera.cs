#region Using Statements
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

namespace PoliticoRefresh
{
    public static class Camera
    {
        public static Matrix Transform { get; private set; }
        private static float zoom;
        private static int virtualWidth = 1920;
        private static int virtualHeight = 1080; 
        static Camera()
        {
            zoom = 0.5f;
        }

        public static void LoadTransform(GraphicsDevice device)
        {
            int screenWidth = device.Viewport.Width;
            int screenHeight = device.Viewport.Height;

            float scaleX = (float)screenWidth / virtualWidth;
            float scaleY = (float)screenHeight / virtualHeight;

            float aspectRatio = Math.Min(scaleX, scaleY);

            Vector2 virtualCenter = new Vector2(virtualWidth / 2f, virtualHeight / 2f);
            float finalScale = aspectRatio * zoom;

            // Compute translation to center the scaled virtual screen in the real screen
            float viewportWidth = virtualWidth * finalScale;
            float viewportHeight = virtualHeight * finalScale;
            float offsetX = (screenWidth - viewportWidth) / 2f;
            float offsetY = (screenHeight - viewportHeight) / 2f;

            Transform =
                Matrix.CreateTranslation(-virtualCenter.X, -virtualCenter.Y, 0f) * // Move world origin to center
                Matrix.CreateScale(finalScale, finalScale, 1f) *                   // Zoom and base scaling
                Matrix.CreateTranslation(offsetX + virtualCenter.X * finalScale,
                offsetY + virtualCenter.Y * finalScale, 0f); // Move back to screen center
        }


    }
}