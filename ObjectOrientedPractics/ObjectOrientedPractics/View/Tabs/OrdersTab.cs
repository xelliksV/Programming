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
    public partial class OrdersTab : UserControl
    {
        private Order _selectedOrder;
        private Store _store = new Store();
        private PriorityOrder _selectedPriorityOrder;
        private List<Customer> customers = new List<Customer>();
        private List<Order> orders = new List<Order>();
        public OrdersTab()
        {
            InitializeComponent();
            statusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
        }
        public List<Customer> Customers { get { return customers; } set { customers = value; } }
        public void getAllOrders()
        {
            foreach (Customer customer in customers)
            {
                orders.AddRange(customer.Orders);
            }
            updateOrders();
        }
        public void updateOrders()
        {
            dataGridView1.Rows.Clear();
            foreach (Order order in orders)
            {
                try
                {
                    dataGridView1.Rows.Add(order.Id, order.TimeCreated.ToString(), order.Status.ToString(), order.Name, order.Address.ToString(), order.Amount);
                }
                catch (Exception ex)
                {
                }
            }
        }

        public void selectedRowChanged(object sender, EventArgs e)
        {
            idTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            createdTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            statusComboBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            foreach (Order order in orders)
            {
                if (order.Id == long.Parse(idTextBox.Text))
                {
                    _selectedOrder = order;
                    if (order.GetType() == typeof(PriorityOrder))
                    {
                        _selectedPriorityOrder = (PriorityOrder) order;
                        priorityLabel.Visible = true;
                        deliveryLabel.Visible = true;
                        timeComboBox.Visible = true;
                        timeComboBox.Text = _selectedPriorityOrder.Time;
                    }
                    else
                    {
                        _selectedPriorityOrder = null;
                        priorityLabel.Visible = false;
                        deliveryLabel.Visible = false;
                        timeComboBox.Visible = false;
                    }
                    itemsListBox.Items.Clear();
                    addressControl1.Address = order.Address;
                    order.Cart.Items.ForEach(item => itemsListBox.Items.Add(item));
                }
            }
            amountLabel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void timeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedPriorityOrder.Time = timeComboBox.Text;
            _store.updateCustomersData(customers);
        }
    }
}
