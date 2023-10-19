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
    public partial class medicineValidationCheck : Form
    {
        public medicineValidationCheck()
        {
            InitializeComponent();
        }

        //connection string
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K6Q9EHO\\SQLEXPRESS;Initial Catalog=mediosoft;Integrated Security=True");

        private void validationBox_Enter(object sender, EventArgs e)
        {
            validationBox.Clear();
        }

        //check validation based on medicine code
        private void btn_btnCheck_Click(object sender, EventArgs e)
        {
            string MedicineCode = validationBox.Text;

            string query = "SELECT expire_date FROM Medicines WHERE medicine_code = '" + MedicineCode + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            string expireDateStr = cmd.ExecuteScalar().ToString(); // getting the expire_date as string
            con.Close();

            // making the expire_date to a DateTime value
            DateTime expireDate = DateTime.Parse(expireDateStr);

            // comparing the expire date based on the current date
            if (expireDate < DateTime.Now)
            {
                label_valid_result.Text = "Not Valid";
                label_valid_result.Show();
            }
            else
            {
                label_valid_result.Text = "Valid";
                label_valid_result.Show();
            }
        }
    }
}
