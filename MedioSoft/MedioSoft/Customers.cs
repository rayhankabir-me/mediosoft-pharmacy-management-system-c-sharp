using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedioSoft
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }
        
        //recieving username by constructor
        public string UserName;

        public Customers(string welcomeUser)
        {
            InitializeComponent();


            UserName = welcomeUser;
            welcomeUsername.Text = UserName;

        }

        //open dashboard by panel
        public void loadform(object Form)
        {
            if (this.homePanel.Controls.Count > 0)
                this.homePanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.homePanel.Controls.Add(f);
            this.homePanel.Tag = f;
            f.Show();



        }

        private void Customers_Load(object sender, EventArgs e)
        {
            btnCustomerInstructions.PerformClick();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void btnCustomerInstructions_Click(object sender, EventArgs e)
        {
            loadform(new customerInstructions());
        }

        private void btnManageMedicine_Click(object sender, EventArgs e)
        {
            loadform(new medicineCustomers(UserName));
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            loadform(new manageProfile(UserName));
        }

        private void btn_validateMedicine_Click(object sender, EventArgs e)
        {
            loadform(new medicineValidationCheck());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            loadform(new customerOrders(UserName));
        }
    }
}
