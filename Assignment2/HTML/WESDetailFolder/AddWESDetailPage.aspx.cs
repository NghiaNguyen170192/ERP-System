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
    public partial class AddWESDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnWESDetail_Click(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            //WESDetail
            int id = 0;
            int productId = int.Parse(DropDownList1.SelectedValue.ToString());
            int wesId = 0;
            string date="", userName="";
            int wareHouseId=0, providerId=0;
            if (Request.QueryString["id"] != null)
            {
                wesId = int.Parse(Request.QueryString["id"].ToString());
                DropDownList ddl = DropDownList1;
                //DropDownList1.Enabled = false;
                //DropDownList1.Attributes.Add("disabled", "true");
                //DropDownList1.Visible=false;
                ddl.Enabled = false;
                ddl.Attributes.Add("disabled","disable");
                ddl.Visible = false;
                date = Request.QueryString["date"].ToString();
                wareHouseId = int.Parse(Request.QueryString["wareHouseId"].ToString());
                providerId = int.Parse(Request.QueryString["providerId"].ToString());
                userName = Request.QueryString["userName"].ToString();
            }
            else {

                wesId = int.Parse(DropDownList2.SelectedValue);
                SqlConnection connection = new SqlConnection("Data Source=NGHIA-PC;Initial Catalog=master;Integrated Security=True");
                
                string query = "SELECT * FROM WES WHERE WesId ="+ wesId;
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Connection = connection;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        
                         date = reader["Date"].ToString();
                         wareHouseId = int.Parse(reader["WareHouseId"].ToString());
                         providerId = int.Parse(reader["ProviderId"].ToString());                         
                         userName = reader["UserName"].ToString();                        

                    }
                }
                

                reader.Close();
                connection.Close();
            }
            
            int quantity = int.Parse(txtQuantity.Text);
            string unit = txtUnit.Text;
            float price = float.Parse(txtPrice.Text);
            m.wesDetailFunction(id, productId, wesId, quantity, unit, price, 0);

            
            //string link = "/HTML/WESDetailFolder/AddWESDetailPage.aspx?id="
            //   + wesId + "&date=" + date + "&wareHouseId=" + wareHouseId 
            //+ "&providerId=" + providerId + "&userName=" + userName;
            
            m.wesFunction(wesId, date, wareHouseId, providerId, price, userName, 1);
            Response.Redirect("/HTML/WESDetailFolder/WESDetailPage.aspx");
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


    }
}