using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary
{
    public static class BoolGenerator
    {
        public static bool Generate()
        {
            Random rand = new Random();
            return rand.Next(0, 2) == 1? true : false;
        }
    }
}
