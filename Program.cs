using System;

namespace PCConfigurator
{
    class Program
    {
        static void Main(string[] args)
        {
            CPU SomeCPU = new CPU(2.2, CPUSocket.AM3, 2, 4, "AMD", "Abcd", 2010);
            CPU OtherSomeCPU = new CPU(4.2, CPUSocket.LGA1151v2, 6, 12, "INTEL", "Abcdaaaaaaaaaaa", 2017);

            SomeCPU.About();
            Console.WriteLine("\n");
            OtherSomeCPU.About();
            Console.Read();
        }
    }
}
