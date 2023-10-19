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
    public partial class medicineCustomers : Form
    {
        public medicineCustomers()
        {
            InitializeComponent();
        }

        private int UserId;
        public medicineCustomers(string username)
        {
            InitializeComponent();

            //get the user id by username
            string queryId = "SELECT user_id FROM Users where user_name = '" + username + "'";
            SqlDataAdapter sda_Customers = new SqlDataAdapter(queryId, con);

            DataTable dt_Customers = new DataTable();
            sda_Customers.Fill(dt_Customers);

            if (dt_Customers.Rows.Count > 0)
            {
                UserId = Convert.ToInt32(dt_Customers.Rows[0]["user_id"]);
            }
        }












        //database connetion string
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K6Q9EHO\\SQLEXPRESS;Initial Catalog=mediosoft;Integrated Security=True");


        private void medicineCustomers_Load(object sender, EventArgs e)
        {
            displayDataTable();




        }


        public void displayDataTable()
        {
            //displaying users in data grid view
            string queryMedicines = "SELECT m.medicine_id, m.medicine_name, m.medicine_code, m.medicine_description, m.medicine_price, m.medicine_quantity, c.category_name, m.manufacturing_date, m.expire_date FROM Medicines m INNER JOIN Categories c ON m.category_id = c.category_id";
            SqlDataAdapter sda = new SqlDataAdapter(queryMedicines, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dt.TableName = "Medicines";
            if (displayMedicinesDataGrid != null)
            {
                displayMedicinesDataGrid.DataSource = dt;
            }

            // set the column headers
            displayMedicinesDataGrid.Columns["medicine_id"].HeaderText = "ID";
            displayMedicinesDataGrid.Columns["medicine_name"].HeaderText = "Medicine Name";
            displayMedicinesDataGrid.Columns["medicine_code"].HeaderText = "Code";
            displayMedicinesDataGrid.Columns["medicine_description"].HeaderText = "Description";
            displayMedicinesDataGrid.Columns["medicine_price"].HeaderText = "Price";
            displayMedicinesDataGrid.Columns["medicine_quantity"].HeaderText = "Quantity";
            displayMedicinesDataGrid.Columns["category_name"].HeaderText = "Category";
            displayMedicinesDataGrid.Columns["manufacturing_date"].HeaderText = "Manufactured";
            displayMedicinesDataGrid.Columns["expire_date"].HeaderText = "Expire Date";


            displayMedicinesDataGrid.Columns["medicine_id"].DataPropertyName = "medicine_id";
            displayMedicinesDataGrid.Columns["medicine_name"].DataPropertyName = "medicine_name";
            displayMedicinesDataGrid.Columns["medicine_code"].DataPropertyName = "medicine_code";
            displayMedicinesDataGrid.Columns["medicine_description"].DataPropertyName = "medicine_description";
            displayMedicinesDataGrid.Columns["medicine_price"].DataPropertyName = "medicine_price";
            displayMedicinesDataGrid.Columns["medicine_quantity"].DataPropertyName = "medicine_quantity";
            displayMedicinesDataGrid.Columns["category_name"].DataPropertyName = "category_name";
            displayMedicinesDataGrid.Columns["manufacturing_date"].DataPropertyName = "manufacturing_date";
            displayMedicinesDataGrid.Columns["expire_date"].DataPropertyName = "expire_date";

            //medicine ID - making visibility hide for the customers
            displayMedicinesDataGrid.Columns["medicine_id"].Visible = false;

        }


        //search medicine by medicine name
        private void medicineSearchBox_TextChanged(object sender, EventArgs e)
        {
            //showing search results in data grid view

            string querySearch = "SELECT m.medicine_id, m.medicine_name, m.medicine_code, m.medicine_description, m.medicine_price, m.medicine_quantity, c.category_name, m.manufacturing_date, m.expire_date FROM Medicines m INNER JOIN Categories c ON m.category_id = c.category_id WHERE medicine_name LIKE '%" + medicineSearchBox.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(querySearch, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dt.TableName = "Medicines";
            if (displayMedicinesDataGrid != null)
            {
                displayMedicinesDataGrid.DataSource = dt;
            }
        }

        




        //reset the search box text after entering it
        private void medicineSearchBox_Enter(object sender, EventArgs e)
        {
            medicineSearchBox.Text = "";
        }

        //show modify and delete button on cell click based on user status
        public string cell_value;
        private int UserStatus;
        private double OrderPrice;
        private string cellPrice;
        private void displayMedicinesDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //get the user status by user Id
            string queryStatus = "SELECT user_status FROM Users where user_id = '" + UserId + "'";
            SqlDataAdapter sda_Status = new SqlDataAdapter(queryStatus, con);

            DataTable dt_Status = new DataTable();
            sda_Status.Fill(dt_Status);

            if (dt_Status.Rows.Count > 0)
            {
                UserStatus = Convert.ToInt32(dt_Status.Rows[0]["user_status"]);
            }

            

            //chekcing if the user status is active

            if(UserStatus == 1)
            {
                label_price.Show();
                label_price_value.Show();
                label_quatity.Show();
                quantityBox.Show();
                btn_OderMedicine.Show();
            }
            else
            {
                MessageBox.Show("You Can't Order! Your account isn't Active! Please Contact Admin...");
            }

            

            //get id from cell click
            DataGridViewRow id = displayMedicinesDataGrid.Rows[e.RowIndex];
            cell_value = id.Cells["medicine_id"].Value.ToString();

            //get price from cell click
            cellPrice = id.Cells["medicine_price"].Value.ToString();
            OrderPrice = double.Parse(cellPrice);

            //setting the order price to the 'Price Value' label;
            label_price_value.Text = OrderPrice.ToString();
            
        }

        //order now button action
        private int Quantity;
        private void btn_OderMedicine_Click(object sender, EventArgs e)
        {

  
            //getting quanity box variables
            Quantity = Convert.ToInt32(quantityBox.Value);


            //inserting oders table in database
            string queryOrders = "INSERT INTO Orders (order_date, order_quantity, order_price, medicine_id, created_by) VALUES('" + DateTime.Now+"', "+ Quantity + ", "+ OrderPrice + " ,"+ cell_value + ", "+UserId+")";

            SqlCommand cmd = new SqlCommand(queryOrders, con);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("You have placed order! Please check 'Manage Orders'");
                    displayDataTable();
                    quantityBox.Value = 1;
                    label_price_value.Text = cellPrice;



                }
                else
                {
                    MessageBox.Show("Placing Order Failed!");
                }
            }
            con.Close();

            
        }


        //increase and decrease price value on quantity chanage
        private void quantityBox_ValueChanged(object sender, EventArgs e)
        {
            

            Quantity = Convert.ToInt32(quantityBox.Value);


            //setting the order price to the 'Price Value' label;
            //OrderPrice = OrderPrice * Quantity;
            OrderPrice = double.Parse(cellPrice) * Quantity;
            label_price_value.Text = OrderPrice.ToString();

        }
    }







}
