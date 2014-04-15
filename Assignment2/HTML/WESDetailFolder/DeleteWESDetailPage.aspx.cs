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
    public partial class DeleteWESDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWESDetail_Click(object sender, EventArgs e)
        {
            Model m = Model.getModel();
            int id = int.Parse(DropDownList1.SelectedValue.ToString());
            int wesId = 0, wareHouseId = 0, providerId = 0;
            string date = "", userName = "";
            float price = 0;

            SqlConnection conn = new SqlConnection("Data Source=NGHIA-PC;Initial Catalog=master;Integrated Security=True");
            string query1 = "SELECT * FROM WESDetail WHERE Id=" + id;

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = query1;
            command.Connection = conn;

            try
            {
                conn.Open();
                SqlDataReader sdr = command.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        wesId = int.Parse(sdr[2].ToString());
                        price = float.Parse(sdr[5].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();

            }

            //Label1.Text = "ID" + wesId + "  /" + id + "    /" + price;
            string query2 = "SELECT * FROM WES WHERE WesId=" + wesId;
            command.CommandText = query2;
            command.Connection = conn;

            try
            {
                conn.Open();
                SqlDataReader sdr = command.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        date = sdr["Date"].ToString();
                        wareHouseId = int.Parse(sdr["WareHouseId"].ToString());
                        providerId = int.Parse(sdr["ProviderId"].ToString());
                        userName = sdr["UserName"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();

            }
            //Label1.Text += "abcd";
            m.wesDetailFunction(id, 0, wesId, 0, "", price, 2);
            price = price * (-1);
            m.wesFunction(wesId, date, wareHouseId, providerId, price, userName, 1);

            Response.Redirect("/HTML/WESDetailFolder/WESDetailPage.aspx");
        }
    }
}