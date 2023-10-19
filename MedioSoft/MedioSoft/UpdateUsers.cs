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
    public partial class UpdateUsers : Form
    {
        public UpdateUsers()
        {
            InitializeComponent();
        }

        //connection string
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K6Q9EHO\\SQLEXPRESS;Initial Catalog=mediosoft;Integrated Security=True");

        private string got_id;
        public UpdateUsers(string get_id)
        {
            InitializeComponent();


            got_id = get_id;
            

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdateUsers_Load(object sender, EventArgs e)
        {
            //displaying users in the update form
            string queryUsers = "SELECT user_name,user_fname,password,user_email,user_phone,address,user_role,user_status FROM Users WHERE user_id = "+ got_id + "";
            SqlCommand cmd = new SqlCommand(queryUsers, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                user_name.Text = reader["user_name"].ToString();
                user_fname.Text = reader["user_fname"].ToString();
                password.Text = reader["password"].ToString();
                user_email.Text = reader["user_email"].ToString();
                user_phone.Text = reader["user_phone"].ToString();
                address.Text = reader["address"].ToString();
                user_role.SelectedItem = reader["user_role"].ToString();

                int user_status_code = 0;

                user_status_code = reader["user_status"].ToString() == "1" ? 0 : 1;

                user_status.SelectedIndex = user_status_code;


            }

            reader.Close();
            con.Close();
        }

        private void btn_updateUser_Click(object sender, EventArgs e)
        {
            //getting updates varibles from update form

            string userName = user_name.Text;
            string fullName = user_fname.Text;
            string User_password = password.Text;
            string User_Role = user_role.SelectedItem.ToString();
            string User_Email = user_email.Text;
            string User_Phone = user_phone.Text;
            string User_Address = address.Text;
            int User_Status = 0;


            User_Status = user_status.SelectedIndex == 0 ? 1 : 0;

            string updateQuery = "UPDATE Users SET user_name = '"+ userName + "',user_fname ='"+ fullName + "', password = '"+ User_password + "', user_role = '"+ User_Role + "', user_email = '"+ User_Email + "', user_phone = '"+ User_Phone + "', address = '"+ User_Address + "', user_status = "+ User_Status + " WHERE user_id = " + got_id + "";

            SqlCommand cmd = new SqlCommand(updateQuery, con);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("User Updated Successfully!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Update User Failed!");
                }
            }
            con.Close();


        }
    }
}
