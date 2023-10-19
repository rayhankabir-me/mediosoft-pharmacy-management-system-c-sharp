
namespace MedioSoft
{
    partial class Pharmacists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacists));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.pharmacistsLabel = new System.Windows.Forms.Label();
            this.btnManageCategories = new System.Windows.Forms.Button();
            this.welcomeUsername = new System.Windows.Forms.Label();
            this.adminImg = new System.Windows.Forms.PictureBox();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnManageMedicine = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminImg)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Lavender;
            this.menuPanel.Controls.Add(this.pharmacistsLabel);
            this.menuPanel.Controls.Add(this.btnManageCategories);
            this.menuPanel.Controls.Add(this.welcomeUsername);
            this.menuPanel.Controls.Add(this.adminImg);
            this.menuPanel.Controls.Add(this.lblwelcome);
            this.menuPanel.Controls.Add(this.btnLogout);
            this.menuPanel.Controls.Add(this.btnInstructions);
            this.menuPanel.Controls.Add(this.btnManageMedicine);
            this.menuPanel.Controls.Add(this.btnProfile);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuPanel.Size = new System.Drawing.Size(1100, 110);
            this.menuPanel.TabIndex = 2;
            // 
            // pharmacistsLabel
            // 
            this.pharmacistsLabel.AutoSize = true;
            this.pharmacistsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pharmacistsLabel.ForeColor = System.Drawing.Color.Black;
            this.pharmacistsLabel.Location = new System.Drawing.Point(12, 66);
            this.pharmacistsLabel.Name = "pharmacistsLabel";
            this.pharmacistsLabel.Size = new System.Drawing.Size(118, 30);
            this.pharmacistsLabel.TabIndex = 10;
            this.pharmacistsLabel.Text = "Pharmacist";
            // 
            // btnManageCategories
            // 
            this.btnManageCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            this.btnManageCategories.FlatAppearance.BorderSize = 0;
            this.btnManageCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCategories.ForeColor = System.Drawing.Color.White;
            this.btnManageCategories.Image = ((System.Drawing.Image)(resources.GetObject("btnManageCategories.Image")));
            this.btnManageCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageCategories.Location = new System.Drawing.Point(642, 13);
            this.btnManageCategories.Name = "btnManageCategories";
            this.btnManageCategories.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnManageCategories.Size = new System.Drawing.Size(166, 83);
            this.btnManageCategories.TabIndex = 9;
            this.btnManageCategories.Text = "Manage Categories";
            this.btnManageCategories.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageCategories.UseVisualStyleBackColor = false;
            this.btnManageCategories.Click += new System.EventHandler(this.btnManageCategories_Click);
            // 
            // welcomeUsername
            // 
            this.welcomeUsername.BackColor = System.Drawing.Color.Lavender;
            this.welcomeUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeUsername.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.welcomeUsername.Location = new System.Drawing.Point(993, 30);
            this.welcomeUsername.Margin = new System.Windows.Forms.Padding(0);
            this.welcomeUsername.Name = "welcomeUsername";
            this.welcomeUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.welcomeUsername.Size = new System.Drawing.Size(95, 20);
            this.welcomeUsername.TabIndex = 8;
            this.welcomeUsername.Text = " user";
            this.welcomeUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // adminImg
            // 
            this.adminImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminImg.BackgroundImage")));
            this.adminImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adminImg.Location = new System.Drawing.Point(17, 18);
            this.adminImg.Name = "adminImg";
            this.adminImg.Size = new System.Drawing.Size(101, 50);
            this.adminImg.TabIndex = 0;
            this.adminImg.TabStop = false;
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.Location = new System.Drawing.Point(990, 13);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(98, 17);
            this.lblwelcome.TabIndex = 7;
            this.lblwelcome.Text = "welcome back !";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(1008, 68);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 28);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            this.btnInstructions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInstructions.FlatAppearance.BorderSize = 0;
            this.btnInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstructions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.ForeColor = System.Drawing.Color.White;
            this.btnInstructions.Image = ((System.Drawing.Image)(resources.GetObject("btnInstructions.Image")));
            this.btnInstructions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstructions.Location = new System.Drawing.Point(253, 13);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnInstructions.Size = new System.Drawing.Size(174, 83);
            this.btnInstructions.TabIndex = 6;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInstructions.UseVisualStyleBackColor = false;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnManageMedicine
            // 
            this.btnManageMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            this.btnManageMedicine.FlatAppearance.BorderSize = 0;
            this.btnManageMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMedicine.ForeColor = System.Drawing.Color.White;
            this.btnManageMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnManageMedicine.Image")));
            this.btnManageMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageMedicine.Location = new System.Drawing.Point(452, 13);
            this.btnManageMedicine.Name = "btnManageMedicine";
            this.btnManageMedicine.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnManageMedicine.Size = new System.Drawing.Size(164, 83);
            this.btnManageMedicine.TabIndex = 4;
            this.btnManageMedicine.Text = "Manage \r\nMedicines";
            this.btnManageMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageMedicine.UseVisualStyleBackColor = false;
            this.btnManageMedicine.Click += new System.EventHandler(this.btnManageMedicine_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(835, 13);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnProfile.Size = new System.Drawing.Size(137, 83);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.White;
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.homePanel.Location = new System.Drawing.Point(0, 110);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(1100, 450);
            this.homePanel.TabIndex = 3;
            // 
            // Pharmacists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 560);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pharmacists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedioSoft - Pharmacists Dashboard";
            this.Load += new System.EventHandler(this.Pharmacists_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label pharmacistsLabel;
        private System.Windows.Forms.Button btnManageCategories;
        private System.Windows.Forms.Label welcomeUsername;
        private System.Windows.Forms.PictureBox adminImg;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnManageMedicine;
        private System.Windows.Forms.Button btnProfile;
        public System.Windows.Forms.Panel homePanel;
    }
}