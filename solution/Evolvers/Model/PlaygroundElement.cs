using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Evolvers.Model
{
    public class PlaygroundElement : IPositionable
    {
        protected Universe Universe { get; private set; }
        public Vector Position { get; set; }

        public double Width;
        public double Height;

        public PlaygroundElement(Universe universe)
        {
            Universe = universe;
        }

        public double GetSize()
        {
            return Width * Height;
        }

        public Rect GetRect()
        {
            return new Rect(Position.X - Width / 2, Position.Y - Height / 2, Width, Height);
        }

        
    }
}
