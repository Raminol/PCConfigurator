using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    enum Grade { Bronze, Silver, Gold, Platinum }

    class PSU : Component, Iproductinfo
    {
        int Power;
        Grade SomeGrade;


        public PSU()
        {

        }

        public PSU(int Power, Grade SomeGrade)
        {
            this.Power = Power;
            this.SomeGrade = SomeGrade;
        }

        public PSU(int Power, Grade SomeGrade, string Producer, string Name, int ReleaseYear) : base(Producer, Name, ReleaseYear)
        {
            this.Power = Power;
            this.SomeGrade = SomeGrade;

        }

        public void About()
        {
            Console.WriteLine("Мощность: " + Power);
            Console.WriteLine("Сертификат: " + SomeGrade);
            Manufacturer.About();
        }
    }
}
