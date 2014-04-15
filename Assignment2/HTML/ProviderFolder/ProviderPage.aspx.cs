using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment2.ModelFolder;
namespace Assignment2.HTML.ProviderFolder
{
    public partial class ProviderPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            List<Provider> list = m.getProviderList();
            //Label1.Text = "Number of Provider: " + list.Count;

        }
    }
}