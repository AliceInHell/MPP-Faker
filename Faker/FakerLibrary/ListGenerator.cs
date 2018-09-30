﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary
{
    public static class ListGenerator
    {
        public static object Generate(Type t)
        {
            string typeName = string.Format("System.Collections.Generic.List`1[[{0}]]", t.AssemblyQualifiedName);
            Type type = Type.GetType(typeName);
            object tmp =  Activator.CreateInstance(type);
            
            ((IList)tmp).Add(FieldValueGenerator.generateValue(t));

            return tmp;
        }
    }
}