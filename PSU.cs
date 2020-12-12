using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    enum Grade { Bronze, Silver, Gold, Platinum }

    class PSU
    {
        int Power;
        Grade SomeGrade;
        ManufacurerInfo Manufacturer;

        public PSU()
        {

        }

        public PSU(int Power, Grade SomeGrade)
        {
            this.Power = Power;
            this.SomeGrade = SomeGrade;
            this.Manufacturer = new ManufacurerInfo(null, null, 0);
        }

        public PSU(int Power, Grade SomeGrade, string Producer, string Name, int ReleaseYear)
        {
            this.Power = Power;
            this.SomeGrade = SomeGrade;
            this.Manufacturer = new ManufacurerInfo(Producer, Name, ReleaseYear);
        }
    }
}
