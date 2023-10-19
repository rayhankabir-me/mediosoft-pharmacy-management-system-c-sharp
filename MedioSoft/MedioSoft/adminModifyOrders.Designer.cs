
namespace MedioSoft
{
    partial class adminModifyOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminModifyOrders));
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.divider = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_updateCat = new System.Windows.Forms.Button();
            this.OrderComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(411, 26);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 29);
            this.btnExit.TabIndex = 77;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.White;
            this.divider.Location = new System.Drawing.Point(22, 61);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(421, 2);
            this.divider.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 32);
            this.label3.TabIndex = 75;
            this.label3.Text = "Order Status";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_updateCat
            // 
            this.btn_updateCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            this.btn_updateCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_updateCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateCat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateCat.ForeColor = System.Drawing.Color.White;
            this.btn_updateCat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_updateCat.Location = new System.Drawing.Point(260, 96);
            this.btn_updateCat.Name = "btn_updateCat";
            this.btn_updateCat.Size = new System.Drawing.Size(183, 30);
            this.btn_updateCat.TabIndex = 74;
            this.btn_updateCat.Text = "Update";
            this.btn_updateCat.UseVisualStyleBackColor = false;
            this.btn_updateCat.Click += new System.EventHandler(this.btn_updateCat_Click);
            // 
            // OrderComboBox
            // 
            this.OrderComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderComboBox.FormattingEnabled = true;
            this.OrderComboBox.Items.AddRange(new object[] {
            "pending",
            "processing",
            "completed",
            "delivered",
            "cancelled"});
            this.OrderComboBox.Location = new System.Drawing.Point(23, 96);
            this.OrderComboBox.Name = "OrderComboBox";
            this.OrderComboBox.Size = new System.Drawing.Size(216, 30);
            this.OrderComboBox.TabIndex = 78;
            // 
            // adminModifyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(460, 338);
            this.Controls.Add(this.OrderComboBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_updateCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "adminModifyOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminModifyOrders";
            this.Load += new System.EventHandler(this.adminModifyOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Panel divider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_updateCat;
        private System.Windows.Forms.ComboBox OrderComboBox;
    }
}