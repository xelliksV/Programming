using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Contacts.model;
using System.Windows;
using Contacts.model.services;

namespace Contacts.viewModel
{
    internal class LoadCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private ContactSerializer serializer = new ContactSerializer();

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        // returns loaded contact for direct calls
        public Contact Execute(object? parameter)
        {
            return serializer.getContact();
        }

        // ICommand.Execute implementation
        void ICommand.Execute(object? parameter)
        {
            try
            {
                var contact = serializer.getContact();
                if (contact == null)
                {
                    MessageBox.Show("Saved contact not found or file is empty.", "Load", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                if (parameter is MainVM vm)
                {
                    vm.LoadContact(contact);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading contact: {ex.Message}", "Load Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
