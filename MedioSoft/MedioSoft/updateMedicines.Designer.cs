
namespace MedioSoft
{
    partial class updateMedicines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateMedicines));
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.expire_date = new System.Windows.Forms.DateTimePicker();
            this.manufacturing_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.medicine_quantity = new System.Windows.Forms.TextBox();
            this.medicine_description = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.medicine_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.medicine_code = new System.Windows.Forms.TextBox();
            this.category_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.medicine_name = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.divider = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_updateMedicine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(235, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 87;
            this.label10.Text = "Expire Date";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 86;
            this.label7.Text = "Manufactured";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // expire_date
            // 
            this.expire_date.CustomFormat = "yyyy-MM-dd";
            this.expire_date.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.expire_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expire_date.Location = new System.Drawing.Point(238, 323);
            this.expire_date.MinDate = new System.DateTime(2022, 12, 1, 0, 0, 0, 0);
            this.expire_date.Name = "expire_date";
            this.expire_date.Size = new System.Drawing.Size(200, 25);
            this.expire_date.TabIndex = 8;
            // 
            // manufacturing_date
            // 
            this.manufacturing_date.CustomFormat = "yyyy-MM-dd";
            this.manufacturing_date.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.manufacturing_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.manufacturing_date.Location = new System.Drawing.Point(19, 323);
            this.manufacturing_date.MinDate = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            this.manufacturing_date.Name = "manufacturing_date";
            this.manufacturing_date.Size = new System.Drawing.Size(200, 25);
            this.manufacturing_date.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(235, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 83;
            this.label6.Text = "Quantity";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // medicine_quantity
            // 
            this.medicine_quantity.BackColor = System.Drawing.Color.White;
            this.medicine_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicine_quantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicine_quantity.Location = new System.Drawing.Point(238, 266);
            this.medicine_quantity.Name = "medicine_quantity";
            this.medicine_quantity.Size = new System.Drawing.Size(200, 25);
            this.medicine_quantity.TabIndex = 6;
            // 
            // medicine_description
            // 
            this.medicine_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicine_description.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.medicine_description.Location = new System.Drawing.Point(19, 190);
            this.medicine_description.Name = "medicine_description";
            this.medicine_description.Size = new System.Drawing.Size(419, 47);
            this.medicine_description.TabIndex = 4;
            this.medicine_description.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(235, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 80;
            this.label8.Text = "Price";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // medicine_price
            // 
            this.medicine_price.BackColor = System.Drawing.Color.White;
            this.medicine_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicine_price.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicine_price.Location = new System.Drawing.Point(238, 134);
            this.medicine_price.Name = "medicine_price";
            this.medicine_price.Size = new System.Drawing.Size(200, 25);
            this.medicine_price.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 79;
            this.label5.Text = "Medicine Code";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // medicine_code
            // 
            this.medicine_code.BackColor = System.Drawing.Color.White;
            this.medicine_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicine_code.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicine_code.Location = new System.Drawing.Point(19, 134);
            this.medicine_code.Name = "medicine_code";
            this.medicine_code.Size = new System.Drawing.Size(200, 25);
            this.medicine_code.TabIndex = 2;
            // 
            // category_combo
            // 
            this.category_combo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.category_combo.FormattingEnabled = true;
            this.category_combo.Location = new System.Drawing.Point(19, 266);
            this.category_combo.Name = "category_combo";
            this.category_combo.Size = new System.Drawing.Size(200, 25);
            this.category_combo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 76;
            this.label1.Text = "Description";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 75;
            this.label2.Text = "Category";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 74;
            this.label4.Text = "Medicine Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // medicine_name
            // 
            this.medicine_name.BackColor = System.Drawing.Color.White;
            this.medicine_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicine_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicine_name.Location = new System.Drawing.Point(19, 80);
            this.medicine_name.Name = "medicine_name";
            this.medicine_name.Size = new System.Drawing.Size(419, 25);
            this.medicine_name.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(406, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 29);
            this.btnExit.TabIndex = 90;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.White;
            this.divider.Location = new System.Drawing.Point(17, 48);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(421, 2);
            this.divider.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 32);
            this.label3.TabIndex = 88;
            this.label3.Text = "Update Medicine";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_updateMedicine
            // 
            this.btn_updateMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            this.btn_updateMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_updateMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateMedicine.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateMedicine.ForeColor = System.Drawing.Color.White;
            this.btn_updateMedicine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_updateMedicine.Location = new System.Drawing.Point(19, 358);
            this.btn_updateMedicine.Name = "btn_updateMedicine";
            this.btn_updateMedicine.Size = new System.Drawing.Size(130, 30);
            this.btn_updateMedicine.TabIndex = 91;
            this.btn_updateMedicine.Text = "Update Medicine";
            this.btn_updateMedicine.UseVisualStyleBackColor = false;
            this.btn_updateMedicine.Click += new System.EventHandler(this.btn_updateMedicine_Click);
            // 
            // updateMedicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(460, 400);
            this.Controls.Add(this.btn_updateMedicine);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.expire_date);
            this.Controls.Add(this.manufacturing_date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.medicine_quantity);
            this.Controls.Add(this.medicine_description);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.medicine_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.medicine_code);
            this.Controls.Add(this.category_combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.medicine_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "updateMedicines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updateMedicines";
            this.Load += new System.EventHandler(this.updateMedicines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker expire_date;
        private System.Windows.Forms.DateTimePicker manufacturing_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox medicine_quantity;
        private System.Windows.Forms.RichTextBox medicine_description;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox medicine_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox medicine_code;
        private System.Windows.Forms.ComboBox category_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox medicine_name;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Panel divider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_updateMedicine;
    }
}