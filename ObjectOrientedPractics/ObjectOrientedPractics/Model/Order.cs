using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    using System.Text.Json.Serialization;

    [JsonDerivedType(typeof(PriorityOrder), "priorityOrder")]
    public class Order
    {
        private static long nextId = 1;

        [JsonPropertyName("id")]
        private long _id;

        [JsonPropertyName("createdTime")]
        private DateTime _createdTime;

        [JsonPropertyName("address")]
        private Address _address;

        [JsonPropertyName("cart")]
        private Cart _cart;

        [JsonPropertyName("amount")]
        private double _amount;

        [JsonPropertyName("status")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        private OrderStatus _status;

        [JsonPropertyName("name")]
        private string _name;

        public Order(Address address, Cart cart, string name)
        {
            _address = address;
            _cart = cart;
            _createdTime = DateTime.Now;
            _amount = cart.Amount;
            _id = nextId++;
            _name = name;
            _status = OrderStatus.New; 
        }
        
        [JsonConstructor]
        public Order() { }

        public long Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public DateTime TimeCreated { get { return _createdTime; } set { _createdTime = value; } }
        public Address Address { get { return _address; } set { _address = value; } }
        public Cart Cart { get { return _cart; } set { _cart = value; } }
        public double Amount { get { return _amount; } set { _amount = value; } }
        public OrderStatus Status { get { return _status; } set { _status = value; } }
    }
}
