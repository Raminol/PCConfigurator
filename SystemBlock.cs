using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    enum FormFactor { MiniATX, ATX, ETX }

    class SystemBlock: Iproductinfo
    {
        string Color = "";
        Motherboard MyMotherboard;
        PSU MyPSU;
        Videocard MyVideocard;
        FormFactor SomeFactor;

        public SystemBlock(FormFactor formFactor) 
        {
            Random SomeRandom = new Random();
            int RandomResult = SomeRandom.Next(1, 3);
            if(RandomResult == 1)
            {
                Color = "ЧёРНЫЙ";
            }
            else if (RandomResult == 2)
            {
                Color = "СИНИЙ";
            }
            else if (RandomResult == 3)
            {
                Color = "КРАСНЫЙ";
            }

            this.SomeFactor = formFactor;
        }

        public void About()
        {
            Console.WriteLine("ЦВЕТ: " + Color);
            Console.WriteLine("Фермафактор: " + SomeFactor);
        }

    }
}
