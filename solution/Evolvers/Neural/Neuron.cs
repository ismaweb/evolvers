using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evolvers.Neural
{
    public class Neuron
    {
        public IEnumerable<float> Weights { get; private set; }

        public Neuron(IEnumerable<float> weights)
        {
            Weights = weights;
        }

        public float GetSignal(IEnumerable<float> inputs)
        {
            float signal = Enumerable.Range(0, inputs.Count()).Sum(k => inputs.ElementAt(k) * Weights.ElementAt(k));
            // sigmoid
            return 2 / (1 + (float)Math.Exp(-2 * signal)) - 1;
        }
    }
}
