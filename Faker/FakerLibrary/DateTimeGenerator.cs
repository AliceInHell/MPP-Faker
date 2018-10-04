using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary
{
    public class DateTimeGenerator : IGenerator
    {
        public object Generate()
        {
            return DateTime.Now;
        }

        public string GetTypeName()
        {
            return "DateTime";
        }
    }
}
