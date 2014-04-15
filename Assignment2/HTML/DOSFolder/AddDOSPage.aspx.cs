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
namespace Assignment2.HTML.DOSFolder
{
    public partial class AddDOSPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            int dosId = 0;
            int fromWareHouse = int.Parse(DropDownList1.SelectedValue.ToString());
            int toWareHouse = int.Parse(DropDownList2.SelectedValue.ToString());
            string date = txtDate.Text;
            string time = DateTime.Now.ToShortTimeString();
            if (fromWareHouse == toWareHouse)
            {
                Response.Write("<script>alert('2 IDs must be different');</script>");
            }
            else {
                m.dosFunction(dosId, date, time, fromWareHouse, toWareHouse, 0);
          
                Response.Redirect("/HTML/DOSDetailFolder/AddDOSDetailPage.aspx");
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtDate.Text = Calendar1.SelectedDate.ToShortDateString();
                

               
        }
    }
}