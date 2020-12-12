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
        ManufacturerInfo Manufacturer;

        public PSU()
        {

        }

        public PSU(int Power, Grade SomeGrade)
        {
            this.Power = Power;
            this.SomeGrade = SomeGrade;
            this.Manufacturer = new ManufacturerInfo(null, null, 0);
        }

        public PSU(int Power, Grade SomeGrade, string Producer, string Name, int ReleaseYear)
        {
            this.Power = Power;
            this.SomeGrade = SomeGrade;
            this.Manufacturer = new ManufacturerInfo(Producer, Name, ReleaseYear);
        }
    }
}
