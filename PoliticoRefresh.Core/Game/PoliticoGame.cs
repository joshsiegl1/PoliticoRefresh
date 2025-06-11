#region Using Statements
using System;
using Microsoft.Xna.Framework;
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
            Camera.LoadTransform(graphicsDevice); 
            grid = new Grid();
            cycle = new ChronoCycle(); 
        }

        public void Update(GameTime gametime)
        {
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