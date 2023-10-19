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
    public partial class updateCategory : Form
    {
        public updateCategory()
        {
            InitializeComponent();
        }

        //connection string
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K6Q9EHO\\SQLEXPRESS;Initial Catalog=mediosoft;Integrated Security=True");

        private string got_id;
        public updateCategory(string get_id)
        {
            InitializeComponent();
            got_id = get_id;
        }



        private void updateCategory_Load(object sender, EventArgs e)
        {
            //displaying categories in the update form
            string queryUsers = "SELECT category_name FROM Categories WHERE category_id = " + got_id + "";
            SqlCommand cmd = new SqlCommand(queryUsers, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                category_name.Text = reader["category_name"].ToString();

            }

            reader.Close();
            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        private void btn_updateCat_Click(object sender, EventArgs e)
        {
            //getting updates varibles from update form

            string catName = category_name.Text;

            string updateQuery = "UPDATE Categories SET category_name = '" + catName + "' WHERE category_id = " + got_id + "";

            SqlCommand cmd = new SqlCommand(updateQuery, con);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Category Updated Successfully!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Update Category Failed!");
                }
            }
            con.Close();
        }
    }
}
