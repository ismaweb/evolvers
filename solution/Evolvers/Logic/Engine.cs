using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Evolvers.Model;

namespace Evolvers.Logic
{
    public class Engine
    {
        public Universe Universe { get; private set; }

        public Engine()
        {
            Universe = new Universe();
        }

        public void Run()
        {
            Universe.NotifyChanges();
        }

    }
}
