using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private List<Customer> customers = new List<Customer>();
        private JsonSerialazer<Customer> serialazer = new JsonSerialazer<Customer>("C:\\Users\\vlad4\\OneDrive\\Документы\\customersData.json");
        public CustomersTab()
        {
            InitializeComponent();
        }
        public List<Customer> Customers { get { return customers; } set
            {
                customers = value;
                updateListBox();
            } }
        private void updateListBox()
        {
            serialazer.clear();
            serialazer.serialize(customers);
            customersListBox.Items.Clear();
            customers.ForEach(x => customersListBox.Items.Add(x));
            addressControl.updateControl();
        }

        private void customersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer customer = customersListBox.SelectedItem as Customer;
            idTextBox.Text = customer.Id.ToString();
            nameTextBox.Text = customer.Fullname;
            addressControl.Address = customer.Address;
            addressControl.updateControl();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                new Customer().Fullname = nameTextBox.Text;
                nameTextBox.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                nameTextBox.BackColor = Color.LightPink;
            }
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Fullname = nameTextBox.Text;
            customer.Address = new Address();
            customers.Add(customer);
            updateListBox();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            customers.Remove(customersListBox.SelectedItem as Customer);
            updateListBox();
        }

        private void refactorButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Fullname = nameTextBox.Text;
            customer.Address = addressControl.Address;
            customers[customersListBox.SelectedIndex] = customer;
            addressControl.updateControl();
            updateListBox();
        }
    }
}
