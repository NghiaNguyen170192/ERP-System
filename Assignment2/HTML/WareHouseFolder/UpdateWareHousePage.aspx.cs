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
namespace Assignment2.HTML.WareHouseFolder
{
    public partial class UpdateWareHousePage : System.Web.UI.Page
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

        protected void btnUpdateWareHouse_Click(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            int id = int.Parse(DropDownList1.SelectedValue.ToString());
            string name = txtName.Text;
            string address = txtAddress.Text;

            m.wareHouseFunction(id, name, address, 1);
            Response.Redirect("/HTML/WareHouseFolder/WareHousePage.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT Name, Address FROM WareHouse WHERE WareHouseId = @id";
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