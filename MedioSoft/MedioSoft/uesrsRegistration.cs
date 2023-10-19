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
    public partial class uesrsRegistration : Form
    {
        public uesrsRegistration()
        {
            InitializeComponent();
        }

        //connection string
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K6Q9EHO\\SQLEXPRESS;Initial Catalog=mediosoft;Integrated Security=True");
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            register_username.Clear();
            register_password.Clear();
            register_phone.Clear();
            register_email.Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //getting the variables
            string userName = register_username.Text;
            string userPass = register_password.Text;
            string userEmail = register_email.Text;
            string userPhone = register_phone.Text;

            //user must fill the username and password field
            if(userName == "" || userPass == "")
            {
                MessageBox.Show("You must fill username and password at least!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    string query = "INSERT INTO Users (user_name, password, user_role, user_email, user_phone) VALUES('" + userName + "', '" + userPass + "', 'Customer', '" + userEmail + "', '" + userPhone + "') ";

                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            
                            LoginForm login = new LoginForm();
                            login.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Registration failed! Please try again!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    con.Close();
                }
            }
        }
    }
}
