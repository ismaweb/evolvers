using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Evolvers.Model
{
    public class PlaygroundElement
    {
        public double CenterX;
        public double CenterY;

        public double Width;
        public double Height;

        public Rect GetRect()
        {
            return new Rect(CenterX - Width / 2, CenterY - Height / 2, Width, Height);
        }

    }
}
