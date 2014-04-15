using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment2.ModelFolder;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Assignment2.HTML.ProductFolder
{
    public partial class DeleteProductPage : System.Web.UI.Page
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

        protected void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            int id = int.Parse(DropDownList1.SelectedValue.ToString());

            bool check = m.checkDeleteProduct(id);
            if (check == false)
            {
                Response.Write("<script>alert('Cannot Delete!!!This Product associated with other fields');</script>");
            }
            else
            {
                m.productFunction(id, "", "", "", 0, 2);
                Response.Redirect("/HTML/ProductFolder/ProductPage.aspx");
            }


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}