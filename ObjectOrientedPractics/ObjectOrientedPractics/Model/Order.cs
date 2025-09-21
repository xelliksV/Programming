using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    [DataContract]
    public class Order
    {
        private static long nextId = 1;
        [DataMember]
        private readonly long _id;
        [DataMember]
        private readonly DateTime _createdTime;
        [DataMember]
        private Address _address;
        [DataMember]
        private Cart _cart;
        [DataMember]
        private double _amount;
        [DataMember]
        private OrderStatus _status;
        [DataMember]
        private string _name;

        public Order(Address address, Cart cart, string name) {
            _address = address;
            _cart = cart;
            _createdTime = DateTime.Now;
            _amount = cart.Amount;
            _id = nextId++;
            _name = name;
        }
        public Order() { }
        public long Id { get { return _id; } }
        public string Name { get { return _name; } }
        public DateTime TimeCreated { get { return _createdTime; } }
        public Address Address { get { return _address; } }
        public Cart Cart { get { return _cart; } }
        public double Amount { get { return _amount; } }
        public OrderStatus Status { get { return _status; } set { _status = value; } }
    }
}
