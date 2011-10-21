namespace Drawings.Widgets
{
    using Drawings.Core;

    public class Circle : Widget
    {
        #region Constants and Fields

        private readonly int diameter;

        #endregion

        #region Constructors and Destructors

        public Circle(Location location, int diameter)
            : base(location)
        {
            this.diameter = diameter;
        }

        #endregion

        #region Public Methods

        public override void Print(IGraphicsRenderer graphics)
        {
            graphics.PrintText(string.Format("Circle ({0},{1}) size={2}", Location.X, Location.Y, diameter));
        }

        #endregion
    }
}