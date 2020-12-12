using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    class Videocard:Provider
    {
        int Memory;
        int CoreSpeed;
        int MemorySpeed;
        int BUS;

        public string Producer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Videocard()
        {

        }

        public Videocard(int Memory, int CoreSpeed, int MemorySpeed, int BUS, string Producer, string Name)
        {
            this.Memory = Memory;
            this.CoreSpeed = CoreSpeed;
            this.MemorySpeed = MemorySpeed;
            this.BUS = BUS;
            this.Producer = Producer;
            this.Name = Name;
        }
    }
}
