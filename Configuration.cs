using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    class Configuration
    {
        SystemBlock MySystemBlock;
        Motherboard MyMotherboard;
        PSU MyPSU;
        Videocard MyVideocard;
        RAM[] MyRAM = new RAM[5];
        int RAMSlots = 1;
        CPU MyCPU;

        public void BuildPC()
        {
            if ( BuildPC_Error() )
            {
                if( ComponentCompatibility() )
                {
                    //TODO ПРОВЕРКА ОСТАЛЬНЫХ УСЛОВИЙ СОВМЕСТИМОСТИ
                }
            }
        }

        private bool BuildPC_Error()
        {
            if (MyMotherboard == null)
            {
                Console.WriteLine("Материнская плата не установлена");
                return false;
            }
            else if (MySystemBlock == null)
            {
                Console.WriteLine("Системный блок отсутствует");
                return false;
            }
            else if (MyPSU == null)
            {
                Console.WriteLine("Блок питания отсутствует");
                return false;
            }
            else if (MyVideocard == null)
            {
                Console.WriteLine("Видеокарты нет. Майнеры спиздили");
                return false;
            }
            else if (MyCPU == null)
            {
                Console.WriteLine("Процессор не установлен");
                return false;
            }

            else
            {
                foreach (RAM RAMSlot in MyRAM)
                {
                    if (RAMSlot == null)
                    {
                        Console.WriteLine("Слоты для памяти я тебе дал. Память я тебе не дал.");
                        return false;
                    }
                }
            }
            return true;
        }

        private bool ComponentCompatibility()
        {
            return MyMotherboard.SomeSocket == MyCPU.SomeSocket;
        }

    }
}
