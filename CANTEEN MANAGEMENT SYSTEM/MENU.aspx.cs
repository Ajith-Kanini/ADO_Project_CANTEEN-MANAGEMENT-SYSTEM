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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Security.Cryptography;

namespace CANTEEN_MANAGEMENT_SYSTEM
{
    public partial class MENU : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=Canteen_Management;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
                con.Open();
                cmd = new SqlCommand("SELECT * FROM MENU order by itemID", con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong : " + ex.Message);
            }
            finally
            { con.Close(); }
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string name = DropDownList1.SelectedValue;
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=Canteen_Management;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
                con.Open();
                cmd = new SqlCommand($"DELETE FROM MENU WHERE Itemname='{name}'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Item {name} removed successfully!!");
                Response.Redirect("MENU.aspx");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong : " + ex.Message);
            }
            finally
            { con.Close(); }
        }

        protected void CNT_Click(object sender, EventArgs e)
        {
            try
            {
                string IType = Itemtype.Value;
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=Canteen_Management;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
                con.Open();
                cmd = new SqlCommand($"sp_cnt", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@type", IType);
                cmd.Parameters.Add("@cnt", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                int count = (int)cmd.Parameters["@cnt"].Value;
                MessageBox.Show($"{count} items available in {IType}");
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