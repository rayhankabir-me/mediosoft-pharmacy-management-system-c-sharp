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
    public partial class ManageMedicines : Form
    {
        public ManageMedicines()
        {
            InitializeComponent();

            
        }


        private int UserId;

        public ManageMedicines(string welcomeUser)
        {


            InitializeComponent();

            //get the user id by username
            string queryId = "SELECT user_id FROM Users where user_name = '" + welcomeUser + "'";
            SqlDataAdapter sda_Customers = new SqlDataAdapter(queryId, con);

            DataTable dt_Customers = new DataTable();
            sda_Customers.Fill(dt_Customers);

            if (dt_Customers.Rows.Count > 0)
            {
                UserId = Convert.ToInt32(dt_Customers.Rows[0]["user_id"]);
            }
            







            
        }




        //connection string
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K6Q9EHO\\SQLEXPRESS;Initial Catalog=mediosoft;Integrated Security=True");

        private void ManageMedicines_Load(object sender, EventArgs e)
        {
            //display data table on load the form
            displayDataTable();


            //displaying category name in combox on load

            string queryCategory = "SELECT category_id, category_name FROM Categories";
            SqlDataAdapter sda = new SqlDataAdapter(queryCategory, con);
            DataTable dtCategories = new DataTable();
            sda.Fill(dtCategories);

            category_combo.DataSource = dtCategories;
            category_combo.DisplayMember = "category_name";
            category_combo.ValueMember = "category_id";

            
        }

        public void displayDataTable()
        {
            //displaying users in data grid view
            string queryMedicines = "SELECT m.medicine_id, m.medicine_name, m.medicine_code, m.medicine_description, m.medicine_price, m.medicine_quantity, c.category_name, m.manufacturing_date, m.expire_date, u.user_name FROM Medicines m INNER JOIN Categories c ON m.category_id = c.category_id INNER JOIN Users u ON m.created_by = u.user_id";
            SqlDataAdapter sda = new SqlDataAdapter(queryMedicines, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dt.TableName = "Medicines";
            if (showMedicinesDataGrid != null)
            {
                showMedicinesDataGrid.DataSource = dt;
            }

            // set the column headers
            showMedicinesDataGrid.Columns["medicine_id"].HeaderText = "ID";
            showMedicinesDataGrid.Columns["medicine_name"].HeaderText = "Medicine Name";
            showMedicinesDataGrid.Columns["medicine_code"].HeaderText = "Code";
            showMedicinesDataGrid.Columns["medicine_description"].HeaderText = "Description";
            showMedicinesDataGrid.Columns["medicine_price"].HeaderText = "Price";
            showMedicinesDataGrid.Columns["medicine_quantity"].HeaderText = "Quantity";
            showMedicinesDataGrid.Columns["category_name"].HeaderText = "Category";
            showMedicinesDataGrid.Columns["manufacturing_date"].HeaderText = "Manufactured";
            showMedicinesDataGrid.Columns["expire_date"].HeaderText = "Expire Date";
            showMedicinesDataGrid.Columns["user_name"].HeaderText = "Created By";

            showMedicinesDataGrid.Columns["medicine_id"].DataPropertyName = "medicine_id";
            showMedicinesDataGrid.Columns["medicine_name"].DataPropertyName = "medicine_name";
            showMedicinesDataGrid.Columns["medicine_code"].DataPropertyName = "medicine_code";
            showMedicinesDataGrid.Columns["medicine_description"].DataPropertyName = "medicine_description";
            showMedicinesDataGrid.Columns["medicine_price"].DataPropertyName = "medicine_price";
            showMedicinesDataGrid.Columns["medicine_quantity"].DataPropertyName = "medicine_quantity";
            showMedicinesDataGrid.Columns["category_name"].DataPropertyName = "category_name";
            showMedicinesDataGrid.Columns["manufacturing_date"].DataPropertyName = "manufacturing_date";
            showMedicinesDataGrid.Columns["expire_date"].DataPropertyName = "expire_date";
            showMedicinesDataGrid.Columns["user_name"].DataPropertyName = "user_name";
        }

        
        private void btn_addMedicine_Click(object sender, EventArgs e)
        {
            //form data variables
            string medicineName = medicine_name.Text;
            string medicineCode = medicine_code.Text;
            string medicineDesc = medicine_description.Text;
            double medicinePrice = double.Parse(medicine_price.Text);
            int Quantity = int.Parse(medicine_quantity.Text);
            int categoryId = Convert.ToInt32(category_combo.SelectedValue);
            DateTime manufacturedDate = manufacturing_date.Value;
            DateTime expireDate = expire_date.Value;


            //adding users in database
            string query = "INSERT INTO Medicines (medicine_name, medicine_code, medicine_description, medicine_price, medicine_quantity, category_id, manufacturing_date, expire_date, created_by) VALUES('" + medicineName + "', '" + medicineCode + "', '" + medicineDesc + "', '" + medicinePrice + "', '" + Quantity + "', '" + categoryId + "', '" + manufacturedDate + "', '" + expireDate + "', '" + UserId + "') ";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Medicine Added Successfully!");
                    displayDataTable();
                    clearAll();

                }
                else
                {
                    MessageBox.Show("Add Medicine Failed!");
                }
            }
            con.Close();









        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            medicine_name.Clear();
            medicine_code.Clear();
            medicine_description.Clear();
            medicine_price.Clear();
            medicine_quantity.Clear();


        }

        //search medicine by medicine name
        private void medicineSearchBox_TextChanged(object sender, EventArgs e)
        {

            //showing search results in data grid view

            string querySearch = "SELECT m.medicine_id, m.medicine_name, m.medicine_code, m.medicine_description, m.medicine_price, m.medicine_quantity, c.category_name, m.manufacturing_date, m.expire_date, u.user_name FROM Medicines m INNER JOIN Categories c ON m.category_id = c.category_id INNER JOIN Users u ON m.created_by = u.user_id WHERE medicine_name LIKE '%" + medicineSearchBox.Text + "%'";

            SqlDataAdapter sda = new SqlDataAdapter(querySearch, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dt.TableName = "Medicines";
            if (showMedicinesDataGrid != null)
            {
                showMedicinesDataGrid.DataSource = dt;
            }

        }

        //search box clear placeholder on mouse click
        private void medicineSearchBox_Enter(object sender, EventArgs e)
        {
            medicineSearchBox.Text = "";
        }


        //show 'modify and delete' button on cell click based on User Role
        private string cell_value;
        private string User_Role;
        private int CreatedBy;
        private void showMedicinesDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //get the user role by user id
            string queryId = "SELECT user_role FROM Users where user_id = '" + UserId + "'";
            SqlDataAdapter sda_Customers = new SqlDataAdapter(queryId, con);

            DataTable dt_Customers = new DataTable();
            sda_Customers.Fill(dt_Customers);

            if (dt_Customers.Rows.Count > 0)
            {
                User_Role = dt_Customers.Rows[0]["user_role"].ToString();
            }

            //always show for admin
            if(User_Role == "Admin" || CreatedBy == UserId)
            {
                btn_editMedicine.Show();
                btn_deleteMedicine.Show();
            }

            //check the current UserId and Created by match
            //if (CreatedBy == UserId)
            //{
            //    btn_editMedicine.Show();
            //    btn_deleteMedicine.Show();
            //}
            else
            {
                btn_editMedicine.Hide();
                btn_deleteMedicine.Hide();
            }



            //get id from cell click
            if (e.RowIndex >= 0 && e.RowIndex < showMedicinesDataGrid.Rows.Count)
            {
                DataGridViewRow id = showMedicinesDataGrid.Rows[e.RowIndex];
                cell_value = id.Cells["medicine_id"].Value.ToString();
            }



            //show the buttons for pharmacists based on 'created_by'
            //get created_by from Medicines by medicines_id
            string queryBy = "SELECT created_by FROM Medicines where medicine_id = '" + cell_value + "'";
            SqlDataAdapter sda_By = new SqlDataAdapter(queryBy, con);

            DataTable dt_By = new DataTable();
            sda_By.Fill(dt_By);

            if (dt_By.Rows.Count > 0)
            {
                CreatedBy = Convert.ToInt32(dt_By.Rows[0]["created_by"]);
            }


        }

        //delete medicines from database
        private void btn_deleteMedicine_Click(object sender, EventArgs e)
        {
            string delete_query = "DELETE FROM Medicines WHERE medicine_id = " + cell_value + "";

            SqlCommand cmd = new SqlCommand(delete_query, con);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {

                    MessageBox.Show("Medicine Deleted Successfully!");
                    btn_editMedicine.Hide();
                    btn_deleteMedicine.Hide();
                    
                    //relaod the data table
                    displayDataTable();



                }
                else
                {
                    MessageBox.Show("Delete Medicine Failed!");
                }
            }
            con.Close();
        }

        private void btn_editMedicine_Click(object sender, EventArgs e)
        {
            updateMedicines f = new updateMedicines(cell_value, UserId);
            f.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            displayDataTable();
        }
    }
}
