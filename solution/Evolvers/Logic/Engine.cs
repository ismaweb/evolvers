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

            double[][][] weights = new double[][][] { 
                new double[][]{ 
                    new double[]{ 1, 2, 3, 4 },
                    new double[]{ -1, 2, -3, 4 },
                    new double[]{ 4, 3, 2, 1 }
                },
            };

            creature.Brain = new NeuralNetwork(weights);

            Universe.Elements.Add(creature);

            while (true)
            {
                foreach (CreatureElement c in Universe.Elements)
                {
                    c.Run();
                }

                Universe.NotifyChanges();
            }
        }

    }
}
