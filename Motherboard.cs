using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    class Motherboard:Provider
    {
        CPU MyCPU;
        RAM [] MyRAM = new RAM[5];
        int RAMSlots = 1;
        FormFactor SomeFactor;

        public string Producer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Motherboard()
        {

        }

        public Motherboard(CPU MyCPU, RAM [] MyRAM, int RAMSlots, FormFactor SomeFactor, string Producer, string Name)
        {
            this.MyCPU = MyCPU;
            this.MyRAM = MyRAM;
            this.RAMSlots = RAMSlots;
            this.SomeFactor = SomeFactor;
            this.Producer = Producer;
            this.Name = Name;

        }
    }
}
