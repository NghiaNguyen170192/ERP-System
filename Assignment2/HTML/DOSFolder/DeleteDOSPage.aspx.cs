﻿using System;
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
    public partial class DeleteDOSPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            int dosId = int.Parse(DropDownList1.SelectedValue.ToString());
            m.dosFunction(dosId, "", "", 0, 0, 2);
            Response.Redirect("/HTML/DOSFolder/DOSPage.aspx");
        }
    }
}