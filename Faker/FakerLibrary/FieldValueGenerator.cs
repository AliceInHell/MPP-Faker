using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FakerLibrary
{
    public static class FieldValueGenerator
    {
        private static List<Type> _DTOList;
        private static Faker _faker;
        private static Assembly _asm;

        //List will contain inserded DTO
        private static List<Type> _cycleControlList;

        //dictionary will contain generators
        private static Dictionary<string, IGenerator> _generatorDictionary;
        private static Dictionary<string, ICollectionGenerator> _collectionGeneratorDictionary;


        public static void DTOAdd(Type t)
        {
            _DTOList.Add(t);
        }


        public static void setFaker(Faker f)
        {
            _faker = f;
        }


        public static object generateValue(Type t)
        {
            //generate inserted DTO if need
            if (_DTOList.Contains(t))
            {
                if (_cycleControlList.Contains(t))
                {
                    _cycleControlList.Remove(t);
                    return null;
                }
                else
                {
                    _cycleControlList.Add(t);
                    return _faker.Create(t);
                }
            }

            //generate non-DTO field/property
            if (_generatorDictionary.ContainsKey(t.Name))
                return _generatorDictionary[t.Name].Generate();
            else
            {
                if (_collectionGeneratorDictionary.ContainsKey(t.Name))
                    return _collectionGeneratorDictionary[t.Name].Generate(t.GenericTypeArguments[0]);
                else
                    return (t.IsValueType) ? Activator.CreateInstance(t) : null;
            }
        }


        static FieldValueGenerator()
        {
            //class initiaization
            _DTOList = new List<Type>();
            _cycleControlList = new List<Type>();
            _asm = Assembly.LoadFrom("E:\\Study\\Labs\\5 semester\\MPP\\lab2\\Faker\\GeneratorPlugins\\bin\\Debug\\GeneratorPlugins.dll");

            //generatorsDictionary initialization
            Type asmType;
            IGenerator obj;
            _generatorDictionary = new Dictionary<string, IGenerator>();
            _generatorDictionary.Add("Double", new DoubleGenerator());
            _generatorDictionary.Add("Char", new CharGenerator());
            _generatorDictionary.Add("Byte", new ByteGenerator());
            _generatorDictionary.Add("Int32", new IntGenerator());
            _generatorDictionary.Add("String", new StringGenerator());
            _generatorDictionary.Add("Int64", new LongGenerator());
            _generatorDictionary.Add("Object", new ObjectGenerator());
            _generatorDictionary.Add("DateTime", new DateTimeGenerator());

            //plugins
            asmType = _asm.GetType("GeneratorPlugins.FloatGenerator");
            obj = (IGenerator) Activator.CreateInstance(asmType);
            _generatorDictionary.Add("Single", obj);

            asmType = _asm.GetType("GeneratorPlugins.BoolGenerator");
            obj = (IGenerator) Activator.CreateInstance(asmType);
            _generatorDictionary.Add("Boolean", obj);

            //collectionGeneratorDictionary initialization
            _collectionGeneratorDictionary = new Dictionary<string, ICollectionGenerator>();
            _collectionGeneratorDictionary.Add("List`1", new ListGenerator());
        }
    }
}
