using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evolvers.Model
{
    public class Universe
    {
        public List<PlaygroundElement> Elements { get; private set; }
        
        public Universe()
        {
            Elements = new List<PlaygroundElement>();
        }

        public void NotifyChanges() {
            if (Changed != null)
                Changed();
        }

        public event Action Changed;

    }
}
