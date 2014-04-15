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
namespace Assignment2.HTML.WESDetailFolder
{
    public partial class UpdateWESDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM WESDetail WHERE Id = @id";
            SqlConnection connection = new SqlConnection("Data Source=NGHIA-PC;Initial Catalog=master;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Parameters.AddWithValue("@id", DropDownList3.SelectedValue);
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = connection;
            try
            {
                connection.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    //txtProductName.Text = "Product Name: " + sdr["Name"].ToString();
                    txtQuantity.Text = sdr["Quantity"].ToString();
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

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT Name FROM Product WHERE Id = @id";
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
                    txtProductName.Text = "Product Name: " + sdr["Name"].ToString();


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

        protected void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT Price FROM Product WHERE Id = @id";
            SqlConnection connection = new SqlConnection("Data Source=NGHIA-PC;Initial Catalog=master;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Parameters.AddWithValue("@id", DropDownList1.SelectedValue);
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = connection;
            float price = 0, total = 0;

            try
            {
                connection.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    price = float.Parse(sdr["Price"].ToString());
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
            total = int.Parse(txtQuantity.Text) * price;
            txtPrice.Text = total.ToString();
        }

        protected void btnWESDetail_Click(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            //WESDetail
            int id = int.Parse(DropDownList3.SelectedValue.ToString());
            int productId = int.Parse(DropDownList1.SelectedValue.ToString());
            int wesId = int.Parse(DropDownList2.SelectedValue.ToString());

            int quantity = int.Parse(txtQuantity.Text);
            string unit = txtUnit.Text;
            float price = float.Parse(txtPrice.Text);
            //bool check = m.wesDetailFunction(id, productId, wesId, quantity, unit, price, 1);
            //if (check == true)
            //{
            //Label1.Text = id + "/" + productId + "/" + wesId + "/" + quantity + "/" + unit + "/" + price;
            //}
            m.wesDetailFunction(id, productId, wesId, quantity, unit, price, 1);
            Response.Redirect("/HTML/WESDetailFolder/WESDetailPage.aspx");

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}