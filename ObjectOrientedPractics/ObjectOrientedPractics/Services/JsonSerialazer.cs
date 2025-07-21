using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    internal class JsonSerialazer<T> where T : class
    {

        public JsonSerialazer() { }
        public void serialize(List<T> obj) {
            FileStream outputStream = File.OpenWrite("C:\\Users\\vlad4\\OneDrive\\Документы\\data.json");
            var ser = new DataContractJsonSerializer(typeof(List<T>));
            ser.WriteObject(outputStream, obj);
            outputStream.Close();
        }
        public List<T> deserialize()
        {
            List<T> list = new List<T>();
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(List<T>));
            using (MemoryStream Stream = new MemoryStream(Encoding.Unicode.GetBytes(File.ReadAllText("C:\\Users\\vlad4\\OneDrive\\Документы\\data.json"))))
            {
                list = json.ReadObject(Stream) as List<T>;
            }
            return list;
        }
    }
}
