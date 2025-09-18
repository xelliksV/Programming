using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {
        private static long nextId = 1;
        private readonly long _id;
        private readonly DateTime _createdTime;
        private Address _address;
        private Cart _cart;
        private double _amount;
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
