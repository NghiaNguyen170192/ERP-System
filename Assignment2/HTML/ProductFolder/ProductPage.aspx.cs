using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment2.ModelFolder;
namespace Assignment2.HTML.ProductFolder
{
    public partial class ProductPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            List<Product> list = m.getProductList();
            //Label1.Text = "Number of Product:  " + list.Count;
            //foreach (var v in list)
            //{
            //    Label1.Text += "/" + v.Name;
            //}
        }
    }
}