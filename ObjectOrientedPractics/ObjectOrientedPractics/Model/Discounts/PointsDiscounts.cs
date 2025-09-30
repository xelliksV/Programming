using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PointsDiscounts : IDiscount, IComparable<PointsDiscounts>
    {
       
        private int count;
        public PointsDiscounts() { }
        public int Count { get { return count; } private set { } }
        private double amount(List<Item> items)
        {
            double total = 0;
            foreach (Item item in items)
            {
                total += item.Cost;
            }
            return total;
        }
        public double Calculate(List<Item> items)
        {
            double total = amount(items);
            if (count <= total * 0.3)
            {
                return count;
            }
            else
            {
                return total * 0.3;
            }
        }
        public double Apply(List<Item> items)
        {
            double result = Calculate(items);
            if (result == count)
            {
                count = 0;
            }
            else
            {
                count -= (int)result;
            }
            return result;
        }
        public void Update(List<Item> items)
        {
            count += (int)(amount(items) * 0.1);
        }

        public int CompareTo(PointsDiscounts? other)
        {
            return (other.Count - Count);
        }

        public string Info { get { return "Накопительная - " + count + " баллов."; } }
    }
}
