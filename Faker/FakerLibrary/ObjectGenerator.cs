using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary
{
    public class ObjectGenerator : IGenerator
    {
        public object Generate()
        {
            return new object();
        }

        public string GetTypeName()
        {
            return "Object";
        }
    }
}
