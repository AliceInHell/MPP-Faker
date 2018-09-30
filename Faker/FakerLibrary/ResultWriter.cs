using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FakerLibrary
{
    public class ResultWriter : IResultWriter
    {
        public void write(MemoryStream ms)
        {
            StreamReader sr = new StreamReader(ms);
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}
