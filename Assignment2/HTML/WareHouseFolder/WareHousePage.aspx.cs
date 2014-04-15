using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment2.ModelFolder;
namespace Assignment2.HTML.WareHouseFolder
{
    public partial class WareHousePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            List<WareHouse> list = m.getWareHouseList();
            //Label1.Text = " Number of warehouse: " + list.Count;

        }
    }
}