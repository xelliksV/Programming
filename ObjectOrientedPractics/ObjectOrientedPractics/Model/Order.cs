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

        public Order(Address address, Cart cart) {
            _address = address;
            _cart = cart;
            _createdTime = DateTime.Now;
            _amount = cart.Amount;
            _id = nextId++;
        }
    }
}
