#region Using Statements
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
#endregion

namespace PoliticoRefresh
{
    public static class Camera
    {
        public static Matrix Transform { get; private set; }
        private static float zoom;
        private static MouseState previousMouseState; 
        static Camera()
        {
            zoom = 0.75f;
        }

        public static void Update(GameTime gametime)
        {
            MouseState currentMouseState = Mouse.GetState();
            int scrollDelta = currentMouseState.ScrollWheelValue - previousMouseState.ScrollWheelValue;
            if (scrollDelta > 0 && zoom > 0)
            {
                zoom -= 0.01f;
                LoadTransform();
            }
            else if (scrollDelta < 0 && zoom < 1f)
            {
                zoom += 0.01f;
                LoadTransform(); 
            }
            previousMouseState = currentMouseState; 
        }

        public static void LoadTransform()
        {
            int screenWidth = Global.ScreenWidth;
            int screenHeight = Global.ScreenHeight;

            float scaleX = (float)screenWidth / Global.VirtualWidth;
            float scaleY = (float)screenHeight / Global.VirtualHeight;

            float aspectRatio = Math.Min(scaleX, scaleY);

            Vector2 virtualCenter = new Vector2(Global.VirtualWidth / 2f, Global.VirtualHeight / 2f);
            float finalScale = aspectRatio * zoom;

            // Compute translation to center the scaled virtual screen in the real screen
            float viewportWidth = Global.VirtualWidth * finalScale;
            float viewportHeight = Global.VirtualHeight * finalScale;
            float offsetX = (screenWidth - viewportWidth) / 2f;
            float offsetY = (screenHeight - viewportHeight) / 2f;

            Transform =
                Matrix.CreateTranslation(-virtualCenter.X, -virtualCenter.Y, 0f) * // Move world origin to center
                Matrix.CreateScale(finalScale, finalScale, 1f) *                   // Zoom and base scaling
                Matrix.CreateTranslation(offsetX + virtualCenter.X * finalScale,
                offsetY + virtualCenter.Y * finalScale, 0f); // Move back to screen center
        }
        #region Overloaded LoadTransform Method
        /// <summary>
        /// Overload allows you to pass a zoom variable into the method to override the fixed zoom value
        /// </summary>
        /// <param name="device"></param>
        /// <param name="zoom"></param>
        public static Matrix LoadTransform(GraphicsDevice device, float zoom)
        {
            int screenWidth = Global.ScreenWidth;
            int screenHeight = Global.ScreenHeight;

            float scaleX = (float)screenWidth / Global.VirtualWidth;
            float scaleY = (float)screenHeight / Global.VirtualHeight;

            float aspectRatio = Math.Min(scaleX, scaleY);

            Vector2 virtualCenter = new Vector2(Global.VirtualWidth / 2f, Global.VirtualHeight / 2f);
            float finalScale = aspectRatio * zoom;

            // Compute translation to center the scaled virtual screen in the real screen
            float viewportWidth = Global.VirtualWidth * finalScale;
            float viewportHeight = Global.VirtualHeight * finalScale;
            float offsetX = (screenWidth - viewportWidth) / 2f;
            float offsetY = (screenHeight - viewportHeight) / 2f;

            return
                Matrix.CreateTranslation(-virtualCenter.X, -virtualCenter.Y, 0f) * // Move world origin to center
                Matrix.CreateScale(finalScale, finalScale, 1f) *                   // Zoom and base scaling
                Matrix.CreateTranslation(offsetX + virtualCenter.X * finalScale,
                offsetY + virtualCenter.Y * finalScale, 0f); // Move back to screen center
        }
        #endregion

    }
}