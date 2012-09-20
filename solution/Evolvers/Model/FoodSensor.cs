using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Evolvers.Model
{
    public class FoodSensor : Sensor
    {
        public Vector DirectionFromParent { get; set; }
        public double Range { get; set; }

        public override double Sense(Universe universe, CreatureElement parent)
        {
            Vector orientation = parent.Orientation + DirectionFromParent;
            Vector displacement;
            double foodSense = 0;

            foreach (FoodElement food in universe.Elements.OfType<FoodElement>())
            {
                displacement = food.Position - parent.Position;

                if (Vector.AngleBetween(orientation, displacement) < Range)
                {
                    foodSense += (1 / displacement.LengthSquared) * food.GetSize();
                }
            }

            return foodSense;
        }
    }
}
