namespace Drawings.Widgets
{
    using Drawings.Core;

    public class Square : Widget
    {
        #region Constants and Fields

        private readonly int width;

        #endregion

        #region Constructors and Destructors

        public Square(Location location, int width) : base(location)
        {
            this.width = width;
        }

        #endregion

        #region Public Methods

        public override string Print()
        {
            return string.Format("Square ({0},{1}) size={2}", Location.X, Location.Y, width);
        }

        #endregion
    }
}