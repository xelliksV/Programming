using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    internal class JsonSerialazer<T> where T : class
    {
        private readonly string path;
        public JsonSerialazer(string path) {
            this.path = path;
        }
        public void serialize(List<T> obj) {
            string json = JsonSerializer.Serialize(obj);
            File.WriteAllText(path, json);
        }
        public List<T> deserialize()
        {
            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<T>>(json);
        }
        public void clear()
        {
            File.WriteAllText(path, "[]");
        }
    }
}
