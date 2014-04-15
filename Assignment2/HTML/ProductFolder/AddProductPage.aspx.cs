using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment2.ModelFolder;
namespace Assignment2.HTML.ProductFolder
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            string name =txtName.Text;
            string des = txtDes.Text;
            string unit = txtUnit.Text;
            float price = float.Parse(txtPrice.Text);
            m.productFunction(0, name, des, unit, price, 0);
            Response.Redirect("/HTML/ProductFolder/ProductPage.aspx");
        }
    }
}