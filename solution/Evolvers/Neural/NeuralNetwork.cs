using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evolvers.Neural
{
    public class NeuralNetwork
    {
        public IEnumerable<NeuralLayer> Layers { get; private set; }

        public NeuralNetwork(double[][][] weights)
        {
            Layers = Enumerable.Range(0, weights.Count()).Select(i => new NeuralLayer(weights[i])).ToArray();
        }

        public IEnumerable<double> Process(IEnumerable<double> inputs)
        {
            IEnumerable<double> signals = inputs;

            foreach (NeuralLayer layer in Layers)
            {
                signals = layer.GetSignals(signals);
            }

            return signals;
        }
    }
}
