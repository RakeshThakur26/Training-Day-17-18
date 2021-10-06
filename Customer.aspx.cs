using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace ASPDOTNETAPP1
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomerSubmit_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            db.InsertDataIntoCustomer(Customer_id.Text, Customer_Name.Text, City.Text,Grade.Text, Salesman_id.Text);

            DataTable Result = db.GetCustomer();
            gvCustomerDetails.DataSource = Result;
            gvCustomerDetails.DataBind();
        }
    }
}