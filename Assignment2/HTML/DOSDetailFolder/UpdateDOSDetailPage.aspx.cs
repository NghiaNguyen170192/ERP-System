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

namespace Assignment2.HTML.DOSDetailFolder
{
    public partial class UpdateDOSDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtQuantity_TextChanged(object sender, EventArgs e)
        {

            int quantity = int.Parse(txtQuantity.Text);

            string query = "SELECT Price FROM Product WHERE Id = @id";
            SqlConnection connection = new SqlConnection("Data Source=NGHIA-PC;Initial Catalog=master;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Parameters.AddWithValue("@id", DropDownList2.SelectedValue);
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            int id = int.Parse(DropDownList3.SelectedValue.ToString());
            int dosId = int.Parse(DropDownList1.SelectedValue.ToString());
            int productId = int.Parse(DropDownList2.SelectedValue.ToString());
            int quantity = int.Parse(txtQuantity.Text);
            float price = float.Parse(txtPrice.Text);
            m.dosDetailFunction(id, dosId, productId, quantity, price, 1);
            Response.Redirect("/HTML/DOSDetailFolder/DOSDetailPage.aspx");
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}