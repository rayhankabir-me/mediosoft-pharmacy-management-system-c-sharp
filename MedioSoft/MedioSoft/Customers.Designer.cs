
namespace MedioSoft
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btn_validateMedicine = new System.Windows.Forms.Button();
            this.adminLabel = new System.Windows.Forms.Label();
            this.btnOrders = new System.Windows.Forms.Button();
            this.welcomeUsername = new System.Windows.Forms.Label();
            this.adminImg = new System.Windows.Forms.PictureBox();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCustomerInstructions = new System.Windows.Forms.Button();
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
            this.menuPanel.Controls.Add(this.btn_validateMedicine);
            this.menuPanel.Controls.Add(this.adminLabel);
            this.menuPanel.Controls.Add(this.btnOrders);
            this.menuPanel.Controls.Add(this.welcomeUsername);
            this.menuPanel.Controls.Add(this.adminImg);
            this.menuPanel.Controls.Add(this.lblwelcome);
            this.menuPanel.Controls.Add(this.btnLogout);
            this.menuPanel.Controls.Add(this.btnCustomerInstructions);
            this.menuPanel.Controls.Add(this.btnManageMedicine);
            this.menuPanel.Controls.Add(this.btnProfile);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuPanel.Size = new System.Drawing.Size(1100, 110);
            this.menuPanel.TabIndex = 1;
            // 
            // btn_validateMedicine
            // 
            this.btn_validateMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(210)))), ((int)(((byte)(46)))));
            this.btn_validateMedicine.FlatAppearance.BorderSize = 0;
            this.btn_validateMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_validateMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validateMedicine.ForeColor = System.Drawing.Color.White;
            this.btn_validateMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btn_validateMedicine.Image")));
            this.btn_validateMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_validateMedicine.Location = new System.Drawing.Point(669, 13);
            this.btn_validateMedicine.Name = "btn_validateMedicine";
            this.btn_validateMedicine.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_validateMedicine.Size = new System.Drawing.Size(157, 83);
            this.btn_validateMedicine.TabIndex = 11;
            this.btn_validateMedicine.Text = "Validate \r\nMedicines";
            this.btn_validateMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_validateMedicine.UseVisualStyleBackColor = false;
            this.btn_validateMedicine.Click += new System.EventHandler(this.btn_validateMedicine_Click);
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLabel.ForeColor = System.Drawing.Color.Black;
            this.adminLabel.Location = new System.Drawing.Point(12, 66);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(106, 30);
            this.adminLabel.TabIndex = 10;
            this.adminLabel.Text = "Customer";
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(210)))), ((int)(((byte)(46)))));
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(510, 13);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnOrders.Size = new System.Drawing.Size(139, 83);
            this.btnOrders.TabIndex = 9;
            this.btnOrders.Text = "Manage Orders";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
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
            this.adminImg.Location = new System.Drawing.Point(13, 18);
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
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(210)))), ((int)(((byte)(46)))));
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
            // btnCustomerInstructions
            // 
            this.btnCustomerInstructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(210)))), ((int)(((byte)(46)))));
            this.btnCustomerInstructions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCustomerInstructions.FlatAppearance.BorderSize = 0;
            this.btnCustomerInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerInstructions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerInstructions.ForeColor = System.Drawing.Color.White;
            this.btnCustomerInstructions.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerInstructions.Image")));
            this.btnCustomerInstructions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerInstructions.Location = new System.Drawing.Point(144, 13);
            this.btnCustomerInstructions.Name = "btnCustomerInstructions";
            this.btnCustomerInstructions.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCustomerInstructions.Size = new System.Drawing.Size(168, 83);
            this.btnCustomerInstructions.TabIndex = 6;
            this.btnCustomerInstructions.Text = "Instructions";
            this.btnCustomerInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerInstructions.UseVisualStyleBackColor = false;
            this.btnCustomerInstructions.Click += new System.EventHandler(this.btnCustomerInstructions_Click);
            // 
            // btnManageMedicine
            // 
            this.btnManageMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(210)))), ((int)(((byte)(46)))));
            this.btnManageMedicine.FlatAppearance.BorderSize = 0;
            this.btnManageMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMedicine.ForeColor = System.Drawing.Color.White;
            this.btnManageMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnManageMedicine.Image")));
            this.btnManageMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageMedicine.Location = new System.Drawing.Point(332, 13);
            this.btnManageMedicine.Name = "btnManageMedicine";
            this.btnManageMedicine.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnManageMedicine.Size = new System.Drawing.Size(158, 83);
            this.btnManageMedicine.TabIndex = 4;
            this.btnManageMedicine.Text = "View \r\nMedicines";
            this.btnManageMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageMedicine.UseVisualStyleBackColor = false;
            this.btnManageMedicine.Click += new System.EventHandler(this.btnManageMedicine_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(210)))), ((int)(((byte)(46)))));
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(847, 13);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnProfile.Size = new System.Drawing.Size(125, 83);
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
            this.homePanel.TabIndex = 2;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 560);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedioSoft - Customers Dashboard";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Label welcomeUsername;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Button btnCustomerInstructions;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnManageMedicine;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox adminImg;
        public System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Button btn_validateMedicine;
        private System.Windows.Forms.Label adminLabel;
    }
}