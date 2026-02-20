using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Contacts.model;

namespace Contacts.viewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private Contact currentContact = new Contact();
        private SaveCommand save = new SaveCommand();
        public MainVM() {
            currentContact = new LoadCommand().Execute(this);
            if (currentContact == null)
            {
                currentContact = new Contact();
                Name = "Смирнов Юрий";
                PhoneNumber = "+7-913-111-22-33";
                Email = "yuri.smirnov@no.mail";
            }
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
                save.Execute(currentContact);
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
                save.Execute(currentContact);
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
                save.Execute(currentContact);
                OnPropertyChanged();
            }
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
