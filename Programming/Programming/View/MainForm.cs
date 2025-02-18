using System.Windows.Forms.VisualStyles;
using Programming.Model;
using Programming.Model.Enums;
using Programming.Model.Geometry;
using Color = System.Drawing.Color;
namespace Programming
{
    public partial class MainForm : Form
    {
        private Model.Geometry.Rectangle[] _rectangles = new Model.Geometry.Rectangle[5];
        private Model.Geometry.Rectangle _currentRectangle;
        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie;
        private List<Model.Geometry.Rectangle> rectangles = new List<Model.Geometry.Rectangle>();
        private Model.Geometry.Rectangle currentRectangle;
        private List<Panel> _rectanglePanel = new List<Panel>();
        public MainForm()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                _rectangles[i] = new Model.Geometry.Rectangle(new Random().NextDouble() * 100, new Random().NextDouble() * 100, "Purple", new Model.Geometry.Point2D(new Random().NextDouble() * 100, new Random().NextDouble() * 100));
            }
            setUpMovies();

        }
        public void setUpMovies()
        {
            _movies[0] = new Model.Movie("Snatch", 104, 2000, Genre.Action, 8.6);
            _movies[1] = new Model.Movie("Drive", 100, 2011, Genre.Drama, 7.3);
            _movies[2] = new Model.Movie("Blade runner 2049", 204, 2017, Genre.Thriller, 7.8);
            _movies[3] = new Model.Movie("The Gentlemen", 113, 2019, Genre.Action, 9);
            _movies[4] = new Model.Movie("Now you see me", 110, 2013, Genre.Thriller, 7.7);
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
        private int findRectangleWithMaxWidth(Model.Geometry.Rectangle[] rectangles)
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
                    loadElemsToValues<Model.Enums.Color>();
                    break;
                case "Form of Education":
                    loadElemsToValues<FormOfEducation>();
                    break;
                case "Genre":
                    loadElemsToValues<Genre>();
                    break;
                case "Season":
                    loadElemsToValues<Season>();
                    break;
                case "Manufactures":
                    loadElemsToValues<SmartphoneManufacturer>();
                    break;
                case "Weekday":
                    loadElemsToValues<Weekday>();
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
            if (Enum.TryParse(text, out Weekday day))
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
            _currentMovie.setGenre(Enum.GetValues<Genre>()[genre.SelectedIndex]);
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
        private int findMovieWithMaxRating(Movie[] movies)
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
        private void updateData()
        {
            listBox3.Items.Clear();
            foreach (Model.Geometry.Rectangle rect in rectangles)
            {
                listBox3.Items.Add(rect.toString());
            }
        }
        private void addRectangle(object sender, EventArgs e)
        {
            Model.Geometry.Rectangle rect = new Model.Geometry.Rectangle(new Random().NextDouble() * 100, new Random().NextDouble() * 100, "Purple", new Model.Geometry.Point2D(new Random().NextDouble() * 500, new Random().NextDouble() * 500));
            Panel panel = new Panel();
            panel.Width = Convert.ToInt16(rect.getWidth());
            panel.Height = Convert.ToInt16(rect.getHeight());
            panel.Location = new Point(Convert.ToInt16(rect.getCenter().getX()), Convert.ToInt16(rect.getCenter().getY()));
            panel.BackColor = Color.FromArgb(127, 127, 255, 127);
            if (_rectanglePanel.Count > 0)
            {
                for (int i = 0; i < rectangles.Count; i++)
                {
                    if (CollisionManager.isCollision(rect, rectangles[i]))
                    {
                        panel.BackColor = Color.FromArgb(127, 255, 127, 127);
                        _rectanglePanel.ElementAt<Panel>(i).BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
            rectangles.Add(rect);
            _rectanglePanel.Add(panel);
            panel1.Controls.Add(panel);
            updateData();
        }

        private void deleteRectangle(object sender, EventArgs e)
        {
            try
            {
                rectangles.RemoveAt(listBox3.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException ignored)
            {

            }
            panel1.Controls.RemoveAt(listBox3.SelectedIndex);
            _rectanglePanel.RemoveAt(listBox3.SelectedIndex);
            updateData();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentRectangle = rectangles[listBox3.SelectedIndex];
            textBox9.Text = currentRectangle.id().ToString();
            textBox8.Text = currentRectangle.getCenter().getX().ToString();
            textBox7.Text = currentRectangle.getCenter().getY().ToString();
            textBox6.Text = currentRectangle.getWidth().ToString();
            textBox5.Text = currentRectangle.getHeight().ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            currentRectangle.setWidth(Convert.ToDouble(textBox6.Text));
            updateData();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            currentRectangle.setHeight(Convert.ToDouble(textBox5.Text));
            updateData();
        }
    }
}
