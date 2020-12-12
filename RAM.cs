using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    enum DDRType { DDR2, DDR3, DDR4 }

    class RAM : Component, Iproductinfo
    {
        int MHz {
            get => MHz;
            set { if (value < 0) { MHz = 0; } } 
        }
        int MemorySize;
        DDRType Type;
   
       
        public RAM()
        {

        }

        public RAM(int MHz, int MemorySize, DDRType Type, string Producer, string Name, int ReleaseYear) : base(Producer, Name, ReleaseYear)
        {
            this.MHz = MHz;
            this.MemorySize = MemorySize;
            this.Type = Type;
        }

        public void About()
        {
            Console.WriteLine("Тактовая частота: " + MHz);
            Console.WriteLine("Размер памяти: " + MemorySize);
            Console.WriteLine("Тип памяти: " + Type);
            Manufacturer.About();
        }

    }
}
