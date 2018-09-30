using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FakerLibrary
{
    interface IFaker
    {
        T Create<T>();  
    }
}
