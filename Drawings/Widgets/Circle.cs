namespace Drawings.Widgets
{
    using Drawings.Core;

    public class Circle : Widget
    {
        private readonly int diameter;

        public Circle(int diameter)
        {
            this.diameter = diameter;
        }
    }
}