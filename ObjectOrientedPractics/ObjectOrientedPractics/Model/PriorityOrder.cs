using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{

    public class PriorityOrder : Order
    {
        [JsonPropertyName("date")]
        private DateTime _date;

        [JsonPropertyName("time")]
        private string _time;

        public PriorityOrder(Address address, Cart cart, DateTime date, string time, string name)
            : base(address, cart, name)
        {
            _date = date;
            _time = time;
        }

       
        [JsonConstructor]
        public PriorityOrder() { }

        public DateTime Date { get { return _date; } set { _date = value; } }
        public string Time { get { return _time; } set { _time = value; } }
    }
}
