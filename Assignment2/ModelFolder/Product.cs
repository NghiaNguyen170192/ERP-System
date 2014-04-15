using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.ModelFolder
{
    public class Product
    {
        private int id;
        private string name;
        private string description;
        private string unit;
        private float price;
        

        public Product(int id, string name, string description, string unit, float price)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.unit = unit;            
            this.price = price;            
        }

        public int Id { get { return this.id; } set { this.id = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public string Description { get { return this.description; } set { this.description = value; } }
        public string Unit { get { return this.unit; } set { this.unit = value; } }        
        public float Price { get { return this.price; } set { this.price = value; } }        

    }
}