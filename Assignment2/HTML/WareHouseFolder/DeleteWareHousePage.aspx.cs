using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Assignment2.ModelFolder;
namespace Assignment2.HTML.WareHouseFolder
{
    public partial class DeleteWareHousePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem != null)
            {


            }
            else
            {

            }
        }

        protected void btnDeleteWareHouse_Click(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            int id = int.Parse(DropDownList1.SelectedValue.ToString());

            bool check = m.checkDeleteWareHouse(id);
            if (check == false)
            {
                Response.Write("<script>alert('Cannot Delete!!!This WareHouse associated with other fields');</script>");
            }
            else
            {
                m.wareHouseFunction(id, "", "", 2);
                Response.Redirect("/HTML/WareHouseFolder/WareHousePage.aspx");
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}