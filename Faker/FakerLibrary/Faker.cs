using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace FakerLibrary
{
    public class Faker : IFaker
    {
        private object CreateByConstructor(Type t, ConstructorInfo info)
        {
            object[] tmp = new object[info.GetParameters().Length];
            int i = 0;
            foreach(ParameterInfo pi in info.GetParameters())
            {
                tmp[i] = (FieldValueGenerator.generateValue(pi.ParameterType));
                i++;
            }

            return info.Invoke(tmp);
        }



        private object CreateByPublicParams(Type t)
        {
            object tmp = Activator.CreateInstance(t);

            //get public fields
            FieldInfo[] fieldInfo = t.GetFields(BindingFlags.Public | BindingFlags.Instance);

            foreach (FieldInfo info in fieldInfo)
                info.SetValue(tmp, FieldValueGenerator.generateValue(info.GetType()));

            return tmp;
        }



        public T Create<T>()
        {
            Type t = typeof(T);

            //lets find parametrized constructor
            ConstructorInfo[] constructorInfo = t.GetConstructors();
            ParameterInfo[] parameterInfo;
            ConstructorInfo parametrizedConstructor  = null;
            foreach (ConstructorInfo info in constructorInfo)
            {
                parameterInfo = info.GetParameters();
                if (parameterInfo.Length > 0)
                    parametrizedConstructor = info;
            }

            object obj;
            if (parametrizedConstructor != null)
            {
                //create by parametrized constructor
                obj = CreateByConstructor(t, parametrizedConstructor);
            }
            else
            {
                //create by params initialization 
                obj = CreateByPublicParams(t);
            }
            return (T) obj;
        }
    }
}
