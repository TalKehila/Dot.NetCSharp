using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ConsoleSerializaton.Models
{
    [Serializable]
    public class Order
    {
        public int Id { get; set; }
        public Guid Code { get; set; } = Guid.NewGuid();
        public bool Status { get; set; }

        [XmlArray("prs")]
        [XmlArrayItem("p")]
        public List<Product> Products { get; set; }
    }
}