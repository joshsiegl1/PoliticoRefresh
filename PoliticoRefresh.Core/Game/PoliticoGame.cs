#region Using Statements
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
#endregion

namespace PoliticoRefresh
{
    public class PoliticoGame
    {
        private GraphicsDevice graphicsDevice; 
        private Grid grid;
        private ChronoCycle cycle;

        public PoliticoGame(GraphicsDevice graphicsDevice)
        {
            this.graphicsDevice = graphicsDevice;
            Camera.LoadTransform(); 
            grid = new Grid();
            cycle = new ChronoCycle(); 
        }

        public void LoadContent(ContentManager Content)
        {
            cycle.LoadContent(); 
            grid.LoadContent(Content); 
        }

        public void Update(GameTime gametime)
        {
            Camera.Update(gametime); 
            grid.Update(gametime);
            cycle.Update(gametime);
        }

        public void Draw(SpriteBatch sbatch)
        {
            sbatch.Begin(SpriteSortMode.FrontToBack, transformMatrix: Camera.LoadTransform(graphicsDevice, 1f));
            cycle.Draw(sbatch); 
            sbatch.End();  
            sbatch.Begin(SpriteSortMode.FrontToBack, transformMatrix: Camera.Transform);
            grid.Draw(sbatch); 
            sbatch.End(); 
        }
    }
}