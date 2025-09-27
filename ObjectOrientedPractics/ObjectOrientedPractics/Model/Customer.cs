using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{

    public class Customer
    {
        private static int idCounter = 1;
        [JsonPropertyName("id")]
        private readonly int _id;
        [JsonPropertyName("fullname")]
        private string _fullname;
        [JsonPropertyName("address")]
        private Address _address;
        [JsonPropertyName("cart")]
        private Cart _cart;
        [JsonPropertyName("orders")]
        private List<Order> _orders;
        [JsonPropertyName("isPriority")]
        private bool _isPriority = false;
        public Customer(string fullname, Address address)
        {
            _id  = idCounter++;
            Fullname = fullname;
            Address = address;
            Cart = new Cart();
        }
        public Customer() { 
            _id = idCounter++;
            _cart = new Cart();
            _orders = new List<Order>();
        }
        public bool isPriority { get { return _isPriority; } set { _isPriority = value; } }
        public Cart Cart
        {
            get { return _cart; } set { _cart = value; }
        }
        public List<Order> Orders { get { return _orders; } set { _orders = value; } }
        public int Id { get { return _id; } }
        public string Fullname { get { return _fullname; } set
            {
                if (value.Length < 200)
                {
                    _fullname = value;
                } else
                {
                    throw new ArgumentException();
                }
            } 
        }
        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
            }
        }

        public override string? ToString()
        {
            return _fullname;
        }
    }
}
