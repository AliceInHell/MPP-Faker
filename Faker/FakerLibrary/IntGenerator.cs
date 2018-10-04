using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FakerLibrary
{
    public class IntGenerator : IGenerator
    {
        public object Generate()
        {
            Random rand = new Random();
            return rand.Next(int.MinValue, int.MaxValue);
        }

        public string GetTypeName()
        {
            return "Int";
        }
    }
}
