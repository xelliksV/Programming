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
using ObjectOrientedPractics.Model.Discounts;
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
        public List<Customer> Customers
        {
            get { return customers; }
            set
            {
                customers = value;
                updateListBox();
            }
        }
        private void updateListBox()
        {
            serialazer.clear();
            serialazer.serialize(customers);
            customersListBox.Items.Clear();
            customers.ForEach(x => customersListBox.Items.Add(x));
            addressControl.updateControl();

        }
        private void UpdateDiscountsListBox(Customer customer)
        {
            discountsListBox.Items.Clear();

            foreach (var discount in customer.Discounts)
            {
                discountsListBox.Items.Add(discount.Info);
            }
        }

        private void customersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer customer = customersListBox.SelectedItem as Customer;
            idTextBox.Text = customer.Id.ToString();
            nameTextBox.Text = customer.Fullname;
            if (customer.Address != null)
            {
                addressControl.Address = customer.Address;
            }
            if (customer.Discounts != null)
            {
                customer.Discounts.ForEach(x => discountsListBox.Items.Add(x));
            }
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
            customer.Address = addressControl.Address;
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

        private void priorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Customer customer = customersListBox.SelectedItem as Customer;
            if (customer.isPriority == false)
            {
                customer.isPriority = true;
            }
            else
            {
                customer.isPriority = false;
            }
            updateListBox();
        }

        private void addDiscButton_Click(object sender, EventArgs e)
        {
            if (customersListBox.SelectedIndex != -1)
            {
                var addDiscountPopUp = new AddDiscountForm(Customers[customersListBox.SelectedIndex]);

                if (addDiscountPopUp.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var discount = new PercentDiscount(addDiscountPopUp.Category);
                Customers[customersListBox.SelectedIndex].Discounts.Add(discount);
                UpdateDiscountsListBox(Customers[customersListBox.SelectedIndex]);
            }
        }
    }
}
