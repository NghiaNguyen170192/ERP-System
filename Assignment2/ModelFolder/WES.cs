using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.ModelFolder
{
    public class WES
    {
        private int wesId, wareHouseId, providerId ;
        private float totalValue;
        private string date, user;

        public WES(int wesId, string date, int wareHouseId, int providerId, float totalValue, string user)
        {
            this.wesId = wesId;
            this.date = date;
            this.wareHouseId = wareHouseId;
            this.providerId = providerId;
            this.totalValue = totalValue;
            this.user = user;

        }
        public int WesId { get { return this.wesId; } set { this.wesId = value; } }
        public string Date { get { return this.date; } set { this.date = value; } }
        public string User { get { return this.user; } set { this.user = value; } }
        public int WareHouseId { get { return this.wareHouseId; } set { this.wareHouseId = value; } }
        public int ProviderId { get { return this.providerId; } set { this.providerId = value; } }
        public float TotalValue { get { return this.totalValue; } set { this.totalValue = value; } }
    }
}