namespace Drawings
{
    using System.Drawing;

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

    public class TextBlock : Widget
    {
        private readonly Rectangle rectangle;

        private readonly string text;

        public TextBlock(Rectangle rectangle, string text)
        {
            this.rectangle = rectangle;
            this.text = text;
        }
    }

    public class Circle : Widget
    {
        private readonly int diameter;

        public Circle(int diameter)
        {
            this.diameter = diameter;
        }
    }

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

    public class Square : Widget
    {
        private readonly int width;

        public Square(int width)
        {
            this.width = width;
        }
    }

    public class Drawing
    {
        public void AddWidget(Point point, Widget widget)
        {
            
        }
    }

    public abstract class Widget
    {

    }

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