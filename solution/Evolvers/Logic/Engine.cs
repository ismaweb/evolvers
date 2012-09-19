using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Evolvers.Model;
using Evolvers.Neural;

namespace Evolvers.Logic
{
    public class Engine
    {
        public Universe Universe { get; private set; }

        public Engine()
        {
            Universe = new Universe();
        }

        public void Run()
        {
            CreatureElement creature = new CreatureElement();

            float[][][] weights = new float[][][] { 
                new float[][]{ 
                    new float[]{ 1, 2, 3, 4 },
                    new float[]{ -1, 2, -3, 4 },
                    new float[]{ 4, 3, 2, 1 }
                },
            };

            creature.Brain = new NeuralNetwork(weights);

            Universe.Creatures.Add(creature);

            while (true)
            {
                foreach (CreatureElement c in Universe.Creatures)
                {
                    c.Run();
                }

                Universe.NotifyChanges();
            }
        }

    }
}
