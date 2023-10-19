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
    public partial class customerOrders : Form
    {
        public customerOrders()
        {
            InitializeComponent();
        }

        //connection string
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K6Q9EHO\\SQLEXPRESS;Initial Catalog=mediosoft;Integrated Security=True");

        //getting the username
        private string userName;
        public customerOrders(string username)
        {
            InitializeComponent();

            userName = username;
        }

        private void customerOrders_Load(object sender, EventArgs e)
        {
            //display data table on load the form
            displayDataTable();


            //reset summary label on load
            label_medicine_name.Text = "";
            label_medicine_code.Text = "";
            label_order_price.Text = "";
            label_order_quantity.Text = "";
            label_order_status.Text = "";
            label_order_date.Text = "";
        }



        public void displayDataTable()
        {
            //displaying ordersw in data grid view
            string queryOrders = "SELECT o.order_id, o.order_date, o.order_quantity, o.order_price, m.medicine_name, o.order_status FROM Orders o JOIN Medicines m ON o.medicine_id = m.medicine_id JOIN Users u ON o.created_by = u.user_id WHERE user_name = '"+ userName + "'";
            SqlDataAdapter sda = new SqlDataAdapter(queryOrders, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dt.TableName = "Orders";
            if (showCustomersOrdersDataGrid != null)
            {
                showCustomersOrdersDataGrid.DataSource = dt;
            }

            // set the column headers
            showCustomersOrdersDataGrid.Columns["order_id"].HeaderText = "Order ID";
            showCustomersOrdersDataGrid.Columns["order_date"].HeaderText = "Order Date";
            showCustomersOrdersDataGrid.Columns["order_quantity"].HeaderText = "Order Quantity";
            showCustomersOrdersDataGrid.Columns["order_price"].HeaderText = "Order Price";
            showCustomersOrdersDataGrid.Columns["medicine_name"].HeaderText = "Medicine Name";
            showCustomersOrdersDataGrid.Columns["order_status"].HeaderText = "Order Status";


            showCustomersOrdersDataGrid.Columns["order_id"].DataPropertyName = "order_id";
            showCustomersOrdersDataGrid.Columns["order_date"].DataPropertyName = "order_date";
            showCustomersOrdersDataGrid.Columns["order_quantity"].DataPropertyName = "order_quantity";
            showCustomersOrdersDataGrid.Columns["order_price"].DataPropertyName = "order_price";
            showCustomersOrdersDataGrid.Columns["medicine_name"].DataPropertyName = "medicine_name";
            showCustomersOrdersDataGrid.Columns["order_status"].DataPropertyName = "order_status";

            showCustomersOrdersDataGrid.Columns["order_id"].Visible = false;
        }


        //getting cell value
        private string cell_value;
        private void showCustomersOrdersDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            displaySummary();


            //get id from cell click

            if (e.RowIndex >= 0 && e.RowIndex < showCustomersOrdersDataGrid.Rows.Count)
            {
                DataGridViewRow id = showCustomersOrdersDataGrid.Rows[e.RowIndex];
                cell_value = id.Cells["order_id"].Value.ToString();
            }



            btn_cancelOrder.Show();
            btn_printInvoice.Show();


            //showing order summary in left side
            displaySummary();
        }

        //display summary function
        public void displaySummary()
        {
            //displaying order data in summary section
            string querySummary = "SELECT o.order_date, o.order_quantity, o.order_price, m.medicine_name, m.medicine_code, u.user_name, o.order_status FROM Orders o JOIN Medicines m ON o.medicine_id = m.medicine_id JOIN Users u ON o.created_by = u.user_id WHERE order_id = '" + cell_value + "'";


            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-K6Q9EHO\\SQLEXPRESS;Initial Catalog=mediosoft;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(querySummary, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    //showing data in label
                    label_medicine_name.Text = reader["medicine_name"].ToString();
                    label_medicine_code.Text = reader["medicine_code"].ToString();
                    label_order_price.Text = reader["order_price"].ToString();
                    label_order_quantity.Text = reader["order_quantity"].ToString();
                    label_order_status.Text = reader["order_status"].ToString();
                    label_order_date.Text = reader["order_date"].ToString();


                }

                reader.Close();
            }

        }

        //changing the order status to cancelled if customer click on 'cancel order'
        private void btn_cancelOrder_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure to Cancel the Order ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string cancelQuery = "UPDATE Orders SET order_status = 'cancelled' WHERE order_id = " + cell_value + "";

                SqlCommand cmd = new SqlCommand(cancelQuery, con);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Order Cancelled Successfully!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        displayDataTable();


                    }
                    else
                    {
                        MessageBox.Show("Order Cencellation Failed!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
                con.Close();
            }


        }
    }
}
