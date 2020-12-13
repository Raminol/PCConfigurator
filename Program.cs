using System;

namespace PCConfigurator
{
    class Program
    {
        public static SHOP DNS = new SHOP();

        static void Main(string[] args)
        {
            DNS.CPULIST[0] = new CPU(2.2, CPUSocket.AM3, 2, 4, "AMD", "Abcd", 2010);
            DNS.CPULIST[1] = new CPU(4.2, CPUSocket.LGA1151v2, 6, 12, "INTEL", "Abcda", 2017);
            DNS.CPULIST[2] = new CPU(6.9, CPUSocket.AM4, 20, 20);

            Console.WriteLine("Привет, педик. Нажми это чтобы это, нажми это чтобы вот это");
            PressKey();
            
            
            
            #region HUETA
            /*
            

            SomeCPU.About();
            Console.WriteLine("\n");
            OtherSomeCPU.About();
            Console.WriteLine("\n");
            ThirdSomeCPU.About();

            Console.Read();
            */
            #endregion
            
        }

        public static void PressKey()
        {
            Console.WriteLine("Нажмите <ENTER>, чтобы перейти к ассортименту или <ESCAPE> для выхода...");
            ConsoleKey Key = Console.ReadKey(true).Key;

            if(Key == ConsoleKey.Enter)
            {
                ShopList();
            }
            else if (Key == ConsoleKey.Escape)
                {
                System.Environment.Exit(0);
                }
            else
            {
                Console.WriteLine("НАЖМИ КНОПКУ");
                PressKey();
            }
        }

        public static void ShopList()
        {
            Console.WriteLine("Нажмите цифру в соответствии с выбором раздела:\n" +
                              "1. Процессоры\n2. Материнские платы\n3. Оперативная память\n4. Блоки питания" +
                              "\n5. Видеокарты\n6. Системные блоки");

            ConsoleKey ShopKey = Console.ReadKey(true).Key;

            if(ShopKey == ConsoleKey.D1)
            {
                DNS.ShowCPULIST();
                Console.Read();
            }
        }
    }
}
