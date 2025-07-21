using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    [DataContract]
    internal class Item
    {
        private static long idCounter = 0;
        [DataMember]
        private readonly long _id;
        [DataMember]
        private string _name;
        [DataMember]
        private string _info;
        [DataMember]
        private double _cost;

        public Item(string name, double cost, string info)
        {
            Name = name;
            Cost = cost;
            Info = info;
            _id = idCounter++;
        }
        public Item()
        {
            _id = idCounter++;
        }
        public long Id { get { return _id; } }
        public string Name { get { return _name; } set
            {
                if (ValueValidator.AssertStringOnLength(value, 200, "Name"))
                {
                    _name = value;
                } 
            } }
        public double Cost
        {
            get { return _cost; }
            set
            {
                if (value >= 0 && value <= 100000)
                {
                    _cost = value;
                } else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string Info { get { return _info; } set
            {
                if (ValueValidator.AssertStringOnLength(value, 1000, "Info"))
                {
                    _info = value; 
                } 
            }
        }

        public override string? ToString()
        {
            return Name;
        }
    }
}
