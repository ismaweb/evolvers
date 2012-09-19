using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evolvers.Neural
{
    public class NeuralLayer
    {

        public IEnumerable<Neuron> Neurons { get; public set; }

        public NeuralLayer(int inputs, int neurons)
        {
            Neurons = Enumerable.Range(0, neurons).Select(i => new Neuron(inputs));
        }

        public IEnumerable<float> GetSignals(IEnumerable<float> inputs)
        {
            return Neurons.Select(n => { n.UpdateSignal(inputs); return n.Signal; });
        }

    }
}
