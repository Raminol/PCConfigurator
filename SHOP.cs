using System;
using System.Collections.Generic;
using System.Text;

namespace PCConfigurator
{

    

    class SHOP
    {
        static readonly int MAXIMUM_ELEMENTS = 5;

        public CPU[] CPULIST = new CPU [MAXIMUM_ELEMENTS];
        public Motherboard[] MotherList = new Motherboard[MAXIMUM_ELEMENTS];
        public Videocard[] VideoList = new Videocard[MAXIMUM_ELEMENTS];
        public RAM[] RAMList = new RAM[MAXIMUM_ELEMENTS];
        public PSU[] PSUList = new PSU[MAXIMUM_ELEMENTS];
        public SystemBlock[] BlockList = new SystemBlock[MAXIMUM_ELEMENTS];



        
        /*
        тут творится настоящая магия нахуй
        */
        public void AddNewComponent(Component new_component)
        {
            Component[] component_list;

            if (new_component is CPU) { component_list = CPULIST; }
            else if (new_component is Motherboard) { component_list = MotherList; }
            else if (new_component is Videocard) { component_list = VideoList; }
            else if (new_component is RAM) { component_list = RAMList; }
            else if (new_component is PSU) { component_list = PSUList; }
            else { component_list = BlockList; }


            for (int index = 0; index < component_list.Length; index++)
            {
                if (component_list[index] == null)
                {
                    component_list[index] = new_component;
                    break;
                }
            }

        }


        /*
        используя апкаст мы можем закинуть сюда любой список комплектующих
        у которой есть интерфейс Iproductinfo, просто передавая его в аргумент, и так как интерфейс реализует метод About то он и выведет свои данные
        мы можем идти по иерархии верх и вниз, не нарушая принцип что с алкашем мы можем обращаться как с человеком, и при этом не каждый человек алкаш.
        */
        public void ShowLIST(Iproductinfo[] mylist)
        {
            Console.WriteLine("\n");
            foreach (Iproductinfo myitem in mylist)
            {
                if (myitem != null)
                {
                    myitem.About();
                    Console.WriteLine("\n");
                }
            }
        }

        public void ShowCPULIST()
        {
            Console.WriteLine("\n");
            foreach (CPU cpu in CPULIST)
            {
                if(cpu != null) 
                { 
                cpu.About();
                Console.WriteLine("\n");
                }
            }
        }
    }
}
