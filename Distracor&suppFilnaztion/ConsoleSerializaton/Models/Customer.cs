using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ConsoleSerializaton.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        [OnSerializing]
        public void OnSerializing(StreamingContext context) => Console.WriteLine("On Serializing");

        [OnSerialized]
        public void OnSerialized(StreamingContext context) => Console.WriteLine("On SerializED");
    }
}