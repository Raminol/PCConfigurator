using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    interface IManufacturer
    {
       public int ReleaseYear { get; }
       public string Producer { get; }
       public string Name { get; }
    }
}
