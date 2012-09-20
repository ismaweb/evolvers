using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evolvers.Neural
{
    public class Neuron
    {
        public IEnumerable<double> Weights { get; private set; }

        public Neuron(IEnumerable<double> weights)
        {
            Weights = weights;
        }

        public double GetSignal(IEnumerable<double> inputs)
        {
            double signal = Enumerable.Range(0, inputs.Count()).Sum(k => inputs.ElementAt(k) * Weights.ElementAt(k));
            // sigmoid
            return 2 / (1 + (double)Math.Exp(-2 * signal)) - 1;
        }
    }
}
