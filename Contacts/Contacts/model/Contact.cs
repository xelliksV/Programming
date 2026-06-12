using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    /// <summary>
    /// Класс, представляющий контакт.
    /// </summary>
    public class Contact : ObservableObject, ICloneable
    {
        /// <summary>
        /// Поле для хранения имени контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Поле для хранения номера телефона контакта.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Поле для хранения электронной почты контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Задает или возвращает имя контакта.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        /// <summary>
        /// Задает или возвращает номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { SetProperty(ref _phoneNumber, value); }
        }

        /// <summary>
        /// Задает или возвращает электронную почту контакта.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса Contact с указанными именем, номером телефона и электронной почтой.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="phoneNumber">Номер телефона контакта.</param>
        /// <param name="email">Электронная почта контакта.</param>
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса Contact без параметров.
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Создает копию текущего контакта.
        /// </summary>
        /// <returns> Копия объекта Contact.</returns>
        public object Clone()
        {
            return new Contact(Name, PhoneNumber, Email);
        }
    }
}
