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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        private Customer currentCustomer;
        private List<Item> items = new List<Item>();
        private List<Customer> customers = new List<Customer>();
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
            currentCustomer = customers[customerComboBox.SelectedIndex];
            currentCustomer.Cart.Items.ForEach(x => itemsListBox.Items.Add(x));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            currentCustomer.Cart.Items.Add((Item)itemsListBox.SelectedItem);
        }
    }
}
