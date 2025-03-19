using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Geometry;

namespace Programming.View
{
    public partial class RectanglesCollisionControl : UserControl
    {
        private List<Model.Geometry.Rectangle> rectangles = new List<Model.Geometry.Rectangle>();
        private Model.Geometry.Rectangle currentRectangle;
        private List<Panel> _rectanglePanel = new List<Panel>();
        private Panel currentPanel;
        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }
        private void updateData()
        {
            listBox3.Items.Clear();
            foreach (Model.Geometry.Rectangle rect in rectangles)
            {
                listBox3.Items.Add(rect.toString());
            }
        }
        private void updateRectanglePanel()
        {
            panel1.Controls.Clear();

            _rectanglePanel.ForEach(x =>
            {
                panel1.Controls.Add(x);
            });
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
            textBox6.Text = Math.Round(currentRectangle.getWidth()).ToString();
            textBox5.Text = Math.Round(currentRectangle.getHeight()).ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            currentRectangle.setWidth(Convert.ToDouble(textBox6.Text));
            currentPanel = _rectanglePanel[listBox3.SelectedIndex];
            currentPanel.Width = Convert.ToInt16(textBox6.Text);
            _rectanglePanel[listBox3.SelectedIndex] = currentPanel;
            if (listBox3.SelectedIndex >= 0)
            {
                _rectanglePanel[listBox3.SelectedIndex].Width = Convert.ToInt16(textBox6.Text);
            }
            updateData();
            updateRectanglePanel();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            currentRectangle.setHeight(Convert.ToDouble(textBox5.Text));
            currentPanel = _rectanglePanel[listBox3.SelectedIndex];
            currentPanel.Height = Convert.ToInt16(textBox5.Text);
            if (listBox3.SelectedIndex >= 0)
            {
                _rectanglePanel[listBox3.SelectedIndex].Height = Convert.ToInt16(textBox5.Text);
            }
            updateData();
            updateRectanglePanel();
        }

       
    }
}
