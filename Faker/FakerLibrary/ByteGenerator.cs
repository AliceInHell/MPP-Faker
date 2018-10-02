using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary
{
    public class ByteGenerator : IGenerator
    {
        public object Generate()
        {
            Random rand = new Random();
            return (byte) rand.Next(0, 256);
        }
    }
}
