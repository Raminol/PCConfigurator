using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    enum FormFactor { MiniATX, ATX, ETX }

    class SystemBlock: Component, Iproductinfo
    {
        string Color = "";
        Motherboard MyMotherboard;
        PSU MyPSU;
        Videocard MyVideocard;
        FormFactor SomeFactor;


        public SystemBlock(FormFactor formFactor) : base (null, null, 0)
        {
            Random SomeRandom = new Random();
            int RandomResult = SomeRandom.Next(1, 3);

                if(RandomResult == 1)
                {
                    Color = "ЧёРНЫЙ (гот типа)";
                }
                else if (RandomResult == 2)
                {
                    Color = "СИНИЙ (Как твой батя)";
                }
                else
                {
                    Color = "КРАСНЫЙ (продающий)";
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
