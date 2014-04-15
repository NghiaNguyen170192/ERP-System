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
    public partial class UpdateWESPage : System.Web.UI.Page
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

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtDate.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void btnUpdateWareHouse_Click(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            int wesId = int.Parse(DropDownList3.SelectedValue);
            string date = txtDate.Text;
            int wareHouseId = int.Parse(DropDownList1.SelectedValue);
            int providerId = int.Parse(DropDownList2.SelectedValue);
            int totalValue = int.Parse(txtTotalValue.Text);
            string userName = txtUser.Text;
            m.wesFunction(wesId, date, wareHouseId, providerId, totalValue, userName, 1);
            Response.Redirect("/HTML/WESFolder/WESPage.aspx");
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

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

            string query = "SELECT Date, WareHouseId, ProviderId, TotalValue, UserName FROM WES WHERE WesId = @wesId";
            SqlConnection connection = new SqlConnection("Data Source=NGHIA-PC;Initial Catalog=master;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Parameters.AddWithValue("@wesId", DropDownList3.SelectedValue);
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = connection;
            try
            {
                connection.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    txtDate.Text = sdr["Date"].ToString();
                    //txtWareHouseName.Text =  sdr["WareHouseId"].ToString();
                    //txtProviderName.Text = sdr["ProviderId"].ToString();
                    txtTotalValue.Text = sdr["TotalValue"].ToString();
                    txtUser.Text = sdr["UserName"].ToString();

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