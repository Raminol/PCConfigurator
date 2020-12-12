using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    enum CPUSocket { AM4, AM3, AM3Plus, FM2Plus, AM2, LGA1150, LGA1151, LGA1151v2, LGA1200, LGA2066 }

    class CPU : Iproductinfo
    {
        double MHz;
        CPUSocket SomeSocket;
        int Cores;
        int CoresThread;
        ManufacurerInfo Manufacturer;


        public CPU()
        {

        }

        public CPU(double MHz, CPUSocket SomeSocket, int Cores, int CoresThread)
        {
            this.MHz = MHz;
            this.SomeSocket = SomeSocket;
            this.Cores = Cores;
            this.CoresThread = CoresThread;
            this.Manufacturer = new ManufacurerInfo(null, null, 0);
        }

        public CPU(double MHz, CPUSocket SomeSocket, int Cores, int CoresThread, string Producer, string Name, int ReleaseYear)
        {
            this.MHz = MHz < 0.0d ? 0.0d : MHz;
            this.SomeSocket = SomeSocket;
            this.Cores = Cores;
            this.CoresThread = CoresThread;
            this.Manufacturer = new ManufacurerInfo(Producer, Name, ReleaseYear);
        }

        public void About()
        {
            Console.WriteLine("Тактовая частота: " + MHz);
            Console.WriteLine("Сокет: " + SomeSocket);
            Console.WriteLine("Количество ядер: "+ Cores);
            Console.WriteLine("Количество потоков: " + CoresThread);
            Manufacturer.About();
        }
    }
}
