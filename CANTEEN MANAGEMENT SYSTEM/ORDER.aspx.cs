using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CANTEEN_MANAGEMENT_SYSTEM
{
    public partial class ORDER : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void update_Click(object sender, EventArgs e)
        {
            try
            {
                string name = DropDownList1.SelectedValue;
                double price = Convert.ToDouble(ItemPrice.Text);
                string off = offer.Text + "%";
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=Canteen_Management;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
                con.Open();
                cmd = new SqlCommand($"Update Menu set price={price},offer='{off}' where itemname='{name}'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Item {name} Updated successfully!!");
                Response.Redirect("MENU.aspx");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong : " + ex.Message);
            }
            finally
            { con.Close(); }
        }
    }
}