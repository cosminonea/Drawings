namespace Drawings.Core
{
    using System.Collections.Generic;

    // I chose simple inheritance over composition 
    // as it was the simplest possible solution given the requirements
    // if the domain changes in the future a refactoring of the design 
    // will be required 
    public class Drawing
    {
        #region Constants and Fields

        private readonly List<Widget> widgets = new List<Widget>();

        #endregion

        #region Public Methods

        public void AddWidget(Widget widget)
        {
            widgets.Add(widget);
        }

        public void Print(IGraphicsRenderer graphics)
        {
            foreach (Widget widget in widgets)
            {
                widget.Print(graphics);
            }
        }

        #endregion
    }
}