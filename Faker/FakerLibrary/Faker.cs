using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace FakerLibrary
{
    public class Faker : IFaker
    {
        public T Create<T>()
        {
            T obj = (T) new Object();

            return obj;
        }
    }
}
