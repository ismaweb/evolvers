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
            List<NeuralLayer> layers = new List<NeuralLayer>();
            /*
            for(int i = 0; i < weights.Length; i++)
            {
                layers.Add(new NeuralLayer(weights[i], 
            }
            */
            Layers = new NeuralLayer[] {
                new NeuralLayer(inputs, 10),
                new NeuralLayer(10, outputs)
            };
        }

        public IEnumerable<float> ProcessInputs(IEnumerable<float> inputs)
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
