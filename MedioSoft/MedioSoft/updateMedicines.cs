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
    public partial class updateMedicines : Form
    {
        public updateMedicines()
        {
            InitializeComponent();
        }

        //connection string
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K6Q9EHO\\SQLEXPRESS;Initial Catalog=mediosoft;Integrated Security=True");

        private int user_id;
        private string got_id;
        public updateMedicines(string get_id, int UserId)
        {
            InitializeComponent();


            got_id = get_id;
            user_id = UserId;

        }

        //hide form on click the cross
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void updateMedicines_Load(object sender, EventArgs e)
        {

            //all cartegory names load on category combo

            string queryCategory = "SELECT category_id, category_name FROM Categories";
            SqlDataAdapter sda = new SqlDataAdapter(queryCategory, con);
            DataTable dtCategories = new DataTable();
            sda.Fill(dtCategories);

            category_combo.DataSource = dtCategories;
            category_combo.DisplayMember = "category_name";
            category_combo.ValueMember = "category_id";


            //displaying users in the update form

            string queryMedicines = "SELECT m.medicine_name, m.medicine_code, m.medicine_description, m.medicine_price, m.medicine_quantity, c.category_id, c.category_name, m.manufacturing_date, m.expire_date FROM Medicines m INNER JOIN Categories c ON m.category_id = c.category_id WHERE m.medicine_id = " + got_id + "";
            SqlCommand cmd = new SqlCommand(queryMedicines, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                medicine_name.Text = reader["medicine_name"].ToString();
                medicine_code.Text = reader["medicine_code"].ToString();
                medicine_description.Text = reader["medicine_description"].ToString();
                medicine_price.Text = reader["medicine_price"].ToString();
                medicine_quantity.Text = reader["medicine_quantity"].ToString();

                category_combo.SelectedValue = reader["category_id"];

                //manufacturing_date.Value = DateTime.Parse(reader["manufacturing_date"].ToString());
                //expire_date.Value = DateTime.Parse(reader["manufacturing_date"].ToString());

                DateTime.TryParse(reader["manufacturing_date"].ToString(), out DateTime manufacturingDate);
                manufacturing_date.Value = manufacturingDate;
                DateTime.TryParse(reader["expire_date"].ToString(), out DateTime expireDate);
                expire_date.Value = expireDate;



            }

            reader.Close();
            con.Close();
        }

        private void btn_updateMedicine_Click(object sender, EventArgs e)
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


            

            string updateQuery = "UPDATE Medicines SET medicine_name = '" + medicineName + "', medicine_code = '" + medicineCode + "', medicine_description = '" + medicineDesc + "', medicine_price = " + medicinePrice + ", medicine_quantity = " + Quantity + ", category_id = " + categoryId + ", manufacturing_date = '" + manufacturedDate + "', expire_date = '" + expireDate + "', created_by = "+ user_id + " WHERE medicine_id = " + got_id;

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
