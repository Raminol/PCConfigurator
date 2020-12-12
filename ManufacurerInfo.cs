using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    class ManufacurerInfo
    {
        protected string Producer { get; }
        protected string Name { get; }
        protected int ReleaseYear { get; }


        public ManufacurerInfo(string Producer, string Name, int ReleaseYear)
        {
            this.Producer = Producer ?? "Неизвестный производитель";
            this.Name = Name ?? "Неизвестное название";
            this.ReleaseYear = ReleaseYear;
        }


        public void About()
        {
            Console.WriteLine("Производитель: " + Producer);
            Console.WriteLine("Модель: " + Name);
            Console.WriteLine(ReleaseYear > 0 ? "Дата производства: " + ReleaseYear : "Неизвестная дата производства");
        }

    }

}
