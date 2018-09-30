using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary
{
    public static class DoubleGenerator
    {
        public static double Generate()
        {
            Random rand = new Random();
            return rand.NextDouble();
        }
    }
}
