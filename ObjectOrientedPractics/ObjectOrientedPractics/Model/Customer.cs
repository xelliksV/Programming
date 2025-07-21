using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    [DataContract]
    internal class Customer
    {
        private static int idCounter = 1;
        [DataMember]
        private readonly int _id;
        [DataMember]
        private string _fullname;
        [DataMember]
        private string _address;

        public Customer(string fullname, string address)
        {
            _id  = idCounter++;
            Fullname = fullname;
            Address = address;
        }

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
        public string Address
        {
            get { return _address; }
            set
            {
                if (value.Length < 500)
                {
                    _address = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}
