using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    
    public class Cart : ICloneable, IEquatable<Cart>
    {
        [JsonPropertyName("items")]
        private List<Item> items = new List<Item>();
        public Cart() {
            
        }
        public List<Item> Items { get { return items; } set { items = value; } }
        public double Amount
        {
            get
            {
                if (items.Count == 0) return 0;
                double total = 0;
                foreach (Item item in items)
                {
                    total += item.Cost;
                }
                return total;
            }
        }

        public object Clone()
        {
            Cart cart = new Cart();
            cart.Items = Items;
            return cart;
        }

        public bool Equals(Cart? other)
        {
            return this == other;
        }
    }
}
