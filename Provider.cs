using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    interface Provider
    {
       public string Producer { get; set; }
       public string Name { get; set; }
    }
}
