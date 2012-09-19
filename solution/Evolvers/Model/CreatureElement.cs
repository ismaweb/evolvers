using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Evolvers.Neural;

namespace Evolvers.Model
{
    public class CreatureElement : PlaygroundElement
    {
        public NeuralNetwork Brain { get; private set;}

        public CreatureElement()
        {
            Brain = new NeuralNetwork();
        }
    }
}
