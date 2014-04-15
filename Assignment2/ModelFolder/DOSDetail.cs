using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2.ModelFolder
{
    public class DOSDetail
    {
        private int id, dosId, productId, quantity;
        private float price;
        public DOSDetail(int id, int dosId, int productId, int quantity, float price)
        {
            this.id = id;
            this.dosId = dosId;
            this.productId = productId;
            this.quantity = quantity;
            this.price = price;
        }

        public int Id { get { return this.id; } set { this.id = value; } }
        public int DosId { get { return this.dosId; } set { this.dosId = value; } }
        public int ProductId { get { return this.productId; } set { this.productId = value; } }
        public int Quantity { get { return this.quantity; } set { this.quantity = value; } }
        public float Price { get { return this.price; } set { this.price = value; } }
    }
}
