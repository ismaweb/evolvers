using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Evolvers.Neural;
using System.Windows;

namespace Evolvers.Model
{
    public class CreatureElement : PlaygroundElement, IOrientable
    {
        public Vector Orientation { get; set; }

        public NeuralNetwork Brain { get; set;}

        public IEnumerable<Sensor> Sensors { get; protected set; }


        public void Run()
        {
           IEnumerable<double> signals = Sensors.Select(s => s.Sense(Universe, Orientation)).ToArray();
           signals = Brain.Process(signals);
        }
    }
}
