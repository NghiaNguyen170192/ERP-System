using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment2.ModelFolder;

namespace Assignment2
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Model m = Model.getModel();

            List<WES> wesList = m.getWesList();
            List<WESDetail> wesDetailList = m.getWESDetailList();
            List<Product> productList = m.getProductList();
            List<WareHouse> wareHouseList = m.getWareHouseList();
            List<Provider> providerList = m.getProviderList();
            List<DOS> dosList = m.getDOSList();
            List<DOSDetail> dosDetailList = m.getDOSDetailList();

            //Label1.Text = "wes " + wesList.Count + "wes detail" + wesDetailList.Count
            //    + " product " + productList.Count
            //    + " warehouse " + wareHouseList.Count + " provider " + providerList.Count
            //    + " dos " + dosList.Count + " dosdetail " + dosDetailList.Count;
            //foreach (var v in wesList)
            //{
            //    Label1.Text += "/" + v.User;
            //}

            bool check = m.wesDetailFunction(8, 50, 4, 1, "bottle", 20000, 1);
            Label1.Text = check + "";
            //Response.Redirect("/HTML/WESDetailFolder/WESDetailPage.aspx");
        }
    }
}
