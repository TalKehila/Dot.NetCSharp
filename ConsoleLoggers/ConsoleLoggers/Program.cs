using RandomNameGeneratorLibrary;
using System;
using System.Timers;

namespace ConsoleLoggers
{
    internal class Program
    {
        static PersonNameGenerator person = new PersonNameGenerator();

        static void Main(string[] args)
        {
            Timer timer = new Timer(1000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            Console.ReadLine();

            var p = new Person();
            p.Update();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            string msg = $"{DateTime.Now} - {person.GenerateRandomFirstAndLastName()}";
            Console.WriteLine(msg);

            //TODO: Check if exists folder of year (2023) into folder (202308) into file (20230829.log)
            //TODO: If file doesn't exist - create, else append data
        }
    }
}