
namespace MedioSoft
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btnManageCats = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.welcomeUsername = new System.Windows.Forms.Label();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnManageMedicine = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.adminLabel = new System.Windows.Forms.Label();
            this.adminImg = new System.Windows.Forms.PictureBox();
            this.homePanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminImg)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Lavender;
            this.menuPanel.Controls.Add(this.btnManageCats);
            this.menuPanel.Controls.Add(this.btnOrders);
            this.menuPanel.Controls.Add(this.welcomeUsername);
            this.menuPanel.Controls.Add(this.lblwelcome);
            this.menuPanel.Controls.Add(this.btnDashboard);
            this.menuPanel.Controls.Add(this.btnProfile);
            this.menuPanel.Controls.Add(this.btnManageMedicine);
            this.menuPanel.Controls.Add(this.btnManageUsers);
            this.menuPanel.Controls.Add(this.btnLogout);
            this.menuPanel.Controls.Add(this.adminLabel);
            this.menuPanel.Controls.Add(this.adminImg);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuPanel.Size = new System.Drawing.Size(1100, 110);
            this.menuPanel.TabIndex = 0;
            // 
            // btnManageCats
            // 
            this.btnManageCats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            this.btnManageCats.FlatAppearance.BorderSize = 0;
            this.btnManageCats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCats.ForeColor = System.Drawing.Color.White;
            this.btnManageCats.Image = ((System.Drawing.Image)(resources.GetObject("btnManageCats.Image")));
            this.btnManageCats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageCats.Location = new System.Drawing.Point(430, 12);
            this.btnManageCats.Name = "btnManageCats";
            this.btnManageCats.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.btnManageCats.Size = new System.Drawing.Size(157, 83);
            this.btnManageCats.TabIndex = 10;
            this.btnManageCats.Text = "Manage Categories";
            this.btnManageCats.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageCats.UseVisualStyleBackColor = false;
            this.btnManageCats.Click += new System.EventHandler(this.btnManageCats_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(735, 12);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.btnOrders.Size = new System.Drawing.Size(133, 83);
            this.btnOrders.TabIndex = 9;
            this.btnOrders.Text = "Manage\r\nOrders";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // welcomeUsername
            // 
            this.welcomeUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.welcomeUsername.Location = new System.Drawing.Point(1002, 31);
            this.welcomeUsername.Margin = new System.Windows.Forms.Padding(0);
            this.welcomeUsername.Name = "welcomeUsername";
            this.welcomeUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.welcomeUsername.Size = new System.Drawing.Size(86, 20);
            this.welcomeUsername.TabIndex = 8;
            this.welcomeUsername.Text = " user";
            this.welcomeUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.Location = new System.Drawing.Point(1029, 14);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(59, 17);
            this.lblwelcome.TabIndex = 7;
            this.lblwelcome.Text = "welcome";
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(104, 12);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.btnDashboard.Size = new System.Drawing.Size(157, 83);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(874, 12);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.btnProfile.Size = new System.Drawing.Size(125, 83);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnManageMedicine
            // 
            this.btnManageMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            this.btnManageMedicine.FlatAppearance.BorderSize = 0;
            this.btnManageMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMedicine.ForeColor = System.Drawing.Color.White;
            this.btnManageMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnManageMedicine.Image")));
            this.btnManageMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageMedicine.Location = new System.Drawing.Point(267, 12);
            this.btnManageMedicine.Name = "btnManageMedicine";
            this.btnManageMedicine.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.btnManageMedicine.Size = new System.Drawing.Size(157, 83);
            this.btnManageMedicine.TabIndex = 4;
            this.btnManageMedicine.Text = "Manage\r\nMedicines";
            this.btnManageMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageMedicine.UseVisualStyleBackColor = false;
            this.btnManageMedicine.Click += new System.EventHandler(this.btnManageMedicine_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnManageUsers.Image")));
            this.btnManageUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUsers.Location = new System.Drawing.Point(592, 12);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.btnManageUsers.Size = new System.Drawing.Size(137, 83);
            this.btnManageUsers.TabIndex = 3;
            this.btnManageUsers.Text = "Manage\r\nUsers";
            this.btnManageUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(1008, 67);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 28);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLabel.ForeColor = System.Drawing.Color.Black;
            this.adminLabel.Location = new System.Drawing.Point(5, 65);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(76, 30);
            this.adminLabel.TabIndex = 1;
            this.adminLabel.Text = "Admin";
            this.adminLabel.Click += new System.EventHandler(this.adminLabel_Click);
            // 
            // adminImg
            // 
            this.adminImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminImg.BackgroundImage")));
            this.adminImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adminImg.Location = new System.Drawing.Point(18, 14);
            this.adminImg.Name = "adminImg";
            this.adminImg.Size = new System.Drawing.Size(51, 50);
            this.adminImg.TabIndex = 0;
            this.adminImg.TabStop = false;
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.White;
            this.homePanel.Location = new System.Drawing.Point(0, 110);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(1100, 450);
            this.homePanel.TabIndex = 1;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 560);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedioSoft - Admin Dashboard";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.PictureBox adminImg;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnManageMedicine;
        private System.Windows.Forms.Label welcomeUsername;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Button btnOrders;
        public System.Windows.Forms.Panel homePanel;
        public System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageCats;
    }
}