using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary
{
    public class BoolGenerator : IGenerator
    {
        public object Generate()
        {
            Random rand = new Random();
            return rand.Next(0, 2) == 1 ? true : false;
        }

        public string GetTypeName()
        {
            return "Bool";
        }
    }
}
