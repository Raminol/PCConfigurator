using System;

namespace PCConfigurator
{
    class Program
    {
        static void Main(string[] args)
        {
            CPU SomeCPU = new CPU(2.2, CPUSocket.AM3, 2, 4, "AMD", "Abcd");
            SomeCPU.About();
            Console.Read();
        }
    }
}
