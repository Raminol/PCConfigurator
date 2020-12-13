using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    class SHOP
    {
        public CPU[] CPULIST = new CPU [5];

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
