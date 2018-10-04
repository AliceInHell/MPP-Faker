using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary
{
    public class StringGenerator : IGenerator
    {
        public object Generate()
        {
            Random rand = new Random();
            int size = rand.Next(0, 513);
            StringBuilder builder = new StringBuilder();
            char ch;

            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rand.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        public string GetTypeName()
        {
            return "String";
        }
    }
}
