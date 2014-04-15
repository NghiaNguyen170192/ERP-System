using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.ModelFolder
{
    public class WESDetail
    {
        private int id;
        private int productId;
        private int wesId;
        private int quantity;
        private string unit;
        private float price;

        public WESDetail(int id, int productId, int wesId, int quantity, string unit, float price)
        {
            this.id = id;
            this.productId = productId;
            this.wesId = wesId;
            this.quantity = quantity;
            this.unit = unit;
            this.price = price;
        }

        public int Id { get { return this.id; } set { this.id = value; } }
        public int ProductId { get { return this.productId; } set { this.productId = value; } }
        public int WesId { get { return this.wesId; } set { this.wesId = value; } }
        public int Quantity { get { return this.quantity; } set { this.quantity = value; } }
        public string Unit { get { return this.unit; } set { this.unit = value; } }
        public float Price { get { return this.price; } set { this.price = value; } }

    }
}