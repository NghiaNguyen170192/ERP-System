using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment2.ModelFolder;
namespace Assignment2.HTML.DOSFolder
{
    public partial class UpdateDOSPage : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            int id = int.Parse(DropDownList3.SelectedValue.ToString());
            int fromWareHouse = int.Parse(DropDownList1.SelectedValue.ToString());
            int toWareHouse = int.Parse(DropDownList2.SelectedValue.ToString());
            string date = txtDate.Text;
            string time = DateTime.Now.ToShortTimeString();
            if (fromWareHouse == toWareHouse)
            {
                Response.Write("<script>alert('2 IDs must be different');</script>");
            }
            else
            {
                m.dosFunction(id, date, time, fromWareHouse, toWareHouse, 1);
                Response.Redirect("/HTML/DOSFolder/DOSPage.aspx");
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtDate.Text = Calendar1.SelectedDate.ToShortDateString();



        }
    }
}