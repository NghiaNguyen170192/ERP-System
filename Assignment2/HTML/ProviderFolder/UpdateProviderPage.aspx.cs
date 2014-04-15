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
    public partial class UpdateProviderPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem != null)
            {
                Label1.Text = "You selected: " + DropDownList1.SelectedItem.Value;

            }
            else
            {
                Label1.Text = "";
            }
        }

        protected void btnProvider_Click(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            int id = int.Parse(DropDownList1.SelectedValue.ToString());
            string name = txtName.Text;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string contactPerson = txtContactPerson.Text;
            string contactPhone = txtContactPhone.Text;
            string contactEmail = txtContactEmail.Text;

            m.providerFunction(id, name, address, phone, email, contactPerson, contactPhone, contactEmail, 1);
            Response.Redirect("/HTML/ProviderFolder/ProviderPage.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT Name, Address, Phone, Email, ContactPerson, ContactPhone, ContactEmail  FROM Provider WHERE Id = @id";
            SqlConnection connection = new SqlConnection("Data Source=NGHIA-PC;Initial Catalog=master;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Parameters.AddWithValue("@id", DropDownList1.SelectedValue);
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = connection;
            try
            {
                connection.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    txtName.Text = sdr["Name"].ToString();
                    txtAddress.Text = sdr["Address"].ToString();
                    txtPhone.Text = sdr["Phone"].ToString();
                    txtEmail.Text = sdr["Email"].ToString();
                    txtContactPerson.Text = sdr["ContactPerson"].ToString();
                    txtContactPhone.Text = sdr["ContactPhone"].ToString();
                    txtContactEmail.Text = sdr["ContactEmail"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }

        }
    }
}