using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    enum CPUSocket { AM4, AM3, AM3Plus, AM2, LGA1150, LGA1151,LGA1170 }

    class CPU:Provider, Iproductinfo
    {
        double MHz;
        CPUSocket SomeSocket;
        int Cores;
        int CoresThread;


        public string Producer { get; set; }
        public string Name { get; set; }

        public CPU()
        {

        }
        public CPU(double MHz, CPUSocket SomeSocket, int Cores, int CoresThread, string Producer, string Name)
        {
            this.MHz = MHz;
            this.SomeSocket = SomeSocket;
            this.Cores = Cores;
            this.CoresThread = CoresThread;
            this.Producer = Producer;
            this.Name = Name;
        }

        public void About()
        {
            Console.WriteLine("Тактовая частота: " + MHz);
            Console.WriteLine("Сокет: " + SomeSocket);
            Console.WriteLine("Количество ядер: "+ Cores);
            Console.WriteLine("Количество потоков: " + CoresThread);
            Console.WriteLine("Производитель: " + Producer);
            Console.WriteLine("Модель: " + Name);
        }
    }
}
