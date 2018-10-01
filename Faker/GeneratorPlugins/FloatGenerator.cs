using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneratorPlugins
{
    public class FloatGenerator : IGeneratorPlugin
    {
        public object Generate()
        {
            Random rand = new Random();
            return (float)rand.NextDouble() + (float)rand.NextDouble();
        }
    }
}
