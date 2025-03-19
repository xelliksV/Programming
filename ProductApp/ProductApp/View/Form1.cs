using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json.Serialization;
using ProductApp.Model;

namespace ProductApp
{
    public partial class Form1 : Form
    {
        private List<Product> products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            DataContractJsonSerializer Json = new DataContractJsonSerializer(typeof(List<Product>));
            using (MemoryStream Stream = new MemoryStream(Encoding.Unicode.GetBytes(File.ReadAllText("C:\\Users\\vlad4\\OneDrive\\Документы\\data.json"))))
            {
                products = Json.ReadObject(Stream) as List<Product>;
            }
            listBox1.DataSource = products;
        }
        public void updateData()
        {
            FileStream stream = File.OpenWrite("C:\\Users\\vlad4\\OneDrive\\Документы\\data.json");
            var ser = new DataContractJsonSerializer(typeof(List<Product>));
            ser.WriteObject(stream, products);
            products.Sort();
            listBox1.DataSource = null;
            listBox1.DataSource = products;
            stream.Close();
        }

        private void delete(object sender, EventArgs e)
        {
            try
            {
                products.RemoveAt(listBox1.SelectedIndex);
            } catch (ArgumentException ex) { }
            updateData();
        }

        private void save(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Count = int.Parse(textBox3.Text);
            product.Name = textBox1.Text;
            product.Type = (Model.Type) Enum.Parse(typeof(Model.Type), comboBox1.Text);
            product.Manufacturer = textBox2.Text;
            products.Add(product);
            updateData();
        }

        private void update(object sender, EventArgs e)
        {
            Product product = products[listBox1.SelectedIndex];
            product.Count = int.Parse(textBox3.Text);
            product.Name = textBox1.Text;
            product.Type = (Model.Type)Enum.Parse(typeof(Model.Type), comboBox1.Text);
            product.Manufacturer = textBox2.Text;
            products.Add(product);
            products.RemoveAt((int)listBox1.SelectedIndex);
            updateData();
        }
    }
}
