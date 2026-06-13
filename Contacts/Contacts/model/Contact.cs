using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace model
{
    /// <summary>
    /// Класс, представляющий контакт.
    /// </summary>
    public class Contact : ObservableObject, ICloneable, IDataErrorInfo
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
        /// Поле для хранения ошибок.
        /// </summary>
        private readonly Dictionary<string, string> _errors = new Dictionary<string, string>();

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
        /// <summary>
        /// Индексатор для валидации свойств объекта (реализация IDataErrorInfo).
        /// Выполняет проверки для указанного свойства и возвращает сообщение об ошибке или null, если ошибок нет.
        /// </summary>
        /// <param name="columnName">Имя проверяемого свойства</param>
        /// <returns>Сообщение об ошибке или null, если свойство валидно</returns>
        public string this[string columnName] => _errors.TryGetValue(columnName, out var error) ? error : null;


        private void ValidateProperty(string propertyName, string value)
        {
            string error = null;

            switch (propertyName)
            {
                case nameof(Name):
                    if (string.IsNullOrWhiteSpace(Name))
                        error = "Name is required.";

                    if (Name.Length > 100)
                        error = "Name cannot be longer than 100 characters.";
                    break;

                case nameof(PhoneNumber):
                    if (string.IsNullOrWhiteSpace(PhoneNumber))
                        error = "Phone number is required.";

                    if (PhoneNumber.Length > 100)
                        error = "Phone number cannot be longer than 100 characters.";

                    if (!Regex.IsMatch(PhoneNumber, @"^[\d\+\-\(\)\s]+$"))
                        error = "Phone number can only contain digits, +, -, (, ) and spaces.";
                    break;

                case nameof(Email):
                    if (string.IsNullOrWhiteSpace(Email))
                        error = "Email is required.";

                    if (Email.Length > 100)
                        error = "Email cannot be longer than 100 characters.";

                    if (!Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                        error = "Invalid email format.";
                    break;
            }

            if (error != null)
                _errors[propertyName] = error;
            else
                _errors.Remove(propertyName);
        }

        /// <summary>
        /// Реализация свойства Error интерфейса IDataErrorInfo.
        /// Всегда возвращает null, что означает отсутствие ошибок на уровне объекта.
        /// </summary>
        public string Error => string.Join("\n", _errors.Values);
    }
}
