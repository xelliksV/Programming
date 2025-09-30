using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Services
{
    public class DataTools
    {
        public delegate bool CompareItems(Item item, object n);
        public delegate bool Compare(Item item1, Item item2);
        public static bool compareByName(Item item1, Item item2)
        {
            return item1.Name.ToCharArray()[0] < item2.Name.ToCharArray()[0];
        }
        public static bool compareByCostAsc(Item item1, Item item2)
        {
            return item1.Cost > item2.Cost;
        }
        public static bool compareByCostDesc(Item item1, Item item2)
        {
            return item1.Cost < item2.Cost;
        }
        public static bool compareByCost(Item item, object cost)
        {
            return item.Cost > (double) cost;
        }
        public static bool compareByCategory(Item item, object category)
        {
            return item.Category == (Category)Enum.GetValues(typeof(Category)).GetValue((int)category);
        }
        public static bool daidinahuy(Item item, object substring)
        {
            return item.Name.Contains((string) substring);
        }
        public static List<Item> filter(List<Item> items, CompareItems compare, object n)
        {
            List<Item> list = new List<Item>();
            foreach (Item item in items)
            {
                if (compare(item, n))
                {
                    list.Add(item);
                }
            }
            return list;
        }
        public static List<Item> sort(List<Item> items, Compare compare)
        {
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 1; j < items.Count; j++)
                {
                    if (compare(items[j], items[j-1]))
                    {
                        Item temp = items[j];
                        items[j] = items[j-1];
                        items[j-1] = temp;
                    }
                }
            }
            return items;
        }
    }
}
