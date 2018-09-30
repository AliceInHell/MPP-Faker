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

            Console.WriteLine("{0}  {1}  {2}  {3}  {4}  {5}  {6}  {7}  {8}", 
                f.getDouble(), f.getFloat(), f.getInt(), f.getBool(), f.getString(), 
                f.getLong(), f.getObkect(), f.getDate(), f.getList()[0]);
            Console.ReadLine();
        }
    }
}
