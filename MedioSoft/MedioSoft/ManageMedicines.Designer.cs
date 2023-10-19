
namespace MedioSoft
{
    partial class ManageMedicines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMedicines));
            this.btn_editMedicine = new System.Windows.Forms.Button();
            this.btn_deleteMedicine = new System.Windows.Forms.Button();
            this.medicineSearchBox = new System.Windows.Forms.TextBox();
            this.showMedicinesDataGrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btn_addMedicine = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btnRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.showMedicinesDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_editMedicine
            // 
            this.btn_editMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            this.btn_editMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_editMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editMedicine.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editMedicine.ForeColor = System.Drawing.Color.White;
            this.btn_editMedicine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_editMedicine.Location = new System.Drawing.Point(824, 396);
            this.btn_editMedicine.Name = "btn_editMedicine";
            this.btn_editMedicine.Size = new System.Drawing.Size(134, 40);
            this.btn_editMedicine.TabIndex = 52;
            this.btn_editMedicine.Text = "Modify Medicine";
            this.btn_editMedicine.UseVisualStyleBackColor = false;
            this.btn_editMedicine.Visible = false;
            this.btn_editMedicine.Click += new System.EventHandler(this.btn_editMedicine_Click);
            // 
            // btn_deleteMedicine
            // 
            this.btn_deleteMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            this.btn_deleteMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_deleteMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteMedicine.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteMedicine.ForeColor = System.Drawing.Color.White;
            this.btn_deleteMedicine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_deleteMedicine.Location = new System.Drawing.Point(964, 396);
            this.btn_deleteMedicine.Name = "btn_deleteMedicine";
            this.btn_deleteMedicine.Size = new System.Drawing.Size(130, 40);
            this.btn_deleteMedicine.TabIndex = 51;
            this.btn_deleteMedicine.Text = " Delete Medicine";
            this.btn_deleteMedicine.UseVisualStyleBackColor = false;
            this.btn_deleteMedicine.Visible = false;
            this.btn_deleteMedicine.Click += new System.EventHandler(this.btn_deleteMedicine_Click);
            // 
            // medicineSearchBox
            // 
            this.medicineSearchBox.BackColor = System.Drawing.Color.White;
            this.medicineSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicineSearchBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineSearchBox.Location = new System.Drawing.Point(864, 22);
            this.medicineSearchBox.Name = "medicineSearchBox";
            this.medicineSearchBox.Size = new System.Drawing.Size(230, 25);
            this.medicineSearchBox.TabIndex = 50;
            this.medicineSearchBox.Text = "Search Medicines. . . . .";
            this.medicineSearchBox.TextChanged += new System.EventHandler(this.medicineSearchBox_TextChanged);
            this.medicineSearchBox.Enter += new System.EventHandler(this.medicineSearchBox_Enter);
            // 
            // showMedicinesDataGrid
            // 
            this.showMedicinesDataGrid.AllowUserToAddRows = false;
            this.showMedicinesDataGrid.AllowUserToDeleteRows = false;
            this.showMedicinesDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showMedicinesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.showMedicinesDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.showMedicinesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showMedicinesDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.showMedicinesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.showMedicinesDataGrid.ColumnHeadersHeight = 35;
            this.showMedicinesDataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.showMedicinesDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.showMedicinesDataGrid.EnableHeadersVisualStyles = false;
            this.showMedicinesDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(80)))), ((int)(((byte)(247)))));
            this.showMedicinesDataGrid.Location = new System.Drawing.Point(372, 61);
            this.showMedicinesDataGrid.Name = "showMedicinesDataGrid";
            this.showMedicinesDataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showMedicinesDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.showMedicinesDataGrid.RowHeadersVisible = false;
            this.showMedicinesDataGrid.RowHeadersWidth = 40;
            this.showMedicinesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showMedicinesDataGrid.Size = new System.Drawing.Size(722, 323);
            this.showMedicinesDataGrid.TabIndex = 49;
            this.showMedicinesDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showMedicinesDataGrid_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(366, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 32);
            this.label9.TabIndex = 48;
            this.label9.Text = "All Medicines";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 32);
            this.label3.TabIndex = 42;
            this.label3.Text = " Add Medicines";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(138, 396);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 40);
            this.btnReset.TabIndex = 41;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btn_addMedicine
            // 
            this.btn_addMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            this.btn_addMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_addMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addMedicine.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addMedicine.ForeColor = System.Drawing.Color.White;
            this.btn_addMedicine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_addMedicine.Location = new System.Drawing.Point(14, 396);
            this.btn_addMedicine.Name = "btn_addMedicine";
            this.btn_addMedicine.Size = new System.Drawing.Size(118, 40);
            this.btn_addMedicine.TabIndex = 40;
            this.btn_addMedicine.Text = "Add Medicine";
            this.btn_addMedicine.UseVisualStyleBackColor = false;
            this.btn_addMedicine.Click += new System.EventHandler(this.btn_addMedicine_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.expire_date);
            this.panel1.Controls.Add(this.manufacturing_date);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.medicine_quantity);
            this.panel1.Controls.Add(this.medicine_description);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.medicine_price);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.medicine_code);
            this.panel1.Controls.Add(this.category_combo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.medicine_name);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 336);
            this.panel1.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label10.Location = new System.Drawing.Point(168, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 71;
            this.label10.Text = "Expire Date";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label7.Location = new System.Drawing.Point(4, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 70;
            this.label7.Text = "Manufactured";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // expire_date
            // 
            this.expire_date.CustomFormat = "yyyy-MM-dd";
            this.expire_date.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.expire_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expire_date.Location = new System.Drawing.Point(171, 300);
            this.expire_date.MinDate = new System.DateTime(2022, 12, 1, 0, 0, 0, 0);
            this.expire_date.Name = "expire_date";
            this.expire_date.Size = new System.Drawing.Size(163, 25);
            this.expire_date.TabIndex = 69;
            // 
            // manufacturing_date
            // 
            this.manufacturing_date.CustomFormat = "yyyy-MM-dd";
            this.manufacturing_date.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.manufacturing_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.manufacturing_date.Location = new System.Drawing.Point(7, 300);
            this.manufacturing_date.MinDate = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            this.manufacturing_date.Name = "manufacturing_date";
            this.manufacturing_date.Size = new System.Drawing.Size(158, 25);
            this.manufacturing_date.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 67;
            this.label6.Text = "Quantity";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // medicine_quantity
            // 
            this.medicine_quantity.BackColor = System.Drawing.Color.White;
            this.medicine_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicine_quantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicine_quantity.Location = new System.Drawing.Point(171, 243);
            this.medicine_quantity.Name = "medicine_quantity";
            this.medicine_quantity.Size = new System.Drawing.Size(163, 25);
            this.medicine_quantity.TabIndex = 66;
            // 
            // medicine_description
            // 
            this.medicine_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicine_description.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.medicine_description.Location = new System.Drawing.Point(7, 132);
            this.medicine_description.Name = "medicine_description";
            this.medicine_description.Size = new System.Drawing.Size(327, 86);
            this.medicine_description.TabIndex = 65;
            this.medicine_description.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(168, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 64;
            this.label8.Text = "Price";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // medicine_price
            // 
            this.medicine_price.BackColor = System.Drawing.Color.White;
            this.medicine_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicine_price.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicine_price.Location = new System.Drawing.Point(171, 76);
            this.medicine_price.Name = "medicine_price";
            this.medicine_price.Size = new System.Drawing.Size(163, 25);
            this.medicine_price.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 63;
            this.label5.Text = "Medicine Code";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // medicine_code
            // 
            this.medicine_code.BackColor = System.Drawing.Color.White;
            this.medicine_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicine_code.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicine_code.Location = new System.Drawing.Point(7, 76);
            this.medicine_code.Name = "medicine_code";
            this.medicine_code.Size = new System.Drawing.Size(158, 25);
            this.medicine_code.TabIndex = 61;
            // 
            // category_combo
            // 
            this.category_combo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.category_combo.FormattingEnabled = true;
            this.category_combo.Location = new System.Drawing.Point(7, 243);
            this.category_combo.Name = "category_combo";
            this.category_combo.Size = new System.Drawing.Size(158, 25);
            this.category_combo.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(4, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Description";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(3, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Category";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "Medicine Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // medicine_name
            // 
            this.medicine_name.BackColor = System.Drawing.Color.White;
            this.medicine_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicine_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicine_name.Location = new System.Drawing.Point(7, 22);
            this.medicine_name.Name = "medicine_name";
            this.medicine_name.Size = new System.Drawing.Size(327, 25);
            this.medicine_name.TabIndex = 48;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(541, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 132;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ManageMedicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_editMedicine);
            this.Controls.Add(this.btn_deleteMedicine);
            this.Controls.Add(this.medicineSearchBox);
            this.Controls.Add(this.showMedicinesDataGrid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btn_addMedicine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "ManageMedicines";
            this.Text = "ManageMedicines";
            this.Load += new System.EventHandler(this.ManageMedicines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showMedicinesDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_editMedicine;
        private System.Windows.Forms.Button btn_deleteMedicine;
        private System.Windows.Forms.TextBox medicineSearchBox;
        private System.Windows.Forms.DataGridView showMedicinesDataGrid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btn_addMedicine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox category_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox medicine_name;
        private System.Windows.Forms.DateTimePicker manufacturing_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox medicine_quantity;
        private System.Windows.Forms.RichTextBox medicine_description;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox medicine_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox medicine_code;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker expire_date;
        private System.Windows.Forms.PictureBox btnRefresh;
    }
}