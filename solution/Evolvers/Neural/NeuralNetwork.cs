using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evolvers.Neural
{
    public class NeuralNetwork
    {
        public IEnumerable<NeuralLayer> Layers { get; private set; }

        public NeuralNetwork(float[][][] weights)
        {
            Layers = Enumerable.Range(0, weights.Count()).Select(i => new NeuralLayer(weights[i])).ToArray();
        }

        public IEnumerable<float> Process(IEnumerable<float> inputs)
        {
            IEnumerable<float> signals = inputs;

            foreach (NeuralLayer layer in Layers)
            {
                signals = layer.GetSignals(signals);
            }

            return signals;
        }
    }
}
