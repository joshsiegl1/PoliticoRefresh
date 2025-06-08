#region Using Statements
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

namespace PoliticoRefresh
{
    public class PoliticoGame
    {
        private Grid grid;
        private ChronoCycle cycle;

        public PoliticoGame()
        {
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
            sbatch.Begin();
            grid.Draw(sbatch); 
            sbatch.End(); 
        }
    }
}