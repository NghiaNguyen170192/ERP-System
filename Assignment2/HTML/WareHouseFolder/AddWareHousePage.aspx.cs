using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment2.ModelFolder;
namespace Assignment2.HTML.WareHouseFolder
{
    public partial class AddWareHousePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddWareHouse_Click(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            int id=0;
            string name = txtName.Text;
            string address = txtAddress.Text;

            m.wareHouseFunction(id, name, address, 0);
            Response.Redirect("/HTML/WareHouseFolder/WareHousePage.aspx");
        }
    }
}