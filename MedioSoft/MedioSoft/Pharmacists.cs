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
    public partial class Pharmacists : Form
    {
        public Pharmacists()
        {
            InitializeComponent();
        }

        //recieving username by constructor
        public string UserName;

        public Pharmacists(string welcomeUser)
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

        private void Pharmacists_Load(object sender, EventArgs e)
        {
            btnInstructions.PerformClick();
        }

        //logout and redirect to login page when click on logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            loadform(new customerInstructions());
        }

        private void btnManageMedicine_Click(object sender, EventArgs e)
        {
            loadform(new ManageMedicines(UserName));
        }

        private void btnManageCategories_Click(object sender, EventArgs e)
        {
            loadform(new ManageCategories());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            loadform(new manageProfile(UserName));
        }
    }
}
