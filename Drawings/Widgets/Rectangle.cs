namespace Drawings.Widgets
{
    using Drawings.Core;

    public class Rectangle : Widget
    {
        private readonly int width;

        private readonly int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }


    }
}