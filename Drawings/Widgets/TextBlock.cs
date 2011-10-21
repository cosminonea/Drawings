namespace Drawings.Widgets
{
    using Drawings.Core;

    // I chose inheritance here but it 
    // could really work using aggregation where the TextBlock
    // encapsulates a Rectangle and decorates it with text printing functionality
    public class TextBlock : Rectangle
    {
        #region Constants and Fields

        private readonly string text;

        #endregion

        #region Constructors and Destructors

        public TextBlock(Location location, int width, int height, string text)
            : base(location, width, height)
        {
            this.text = text;
        }

        #endregion

        #region Public Methods

        public override void Print(IGraphicsRenderer graphics)
        {
            graphics.PrintText(
                string.Format(
                    "TextBlock ({0},{1})  width = {2} height = {3} text=\"{4}\" ", 
                    Location.X, 
                    Location.X, 
                    Width, 
                    Height, 
                    text));
        }

        #endregion
    }
}