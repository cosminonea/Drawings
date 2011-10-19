namespace Drawings.Widgets
{
    using Drawings.Core;

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
}