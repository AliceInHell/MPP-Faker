using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary
{
    public static class FieldValueGenerator
    {
        private static List<Type> _DTO;
        private static Faker _faker;
        private static Assembly _asm;



        public static void DTOAdd(Type t)
        {
            _DTO.Add(t);
        }



        public static void setFaker(Faker f)
        {
            _faker = f;
        }



        public static object generateValue(Type t)
        {
            //generate inserted DTO
            if (_DTO.Contains(t))
                return _faker.Create<object>();

            Type asmType;
            object obj;
            switch (t.Name)
            {
                //generate by plagin
                case "Single":
                    asmType = _asm.GetType("GeneratorPlugins.FloatGenerator");
                    obj = Activator.CreateInstance(asmType);
                    return asmType.GetMethod("Generate").Invoke(obj, null);
                case "Boolean":
                    asmType = _asm.GetType("GeneratorPlugins.BoolGenerator");
                    obj = Activator.CreateInstance(asmType);
                    return asmType.GetMethod("Generate").Invoke(obj, null);

                //generate by classes
                case "Double":
                    return DoubleGenerator.Generate();
                case "Int32":
                    return IntGenerator.Genearte();
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


        static FieldValueGenerator()
        {
            //initiaization
            _DTO = new List<Type>();
            _asm = Assembly.LoadFrom("E:\\Study\\Labs\\5 semester\\MPP\\lab2\\Faker\\GeneratorPlugins\\bin\\Debug\\GeneratorPlugins.dll");
        }
    }
}
