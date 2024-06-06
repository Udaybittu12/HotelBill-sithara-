using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;


namespace HotelBill
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void BindCustomers()
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            double cost = 1;
            double services = 1;
            if (CheckBox1.Checked == true)
            {
                services = services + 200;
            }
            if (CheckBox2.Checked == true)
            {
                services = services + 100;
            }
            if (CheckBox3.Checked == true)
            {
                services = services + 100;
            }
            if (CheckBox4.Checked == true)
            {
                services = services + 400;
            }
            int days = Convert.ToInt32(TextBox2.Text);
            double meals = 1;
            if (RadioButton3.Checked == true)
            {
                meals = 300;
            }
            else if (RadioButton4.Checked == true)
            {
                meals = 0;
            }
            if (RadioButton1.Checked == true)
            {
                cost = 1500;
            }
            else if (RadioButton2.Checked == true)
            {
                cost = 800;
            }
            double billamt = days * (meals + cost + services);
            TextBox3.Text = billamt.ToString();
            // customer name and bill storing in database
            string connectionString = ConfigurationManager.ConnectionStrings["hotelbill"].ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("sp_hbill", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Cname", TextBox1.Text);
                command.Parameters.AddWithValue("@cbill", TextBox3.Text);
                int k = command.ExecuteNonQuery();
                if (k != 0) { Response.Write("customer registered successfulyy"); }
                else { Response.Write("customer not registered due to error"); }
                connection.Close();
            }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            TextBox2.Text = TextBox3.Text = "";
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            TextBox2.Text = TextBox3.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["hotelbill"].ConnectionString;
            string query = "select*from hotel";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        GridView1.DataSource = dataTable;
                        GridView1.DataBind();
                    }

                }
            }

        }
    }
}
    
