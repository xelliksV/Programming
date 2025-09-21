using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class PriorityOrder : Order
    {
        private DateTime _date;
        private String _time;
        public PriorityOrder(Address address, Cart cart, DateTime date, String time, String name) : base(address, cart, name)
        {

            _date = date;
            _time = time;
        }
        public PriorityOrder() { }
        public String Time { get { return _time; } set { _time = value; } }
    }
}
