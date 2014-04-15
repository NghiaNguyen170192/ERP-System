using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.ModelFolder
{
    public class WareHouse
    {
        private int wareHouseId;
        private string name;
        private string address;
        public WareHouse(int wareHouseId, string name, string address)
        {
            this.wareHouseId = wareHouseId;
            this.name = name;
            this.address = address;

        }
        public int WareHouseId { get { return this.wareHouseId; } set { this.wareHouseId = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public string Address { get { return this.address; } set { this.address = value; } }
    }
}