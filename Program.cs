using System;

namespace PCConfigurator
{
    class Program
    {
        public static SHOP DNS = new SHOP();

        //TODO(SUM) ПРОВЕРКИ, ПОКУПКА, ВЫВОД И НАВИГАЦИЯ ... вишлист


        static void CreateShopLists(){

            DNS.AddNewComponent(new CPU(2.2, CPUSocket.AM3, 2, 4, "AMD", "Abcd", 2010));
            DNS.AddNewComponent(new CPU(4.2, CPUSocket.LGA1151v2, 6, 12, "INTEL", "Abcda", 2017));
            DNS.AddNewComponent(new CPU(6.9, CPUSocket.AM4, 20, 20, "AMD", "Ryazan Perdakripper", 2019));
            DNS.AddNewComponent(new CPU(1.5, CPUSocket.FM2Plus, 2, 2, "Skolkovo", "Elbrusok", 2015));
            DNS.AddNewComponent(new CPU(6.4, CPUSocket.AM4, 19, 29, "NASA", "MoonWalker", 2016));


            /*
            DNS.CPULIST[0] = new CPU(2.2, CPUSocket.AM3, 2, 4, "AMD", "Abcd", 2010);
            DNS.CPULIST[1] = ;
            DNS.CPULIST[2] = ;
            DNS.CPULIST[3] = ;
            DNS.CPULIST[4] = ;
            */



            DNS.MotherList[0] = new Motherboard(CPUSocket.AM4, 2, FormFactor.ATX, DDRType.DDR4);
            DNS.MotherList[1] = new Motherboard(CPUSocket.AM4, 2, FormFactor.ATX, DDRType.DDR4);
            DNS.MotherList[2] = new Motherboard(CPUSocket.AM3, 4, FormFactor.ETX, DDRType.DDR3);
            DNS.MotherList[3] = new Motherboard(CPUSocket.AM4, 2, FormFactor.ATX, DDRType.DDR4);
            DNS.MotherList[4] = new Motherboard(CPUSocket.AM2, 4, FormFactor.MiniATX, DDRType.DDR3);


            DNS.RAMList[0] = new RAM(1666, 8, DDRType.DDR4, "Hynyx", "Bolistix", 2014);
            DNS.AddNewComponent(new RAM(2000, 10, DDRType.DDR4, "Hynyx", "Eb0la", 2018));
            DNS.AddNewComponent(new RAM(333, 2, DDRType.DDR2, "Micronix", "TvoyChlen", 2010));

            DNS.PSUList[0] = new PSU(450,Grade.Bronze, "Tesla", "Syn Elona", 2014);
            DNS.AddNewComponent(new PSU(650, Grade.Platinum, "Belarus", "AES reaktor edition", 2019));
            DNS.AddNewComponent(new PSU(550, Grade.Gold, "Iron Man", "Mstiteli", 2016));


            DNS.VideoList[0] = new Videocard(4, 1400, 4000, 192, "NVidia", "GTXRTXRX KIANU_REVS_2077", 2076);
            DNS.AddNewComponent(new Videocard(10, 1800, 4500, 256, "NVidia", "RTX CRYSIS EDISHON", 2020));
            DNS.AddNewComponent(new Videocard(2, 700, 1500, 128, "AMD", "Radeon 5770 HIS", 2011));
            DNS.AddNewComponent(new Videocard(6, 1800, 4200, 198, "AMD", "Radeon 5600 XT", 2018));
            DNS.AddNewComponent(new Videocard(4, 1300, 3300, 154, "AMD", "Bichara (c) Special", 2016));


            DNS.BlockList[0] = new SystemBlock(FormFactor.ATX);
            DNS.AddNewComponent(new SystemBlock(FormFactor.MiniATX));
            DNS.AddNewComponent(new SystemBlock(FormFactor.ETX));
        }


        static void Main(string[] args)
        { 
            CreateShopLists();

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
            Console.Clear();
            Console.WriteLine("Нажмите цифру в соответствии с выбором раздела:\n" +
                              "1. Процессоры\n2. Материнские платы\n3. Оперативная память\n4. Блоки питания" +
                              "\n5. Видеокарты\n6. Системные блоки");

            ConsoleKey ShopKey = Console.ReadKey(true).Key;

            if(ShopKey == ConsoleKey.D1 || ShopKey == ConsoleKey.NumPad1)
            {
                DNS.ShowLIST(DNS.CPULIST); // <=== вот это новое
                //DNS.ShowCPULIST();
                
            }
            else if (ShopKey == ConsoleKey.D2 || ShopKey == ConsoleKey.NumPad2)
            {
                DNS.ShowLIST(DNS.MotherList); 
            }
            else if (ShopKey == ConsoleKey.D3 || ShopKey == ConsoleKey.NumPad3)
            {
                DNS.ShowLIST(DNS.RAMList);
            }
            else if (ShopKey == ConsoleKey.D4 || ShopKey == ConsoleKey.NumPad4)
            {
                DNS.ShowLIST(DNS.PSUList);
            }
            else if (ShopKey == ConsoleKey.D5 || ShopKey == ConsoleKey.NumPad5)
            {
                DNS.ShowLIST(DNS.VideoList);
            }
            else if (ShopKey == ConsoleKey.D6 || ShopKey == ConsoleKey.NumPad6)
            {
                DNS.ShowLIST(DNS.BlockList);
            }

            else
            {                
                ShopList();
                return;
            }

            MainMenu();
            Console.Read();

        }

        public static void MainMenu()
        {
            ConsoleKey AnyKey = Console.ReadKey(true).Key;

                if (AnyKey == ConsoleKey.Escape || AnyKey == ConsoleKey.Spacebar)
                {
                ShopList();
                }
                else
                {
                    MainMenu();
                }
        }
    }
}
