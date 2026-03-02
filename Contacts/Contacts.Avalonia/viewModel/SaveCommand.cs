using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Contacts.model;
using Contacts.model.services;

namespace Contacts.viewModel
{
    public class SaveCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private ContactSerializer serializer = new ContactSerializer();
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            serializer.saveContact((Contact) parameter);
        }
    }
}
