using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary
{
    public static class FloatGenerator
    {
        public static float Generate()
        {
            Random rand = new Random();
            return (float)rand.NextDouble() + (float)rand.NextDouble();
        }
    }
}
