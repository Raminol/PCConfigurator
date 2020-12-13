using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    enum FormFactor { MiniATX, ATX, ETX }

    class SystemBlock
    {
        Motherboard MyMotherboard;
        PSU MyPSU;
        Videocard MyVideocard;
        FormFactor SomeFactor;

        public SystemBlock(FormFactor formFactor) 
        {
            this.SomeFactor = formFactor;
        }

    }
}
