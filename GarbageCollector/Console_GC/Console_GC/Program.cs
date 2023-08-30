using System; //BCL (FCL)

namespace Console_GC
{
    internal class Program
    {
        static Person p = new Person();

        static void Main(string[] args)
        {
            //ForTerminal(args);

            //WeakRef();

            Console.ReadLine();
        }

        private static void ForTerminal(string[] args)
        {
            switch (args[0])
            {
                case "gcloud":
                    switch (args[1])
                    {
                        case "-v":
                            Console.WriteLine("Version Cloud");
                            break;
                        case "-h":
                            Console.WriteLine("Help");
                            break;
                    }
                    break;
                case "sudo":
                    switch (args[1])
                    {
                        case "-v":
                            Console.WriteLine("Version Stam");
                            break;
                    }
                    break;
            }


            if (args[0] == "Add-Migration")
            {
                if (args[1].Length == 0)
                {
                    Console.WriteLine("Insert Name");
                }
                Console.WriteLine("OK");
            }
            else
                Console.WriteLine("TEST");
        }

        private static void WeakRef()
        {
            var p1 = new Person { Name = "First" }; //strong ref    //CountRef++
            var p2 = p1;                            //strong ref    //CountRef++

            var wr = new WeakReference(p1);         //weak ref

            p1 = null;                                              //CountRef--

            GC.Collect();                                           //if (CountRef == 0) DELETE (Mark)
                                                                    //Console.WriteLine(p1.Name);

            //for (int i = 0; i < 1e3; i++)
            //{
            //    var nums = new List<Person>();
            //    for (int j = 0; j < 1e3; j++)
            //        nums.Add(new Person { Name = j.ToString() });
            //}

            Console.WriteLine((wr.Target as Person).Name);

            //Console.WriteLine(p2.Name);
        }
    }

    class Person
    {
        object[] objects = new object[100000];
        public string Name { get; set; }
        public int Age { get; set; }

        //Saved Code = Managed Code (by CRL & GC on the HEAP ONLY)

        public unsafe void Test()
        {
            //var f = new Person() { Age = 12 };
            // f.a = 1

            //fixed (int* ptr = &f.Age)
            //{
            //    *ptr = 2;
            //}


            //f = null;
            //delete f;
        }
    }
}