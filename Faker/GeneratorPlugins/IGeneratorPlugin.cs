using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneratorPlugins
{
    interface IGeneratorPlugin
    {
        object Generate();
    }
}
