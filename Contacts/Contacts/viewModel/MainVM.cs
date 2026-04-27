using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Contacts.model;
using System.Windows.Input;

namespace Contacts.viewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private Contact currentContact = new Contact();
        private SaveCommand save = new SaveCommand();
        private LoadCommand load = new LoadCommand();
        public ICommand SaveCommand { get; }
        public ICommand LoadCommand { get; }
        public MainVM() {
            // initialize command properties
            SaveCommand = save;
            LoadCommand = load;

            // try to load saved contact
            var loaded = load.Execute(this);
            if (loaded != null)
                currentContact = loaded;
            if (currentContact == null)
            {
                currentContact = new Contact();
                Name = "Смирнов Юрий";
                PhoneNumber = "+7-913-111-22-33";
                Email = "yuri.smirnov@no.mail";
            }
        }
        // expose current contact for binding as CommandParameter
        public Contact CurrentContact => currentContact;

        // allow LoadCommand to update VM with loaded contact
        public void LoadContact(Contact c)
        {
            if (c == null) return;
            currentContact = c;
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(PhoneNumber));
            OnPropertyChanged(nameof(Email));
        }
        public String Name
        {
            get
            {
                return currentContact.Name; 
            }
            set
            {
                currentContact.Name = value;
                //save.Execute(currentContact);
                OnPropertyChanged();
            }
        }
        public String PhoneNumber
        {
            get
            {
                return currentContact.Phone;
            }
            set
            {
                currentContact.Phone = value;
                //save.Execute(currentContact);
                OnPropertyChanged();
            }
        }
        public String Email
        {
            get
            {
                return currentContact.Email;
            }
            set
            {
                currentContact.Email = value;
                //save.Execute(currentContact);
                OnPropertyChanged();
            }
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
