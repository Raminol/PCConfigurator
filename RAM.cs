using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    enum DDRType { DDR2, DDR3, DDR4 }

    class RAM:Provider
    {
        int MHz;
        int MemorySize;
        DDRType Type;

        public string Producer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public RAM()
        {

        }

        public RAM(int MHz, int MemorySize, DDRType Type, string Producer, string Name)
        {
            this.MHz = MHz;
            this.MemorySize = MemorySize;
            this.Type = Type;
            this.Producer = Producer;
            this.Name = Name;
        }
    }
}
