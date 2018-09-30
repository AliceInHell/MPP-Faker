using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FakerLibrary
{
    public interface IResultWriter
    {
        void write(MemoryStream ms);
    }
}
