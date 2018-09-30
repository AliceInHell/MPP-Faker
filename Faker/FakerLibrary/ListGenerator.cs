using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary
{
    public static class ListGenerator
    {
        public static List<object> Generate(Type t)
        {
            List<object> tmp = new List<object>();
            tmp.Add(FieldValueGenerator.generateValue(t));

            return tmp;
        }
    }
}
