namespace Drawings.Widgets
{
    using Drawings.Core;

    public class Ellipse : Widget
    {
        private readonly int horizontalDiameter;

        private readonly int verticalDiameter;

        public Ellipse(int horizontalDiameter, int verticalDiameter)
        {
            this.horizontalDiameter = horizontalDiameter;
            this.verticalDiameter = verticalDiameter;
        }
    }
}