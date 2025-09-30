using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        private Store store = new Store();
        private Customer currentCustomer;
        private List<Item> items = new List<Item>();
        private List<Customer> customers = new List<Customer>();
        private JsonSerialazer<Item> itemSerializer = new JsonSerialazer<Item>("C:\\Users\\vlad4\\OneDrive\\Документы\\itemsData.json");
        private JsonSerialazer<Customer> serialazer = new JsonSerialazer<Customer>("C:\\Users\\vlad4\\OneDrive\\Документы\\customersData.json");
        public CartsTab()
        {
            InitializeComponent();
        }
        public List<Item> Items
        {
            get { return items; }
            set
            {
                items = value;
                items.ForEach(x => itemsListBox.Items.Add(x));
            }
        }
        public List<Customer> Customers
        {
            get { return customers; }
            set
            {
                customers = value;
                customers.ForEach(x => customerComboBox.Items.Add(x));
            }
        }

        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCustomer = (Customer)customerComboBox.SelectedItem;
            cartListBox.Items.Clear();
            if (currentCustomer.Cart.Items.Count > 0)
            {
                currentCustomer.Cart.Items.ForEach(x => cartListBox.Items.Add(x));
            }
            
            amountLabel.Text = currentCustomer.Cart.Amount.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (currentCustomer.Cart != null)
            {
                currentCustomer.Cart.Items.Add((Item)itemsListBox.SelectedItem);
            }
            cartListBox.Items.Add((Item)itemsListBox.SelectedItem);
            store.updateCustomersData(customers);
            amountLabel.Text = currentCustomer.Cart.Amount.ToString();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (currentCustomer.isPriority == false)
            {
                currentCustomer.Orders.Add(new Order(currentCustomer.Address, currentCustomer.Cart, currentCustomer.Fullname));
            } else
            {
                currentCustomer.Orders.Add(new PriorityOrder(currentCustomer.Address, currentCustomer.Cart, DateTime.Now, " ", currentCustomer.Fullname));
            }
     
            store.updateCustomersData(customers);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Item item = (Item)cartListBox.SelectedItem;
            currentCustomer.Cart.Items.Remove(item);
            cartListBox.Items.Remove(item);
            amountLabel.Text = currentCustomer.Cart.Amount.ToString();
            store.updateCustomersData(customers);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            currentCustomer.Cart.Items.Clear();
            cartListBox.Items.Clear();
            amountLabel.Text = currentCustomer.Cart.Amount.ToString();
            store.updateCustomersData(customers);
        }
        public void refreshData()
        {
            itemsListBox.Items.Clear();
            items = itemSerializer.deserialize();
            items.ForEach(item => itemsListBox.Items.Add(item));
            customerComboBox.Items.Clear();
            customers = serialazer.deserialize();
            customers.ForEach(c => customerComboBox.Items.Add(c));
        }
    }
}
