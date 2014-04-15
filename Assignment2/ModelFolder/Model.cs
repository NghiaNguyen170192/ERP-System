using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Assignment2.ModelFolder
{
    public class Model
    {
        private static Model model = new Model();
        private string CONNECTION_STRING = "Data Source=NGHIA-PC;Initial Catalog=master;Integrated Security=True";
        private SqlConnection connection;
        private List<Product> productList;
        private List<WareHouse> wareHouseList;
        private List<WES> wesList;
        private List<Provider> providerList;
        private List<WESDetail> wesDetailList;
        private List<DOS> dosList;
        private List<DOSDetail> dosDetailList;

        public Model()
        {
            productList = new List<Product>();
            wareHouseList = new List<WareHouse>();
            wesList = new List<WES>();
            providerList = new List<Provider>();
            wesDetailList = new List<WESDetail>();
            dosList = new List<DOS>();
            dosDetailList = new List<DOSDetail>();
            connection = new SqlConnection(CONNECTION_STRING);
            init();
        }

        public static Model getModel()
        {
            return model;
        }
        private void init()
        {
            initProduct();
            initWareHouse();
            initWes();
            initProvider();
            initWesDetail();
            initDOS();
            initDOSDetail();
        }

        /*Initialize all data from SQL Server and load into List*/
        private bool initProduct()
        {
            bool success = false;

            connection.Open();

            SqlCommand command = new SqlCommand("SelectAllProduct", connection);
            command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.Add("@emp_id", SqlDbType.VarChar, 10);
            //command.Parameters["@emp_id"].Value = "1";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {

                    int id = int.Parse(reader[0].ToString());
                    string name = reader[1].ToString();
                    string description = reader[2].ToString();
                    string unit = reader[3].ToString();

                    float price = float.Parse(reader[4].ToString());

                    productList.Add(new Product(id, name, description, unit, price));

                }
            }
            else
            {
                success = false;
            }
            reader.Close();
            connection.Close();
            success = true;
            return success;
        }

        private bool initWareHouse()
        {

            bool success = false;

            connection.Open();

            SqlCommand command = new SqlCommand("SelectAllWareHouse", connection);
            command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.Add("@emp_id", SqlDbType.VarChar, 10);
            //command.Parameters["@emp_id"].Value = "1";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {

                    int id = int.Parse(reader[0].ToString());
                    string name = reader[1].ToString();
                    string address = reader[2].ToString();
                    wareHouseList.Add(new WareHouse(id, name, address));

                }
            }
            else
            {
                success = false;
            }

            reader.Close();
            connection.Close();
            success = true;
            return success;

        }

        private bool initWes()
        {

            bool success = false;

            connection.Open();

            SqlCommand command = new SqlCommand("dbo.SelectAllWes", connection);
            command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.Add("@emp_id", SqlDbType.VarChar, 10);
            //command.Parameters["@emp_id"].Value = "1";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {

                    int wesId = int.Parse(reader[0].ToString());
                    string date = reader[1].ToString();
                    int wareHouseId = int.Parse(reader[2].ToString());
                    int providerId = int.Parse(reader[3].ToString());
                    float totalValue = float.Parse(reader[4].ToString());
                    string user = reader[5].ToString();
                    wesList.Add(new WES(wesId, date, wareHouseId, providerId, totalValue, user));

                }
            }
            else
            {
                success = false;
            }

            reader.Close();
            connection.Close();
            success = true;
            return success;
        }

        private bool initProvider()
        {

            bool success = false;

            connection.Open();

            SqlCommand command = new SqlCommand("dbo.SelectAllProvider", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {

                    int id = int.Parse(reader[0].ToString());
                    string name = reader[1].ToString();
                    string address = reader[2].ToString();
                    string phone = reader[3].ToString();
                    string email = reader[4].ToString();
                    string contactPerson = reader[5].ToString();
                    string contactPhone = reader[6].ToString();
                    string contactEmail = reader[7].ToString();
                    providerList.Add(new Provider(id, name, address, phone, email, contactPerson, contactPhone, contactEmail));

                }
            }
            else
            {
                success = false;
            }

            reader.Close();
            connection.Close();
            success = true;
            return success;
        }

        private bool initWesDetail()
        {

            bool success = false;

            connection.Open();

            SqlCommand command = new SqlCommand("dbo.SelectAllWESDetail", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    int id = int.Parse(reader[0].ToString());
                    int productId = int.Parse(reader[1].ToString());
                    int wesId = int.Parse(reader[2].ToString());
                    int quantity = int.Parse(reader[3].ToString());
                    string unit = reader[4].ToString();
                    float price = float.Parse(reader[5].ToString());

                    wesDetailList.Add(new WESDetail(id, productId, wesId, quantity, unit, price));

                }
            }
            else
            {
                success = false;
            }

            reader.Close();
            connection.Close();
            success = true;
            return success;
        }

        private bool initDOS()
        {

            bool success = false;

            connection.Open();

            SqlCommand command = new SqlCommand("dbo.SelectAllDOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    int dosId = int.Parse(reader[0].ToString());
                    string date = reader[1].ToString();
                    string time = reader[2].ToString();
                    int fromWareHouse = int.Parse(reader[3].ToString());
                    int toWareHouse = int.Parse(reader[4].ToString());

                    dosList.Add(new DOS(dosId, date, time, fromWareHouse, toWareHouse));


                }
            }
            else
            {
                success = false;
            }

            reader.Close();
            connection.Close();
            success = true;
            return success;
        }

        private bool initDOSDetail()
        {

            bool success = false;

            connection.Open();

            SqlCommand command = new SqlCommand("dbo.SelectAllDOSDetail", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    int id = int.Parse(reader[0].ToString());
                    int dosId = int.Parse(reader[1].ToString());
                    int productId = int.Parse(reader[2].ToString());
                    int quantity = int.Parse(reader[3].ToString());
                    float price = float.Parse(reader[4].ToString());

                    dosDetailList.Add(new DOSDetail(id, dosId, productId, quantity, price));


                }
            }
            else
            {
                success = false;
            }

            reader.Close();
            connection.Close();
            success = true;
            return success;
        }
        
        //public bool checkDeleteWareHouse(int id)
        //{
        //    bool success = true;
        //    for (int i = 0; i < wareHouseList.Count; i++)
        //    {
        //        if (wareHouseList[i].WareHouseId == id)
        //        {
        //            for (int j = 0; j < wesList.Count; j++)
        //            {
        //                if (wesList[i].WareHouseId == id)
        //                {
        //                    success = false;
        //                }
        //                else
        //                {
        //                    success = true;
        //                }
        //            }

        //        }
        //    }

        //    return success;
        //}

        public bool wareHouseFunction(int id, string name, string address, int function)
        {
            bool success = false;

            SqlCommand command = new SqlCommand("WareHouseFunction", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters.Add("@name", SqlDbType.VarChar, 255);
            command.Parameters.Add("@address", SqlDbType.VarChar, 255);
            command.Parameters.Add("@function", SqlDbType.Int);

            command.Parameters["@id"].Value = id;
            command.Parameters["@name"].Value = name;
            command.Parameters["@address"].Value = address;

            command.Parameters["@function"].Value = function;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Execption WareHouseFunction" + ex.Message);

            }
            finally
            {
                success = true;
                connection.Close();
                wareHouseList.Clear();
                initWareHouse();

            }

            return success;
        }

        public bool productFunction(int id, string name, string description, string unit, float price, int function)
        {
            bool success = false;

            SqlCommand command = new SqlCommand("ProductFunction", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters.Add("@name", SqlDbType.VarChar, 255);
            command.Parameters.Add("@description", SqlDbType.VarChar, 255);
            command.Parameters.Add("@unit", SqlDbType.VarChar, 10);
            command.Parameters.Add("@price", SqlDbType.Float);

            command.Parameters.Add("@function", SqlDbType.Int);

            command.Parameters["@id"].Value = id;
            command.Parameters["@name"].Value = name;
            command.Parameters["@description"].Value = description;
            command.Parameters["@unit"].Value = unit;
            command.Parameters["@price"].Value = price;

            command.Parameters["@function"].Value = function;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Execption ProductFunction" + ex.Message);

            }
            finally
            {
                success = true;
                connection.Close();
                productList.Clear();
                initProduct();
            }
            return success;
        }

        public bool providerFunction(int id, string name, string address, string phone, string email, string contactPerson, string contactPhone, string contactEmail, int function)
        {
            bool success = false;

            SqlCommand command = new SqlCommand("ProviderFunction", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters.Add("@name", SqlDbType.VarChar, 255);
            command.Parameters.Add("@address", SqlDbType.VarChar, 255);
            command.Parameters.Add("@phone", SqlDbType.VarChar, 255);
            command.Parameters.Add("@email", SqlDbType.VarChar, 255);
            command.Parameters.Add("@contactPerson", SqlDbType.VarChar, 255);
            command.Parameters.Add("@contactPhone", SqlDbType.VarChar, 255);
            command.Parameters.Add("@contactEmail", SqlDbType.VarChar, 255);
            command.Parameters.Add("@function", SqlDbType.Int);

            command.Parameters["@id"].Value = id;
            command.Parameters["@name"].Value = name;
            command.Parameters["@address"].Value = address;
            command.Parameters["@phone"].Value = phone;
            command.Parameters["@email"].Value = email;
            command.Parameters["@contactPerson"].Value = contactPerson;
            command.Parameters["@contactPhone"].Value = contactPhone;
            command.Parameters["@contactEmail"].Value = contactEmail;

            command.Parameters["@function"].Value = function;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Execption ProviderFunction" + ex.Message);

            }
            finally
            {
                success = true;
                connection.Close();
                providerList.Clear();
                initProvider();

            }

            return success;
        }

        public bool wesFunction(int wesId, string date, int wareHouseId, int providerId, float totalValue, string userName, int function)
        {
            bool success = false;

            SqlCommand command = new SqlCommand("WESFunction", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@wesId", SqlDbType.Int);
            command.Parameters.Add("@date", SqlDbType.VarChar, 255);
            command.Parameters.Add("@wareHouseId", SqlDbType.Int);
            command.Parameters.Add("@providerId", SqlDbType.Int);
            command.Parameters.Add("@totalValue", SqlDbType.Float);
            command.Parameters.Add("@userName", SqlDbType.VarChar, 255);

            command.Parameters.Add("@function", SqlDbType.Int);

            command.Parameters["@wesId"].Value = wesId;
            command.Parameters["@date"].Value = date;
            command.Parameters["@wareHouseId"].Value = wareHouseId;
            command.Parameters["@providerId"].Value = providerId;
            command.Parameters["@totalValue"].Value = totalValue;
            command.Parameters["@userName"].Value = userName;

            command.Parameters["@function"].Value = function;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Execption WESFunction" + ex.Message);

            }
            finally
            {
                success = true;
                connection.Close();
                wesList.Clear();
                initWes();

            }

            return success;
        }

        public bool wesDetailFunction(int id, int productId, int wesId, int quantity, string unit, float price, int function)
        {
            bool success = false;

            SqlCommand command = new SqlCommand("dbo.WESDetailFunction", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Id", SqlDbType.Int);
            command.Parameters.Add("@productId", SqlDbType.Int);
            command.Parameters.Add("@wesId", SqlDbType.Int);
            command.Parameters.Add("@quantity", SqlDbType.Int);
            command.Parameters.Add("@unit", SqlDbType.VarChar, 255);
            command.Parameters.Add("@price", SqlDbType.Float);

            command.Parameters.Add("@function", SqlDbType.Int);

            command.Parameters["@Id"].Value = id;
            command.Parameters["@productId"].Value = productId;
            command.Parameters["@wesId"].Value = wesId;
            command.Parameters["@quantity"].Value = quantity;
            command.Parameters["@unit"].Value = unit;
            command.Parameters["@Price"].Value = price;

            command.Parameters["@function"].Value = function;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Execption WESDetailFunction" + ex.Message);

            }
            finally
            {
                success = true;
                connection.Close();
                wesDetailList.Clear();
                initWesDetail();

            }

            return success;
        }

        public bool dosFunction(int dosId, string date, string time, int fromWareHouse, int toWareHouse, int function) {

            bool success = false;

            SqlCommand command = new SqlCommand("dbo.DOSFunction", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@dosId", SqlDbType.Int);
            command.Parameters.Add("@date", SqlDbType.VarChar, 255);
            command.Parameters.Add("@time", SqlDbType.VarChar, 255);
            command.Parameters.Add("@fromWareHouse", SqlDbType.Int);
            command.Parameters.Add("@toWareHouse", SqlDbType.Int);
            

            command.Parameters.Add("@function", SqlDbType.Int);

            command.Parameters["@dosId"].Value = dosId;
            command.Parameters["@date"].Value = date;
            command.Parameters["@time"].Value = time;
            command.Parameters["@fromWareHouse"].Value = fromWareHouse;
            command.Parameters["@toWareHouse"].Value = toWareHouse;            

            command.Parameters["@function"].Value = function;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Execption DOSFunction" + ex.Message);

            }
            finally
            {
                success = true;
                connection.Close();
                dosList.Clear();
                initDOS();

            }

            return success;
        }

        public bool dosDetailFunction(int id, int dosId, int productId, int quantity, float price, int function) {


            bool success = false;

            SqlCommand command = new SqlCommand("dbo.DOSDetailFunction", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters.Add("@dosId", SqlDbType.Int);
            command.Parameters.Add("@productId", SqlDbType.Int);
            command.Parameters.Add("@quantity", SqlDbType.Int);
            command.Parameters.Add("@price", SqlDbType.Float);


            command.Parameters.Add("@function", SqlDbType.Int);

            command.Parameters["@id"].Value = id;
            command.Parameters["@dosId"].Value = dosId;
            command.Parameters["@productId"].Value = productId;
            command.Parameters["@quantity"].Value = quantity;
            command.Parameters["@price"].Value = price;           

            command.Parameters["@function"].Value = function;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Execption DOSDetailFunction" + ex.Message);

            }
            finally
            {
                success = true;
                connection.Close();
                dosDetailList.Clear();
                initDOSDetail();

            }

            return success;
        
        
        }


        /*Checking delete*/
        public bool checkDeleteProduct(int id)
        {
            bool canDelete = true;
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            string query1 = "SELECT ProductId FROM DOSDetail WHERE ProductId=" + id;
            string query2 = "SELECT ProductId FROM WESDetail WHERE ProductId=" + id;
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
                    canDelete = false;
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


            command.CommandText = query2;
            command.Connection = conn;

            try
            {
                conn.Open();
                SqlDataReader sdr = command.ExecuteReader();
                if (sdr.HasRows)
                {
                    canDelete = false;
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

            return canDelete;
        }

        /*checkDelete Provider*/
        public bool checkDeleteProvider(int id)
        {
            bool canDelete = true;
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            string query1 = "SELECT ProviderId FROM WES WHERE ProviderId=" + id;

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
                    canDelete = false;
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

            return canDelete;
        }

        /*check delete warehouse*/
        public bool checkDeleteWareHouse(int id)
        {
            bool canDelete = true;
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            string query1 = "SELECT * FROM DOS WHERE FromWareHouse=" + id + " OR ToWareHouse=" + id;
            string query2 = "SELECT * FROM WES WHERE WareHouseId=" + id;
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
                    canDelete = false;
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


            command.CommandText = query2;
            command.Connection = conn;

            try
            {
                conn.Open();
                SqlDataReader sdr = command.ExecuteReader();
                if (sdr.HasRows)
                {
                    canDelete = false;
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

            return canDelete;

        }

        /*check Delete WES*/
        public bool checkDeleteWES(int id)
        {
            bool canDelete = true;
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            string query1 = "SELECT * FROM WESDetail WHERE WesId=" + id;

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
                    canDelete = false;
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

            return canDelete;
        }

        /*Method to get the list*/
        public List<Product> getProductList()
        {
            return this.productList;
        }
        public List<WareHouse> getWareHouseList()
        {
            return this.wareHouseList;
        }
        public List<WES> getWesList()
        {
            return this.wesList;
        }
        public List<Provider> getProviderList()
        {
            return this.providerList;
        }
        public List<WESDetail> getWESDetailList()
        {
            return this.wesDetailList;
        }
        public List<DOS> getDOSList()
        {
            return this.dosList;
        }
        public List<DOSDetail> getDOSDetailList()
        {
            return this.dosDetailList;
        }
    }
}
