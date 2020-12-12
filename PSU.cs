using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    enum Grade { Bronze, Silver, Gold, Platinum }
    class PSU:Provider
    {
        int Power;
        Grade SomeGrade;

        public string Producer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public PSU()
        {

        }

        public PSU(int Power, Grade SomeGrade, string Producer, string Name)
        {
            this.Power = Power;
            this.SomeGrade = SomeGrade;
            this.Producer = Producer;
            this.Name = Name;
        }
    }
}
