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
    public partial class LoginForm : Form
    {

        
        public LoginForm()
        {
            InitializeComponent();
        }

        
        //connection string
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K6Q9EHO\\SQLEXPRESS;Initial Catalog=mediosoft;Integrated Security=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string welcomeUser = loginUsername.Text;


        if(loginUsername.Text == "" || loginPass.Text == "")
            {
                MessageBox.Show("Please fill the info!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //application default login authentication
                if (loginUsername.Text == "admin" && loginPass.Text == "admin")
                {
                    Admin ad = new Admin(welcomeUser);
                    ad.Show();
                    this.Hide();

                    //sending username to ManageMedicines Form
                    ManageMedicines mm = new ManageMedicines(welcomeUser);
                }
                else
                {

                    //getting the users available in the database
                    string queryUsers = "SELECT * FROM Users WHERE user_name = '"+loginUsername.Text+"'";
                    SqlDataAdapter sda_Users = new SqlDataAdapter(queryUsers, con);
                    DataTable dt_Users = new DataTable();
                    sda_Users.Fill(dt_Users);
                    int count = dt_Users.Rows.Count;
                    if (count < 1)
                    {
                        MessageBox.Show("Incorrect Login Details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //database user login authentication
                        string loginUserName = loginUsername.Text;
                        string loginPassword = loginPass.Text;

                        string query = "SELECT user_role FROM Users WHERE user_name = '" + loginUserName + "' AND password = '" + loginPassword + "'";



                        SqlDataAdapter sda = new SqlDataAdapter(query, con);

                        DataTable dt = new DataTable();

                        sda.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            string userRole = dt.Rows[0]["user_role"].ToString();

                            if (userRole == "Admin")
                            {
                                Admin ad = new Admin(welcomeUser);  //sending username to admin form
                                ad.Show();
                                this.Hide();



                            }
                            else if (userRole == "Pharmacist")
                            {
                                Pharmacists ph = new Pharmacists(welcomeUser);
                                ph.Show();
                                this.Hide();
                            }
                            else if (userRole == "Customer")
                            {
                                Customers ct = new Customers(welcomeUser);
                                ct.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Login Credentials!");
                            }

                        }
                    }







                }
            }




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loginUsername.Clear();
            loginPass.Clear();
        }

        private void btn_user_registration_Click(object sender, EventArgs e)
        {
            
            uesrsRegistration ur = new uesrsRegistration();
            ur.Show();
            this.Hide();
        }

        private void btn_forgotPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Email to the admin!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
