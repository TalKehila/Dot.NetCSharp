using ConsoleSerializaton.Models;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleSerializaton.DAL
{
    public class RepositoryXml
    {
        public void Save<T>(T data)
        {
            var xml = new XmlSerializer(typeof(T));
            using (var sw = new StreamWriter("data.xml"))
                xml.Serialize(sw, data);
        }

        public T Load<T>()
        {
            var xml = new XmlSerializer(typeof(T));
            using (var sr = new StreamReader("data.xml"))
                return (T)xml.Deserialize(sr);
        }

        //public void Save(Product data)
        //{
        //    var xml = new XmlSerializer(typeof(Product));
        //    using (var sw = new StreamWriter("data.xml"))
        //        xml.Serialize(sw, data);
        //}

        //public void Save(Order data)
        //{
        //    var xml = new XmlSerializer(typeof(Order));
        //    using (var sw = new StreamWriter("data.xml"))
        //        xml.Serialize(sw, data);
        //}

        //public void Save(Customer data)
        //{
        //    var xml = new XmlSerializer(typeof(Customer));
        //    using (var sw = new StreamWriter("data.xml"))
        //        xml.Serialize(sw, data);
        //}
    }
}