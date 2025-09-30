using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Discounts
{
    
    public class PercentDiscount : IDiscount, IComparable<PercentDiscount>
    {
        
        private Category category;
 
        private double percent = 0.99;
   
        private double total;
        public PercentDiscount(Category category)
        {
            this.category = category;
        }
        public Category Category { get { return category; } set { category = value; } }
        public string Info { get { return "Процентная " + category.ToString() + " - " + (1 - percent).ToString(); } }
        private double isCategoryPresent(List<Item> items)
        {
            double total = 0;
            foreach (Item item in items)
            {
                if (item.Category == category)
                {
                    total += item.Cost;
                }
            }
            return total;
        }
        public double Calculate(List<Item> items)
        {
            double total = isCategoryPresent(items);
            this.total += total;
            return total * percent;
        }
        public double Apply(List<Item> items)
        {
            Update(items);
            return Calculate(items);
        }
        public void Update(List<Item> items)
        {
            if (isCategoryPresent(items) > 1000 && percent <= 0.9)
            {
                percent -= 0.01;
            }
        }

        public int CompareTo(PercentDiscount? other)
        {
            return (int) (other.percent - percent);
        }
    }
}
