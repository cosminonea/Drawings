namespace Drawings.Renderers
{
    using System.IO;

    using Drawings.Core;

    public class PrinterRenderer : IGraphicsRenderer
    {
        private readonly TextWriter textWriter;

        public PrinterRenderer(TextWriter textWriter)
        {
            this.textWriter = textWriter;
        }

        public void PrintText(string text)
        {
            textWriter.WriteLine(text);
        }
    }
}