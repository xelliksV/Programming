using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    [DataContract]
    internal class Product
    {
        [DataMember]
        private String name;
        [DataMember]
        private String manufacturer;
        
        private Type type;
        [DataMember]
        private int count;
        public Product()
        {
            
        }
        public Product(String name, String manufacturer, Type type, int count)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.type = type;
            this.count = count;
        }
        public int Count { get { return count; } set { count = value; } }
        public String Name { get { return name; } set {
                if (value.Length <= 100)
                {
                    name = value;
                }
            } 
        }
        public String Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (value.Length <= 100)
                {
                    manufacturer = value;
                }
            }
        }
        public Type Type { get { return type; } set { type = value; } }
       

        public override string? ToString()
        {
            return name;
        }
    }
}
