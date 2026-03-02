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
        String pathToFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "contacts.json");
        public void saveContact(Contact contact)
        {
            File.WriteAllText(pathToFile, JsonConvert.SerializeObject(contact));
        }
        public Contact getContact()
        {
            if (!File.Exists(pathToFile)) return null;
            return JsonConvert.DeserializeObject<Contact>(File.ReadAllText(pathToFile));
        }
    }
}
