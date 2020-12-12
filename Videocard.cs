using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    class Videocard : Component
    {
        int Memory;
        int CoreSpeed;
        int MemorySpeed;
        int BUS;


        public Videocard()
        {

        }

        public Videocard(int Memory, int CoreSpeed, int MemorySpeed, int BUS, string Producer, string Name, int ReleaseYear) : base(Producer, Name, ReleaseYear)
        {
            this.Memory = Memory;
            this.CoreSpeed = CoreSpeed;
            this.MemorySpeed = MemorySpeed;
            this.BUS = BUS;
        }
    }
}
