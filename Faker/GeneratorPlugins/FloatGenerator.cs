using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FakerLibrary;

namespace GeneratorPlugins
{
    public class FloatGenerator : IGenerator
    {
        public object Generate()
        {
            Random rand = new Random();
            return (float)rand.NextDouble() + (float)rand.NextDouble();
        }
    }
}
