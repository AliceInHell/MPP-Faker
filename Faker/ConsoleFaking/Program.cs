﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using FakerLibrary;

namespace ConsoleFaking
{
    class Program
    {
        static void Main(string[] args)
        {
            Faker faker = new Faker();
            Foo f = faker.Create<Foo>();

            Console.WriteLine("{0}  {1}  {2}", f.first, f.second, f.getThird());
            Console.ReadLine();
        }
    }
}
