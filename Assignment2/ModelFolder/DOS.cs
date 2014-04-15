using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2.ModelFolder
{
    public class DOS
    {
        private int dosId, fromWareHouse, toWareHouse;
        private string date, time;
        

        public DOS(int dosId, string date, string time, int fromWareHouse, int toWareHouse)
        {
            this.dosId = dosId;
            this.date = date;
            this.time = time;
            this.fromWareHouse = fromWareHouse;
            this.toWareHouse = toWareHouse;
        }

        public int DosId { get { return this.dosId; } set { this.dosId = value; } }
        public string Date { get { return this.date; } set { this.date = value; } }
        public string Time { get { return this.time; } set { this.time = value; } }
        public int FromWareHouse { get { return this.fromWareHouse; } set { this.fromWareHouse = value; } }
        public int ToWareHouse { get { return this.toWareHouse; } set { this.toWareHouse = value; } }
    }
}
