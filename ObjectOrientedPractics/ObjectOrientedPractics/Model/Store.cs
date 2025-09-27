using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.Model
{
    public class Store
    {
        private List<Item> _items = new List<Item>();
        private List<Customer> customers = new List<Customer>();
        private JsonSerialazer<Item> itemSerializer = new JsonSerialazer<Item>("C:\\Users\\vlad4\\OneDrive\\Документы\\itemsData.json");
        private JsonSerialazer<Customer> serialazer = new JsonSerialazer<Customer>("C:\\Users\\vlad4\\OneDrive\\Документы\\customersData.json");
        public Store() 
        {
            _items = itemSerializer.deserialize();
            if (_items == null)
            {
                
                _items = new List<Item>();
            }
            customers = serialazer.deserialize();
            if (customers == null)
            {
                customers = new List<Customer>();
            }
        }
        public List<Item> Items { get { return _items; } set { _items = value; } }  
        public List<Customer> Customers { get { return customers; } set { customers = value; } }
        public void updateItemsData(List<Item> items)
        {
            itemSerializer.clear();
            itemSerializer.serialize(items);
        }
        public void updateCustomersData(List<Customer> customers)
        {
            serialazer.clear();
            serialazer.serialize(customers);
        }

    }
}
