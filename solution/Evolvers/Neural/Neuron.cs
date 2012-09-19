using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evolvers.Neural
{
    public class Neuron
    {
        public IEnumerable<float> Weights { get; private set; }

        public float Signal;

        public Neuron(int inputs)
        {
            Weights = new float[inputs];
        }

        public void UpdateSignal(IEnumerable<float> inputs)
        {
            Signal = Enumerable.Range(0, Weights.Count()).Sum(i => inputs.ElementAt(i) * Weights.ElementAt(i));
        }
    }
}
