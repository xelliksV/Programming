using System.Windows.Forms.VisualStyles;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void MainForm_load(object sender, EventArgs e)
        {

        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (EnumsListBox.SelectedItem)
            {
                case "Color":
                    loadElemsToValues<Model.Color>();
                    break;
                case "Form of Education":
                    loadElemsToValues<Model.FormOfEducation>();
                    break;
                case "Genre":
                    loadElemsToValues<Model.Genre>();
                    break;
                case "Season":
                    loadElemsToValues<Model.Season>();
                    break;
                case "Manufactures":
                    loadElemsToValues<Model.SmartphoneManufacturer>();
                    break;
                case "Weekday":
                    loadElemsToValues<Model.Weekday>();
                    break;
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt16(ValuesListBox.SelectedItem);
            ++index;
            ValueBox.Text = index.ToString();
        }

        private void parsingButton_Click(object sender, EventArgs e)
        {
            String text = parsingBox.Text;
            if (Enum.TryParse(text, out Model.Weekday day))
            {
                parseLabel.Text = $"Это день недели ({text} = {Convert.ToInt16(day) + 1})";
            }
            else
            {
                parseLabel.Text = "Нет такого дня недели";
            }
        }

        private void seasonButton_Click(object sender, EventArgs e)
        {
            switch (seasonBox.SelectedItem)
            {
                case "Spring":
                    this.tabPage4.BackColor = Color.Green;
                    break;
                case "Winter":
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Autumn":
                    this.tabPage4.BackColor = Color.Orange;
                    break;
            }
        }

        private void loadElemsToValues<TEnum>() where TEnum : Enum
        {
            var forms = Enum.GetValues(typeof(TEnum)).Cast<TEnum>();
            ValuesListBox.Items.Clear();
            foreach (var form in forms)
            {
                ValuesListBox.Items.Add(form);
            }
        }
    }
}
