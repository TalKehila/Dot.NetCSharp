using Newtonsoft.Json;
using System.Xml.Serialization;

namespace ConsoleSerializaton.Models
{
    public class Product
    {
        [JsonProperty("i")]
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlElement("ti")]
        public string Title { get; set; }

        public double Price { get; set; }
    }
}