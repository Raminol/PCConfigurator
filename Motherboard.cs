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

    
        public Motherboard()
        {

        }

        public Motherboard(CPU MyCPU, RAM[] MyRAM, int RAMSlots, FormFactor SomeFactor)
        {
            this.MyCPU = MyCPU;
            this.MyRAM = MyRAM;
            this.RAMSlots = RAMSlots;
            this.SomeFactor = SomeFactor;
        }

        public Motherboard(CPU MyCPU, RAM [] MyRAM, int RAMSlots, FormFactor SomeFactor, string Producer, string Name, int ReleaseYear) : base (Producer, Name, ReleaseYear)
        {
            this.MyCPU = MyCPU;
            this.MyRAM = MyRAM;
            this.RAMSlots = RAMSlots;
            this.SomeFactor = SomeFactor;
        }

        public void About()
        {
            //Console.WriteLine("Установленный процессор: " + MyCPU..Name);
            //Console.WriteLine("Сокет: " + SomeSocket);
            //Console.WriteLine("Количество ядер: "+ Cores);
            //Console.WriteLine("Количество потоков: " + CoresThread);
            //Console.WriteLine("Производитель: " + Producer);
            //Console.WriteLine("Модель: " + Name);
        }

    }
}
