using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Evolvers.Model
{
    public abstract class Sensor
    {
        public abstract double Sense(Universe universe, Vector parentDirection);
    }
}
