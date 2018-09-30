using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FakerLibrary
{
    public static class IntGenerator
    {
        public static int genearte()
        {
            Random rand = new Random();
            return rand.Next(int.MinValue, int.MaxValue);
        }
    }
}
