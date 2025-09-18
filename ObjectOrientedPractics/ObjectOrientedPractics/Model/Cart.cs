using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Cart
    {
        private List<Item> items = new List<Item>();
        public Cart() { }
        public List<Item> Items { get; set; }
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
    }
}
