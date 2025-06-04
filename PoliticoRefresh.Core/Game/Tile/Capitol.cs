#region Using Statements
using Microsoft.Xna.Framework;
#endregion

namespace PoliticoRefresh
{
    public class Capitol : Tile
    {
        public Capitol(Vector2 position) : base()
        { 
            
        }
        public override int TileNumber()
        {
            return 2;
        }
        public override bool CanBeDestroyed()
        {
            return false; 
        }
    }
}