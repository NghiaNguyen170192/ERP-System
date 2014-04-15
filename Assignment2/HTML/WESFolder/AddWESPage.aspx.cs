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

namespace Assignment2.HTML.WESFolder
{
    public partial class AddWESPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtDate.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void btnUpdateWareHouse_Click(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            int wesId = 0;
            string date = txtDate.Text;
            int wareHouseId = int.Parse(DropDownList1.SelectedValue);
            int providerId = int.Parse(DropDownList2.SelectedValue);
            int totalValue = 0;
            string userName = txtUser.Text;
            m.wesFunction(wesId, date, wareHouseId, providerId, totalValue, userName, 0);

            string query = "SELECT WesId FROM WES WHERE TotalValue=0";
            SqlConnection connection = new SqlConnection("Data Source=NGHIA-PC;Initial Catalog=master;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = connection;
            try
            {
                connection.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    wesId = int.Parse(sdr["WesId"].ToString());
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
            string link = "/HTML/WESDetailFolder/AddWESDetailPage.aspx?id="
                + wesId + "&date=" + date + "&wareHouseId=" + wareHouseId + 
                "&providerId=" + providerId + "&userName=" + userName;
            //string link = "/HTML/WESDetailFolder/AddWESDetailPage.aspx";
            Response.Redirect(link);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT Name FROM WareHouse WHERE WareHouseId = @id";
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
                    txtWareHouseName.Text = "Ware House Name: " + sdr["Name"].ToString();


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

            string query = "SELECT Name FROM Provider WHERE Id = @id";
            SqlConnection connection = new SqlConnection("Data Source=NGHIA-PC;Initial Catalog=master;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Parameters.AddWithValue("@id", DropDownList2.SelectedValue);
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = connection;
            try
            {
                connection.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    txtProviderName.Text = "Provider Name: " + sdr["Name"].ToString();


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