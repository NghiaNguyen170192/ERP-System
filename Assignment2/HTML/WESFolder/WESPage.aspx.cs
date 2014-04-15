using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment2.ModelFolder;
namespace Assignment2.HTML.WESFolder
{
    public partial class WESPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            List<WES> list = m.getWesList();
            //Label1.Text = "Number of WES: " + list.Count;

        }
    }
}