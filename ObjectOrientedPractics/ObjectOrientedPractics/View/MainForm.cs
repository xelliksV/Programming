using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();

        public MainForm()
        {
            InitializeComponent();
            itemTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;
        }

        private void itemTab1_Load(object sender, EventArgs e)
        {

        }

        private void cartsTab1_Load(object sender, EventArgs e)
        {

        }
        private void selectedTabChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                cartsTab1.refreshData();
            }
        }
    }
}
