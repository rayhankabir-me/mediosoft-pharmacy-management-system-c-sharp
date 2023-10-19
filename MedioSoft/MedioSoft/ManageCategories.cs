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
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }

        //database connection string
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K6Q9EHO\\SQLEXPRESS;Initial Catalog=mediosoft;Integrated Security=True");



        private void ManageCategories_Load(object sender, EventArgs e)
        {
            displayDataTable();
        }

        public void displayDataTable()
        {
            //displaying category list in data grid view
            string queryCats = "SELECT category_id,category_name FROM Categories";
            SqlDataAdapter sda = new SqlDataAdapter(queryCats, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dt.TableName = "Categories";
            if (showCategoryDataGrid != null)
            {
                showCategoryDataGrid.DataSource = dt;
            }

            // set the column headers
            showCategoryDataGrid.Columns["category_id"].HeaderText = "Category ID";
            showCategoryDataGrid.Columns["category_name"].HeaderText = "Category Name";


        
            showCategoryDataGrid.Columns["category_id"].DataPropertyName = "category_id";
            showCategoryDataGrid.Columns["category_name"].DataPropertyName = "category_name";
        }


        private void btn_addCategory_Click(object sender, EventArgs e)
        {
            //form data variables
            string categoryName = category_name.Text;

            if(categoryName == "")
            {
                MessageBox.Show("Please Fill Category Name!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //adding users in database
                string query = "INSERT INTO Categories (category_name) VALUES('" + categoryName + "') ";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Category Added Successfully!");
                        displayDataTable();
                        clearAll();

                    }
                    else
                    {
                        MessageBox.Show("Add Category Failed!");
                    }
                }
                con.Close();
            }
        }

        
        public void clearAll()
        {
            category_name.Clear();
        }



        //search box clear placeholder on mouse click
        private void catSearchBox_Enter(object sender, EventArgs e)
        {
            catSearchBox.Text = "";
        }


        //show modify and delete button on cell click
        public string cell_value;

        private void showCategoryDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_editCategory.Show();
            btn_deleteCategory.Show();

            //get id from cell click
            if (e.RowIndex >= 0 && e.RowIndex < showCategoryDataGrid.Rows.Count)
            {
                DataGridViewRow id = showCategoryDataGrid.Rows[e.RowIndex];
                cell_value = id.Cells["category_id"].Value.ToString();
            }

        }


        //showing search results in data grid view
        private void catSearchBox_TextChanged_2(object sender, EventArgs e)
        {
            string querySearch = "SELECT category_id,category_name FROM Categories WHERE category_name LIKE '%" + catSearchBox.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(querySearch, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dt.TableName = "Categories";
            if (showCategoryDataGrid != null)
            {
                showCategoryDataGrid.DataSource = dt;
            }
        }

        //delete user from database
        private void btn_deleteCategory_Click(object sender, EventArgs e)
        {
            string delete_query = "DELETE FROM Categories WHERE category_id = " + cell_value + "";

            SqlCommand cmd = new SqlCommand(delete_query, con);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {

                    MessageBox.Show("Category Deleted Successfully!");
                    btn_editCategory.Hide();
                    btn_deleteCategory.Hide();
                    displayDataTable();



                }
                else
                {
                    MessageBox.Show("Category User Failed!");
                }
            }
            con.Close();
        }



        //update user form load
        private void btn_editCategory_Click(object sender, EventArgs e)
        {
            updateCategory f = new updateCategory(cell_value);
            f.Show();
        }

        //reset form field on reset button click
        private void btnReset_Click_1(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            displayDataTable();
        }
    }
}
