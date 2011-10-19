namespace Drawings.Core
{
    public abstract class Widget
    {
        #region Constants and Fields

        protected readonly Location Location;

        #endregion

        #region Constructors and Destructors

        // a widget also contains its location 
        // which would be needed in a real life scenario 
        // for the widget to draw itself at the specified location
        protected Widget(Location location)
        {
            Location = location;
        }

        #endregion

        // here we can also make this non-abstract and virtual 
        // and print the location and the type of the widget 
        // as a default implementation
        #region Public Methods

        public abstract string Print();

        #endregion
    }
}