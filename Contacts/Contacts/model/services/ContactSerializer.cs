using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Contacts.model.services
{
    public class ContactSerializer
    {
        String pathToFile = "C:\\Users\\vlad4\\Documents\\contacts.json";
        public void saveContact(Contact contact)
        {
            File.WriteAllText(pathToFile, "");
            File.WriteAllText(pathToFile, JsonConvert.SerializeObject(contact));
        }
        public Contact getContact()
        {
            try
            {
                if (!File.Exists(pathToFile)) return null;
                var text = File.ReadAllText(pathToFile);
                if (string.IsNullOrWhiteSpace(text)) return null;
                return JsonConvert.DeserializeObject<Contact>(text);
            }
            catch
            {
                return null;
            }
        }
    }
}
