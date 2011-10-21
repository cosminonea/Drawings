namespace Drawings.Renderer
{
    using System.IO;

    using Drawings.Core;

    public class ConsoleRenderer : IGraphicsRenderer
    {
        private readonly TextWriter textWriter;

        public ConsoleRenderer(TextWriter textWriter)
        {
            this.textWriter = textWriter;
        }

        public void PrintText(string text)
        {
            textWriter.WriteLine(text);
        }
    }
}