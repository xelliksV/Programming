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
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {
        private PriorityOrder priorityOrder = new PriorityOrder();
        private List<Item> items = new List<Item>();
        public PriorityOrdersTab()
        {
            InitializeComponent();
            statusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            priorityOrder.Cart.Items.ForEach(x => itemsListBox.Items.Add(x));
            addressControl1.Address = priorityOrder.Address;
        }
        public List<Item> Items { get { return items; } set { items = value; } }
        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            priorityOrder.Status = (OrderStatus)Enum.GetValues(typeof(OrderStatus)).GetValue(statusComboBox.SelectedIndex);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            priorityOrder.Cart.Items.Add(items[Random.Shared.Next(0, items.Count)]);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            priorityOrder.Cart.Items.Remove((Item)itemsListBox.SelectedItem);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            priorityOrder = new PriorityOrder();
        }

        private void timeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            priorityOrder.Time = timeComboBox.SelectedText;
        }
    }
}
