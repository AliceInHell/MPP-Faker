using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary
{
    public class LongGenerator : IGenerator
    {
        public object Generate()
        {
            Random rand = new Random();
            return rand.Next(int.MinValue, int.MaxValue) + rand.Next(int.MinValue, int.MaxValue);
        }
    }
}
