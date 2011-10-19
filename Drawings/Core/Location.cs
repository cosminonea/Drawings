namespace Drawings.Core
{
    public class Location
    {
        #region Constructors and Destructors

        public Location(int x, int y)
        {
            X = x;
            Y = y;
        }

        #endregion

        #region Public Properties

        public int X { get; private set; }

        public int Y { get; private set; }

        #endregion
    }
}