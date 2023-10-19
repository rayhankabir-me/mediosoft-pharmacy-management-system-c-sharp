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
    public partial class Admin : Form
    {

        public Panel GetPanel()
        {
            return homePanel;
        }
        public Admin()
        {
            InitializeComponent();

            
        }

        public string UserName;
        public Admin(string welcomeUser)
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



        private void adminLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();

        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            loadform(new ManageUsers());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            loadform(new UserDashboard());
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            btnDashboard.PerformClick();

            

        }

        private void btnManageCats_Click(object sender, EventArgs e)
        {
            loadform(new ManageCategories());
        }

        private void btnManageMedicine_Click(object sender, EventArgs e)
        {
            loadform(new ManageMedicines(UserName));
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            loadform(new manageProfile(UserName));
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            loadform(new adminOrders());
        }
    }
}
