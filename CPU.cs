using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{
    enum CPUSocket { AM4, AM3, AM3Plus, FM2Plus, AM2, LGA1150, LGA1151, LGA1151v2, LGA1200, LGA2066 }

    class CPU : Component, Iproductinfo
    {
        // fields
        double MHz;
        CPUSocket SomeSocket;
        int Cores;
        int CoresThread;


        // constructors
        public CPU()
        {

        }

        public CPU(double MHz, CPUSocket SomeSocket, int Cores, int CoresThread) : base(null, null, 0)
        {
            this.MHz = MHz;
            this.SomeSocket = SomeSocket;
            this.Cores = Cores;
            this.CoresThread = CoresThread;
        }

        public CPU(double MHz, CPUSocket SomeSocket, int Cores, int CoresThread, string Producer, string Name, int ReleaseYear) : base ( Producer, Name, ReleaseYear )
        {
            this.MHz = MHz < 0.0d ? 0.0d : MHz;
            this.SomeSocket = SomeSocket;
            this.Cores = Cores;
            this.CoresThread = CoresThread;
        }

        // methods
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
