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
namespace Assignment2.HTML.ProductFolder
{
    public partial class UpdateProductPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (DropDownList1.SelectedItem != null)
            {
                //Label1.Text = "You selected: " + DropDownList1.SelectedItem.Value;

            }
            else
            {
                //Label1.Text = "";
            }

        }

        protected void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            int id = int.Parse(DropDownList1.SelectedValue.ToString());
            string name = txtName.Text;
            string des = txtDes.Text;
            string unit = txtUnit.Text;
            float price = float.Parse(txtPrice.Text.ToString());
            m.productFunction(id, name, des, unit, price, 1);
            Response.Redirect("/HTML/ProductFolder/ProductPage.aspx");

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT Name, Description, Unit, Price FROM Product WHERE Id = @id";
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
                    txtDes.Text = sdr["Description"].ToString();
                    txtUnit.Text = sdr["Unit"].ToString();
                    txtPrice.Text = sdr["Price"].ToString();
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