
namespace MedioSoft
{
    partial class medicineCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_OderMedicine = new System.Windows.Forms.Button();
            this.medicineSearchBox = new System.Windows.Forms.TextBox();
            this.displayMedicinesDataGrid = new System.Windows.Forms.DataGridView();
            this.divider = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.quantityBox = new System.Windows.Forms.NumericUpDown();
            this.label_quatity = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_price_value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayMedicinesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OderMedicine
            // 
            this.btn_OderMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(210)))), ((int)(((byte)(46)))));
            this.btn_OderMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_OderMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OderMedicine.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OderMedicine.ForeColor = System.Drawing.Color.White;
            this.btn_OderMedicine.Location = new System.Drawing.Point(957, 386);
            this.btn_OderMedicine.Name = "btn_OderMedicine";
            this.btn_OderMedicine.Size = new System.Drawing.Size(113, 35);
            this.btn_OderMedicine.TabIndex = 35;
            this.btn_OderMedicine.Text = "Order Now";
            this.btn_OderMedicine.UseVisualStyleBackColor = false;
            this.btn_OderMedicine.Visible = false;
            this.btn_OderMedicine.Click += new System.EventHandler(this.btn_OderMedicine_Click);
            // 
            // medicineSearchBox
            // 
            this.medicineSearchBox.BackColor = System.Drawing.Color.White;
            this.medicineSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicineSearchBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineSearchBox.Location = new System.Drawing.Point(840, 33);
            this.medicineSearchBox.Name = "medicineSearchBox";
            this.medicineSearchBox.Size = new System.Drawing.Size(230, 25);
            this.medicineSearchBox.TabIndex = 33;
            this.medicineSearchBox.Text = "Search Medicine . . . . .";
            this.medicineSearchBox.TextChanged += new System.EventHandler(this.medicineSearchBox_TextChanged);
            this.medicineSearchBox.Enter += new System.EventHandler(this.medicineSearchBox_Enter);
            // 
            // displayMedicinesDataGrid
            // 
            this.displayMedicinesDataGrid.AllowUserToAddRows = false;
            this.displayMedicinesDataGrid.AllowUserToDeleteRows = false;
            this.displayMedicinesDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayMedicinesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.displayMedicinesDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.displayMedicinesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayMedicinesDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(210)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(210)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.displayMedicinesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.displayMedicinesDataGrid.ColumnHeadersHeight = 35;
            this.displayMedicinesDataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.displayMedicinesDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.displayMedicinesDataGrid.EnableHeadersVisualStyles = false;
            this.displayMedicinesDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(210)))), ((int)(((byte)(46)))));
            this.displayMedicinesDataGrid.Location = new System.Drawing.Point(32, 76);
            this.displayMedicinesDataGrid.Name = "displayMedicinesDataGrid";
            this.displayMedicinesDataGrid.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.displayMedicinesDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.displayMedicinesDataGrid.RowHeadersVisible = false;
            this.displayMedicinesDataGrid.RowHeadersWidth = 40;
            this.displayMedicinesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.displayMedicinesDataGrid.Size = new System.Drawing.Size(1038, 289);
            this.displayMedicinesDataGrid.TabIndex = 32;
            this.displayMedicinesDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayMedicinesDataGrid_CellClick);
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(210)))), ((int)(((byte)(46)))));
            this.divider.Location = new System.Drawing.Point(31, 56);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(348, 2);
            this.divider.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(26, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 32);
            this.label8.TabIndex = 58;
            this.label8.Text = "MedioSoft Medicines";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quantityBox
            // 
            this.quantityBox.BackColor = System.Drawing.Color.White;
            this.quantityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityBox.Location = new System.Drawing.Point(840, 388);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(90, 33);
            this.quantityBox.TabIndex = 60;
            this.quantityBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityBox.Visible = false;
            this.quantityBox.ValueChanged += new System.EventHandler(this.quantityBox_ValueChanged);
            // 
            // label_quatity
            // 
            this.label_quatity.AutoSize = true;
            this.label_quatity.BackColor = System.Drawing.Color.Transparent;
            this.label_quatity.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quatity.ForeColor = System.Drawing.Color.Black;
            this.label_quatity.Location = new System.Drawing.Point(686, 390);
            this.label_quatity.Name = "label_quatity";
            this.label_quatity.Size = new System.Drawing.Size(139, 25);
            this.label_quatity.TabIndex = 61;
            this.label_quatity.Text = "Select Quanity";
            this.label_quatity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_quatity.Visible = false;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.BackColor = System.Drawing.Color.Transparent;
            this.label_price.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.ForeColor = System.Drawing.Color.Black;
            this.label_price.Location = new System.Drawing.Point(516, 390);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(66, 25);
            this.label_price.TabIndex = 63;
            this.label_price.Text = "Price :";
            this.label_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_price.Visible = false;
            // 
            // label_price_value
            // 
            this.label_price_value.AutoSize = true;
            this.label_price_value.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label_price_value.Location = new System.Drawing.Point(604, 390);
            this.label_price_value.Name = "label_price_value";
            this.label_price_value.Size = new System.Drawing.Size(66, 25);
            this.label_price_value.TabIndex = 64;
            this.label_price_value.Text = "500.00";
            this.label_price_value.Visible = false;
            // 
            // medicineCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.label_price_value);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_quatity);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_OderMedicine);
            this.Controls.Add(this.medicineSearchBox);
            this.Controls.Add(this.displayMedicinesDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "medicineCustomers";
            this.Text = "medicineCustomers";
            this.Load += new System.EventHandler(this.medicineCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayMedicinesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OderMedicine;
        private System.Windows.Forms.TextBox medicineSearchBox;
        private System.Windows.Forms.DataGridView displayMedicinesDataGrid;
        private System.Windows.Forms.Panel divider;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown quantityBox;
        private System.Windows.Forms.Label label_quatity;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_price_value;
    }
}