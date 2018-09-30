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

            Foo<string> foo = faker.Create<Foo<string>>();
            Bar<bool> bar = faker.Create<Bar<bool>>();

            ResultWriter newWriter = new ResultWriter();
            JSONSerializer newSerializer = new JSONSerializer();

            newWriter.write(newSerializer.serialize(foo));
            Console.Write("\n\n\n");
            
            newWriter.write(newSerializer.serialize(bar));
            Console.ReadLine();
        }
    }
}
