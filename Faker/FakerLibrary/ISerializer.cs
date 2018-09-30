using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FakerLibrary
{
    public interface ISerializer
    {
        MemoryStream serialize(object result);
    }
}
