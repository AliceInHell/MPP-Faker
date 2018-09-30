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
            switch (t.Name)
            {
                case "Int32":
                    return IntGenerator.Genearte();
                case "Single":
                    return FloatGenerator.Generate();
                case "Double":
                    return DoubleGenerator.Generate();
                case "Boolean":
                    return BoolGenerator.Generate();
                case "String":
                    return StringGenerator.Generate();
                case "Int64":
                    return LongGenerator.Generate();
                case "Object":
                    return ObjectGenerator.Generate();
                case "DateTime":
                    return DateTimeGenerator.Generate();
                case "List`1":
                    return ListGenerator.Generate(t.GenericTypeArguments[0]);
                default :
                    return (t.IsValueType) ? Activator.CreateInstance(t) : null;
            }
        }
    }
}
