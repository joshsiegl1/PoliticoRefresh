#region Using Statements
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

namespace PoliticoRefresh
{
    internal class SunParticle : Particle
    { 
        public float LayerDepth;
        public float randAdditive; 

        public SunParticle()
        {
            //weird magic number. Needs to be documented somewhere
            LayerDepth = 0.00003f; 
        }

        public override void Update(GameTime gametime)
        {
            base.Update(gametime);

            double time = gametime.TotalGameTime.TotalSeconds;
            float pulsate = (float)Math.Sin(time * randAdditive * 0.01f) + 10;
            scale = (pulsate) * 0.1f;
        }

        public override void Draw(SpriteBatch sbatch)
        {
            sbatch.Draw(texture, position, null, color * ChronoCycle.DayColor, 0f, new Vector2(100, 100), scale, SpriteEffects.None, LayerDepth); 
        }
    }
}