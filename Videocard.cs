using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    class Videocard
    {
        int Memory;
        int CoreSpeed;
        int MemorySpeed;
        int BUS;
        ManufacturerInfo Manufacturer;
        public Videocard()
        {

        }

        public Videocard(int Memory, int CoreSpeed, int MemorySpeed, int BUS, string Producer, string Name, int ReleaseYear)
        {
            this.Memory = Memory;
            this.CoreSpeed = CoreSpeed;
            this.MemorySpeed = MemorySpeed;
            this.BUS = BUS;
            this.Manufacturer = new ManufacturerInfo(Producer, Name, ReleaseYear);

        }
    }
}
