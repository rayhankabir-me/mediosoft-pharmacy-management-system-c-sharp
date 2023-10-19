
namespace MedioSoft
{
    partial class ManageUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers));
            this.btnReset = new System.Windows.Forms.Button();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_email = new System.Windows.Forms.TextBox();
            this.user_role = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.user_phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.user_fname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.showUsersDataGrid = new System.Windows.Forms.DataGridView();
            this.userSearchBox = new System.Windows.Forms.TextBox();
            this.btn_deleteUser = new System.Windows.Forms.Button();
            this.btn_editUser = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.showUsersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(114, 390);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 40);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btn_addUser
            // 
            this.btn_addUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            this.btn_addUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addUser.ForeColor = System.Drawing.Color.White;
            this.btn_addUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_addUser.Location = new System.Drawing.Point(8, 390);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(100, 40);
            this.btn_addUser.TabIndex = 12;
            this.btn_addUser.Text = "Add User";
            this.btn_addUser.UseVisualStyleBackColor = false;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(8, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "User Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // user_name
            // 
            this.user_name.BackColor = System.Drawing.Color.White;
            this.user_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(12, 77);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(158, 25);
            this.user_name.TabIndex = 1;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.Window;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.password.Location = new System.Drawing.Point(12, 132);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(327, 25);
            this.password.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = " Add Users";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(8, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(8, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "User Role";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // user_email
            // 
            this.user_email.BackColor = System.Drawing.SystemColors.Window;
            this.user_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_email.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.user_email.Location = new System.Drawing.Point(12, 187);
            this.user_email.Name = "user_email";
            this.user_email.Size = new System.Drawing.Size(327, 25);
            this.user_email.TabIndex = 4;
            // 
            // user_role
            // 
            this.user_role.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.user_role.FormattingEnabled = true;
            this.user_role.Items.AddRange(new object[] {
            "Admin",
            "Pharmacist",
            "Customer"});
            this.user_role.Location = new System.Drawing.Point(12, 353);
            this.user_role.Name = "user_role";
            this.user_role.Size = new System.Drawing.Size(327, 25);
            this.user_role.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.Location = new System.Drawing.Point(8, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Phone (Optional)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // user_phone
            // 
            this.user_phone.BackColor = System.Drawing.SystemColors.Window;
            this.user_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_phone.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.user_phone.Location = new System.Drawing.Point(12, 242);
            this.user_phone.Name = "user_phone";
            this.user_phone.Size = new System.Drawing.Size(327, 25);
            this.user_phone.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label7.Location = new System.Drawing.Point(8, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Address (Optional)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.SystemColors.Window;
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.address.Location = new System.Drawing.Point(12, 298);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(327, 25);
            this.address.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(173, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Full Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // user_fname
            // 
            this.user_fname.BackColor = System.Drawing.Color.White;
            this.user_fname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_fname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_fname.Location = new System.Drawing.Point(176, 77);
            this.user_fname.Name = "user_fname";
            this.user_fname.Size = new System.Drawing.Size(163, 25);
            this.user_fname.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(360, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 32);
            this.label9.TabIndex = 26;
            this.label9.Text = "All Users";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // showUsersDataGrid
            // 
            this.showUsersDataGrid.AllowUserToAddRows = false;
            this.showUsersDataGrid.AllowUserToDeleteRows = false;
            this.showUsersDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showUsersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.showUsersDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.showUsersDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showUsersDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.showUsersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.showUsersDataGrid.ColumnHeadersHeight = 35;
            this.showUsersDataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.showUsersDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.showUsersDataGrid.EnableHeadersVisualStyles = false;
            this.showUsersDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(80)))), ((int)(((byte)(247)))));
            this.showUsersDataGrid.Location = new System.Drawing.Point(366, 55);
            this.showUsersDataGrid.Name = "showUsersDataGrid";
            this.showUsersDataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showUsersDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.showUsersDataGrid.RowHeadersVisible = false;
            this.showUsersDataGrid.RowHeadersWidth = 40;
            this.showUsersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showUsersDataGrid.Size = new System.Drawing.Size(722, 323);
            this.showUsersDataGrid.TabIndex = 27;
            this.showUsersDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showUsersDataGrid_CellClick);
            // 
            // userSearchBox
            // 
            this.userSearchBox.BackColor = System.Drawing.Color.White;
            this.userSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userSearchBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSearchBox.Location = new System.Drawing.Point(858, 16);
            this.userSearchBox.Name = "userSearchBox";
            this.userSearchBox.Size = new System.Drawing.Size(230, 25);
            this.userSearchBox.TabIndex = 28;
            this.userSearchBox.Text = "Search User. . . . .";
            this.userSearchBox.TextChanged += new System.EventHandler(this.userSearchBox_TextChanged);
            this.userSearchBox.Enter += new System.EventHandler(this.userSearchBox_Enter);
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            this.btn_deleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteUser.ForeColor = System.Drawing.Color.White;
            this.btn_deleteUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_deleteUser.Location = new System.Drawing.Point(988, 390);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Size = new System.Drawing.Size(100, 40);
            this.btn_deleteUser.TabIndex = 29;
            this.btn_deleteUser.Text = " Delete User";
            this.btn_deleteUser.UseVisualStyleBackColor = false;
            this.btn_deleteUser.Visible = false;
            this.btn_deleteUser.Click += new System.EventHandler(this.btn_deleteUser_Click);
            // 
            // btn_editUser
            // 
            this.btn_editUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            this.btn_editUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_editUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editUser.ForeColor = System.Drawing.Color.White;
            this.btn_editUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_editUser.Location = new System.Drawing.Point(874, 390);
            this.btn_editUser.Name = "btn_editUser";
            this.btn_editUser.Size = new System.Drawing.Size(108, 40);
            this.btn_editUser.TabIndex = 30;
            this.btn_editUser.Text = "Modify User";
            this.btn_editUser.UseVisualStyleBackColor = false;
            this.btn_editUser.Visible = false;
            this.btn_editUser.Click += new System.EventHandler(this.btn_editUser_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(481, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 132;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btn_editUser);
            this.Controls.Add(this.btn_deleteUser);
            this.Controls.Add(this.userSearchBox);
            this.Controls.Add(this.showUsersDataGrid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.user_fname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.user_phone);
            this.Controls.Add(this.user_role);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btn_addUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsers";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showUsersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btn_addUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_email;
        private System.Windows.Forms.ComboBox user_role;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox user_phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox user_fname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView showUsersDataGrid;
        private System.Windows.Forms.TextBox userSearchBox;
        private System.Windows.Forms.Button btn_deleteUser;
        private System.Windows.Forms.Button btn_editUser;
        private System.Windows.Forms.PictureBox btnRefresh;
    }
}