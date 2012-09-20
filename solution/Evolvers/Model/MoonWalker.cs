using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Evolvers.Model
{
    public class MoonWalker : CreatureElement
    {
        public MoonWalker()
        {
            Sensors = new Sensor[]{
                new FoodSensor(){DirectionFromParent = new Vector(-1, 1)},
                new FoodSensor(){DirectionFromParent = new Vector(1, 1)},
            };
        }

    }
}
