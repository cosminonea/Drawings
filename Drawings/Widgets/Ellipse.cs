namespace Drawings.Widgets
{
    using Drawings.Core;

    public class Ellipse : Widget
    {
        #region Constants and Fields

        private readonly int horizontalDiameter;

        private readonly int verticalDiameter;

        #endregion

        #region Constructors and Destructors

        public Ellipse(Location location, int horizontalDiameter, int verticalDiameter)
            : base(location)
        {
            this.horizontalDiameter = horizontalDiameter;
            this.verticalDiameter = verticalDiameter;
        }

        #endregion

        #region Public Methods

        public override void Print(IGraphicsRenderer graphics)
        {
            graphics.PrintText(
                string.Format(
                    "Ellipse ({0},{1}) diameterH = {2} diameterV = {3} ", 
                    Location.X, 
                    Location.Y, 
                    horizontalDiameter, 
                    verticalDiameter));
        }

        #endregion
    }
}