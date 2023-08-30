using Newtonsoft.Json;
using System.IO;

namespace ConsoleSerializaton.DAL
{
    public class RepositoryJson
    {
        public void Save<T>(T data)
        {
            var json = new JsonSerializer { Formatting = Formatting.Indented };
            using (var sw = new StreamWriter("data.json"))
                json.Serialize(sw, data);
        }

        public T Load<T>()
        {
            var res = File.ReadAllText("data.json");
            return JsonConvert.DeserializeObject<T>(res);
        }
    }
}