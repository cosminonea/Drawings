﻿namespace Drawings
{
    using System;

    using Drawings.Core;
    using Drawings.Widgets;

    internal class Program
    {
        #region Methods

        // I used stylecop and resharper for code formatting and followed their rules
        private static void Main()
        {
            // for simplicity, there is no exception handling in the solution
            // in a real setup all dependencies injected in the constructors 
            // and invalid locations would be checked
            var drawing = new Drawing(Console.Out);

            drawing.AddWidget(new Rectangle(new Location(10, 10), 30, 40));
            drawing.AddWidget(new Square(new Location(15, 30), 35));
            drawing.AddWidget(new Ellipse(new Location(100, 150), 300, 200));
            drawing.AddWidget(new Circle(new Location(1, 1), 300));
            drawing.AddWidget(new TextBlock(new Location(5, 5), 200, 100, "sample text"));

            drawing.Print();
        }

        #endregion
    }
}