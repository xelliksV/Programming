using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Item
    {
        private static long idCounter = 0;
        private readonly long _id;
        private string _name;
        private string _info;
        private double _cost;

        public Item(string name, double cost, string info)
        {
            Name = name;
            Cost = cost;
            Info = info;
            _id = idCounter++;
        }

        public string Name { get { return _name; } set
            {
                if (value.Length < 200)
                {
                    _name = value;
                } else
                {
                    throw new ArgumentException();
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
                if (value.Length < 1000)
                {
                    _info = value; 
                } else
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}
