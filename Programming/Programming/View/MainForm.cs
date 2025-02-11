using System.Windows.Forms.VisualStyles;
namespace Programming
{
    public partial class MainForm : Form
    {
        private Model.Rectangle[] _rectangles = new Model.Rectangle[5];
        private Model.Rectangle _currentRectangle;
        private Model.Movie[] _movies = new Model.Movie[5];
        private Model.Movie _currentMovie;

        public MainForm()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                _rectangles[i] = new Model.Rectangle(new Random().NextDouble() * 100, new Random().NextDouble() * 100, "Purple", new Model.Point2D(new Random().NextDouble() * 100, new Random().NextDouble() * 100));
            }
            setUpMovies();
        }
        public void setUpMovies()
        {
            _movies[0] = new Model.Movie("Snatch", 104, 2000, Model.Genre.Action, 8.6);
            _movies[1] = new Model.Movie("Drive", 100, 2011, Model.Genre.Drama, 7.3);
            _movies[2] = new Model.Movie("Blade runner 2049", 204, 2017, Model.Genre.Thriller, 7.8);
            _movies[3] = new Model.Movie("The Gentlemen", 113, 2019, Model.Genre.Action, 9);
            _movies[4] = new Model.Movie("Now you see me", 110, 2013, Model.Genre.Thriller, 7.7);
        }
        private void HeightChanged(object? sender, EventArgs e)
        {
            try
            {
                textBox1.BackColor = Color.White;
                _currentRectangle.setHeight(Double.Parse(textBox1.Text));
            }
            catch (Exception ex)
            {
                textBox1.BackColor = Color.LightPink;
            }
        }
        private void WidthChanged(object? sender, EventArgs e)
        {
            try
            {
                textBox1.BackColor = Color.White;
                _currentRectangle.setWidth(Double.Parse(textBox1.Text));
            }
            catch (Exception ex)
            {
                textBox1.BackColor = Color.LightPink;
            }
        }
        private void colorChanged(object? sender, EventArgs e)
        {
            try
            {
                textBox1.BackColor = Color.White;
                _currentRectangle.setColor(textBox1.Text);
            }
            catch (Exception ex)
            {
                textBox1.BackColor = Color.LightPink;
            }
        }
        private int findRectangleWithMaxWidth(Model.Rectangle[] rectangles)
        {
            double max = 0;
            int index = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].getWidth() > max)
                {
                    max = rectangles[i].getWidth();
                    index = i;
                }
            }
            return index;
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[listBox1.SelectedIndex];
            textBox1.Text = _currentRectangle.getHeight().ToString();
            textBox2.Text = _currentRectangle.getWidth().ToString();
            textBox3.Text = _currentRectangle.getColor();
            textBox4.Text = _currentRectangle.getCenter().toString();
            id.Text = _currentRectangle.id().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = findRectangleWithMaxWidth(_rectangles);
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            name.BackColor = Color.White;
            _currentMovie.setName(name.Text);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[listBox2.SelectedIndex];
            name.Text = _currentMovie.getName();
            duration.Text = _currentMovie.getDuration().ToString();
            year.Text = _currentMovie.getYearOfRelease().ToString();
            genre.Text = _currentMovie.getGenre().ToString();
            raiting.Text = _currentMovie.getRating().ToString();
        }

        private void duration_TextChanged(object sender, EventArgs e)
        {
            try
            {
                duration.BackColor = Color.White;
                _currentMovie.setDuration(int.Parse(duration.Text));
            }
            catch (Exception ex)
            {
                duration.BackColor = Color.LightPink;
            }
        }

        private void year_TextChanged(object sender, EventArgs e)
        {
            try
            {
                year.BackColor = Color.White;
                _currentMovie.setYearOfRelease(int.Parse(year.Text));
            }
            catch (Exception ex)
            {
                year.BackColor = Color.LightPink;
            }
        }

        private void genre_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.setGenre(Enum.GetValues<Model.Genre>()[genre.SelectedIndex]);
        }

        private void raiting_TextChanged(object sender, EventArgs e)
        {
            try
            {
                raiting.BackColor = Color.White;
                _currentMovie.setRating(double.Parse(raiting.Text));
            }
            catch (Exception ex)
            {
                raiting.BackColor = Color.LightPink;
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
        private int findMovieWithMaxRating(Model.Movie[] movies)
        {
            double max = 0;
            int index = 0;
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].getRating() > max)
                {
                    max = movies[i].getRating();
                    index = i;
                }
            }
            return index;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           listBox2.SelectedIndex = findMovieWithMaxRating(_movies);
        }
    }
}
