using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneratorPlugins
{
    public class BoolGenerator : IGeneratorPlugin
    {
        public object Generate()
        {
            Random rand = new Random();
            return rand.Next(0, 2) == 1 ? true : false;
        }
    }
}
