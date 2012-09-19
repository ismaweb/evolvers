using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evolvers.Model
{
    public class Universe
    {
        public List<FoodElement> Food { get; private set; }
        public List<CreatureElement> Creatures { get; private set; }

        public Universe()
        {
            Food = new List<FoodElement>();
            Creatures = new List<CreatureElement>();
        }

        public void NotifyChanges() {
            if (Changed != null)
                Changed();
        }

        public event Action Changed;

    }
}
