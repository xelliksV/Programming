using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using model;
using model.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    /// <summary>
    /// Основная ViewModel для управления списком контактов.
    /// </summary>
    public class MainVM : ObservableObject
    {
        /// <summary>
        /// Сериализатор для работы с контактами.
        /// </summary>
        private readonly ContactSerializer _contactSerializer = new();

        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        private Contact _selectedContact;

        /// <summary>
        /// Флаг, указывающий, находится ли выбранный контакт в режиме редактирования.
        /// </summary>
        private bool _isEditing;

        /// <summary>
        /// Индекс редактируемого контакта. Равен -1 при добавлении контакта. 
        /// </summary>
        private int _indexContact;

        /// <summary>
        /// Задает или возвращает выбранный контакт.
        /// </summary>
        public Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                if (_selectedContact != null)
                {
                    _selectedContact.PropertyChanged -= OnContactPropertyChanged;
                }
                if (SetProperty(ref _selectedContact, value))
                {
                    IsEditing = false;
                    OnPropertyChanged(nameof(CanEdit));
                    OnPropertyChanged(nameof(CanRemove));
                    ((RelayCommand)EditCommand).NotifyCanExecuteChanged();
                    ((RelayCommand)RemoveCommand).NotifyCanExecuteChanged();
                }
            }
        }

        /// <summary>
        /// Задает или возвращает флаг, указывающий, находится ли выбранный контакт в режиме редактирования.
        /// </summary>
        public bool IsEditing
        {
            get => _isEditing;
            set
            {
                if (SetProperty(ref _isEditing, value))
                {
                    OnPropertyChanged(nameof(CanApply));
                    ((RelayCommand)ApplyCommand).NotifyCanExecuteChanged();
                }
            }
        }

        /// <summary>
        /// Возвращает коллекцию контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; } = new();

        /// <summary>
        /// Возвращает значение, указывающее, можно ли редактировать выбранный контакт.
        /// </summary>
        public bool CanEdit => SelectedContact != null && !IsEditing;

        /// <summary>
        /// Возвращает значение, указывающее, можно ли удалить выбранный контакт.
        /// </summary>
        public bool CanRemove => SelectedContact != null;

        /// <summary>
        /// Возвращает значение, указывающее, можно ли применить изменения.
        /// </summary>
        public bool CanApply => IsEditing;

        /// <summary>
        /// Команда для добавления нового контакта.
        /// </summary>
        public ICommand AddCommand { get; }

        /// <summary>
        /// Команда для редактирования выбранного контакта.
        /// </summary>
        public ICommand EditCommand { get; }

        /// <summary>
        /// Команда для удаления выбранного контакта.
        /// </summary>
        public ICommand RemoveCommand { get; }

        /// <summary>
        /// Команда для применения изменений.
        /// </summary>
        public ICommand ApplyCommand { get; }

        /// <summary>
        /// Инициализирует новый экземпляр класса MainVM.
        /// </summary>
        public MainVM()
        {
            LoadContacts();

            AddCommand = new RelayCommand(AddContact);
            EditCommand = new RelayCommand(EditContact, () => CanEdit);
            RemoveCommand = new RelayCommand(RemoveContact, () => CanRemove);
            ApplyCommand = new RelayCommand(ApplyChanges, () => CanApply && IsContactValid);
        }

        /// <summary>
        /// Добавляет новый контакт в коллекцию.
        /// </summary>
        private void AddContact()
        {
            var newContact = new Contact();
            SelectedContact = null;
            SelectedContact = newContact;
            IsEditing = true;
            _indexContact = -1;
        }

        /// <summary>
        /// Включает режим редактирования для выбранного контакта.
        /// </summary>
        private void EditContact()
        {
            if (SelectedContact != null)
            {
                _indexContact = Contacts.IndexOf(SelectedContact);
                SelectedContact = (Contact)Contacts[_indexContact].Clone();
                IsEditing = true;
            }
        }

        /// <summary>
        /// Применяет изменения и сохраняет контакты.
        /// </summary>
        private void ApplyChanges()
        {
            if (SelectedContact != null && !Contacts.Contains(SelectedContact) && _indexContact == -1)
            {

                Contacts.Add(SelectedContact);

            }

            if (SelectedContact != null && _indexContact != -1)
            {
                Contacts[_indexContact] = SelectedContact;
            }
            OnPropertyChanged(nameof(IsContactValid));
            ((RelayCommand)ApplyCommand).NotifyCanExecuteChanged();
            IsEditing = false;
            SaveContacts();
        }

        /// <summary>
        /// Удаляет выбранный контакт из коллекции.
        /// </summary>
        private void RemoveContact()
        {
            if (SelectedContact == null) return;

            int index = Contacts.IndexOf(SelectedContact);
            Contacts.Remove(SelectedContact);

            SelectedContact = Contacts.Count > 0
                ? (index < Contacts.Count ? Contacts[index] : Contacts[^1])
                : null;

            SaveContacts();
        }

        /// <summary>
        /// Сохраняет список контактов в файл.
        /// </summary>
        private void SaveContacts()
        {
            _contactSerializer.SaveContacts(Contacts);
        }

        /// <summary>
        /// Загружает список контактов из файла.
        /// </summary>
        private void LoadContacts()
        {
            var loadedContacts = _contactSerializer.LoadContacts();
            foreach (var contact in loadedContacts)
            {
                Contacts.Add(contact);
            }
        }
        /// <summary>
        /// Обработчик изменения свойства контакта.
        /// Проверяет корректность свойства и обновляет состояние команды применения изменений.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие (контакт)</param>
        /// <param name="e">Аргументы события, содержащие имя измененного свойства</param>
        private void OnContactPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Contact.Name) ||
                e.PropertyName == nameof(Contact.PhoneNumber) ||
                e.PropertyName == nameof(Contact.Email))
            {
                OnPropertyChanged(nameof(IsContactValid));

                ((RelayCommand)ApplyCommand).NotifyCanExecuteChanged();
            }
        }

        /// <summary>
        /// Проверяет валидность текущего выбранного контакта.
        /// Контакт считается валидным, если все обязательные поля (Имя, Телефон, Email) заполнены.
        /// </summary>
        public bool IsContactValid
        {
            get
            {
                if (SelectedContact != null)
                {
                    return !string.IsNullOrEmpty(SelectedContact[nameof(Contact.Name)]) &&
                           !string.IsNullOrEmpty(SelectedContact[nameof(Contact.PhoneNumber)]) &&
                           !string.IsNullOrEmpty(SelectedContact[nameof(Contact.Email)]);
                }

                return false;
            }
        }
    }
}