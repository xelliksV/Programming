using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Contacts.model;
using Contacts.model.services;

namespace Contacts.viewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private readonly ContactSerializer _serializer = new ContactSerializer();
        private Contact currentContact = new Contact();

        public MainVM()
        {
            var loaded = _serializer.getContact();
            if (loaded != null)
                currentContact = loaded;
            else
            {
                currentContact = new Contact();
                currentContact.Name = "Смирнов Юрий";
                currentContact.Phone = "+7-913-111-22-33";
                currentContact.Email = "yuri.smirnov@no.mail";
            }

            SaveCommand = new DelegateCommand(_ => _serializer.saveContact(currentContact));
            LoadCommand = new DelegateCommand(_ => {
                var c = _serializer.getContact();
                if (c != null)
                {
                    currentContact = c;
                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(PhoneNumber));
                    OnPropertyChanged(nameof(Email));
                }
            });
        }

        public ICommand SaveCommand { get; }
        public ICommand LoadCommand { get; }

        public Contact CurrentContact => currentContact;

        public string Name
        {
            get => currentContact.Name;
            set
            {
                currentContact.Name = value;
                _serializer.saveContact(currentContact);
                OnPropertyChanged();
            }
        }

        public string PhoneNumber
        {
            get => currentContact.Phone;
            set
            {
                currentContact.Phone = value;
                _serializer.saveContact(currentContact);
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => currentContact.Email;
            set
            {
                currentContact.Email = value;
                _serializer.saveContact(currentContact);
                OnPropertyChanged();
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
