using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    class SHOP
    {
        public CPU[] CPULIST = new CPU [5];
        public Motherboard[] MotherList = new Motherboard[5];
        public Videocard[] VideoList = new Videocard[5];
        public RAM[] RAMList = new RAM[5];
        public PSU[] PSUList = new PSU[5];
        public SystemBlock[] BlockList = new SystemBlock[5];



        /*
        используя апкаст мы можем закинуть сюда любой список комплектующих
        у которой есть интерфейс Iproductinfo, просто передавая его в аргумент, и так как интерфейс реализует метод About то он и выведет свои данные
        мы можем идти по иерархии верх и вниз, не нарушая принцип что с алкашем мы можем обращаться как с человеком, и при этом не каждый человек алкаш.
        */
        public void ShowLIST(Iproductinfo[] mylist)
        {
            Console.WriteLine("\n");
            foreach (Iproductinfo myitem in mylist)
            {
                if (myitem != null)
                {
                    myitem.About();
                    Console.WriteLine("\n");
                }
            }
        }

        public void ShowCPULIST()
        {
            Console.WriteLine("\n");
            foreach (CPU cpu in CPULIST)
            {
                if(cpu != null) 
                { 
                cpu.About();
                Console.WriteLine("\n");
                }
            }
        }
    }
}
