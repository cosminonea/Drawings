namespace Drawings
{
    using System.Drawing;

    using Drawings.Core;
    using Drawings.Widgets;

    using Rectangle = Drawings.Widgets.Rectangle;

    internal class Program
    {
        #region Methods

        private static void Main(string[] args)
        {
            var drawing = new Drawing();

            drawing.AddWidget(new Point(10, 10), new Rectangle(30, 40));
            drawing.AddWidget(new Point(15, 30), new Square(35));
            drawing.AddWidget(new Point(100, 150), new Ellipse(300, 200));
            drawing.AddWidget(new Point(1, 1), new Circle(300));
            drawing.AddWidget(new Point(5, 5), new TextBlock(new Rectangle(200, 100), "sample text"));
        }

        #endregion
    }
}