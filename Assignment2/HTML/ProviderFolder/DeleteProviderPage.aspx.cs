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
    public partial class DeleteProviderPage : System.Web.UI.Page
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

        protected void btnProvider_Click(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            int id = int.Parse(DropDownList1.SelectedValue.ToString());
            //string name = txtName.Text;
            //string address = txtAddress.Text;
            //string phone = txtPhone.Text;
            //string email = txtEmail.Text;
            //string contactPerson = txtContactPerson.Text;
            //string contactPhone = txtContactPhone.Text;
            //string contactEmail = txtContactEmail.Text;
            bool check = m.checkDeleteProvider(id);
            if (check == false)
            {
                Response.Write("<script>alert('Cannot Delete!!!This Provider associated with other fields');</script>");
            }
            else
            {
                m.providerFunction(id, "", "", "","", "", "", "", 2);
                Response.Redirect("/HTML/ProviderFolder/ProviderPage.aspx");
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}