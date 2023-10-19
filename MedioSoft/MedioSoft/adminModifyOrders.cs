using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MedioSoft
{
    public partial class adminModifyOrders : Form
    {
        public adminModifyOrders()
        {
            InitializeComponent();
        }

        //connection string
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K6Q9EHO\\SQLEXPRESS;Initial Catalog=mediosoft;Integrated Security=True");

        //got order id
        private string gotOrderId;
        public adminModifyOrders(string getOrderId)
        {
            InitializeComponent();

            gotOrderId = getOrderId;
        }
        private void adminModifyOrders_Load(object sender, EventArgs e)
        {
            //displaying current order status in the update form
            string queryStatus = "SELECT order_status FROM Orders WHERE order_id = " + gotOrderId + "";
            SqlCommand cmd = new SqlCommand(queryStatus, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                OrderComboBox.SelectedItem = reader["order_status"].ToString();


            }

            reader.Close();
            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //update order status
        private void btn_updateCat_Click(object sender, EventArgs e)
        {

            //getting updates varibles from update form
            string OrderStatus = OrderComboBox.SelectedItem.ToString();

            string updateQuery = "UPDATE Orders SET order_status = '" + OrderStatus + "' WHERE order_id = " + gotOrderId + "";

            SqlCommand cmd = new SqlCommand(updateQuery, con);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Order Status Updated Successfully!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Order Status Update Failed!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            con.Close();
        }
    }
}
