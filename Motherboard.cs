using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    class Motherboard : Iproductinfo
    {
        CPU MyCPU;
        RAM [] MyRAM = new RAM[5];
        int RAMSlots = 1;
        FormFactor SomeFactor;
        ManufacurerInfo Manufacturer;

    
        public Motherboard()
        {

        }

        public Motherboard(CPU MyCPU, RAM[] MyRAM, int RAMSlots, FormFactor SomeFactor)
        {
            this.MyCPU = MyCPU;
            this.MyRAM = MyRAM;
            this.RAMSlots = RAMSlots;
            this.SomeFactor = SomeFactor;
            this.Manufacturer = new ManufacurerInfo(null, null, 0);
        }

        public Motherboard(CPU MyCPU, RAM [] MyRAM, int RAMSlots, FormFactor SomeFactor, string Producer, string Name, int ReleaseYear)
        {
            this.MyCPU = MyCPU;
            this.MyRAM = MyRAM;
            this.RAMSlots = RAMSlots;
            this.SomeFactor = SomeFactor;
            this.Manufacturer = new ManufacurerInfo(Producer, Name, ReleaseYear);
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
