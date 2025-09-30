using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{

    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        private static long idCounter = 0;
        [JsonPropertyName("id")]
        private readonly long _id;
        [JsonPropertyName("name")]
        private string _name;
        [JsonPropertyName("info")]
        private string _info;
        [JsonPropertyName("cost")]
        private double _cost;
        [JsonConverter(typeof(JsonStringEnumConverter))]
        private Category _category;

        public Item(string name, double cost, string info, Category category)
        {
            Name = name;
            Cost = cost;
            Info = info;
            _id = idCounter++;
            Category = category;
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
        public Category Category { get; set; }  

        public override string? ToString()
        {
            return Name;
        }

        public object Clone()
        {
            return new Item(_name, _cost, _info, _category);
        }

        public bool Equals(Item? other)
        {
            return this == other;
        }

        public int CompareTo(Item? other)
        {
            return (int) (other._cost - _cost);
        }
    }
}
