using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CANTEEN_MANAGEMENT_SYSTEM
{
    public partial class Canteen_Home : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Fetch_Click(object sender, EventArgs e)
        {
            Response.Redirect("MENU.aspx");
        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                string name = ItemName.Text;
                string IType = Itemtype.Value;
                double price = Convert.ToDouble(ItemPrice.Text);
                string off = offer.Text + "%";
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=Canteen_Management;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
                con.Open();
                cmd = new SqlCommand($"INSERT INTO MENU(itemname,itemtype,price,offer) values('{name}','{IType}',{price},'{off}')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Item {name} added successfully!!");
                Response.Redirect("MENU.aspx");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Item already added!!!");
            }
            finally
            { con.Close(); }
        }

        protected void order_Click(object sender, EventArgs e)
        {
            Response.Redirect("ORDER.aspx");
        }

        protected void search1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = sea.Value;
            
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=Canteen_Management;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
                con.Open();
                cmd = new SqlCommand($"SELECT * FROM MENU where itemname='{name}'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                // GridView1.DataSource = dt;
                //GridView1.DataBind();
                ItemName.Text = dt.Rows[0]["itemName"].ToString();
                Itemtype.Value = dt.Rows[0]["itemtype"].ToString();
                ItemPrice.Text = dt.Rows[0]["price"].ToString();
                offer.Text = dt.Rows[0]["offer"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong : " + ex.Message);
            }
            finally
            { con.Close(); }
        }

        protected void reset_Click(object sender, EventArgs e)
        {
            ItemName.Text = "";
            Itemtype.Value = "";
            ItemPrice.Text = "";
            offer.Text = "";
        }
    }
}