using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{

    public class Address : ICloneable, IEquatable<Address>
    {
        [JsonPropertyName("index")]
        private int _index;
        [JsonPropertyName("country")]
        private string _country;
        [JsonPropertyName("city")]
        private string _city;
        [JsonPropertyName("street")]
        private string _street;
        [JsonPropertyName("building")]
        private string _building;
        [JsonPropertyName("apartment")]
        private string _apartment;

        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
        public Address() { }

        public int Index { get { return _index; } set
            {
                if (value <= 999999)
                {
                    _index = value;
                } else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string Country
        {
            get { return _country; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 50, "Country"))
                {
                    _country = value;
                } else
                {
                    _country = " ";
                }
            }
        }
        public string City
        {
            get { return _city; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 50, "City"))
                {
                    _city = value;
                } else
                {
                    _city = " ";
                }
            }
        }
        public string Street
        {
            get { return _street; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 100, "Street"))
                {
                    _street = value;
                } else
                {
                    _street = " ";
                }
            }
        }
        public string Building
        {
            get { return _building; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 10, "Building"))
                {
                    _building = value;
                } else
                {
                    _building = " ";
                }
            }
        }
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 10, "Apartment"))
                {
                    _apartment = value;
                } else
                {
                    _apartment = " ";
                }
            }
        }

        

        public bool Equals(Address? other)
        {
            return this == other;
        }

        public object Clone()
        {
            return new Address(_index, _country, _city, _street, _building, _apartment);
        }
    }
}
