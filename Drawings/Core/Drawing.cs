namespace Drawings.Core
{
    using System.Collections.Generic;
    using System.IO;

    // I chose simple inheritance over composition 
    // as it was the simplest possible solution given the requirements
    // if the domain changes in the future a refactoring of the design 
    // will be required 
    public class Drawing
    {
        #region Constants and Fields

        private readonly TextWriter textWriter;

        private readonly List<Widget> widgets = new List<Widget>();

        #endregion
        
        #region Constructors and Destructors

        // this dependency is here just based on current requirements
        // for simplicity I am not passing this down to widgets
        public Drawing(TextWriter textWriter)
        {
            this.textWriter = textWriter;
        }

        #endregion

        #region Public Methods

        public void AddWidget(Widget widget)
        {
            widgets.Add(widget);
        }

        public void Print()
        {
            foreach (Widget widget in widgets)
            {
                textWriter.WriteLine(widget.Print());
            }
        }

        #endregion
    }
}