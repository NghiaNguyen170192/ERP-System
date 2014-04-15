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

namespace Assignment2.HTML.ProviderFolder
{
    public partial class AddProviderPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProvider_Click(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            int id = 0;
            string name = txtName.Text;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string contactPerson = txtContactPerson.Text;
            string contactPhone = txtContactPhone.Text;
            string contactEmail = txtContactEmail.Text;

            m.providerFunction(id, name, address, phone, email, contactPerson, contactPhone, contactEmail, 0);
            Response.Redirect("/HTML/ProviderFolder/ProviderPage.aspx");
        }
    }
}