using Logic;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OldStyle();
            Console.WriteLine("Finish OLD");

            //NewStyle();
            //Console.WriteLine("Finish NEW");


            //Exercise();

            //for (int i = 0; i < 100; i++)
            //{
            //    var a = new A();
            //    GC.Collect();
            //}
        }

        private static void OldStyle()
        {
            var logic = new MyLogic();
            Working(logic);
        }

        private static void NewStyle()
        {
            using (var logic = new MyLogic())
                Working(logic);
        }

        private static void Working(MyLogic logic)
        {
            logic.ConnectEv += PrintMessage;
            logic.WorkEv += PrintMessage;
            logic.DisconnectEv += PrintMessage;

            logic.Connection();
            logic.Work();
        }

        private static void Exercise()
        {
            //MyLogic logic = new MyLogic();
            //logic.Connect += Logic_Connect;
            //logic.WorkEv += Logic_WorkEv;
            //logic.Disconnect += Logic_Disconnect;

            //logic.Connection();
            //logic.Work();

            //logic = null;
            //GC.Collect();

            //Console.WriteLine("Finish");
        }

        private static void PrintMessage(string msg) => Console.WriteLine(msg);

        //private static void Logic_Disconnect() => Console.WriteLine("Disconnect");
        //private static void Logic_WorkEv() => Console.WriteLine("Working");
        //private static void Logic_Connect() => Console.WriteLine("Connect");
    }

    class A
    {
        public A()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("c-tor");
        }
        ~A()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("D-TOR");
        }
    }
}