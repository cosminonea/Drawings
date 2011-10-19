namespace Drawings.Widgets
{
    using Drawings.Core;

    public class Rectangle : Widget
    {
        #region Constants and Fields

        protected readonly int Height;

        protected readonly int Width;

        #endregion

        #region Constructors and Destructors

        public Rectangle(Location location, int width, int height)
            : base(location)
        {
            Width = width;
            Height = height;
        }

        #endregion

        #region Public Methods

        public override string Print()
        {
            return string.Format("Rectangle ({0},{1}) width = {2} height = {3} ", Location.X, Location.Y, Width, Height);
        }

        #endregion
    }
}