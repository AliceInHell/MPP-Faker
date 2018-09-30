using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary
{
    public static class FieldValueGenerator
    {
        public static object generateValue(Type t)
        {
            switch (t.ToString())
            {
                case "System.Int32":
                    return IntGenerator.genearte();
                default :
                    return (t.IsValueType) ? Activator.CreateInstance(t) : null;
            }
        }
    }
}
