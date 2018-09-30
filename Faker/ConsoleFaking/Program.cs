using System;
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
            Foo<string> f = faker.Create<Foo<string>>();

            ResultWriter newWriter = new ResultWriter();
            JSONSerializer newSerializer = new JSONSerializer();

            newWriter.write(newSerializer.serialize(f));
            Console.ReadLine();
        }
    }
}
