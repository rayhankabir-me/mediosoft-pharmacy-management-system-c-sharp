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
    public partial class manageProfile : Form
    {
        public manageProfile()
        {
            InitializeComponent();
        }

        //database connection string
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K6Q9EHO\\SQLEXPRESS;Initial Catalog=mediosoft;Integrated Security=True");

        //getting the user name by constructor
        public string userName;
        public manageProfile(string username)
        {
            InitializeComponent();

            userName = username;
        }
        private void manageProfile_Load(object sender, EventArgs e)
        {
            displayData();
        }

        public void displayData()
        {
            //displaying profile data in label section
            string queryProfile = "SELECT user_name,user_fname,password,user_email,user_phone,address,user_role, CASE WHEN user_status = 1 THEN 'Active' ELSE 'Not Active' END AS status FROM Users WHERE user_name = '"+ userName + "'";

            
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-K6Q9EHO\\SQLEXPRESS;Initial Catalog=mediosoft;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(queryProfile, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    //showing data in label
                    label_user_name.Text = reader["user_name"].ToString();
                    label_fname.Text = reader["user_fname"].ToString();
                    label_password.Text = reader["password"].ToString();
                    label_email_address.Text = reader["user_email"].ToString();
                    label_phone.Text = reader["user_phone"].ToString();
                    label_address.Text = reader["address"].ToString();
                    label_role.Text = reader["user_role"].ToString();


                    //showig data in update textbox

                    
                    user_fname.Text = reader["user_fname"].ToString();
                    password.Text = reader["password"].ToString();
                    user_email.Text = reader["user_email"].ToString();
                    user_phone.Text = reader["user_phone"].ToString();
                    address.Text = reader["address"].ToString();


                }
                
                reader.Close();
            }

        }

        
        private void btn_updateProfile_Click(object sender, EventArgs e)
        {

            string userRole = "Active";
            int userStatus = 1;

            
            //getting user_role by username
            
            string querySR = "SELECT user_status,user_role FROM Users WHERE user_name = '"+ this.userName + "'";

            SqlCommand cmd_SR = new SqlCommand(querySR, con);
            con.Open();
            SqlDataReader reader = cmd_SR.ExecuteReader();

            if (reader.Read())
            {

                userRole = reader["user_role"].ToString();
                userStatus = int.Parse(reader["user_status"].ToString());

            }

            reader.Close();
            con.Close();




            //getting updates varibles from update form
            string fullName = user_fname.Text;
            string User_password = password.Text;
            string User_Email = user_email.Text;
            string User_Phone = user_phone.Text;
            string User_Address = address.Text;
            string User_Role = userRole;
            int User_Status = userStatus;




            string updateQuery = "UPDATE Users SET user_name = '" + userName + "',user_fname ='" + fullName + "', password = '" + User_password + "', user_role = '" + User_Role + "', user_email = '" + User_Email + "', user_phone = '" + User_Phone + "', address = '" + User_Address + "', user_status = " + User_Status + " WHERE user_name = '" + userName + "'";

            SqlCommand cmdProfile = new SqlCommand(updateQuery, con);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                int rows = cmdProfile.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Profile Updated Successfully!");
                    displayData();
                }
                else
                {
                    MessageBox.Show("Update Profile Failed!");
                }
            }
            con.Close();
        }
    }
}
