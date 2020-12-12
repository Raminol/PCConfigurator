using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    class Component
    {

        protected ManufacturerInfo Manufacturer;


        public Component()
        {

        }

        public Component(string Producer, string Name, int ReleaseYear)
        {
            Manufacturer = new ManufacturerInfo(Producer, Name, ReleaseYear);
        }

    }
}
