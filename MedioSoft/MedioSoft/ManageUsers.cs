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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();

            
        }




        //data base conneciton string
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K6Q9EHO\\SQLEXPRESS;Initial Catalog=mediosoft;Integrated Security=True");

        private void ManageUsers_Load(object sender, EventArgs e)
        {

            //display data table on load the form
            displayDataTable();

        }



        public void displayDataTable()
        {
            //displaying users in data grid view
            string queryUsers = "SELECT user_id,user_name,user_fname,user_email,user_phone,address,user_role, CASE WHEN user_status = 1 THEN 'Active' ELSE 'Not Active' END AS status FROM Users";
            SqlDataAdapter sda = new SqlDataAdapter(queryUsers, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dt.TableName = "Users";
            if (showUsersDataGrid != null)
            {
                showUsersDataGrid.DataSource = dt;
            }

            // set the column headers
            showUsersDataGrid.Columns["user_id"].HeaderText = "ID";
            showUsersDataGrid.Columns["user_name"].HeaderText = "User Name";
            showUsersDataGrid.Columns["user_fname"].HeaderText = "Full Name";
            showUsersDataGrid.Columns["user_email"].HeaderText = "Email Address";
            showUsersDataGrid.Columns["user_phone"].HeaderText = "Phone Number";
            showUsersDataGrid.Columns["address"].HeaderText = "Address";
            showUsersDataGrid.Columns["user_role"].HeaderText = "User Role";
            showUsersDataGrid.Columns["status"].HeaderText = "User Status";

            showUsersDataGrid.Columns["user_id"].DataPropertyName = "user_id";
            showUsersDataGrid.Columns["user_name"].DataPropertyName = "user_name";
            showUsersDataGrid.Columns["user_fname"].DataPropertyName = "user_fname";
            showUsersDataGrid.Columns["user_email"].DataPropertyName = "user_email";
            showUsersDataGrid.Columns["user_phone"].DataPropertyName = "user_phone";
            showUsersDataGrid.Columns["address"].DataPropertyName = "address";
            showUsersDataGrid.Columns["user_role"].DataPropertyName = "user_role";
            showUsersDataGrid.Columns["status"].DataPropertyName = "status";
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            //form data variables
            string userName = user_name.Text;
            string fullName = user_fname.Text;
            string User_password = password.Text;
            string User_Role = user_role.SelectedItem.ToString();
            string User_Email = user_email.Text;
            string User_Phone = user_phone.Text;
            string User_Address = address.Text;

            if(userName == "" || User_password == "")
            {
                MessageBox.Show("You must fill username and password at least", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                //checking if the username is already exists in the database
                string queryUsers = "SELECT * FROM Users where user_name = '" + userName + "'";
                SqlDataAdapter sda = new SqlDataAdapter(queryUsers, con);
                DataTable usersData = new DataTable();
                sda.Fill(usersData);
                int row = usersData.Rows.Count;

                if (row > 0)
                {
                    MessageBox.Show("This username already exists! Try another!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    //adding users in database
                    string query = "INSERT INTO Users (user_name, user_fname, password, user_role, user_email, user_phone, address) VALUES('" + userName + "', '" + fullName + "', '" + User_password + "', '" + User_Role + "', '" + User_Email + "', '" + User_Phone + "', '" + User_Address + "') ";

                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("User Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            displayDataTable();
                            clearAll();

                        }
                        else
                        {
                            MessageBox.Show("Add User Failed!");
                        }
                    }
                    con.Close();
                }



            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            user_name.Clear();
            user_fname.Clear();
            password.Clear();
            user_role.DataBindings.Clear();
            user_email.Clear();
            user_phone.Clear();
            address.Clear();
        }

        private void userSearchBox_TextChanged(object sender, EventArgs e)
        {
            //showing search results in data grid view
            string querySearch = "SELECT user_id,user_name,user_fname,user_email,user_phone,address,user_role, CASE WHEN user_status = 1 THEN 'Active' ELSE 'Not Active' END AS status FROM Users WHERE user_name LIKE '%"+userSearchBox.Text+"%'";
            SqlDataAdapter sda = new SqlDataAdapter(querySearch, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dt.TableName = "Users";
            if (showUsersDataGrid != null)
            {
                showUsersDataGrid.DataSource = dt;
            }
        }

        //search box clear placeholder on mouse click
        
        private void userSearchBox_Enter(object sender, EventArgs e)
        {
            userSearchBox.Text = "";
        }

        //show modify and delete button on cell click
        public string cell_value;
        private void showUsersDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_editUser.Show();
            btn_deleteUser.Show();



            //get id from cell click
            if (e.RowIndex >= 0 && e.RowIndex < showUsersDataGrid.Rows.Count)
            {
                DataGridViewRow id = showUsersDataGrid.Rows[e.RowIndex];
                cell_value = id.Cells["user_id"].Value.ToString();
            }

            
            
        }


        //delete user from database
        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            
            string delete_query = "DELETE FROM Users WHERE user_id = "+ cell_value + "";

            SqlCommand cmd = new SqlCommand(delete_query, con);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {

                    MessageBox.Show("User Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_editUser.Hide();
                    btn_deleteUser.Hide();
                    displayDataTable();



                }
                else
                {
                    MessageBox.Show("Delete User Failed!");
                }
            }
            con.Close();
        }



        //update user form load
        private void btn_editUser_Click(object sender, EventArgs e)
        {

            UpdateUsers f = new UpdateUsers(cell_value);
            f.Show();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            displayDataTable();
        }
    }
}
