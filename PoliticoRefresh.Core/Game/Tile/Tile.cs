#region Using Statements
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

namespace PoliticoRefresh
{
    public interface IPowerable
    {
        bool haspower { get; set; }
    }

    public abstract class Tile : IPowerable
    {
        static int KeyTracker = 0;
        public int UniqueKey;
        public const int TileWidth = 64;
        public const int TileHeight = 64;

        public const int TileStepX = 64;
        public const int TileStepY = 16;

        public const int OddRowXOffset = 32;
        public const int HeightTileOffset = 32;
        public bool haspower { get; set; }
        /// <returns>A unique number that identifies the tile</returns>
        public abstract int TileNumber();
        public virtual bool CanBeReplaced()
        {
            return false;
        }
        public virtual bool CanBeDestroyed()
        {
            return false;
        }
    }
}