using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address = new Address();
        public AddressControl()
        {
            InitializeComponent();
        }

        public Address Address
        {
            get { return _address; }
            set
            {
                if (value != null)
                {
                    _address = value;
                    postTextBox.Text = _address.Index.ToString();
                    countryTextBox.Text = _address.Country.ToString();
                    cityTextBox.Text = _address.City.ToString();
                    streetTextBox.Text = _address.Street.ToString();
                    buildingTextBox.Text = _address.Building.ToString();
                    apartmentTextBox.Text = _address.Apartment.ToString();
                } else
                {
                    _address = new Address();
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _address.Country = countryTextBox.Text;
            _address.City = cityTextBox.Text;
            _address.Street = streetTextBox.Text;
            _address.Index = int.Parse(postTextBox.Text);
            _address.Building = buildingTextBox.Text;
            _address.Apartment = apartmentTextBox.Text;
        }
        public void updateControl()
        {
            postTextBox.Text = _address.Index.ToString();
            countryTextBox.Text = _address.Country.ToString();
            cityTextBox.Text = _address.City.ToString();
            streetTextBox.Text = _address.Street.ToString();
            buildingTextBox.Text = _address.Building.ToString();
            apartmentTextBox.Text = _address.Apartment.ToString();
        }

        private void postTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                postTextBox.BackColor = Color.White;
                new Address().Index = int.Parse(postTextBox.Text);
            }
            catch (Exception ex)
            {
                postTextBox.BackColor = Color.LightPink;
            }
        }

        private void countryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                countryTextBox.BackColor = Color.White;
                new Address().Country = countryTextBox.Text;
            }
            catch (Exception ex)
            {
                countryTextBox.BackColor = Color.LightPink;
            }
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cityTextBox.BackColor = Color.White;
                new Address().City = cityTextBox.Text;
            }
            catch (Exception ex)
            {
                cityTextBox.BackColor = Color.LightPink;
            }
        }

        private void streetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                streetTextBox.BackColor = Color.White;
                new Address().Street = streetTextBox.Text;
            }
            catch (Exception ex)
            {
                streetTextBox.BackColor = Color.LightPink;
            }
        }

        private void buildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                buildingTextBox.BackColor = Color.White;
                new Address().Building = buildingTextBox.Text;
            }
            catch (Exception ex)
            {
                buildingTextBox.BackColor = Color.LightPink;
            }
        }

        private void apartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                apartmentTextBox.BackColor = Color.White;
                new Address().Apartment = apartmentTextBox.Text;
            } catch (Exception ex)
            {
                apartmentTextBox.BackColor = Color.LightPink;
            }
        }
    }
}
