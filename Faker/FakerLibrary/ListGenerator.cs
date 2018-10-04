using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary
{
    public class ListGenerator : ICollectionGenerator
    {
        public object Generate(Type t)
        {
            object tmp =  Activator.CreateInstance(typeof(List<>).MakeGenericType(t));
            
            ((IList)tmp).Add(FieldValueGenerator.GenerateValue(t));

            return tmp;
        }

        public string GetTypeName()
        {
            return "List`1";
        }
    }
}
