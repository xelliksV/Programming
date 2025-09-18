using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    [DataContract]
    public class Customer
    {
        private static int idCounter = 1;
        [DataMember]
        private readonly int _id;
        [DataMember]
        private string _fullname;
        [DataMember]
        private Address _address;
        [DataMember]
        private Cart _cart;
        public Customer(string fullname, Address address)
        {
            _id  = idCounter++;
            Fullname = fullname;
            Address = address;
            _cart = new Cart();
        }
        public Customer() { 
            _id = idCounter++;
        }
        public Cart Cart
        {
            get; set;
        }
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
