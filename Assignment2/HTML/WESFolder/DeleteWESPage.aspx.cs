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

namespace Assignment2.HTML.WESFolder
{
    public partial class DelteWESPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnUpdateWareHouse_Click(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            int wesId = int.Parse(DropDownList3.SelectedValue);
            //string date = txtDate.Text;
            //int wareHouseId = int.Parse(DropDownList1.SelectedValue);
            //int providerId = int.Parse(DropDownList2.SelectedValue);
            //int totalValue = int.Parse(txtTotalValue.Text);
            //string userName = txtUser.Text;
            bool check = m.checkDeleteWES(wesId);
            if (check == false)
            {
                Response.Write("<script>alert('Cannot Delete!!!This WES associated with other fields');</script>");
            }
            else
            {
                m.wesFunction(wesId, "", 0, 0, 0, "", 2);
                Response.Redirect("/HTML/WESFolder/WESPage.aspx");
            }
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}