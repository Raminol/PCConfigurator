using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    class Motherboard : Component, Iproductinfo
    {
        CPU MyCPU;
        RAM [] MyRAM = new RAM[5];
        int RAMSlots = 1;
        FormFactor SomeFactor;
        DDRType dDRType;
        CPUSocket SomeSocket;
    
        public Motherboard()
        {

        }
    
        public Motherboard(CPUSocket SomeSocket, int RAMSlots, FormFactor SomeFactor)
        {
            this.SomeSocket = SomeSocket;
            this.RAMSlots = RAMSlots;
            this.SomeFactor = SomeFactor;
        }

        public Motherboard(CPUSocket SomeSocket, int RAMSlots, FormFactor SomeFactor, DDRType dDRType, string Producer, string Name, int ReleaseYear) : base (Producer, Name, ReleaseYear)
        {
            this.SomeSocket = SomeSocket;
            this.RAMSlots = RAMSlots;
            this.SomeFactor = SomeFactor;
            this.dDRType = dDRType;
        }

        public void About()
        {
            Console.WriteLine("Слотов оперативной памяти: "+ RAMSlots);
            Console.WriteLine("Тип памяти:  " + dDRType);
            Console.WriteLine("Сокет: " + SomeSocket);
            Console.WriteLine("Форм фактор: " + SomeFactor);
            Manufacturer.About();
        }

    }
}
