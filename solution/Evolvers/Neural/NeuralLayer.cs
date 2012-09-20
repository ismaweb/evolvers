using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evolvers.Neural
{
    public class NeuralLayer
    {
        public IEnumerable<Neuron> Neurons { get; private set; }

        public NeuralLayer(double[][] weights)
        {
            Neurons = Enumerable.Range(0, weights.Count()).Select(i => new Neuron(weights[i])).ToArray();
        }

        internal IEnumerable<double> GetSignals(IEnumerable<double> inputs)
        {
            return Neurons.Select(n => n.GetSignal(inputs)).ToArray();
        }
    }
}
