using model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.Services
{
    /// <summary>
    /// Класс для сериализации и десериализации списка контактов в формате JSON.
    /// </summary>
    public class ContactSerializer
    {
        /// <summary>
        /// Путь к файлу, в котором хранятся контакты.
        /// </summary>
        private readonly string _filePath;

        /// <summary>
        /// Инициализирует новый экземпляр класса ContactSerializer.
        /// Создает директорию для хранения контактов, если она не существует.
        /// </summary>
        public ContactSerializer()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string contactsDirectory = Path.Combine(documentsPath, "Contacts");
            _filePath = Path.Combine(contactsDirectory, "contacts.json");

            if (!Directory.Exists(contactsDirectory))
            {
                Directory.CreateDirectory(contactsDirectory);
            }
        }

        /// <summary>
        /// Сохраняет список контактов в файл в формате JSON.
        /// </summary>
        /// <param name="contacts">Список контактов для сохранения.</param>
        public void SaveContacts(ObservableCollection<Contact> contacts)
        {
            string json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        /// <summary>
        /// Загружает список контактов из файла.
        /// </summary>
        /// <returns>Список контактов. Если файл не существует, возвращает пустую коллекцию.</returns>
        public ObservableCollection<Contact> LoadContacts()
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    return new ObservableCollection<Contact>();
                }

                string json = File.ReadAllText(_filePath);
                return JsonConvert.DeserializeObject<ObservableCollection<Contact>>(json) ?? new ObservableCollection<Contact>();
            }
            catch (Exception ex)
            {
                return new ObservableCollection<Contact>();
            }
        }
    }
}