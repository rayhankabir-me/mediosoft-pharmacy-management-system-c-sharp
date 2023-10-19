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
    public partial class adminOrders : Form
    {
        public adminOrders()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K6Q9EHO\\SQLEXPRESS;Initial Catalog=mediosoft;Integrated Security=True");
        private void adminOrders_Load(object sender, EventArgs e)
        {
            //display data table on load the form
            displayDataTable();


            //reset summary label on load
            label_medicine_name.Text = "";
            label_customer_name.Text = "";
            label_medicine_code.Text = "";
            label_order_price.Text = "";
            label_order_quantity.Text = "";
            label_order_status.Text = "";
            label_order_date.Text = "";
        }






        public void displayDataTable()
        {
            //displaying ordersw in data grid view
            string queryOrders = "SELECT o.order_id, o.order_date, o.order_quantity, o.order_price, m.medicine_name, u.user_name, o.order_status FROM Orders o JOIN Medicines m ON o.medicine_id = m.medicine_id JOIN Users u ON o.created_by = u.user_id";
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
            showCustomersOrdersDataGrid.Columns["user_name"].HeaderText = "Order By";
            showCustomersOrdersDataGrid.Columns["order_status"].HeaderText = "Order Status";


            showCustomersOrdersDataGrid.Columns["order_id"].DataPropertyName = "order_id";
            showCustomersOrdersDataGrid.Columns["order_date"].DataPropertyName = "order_date";
            showCustomersOrdersDataGrid.Columns["order_quantity"].DataPropertyName = "order_quantity";
            showCustomersOrdersDataGrid.Columns["order_price"].DataPropertyName = "order_price";
            showCustomersOrdersDataGrid.Columns["medicine_name"].DataPropertyName = "medicine_name";
            showCustomersOrdersDataGrid.Columns["user_name"].DataPropertyName = "user_name";
            showCustomersOrdersDataGrid.Columns["order_status"].DataPropertyName = "order_status";
        }

        //search order by username
        private void userSearchBox_TextChanged(object sender, EventArgs e)
        {
            //showing search results in data grid view

            string querySearch = "SELECT o.order_id, o.order_date, o.order_quantity, o.order_price, m.medicine_name, u.user_name, o.order_status FROM Orders o JOIN Medicines m ON o.medicine_id = m.medicine_id JOIN Users u ON o.created_by = u.user_id WHERE user_name LIKE '" + userSearchBox.Text + "%'";

            SqlDataAdapter sda = new SqlDataAdapter(querySearch, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dt.TableName = "Orders";
            if (showCustomersOrdersDataGrid != null)
            {
                showCustomersOrdersDataGrid.DataSource = dt;
            }
        }





        //search box clear placeholder on mouse click

        private void userSearchBox_Enter(object sender, EventArgs e)
        {
            userSearchBox.Text = "";
        }


        //update order status on update order button click
        private void btn_modifyOrder_Click(object sender, EventArgs e)
        {
            adminModifyOrders f = new adminModifyOrders(cell_value);
            f.Show();
        }

        //show 'modify and delete' button on cell click based on User Role
        public string cell_value;
        private void showCustomersOrdersDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //get id from cell click

            if (e.RowIndex >= 0 && e.RowIndex < showCustomersOrdersDataGrid.Rows.Count)
            {
                DataGridViewRow id = showCustomersOrdersDataGrid.Rows[e.RowIndex];
                cell_value = id.Cells["order_id"].Value.ToString();
            }



                btn_modifyOrder.Show();
                btn_deleteOrder.Show();
                btn_printInvoice.Show();


            //showing order summary in left side
            displaySummary();

        }

 
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
                    label_customer_name.Text = reader["user_name"].ToString();
                    label_medicine_code.Text = reader["medicine_code"].ToString();
                    label_order_price.Text = reader["order_price"].ToString();
                    label_order_quantity.Text = reader["order_quantity"].ToString();
                    label_order_status.Text = reader["order_status"].ToString();
                    label_order_date.Text = reader["order_date"].ToString();


                }

                reader.Close();
            }

        }

        private void btn_deleteOrder_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure to Delete the Order ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string delete_query = "DELETE FROM Orders WHERE order_id = " + cell_value + "";

                SqlCommand cmd = new SqlCommand(delete_query, con);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {

                        MessageBox.Show("Order Deleted Successfully!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        btn_modifyOrder.Hide();
                        btn_deleteOrder.Hide();
                        btn_printInvoice.Hide();

                        //relaod the data table
                        displayDataTable();



                    }
                    else
                    {
                        MessageBox.Show("Delete Order Failed!");
                    }
                }
                con.Close();
            }





        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            displayDataTable();
        }
    }
}
