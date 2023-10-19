
namespace MedioSoft
{
    partial class customerOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_cancelOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label_order_status = new System.Windows.Forms.Label();
            this.label_order_quantity = new System.Windows.Forms.Label();
            this.label_medicine_code = new System.Windows.Forms.Label();
            this.label_order_price = new System.Windows.Forms.Label();
            this.label_medicine_name = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showCustomersOrdersDataGrid = new System.Windows.Forms.DataGridView();
            this.btn_printInvoice = new System.Windows.Forms.Button();
            this.label_order_date = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showCustomersOrdersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelOrder
            // 
            this.btn_cancelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            this.btn_cancelOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelOrder.ForeColor = System.Drawing.Color.White;
            this.btn_cancelOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cancelOrder.Location = new System.Drawing.Point(941, 387);
            this.btn_cancelOrder.Name = "btn_cancelOrder";
            this.btn_cancelOrder.Size = new System.Drawing.Size(127, 38);
            this.btn_cancelOrder.TabIndex = 104;
            this.btn_cancelOrder.Text = "Delete Order";
            this.btn_cancelOrder.UseVisualStyleBackColor = false;
            this.btn_cancelOrder.Visible = false;
            this.btn_cancelOrder.Click += new System.EventHandler(this.btn_cancelOrder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            this.panel1.Location = new System.Drawing.Point(659, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 2);
            this.panel1.TabIndex = 102;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(654, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 32);
            this.label16.TabIndex = 101;
            this.label16.Text = "All Orders";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_order_status
            // 
            this.label_order_status.AutoSize = true;
            this.label_order_status.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_order_status.Location = new System.Drawing.Point(223, 235);
            this.label_order_status.Name = "label_order_status";
            this.label_order_status.Size = new System.Drawing.Size(92, 21);
            this.label_order_status.TabIndex = 99;
            this.label_order_status.Text = "processing";
            // 
            // label_order_quantity
            // 
            this.label_order_quantity.AutoSize = true;
            this.label_order_quantity.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_order_quantity.Location = new System.Drawing.Point(223, 200);
            this.label_order_quantity.Name = "label_order_quantity";
            this.label_order_quantity.Size = new System.Drawing.Size(28, 21);
            this.label_order_quantity.TabIndex = 98;
            this.label_order_quantity.Text = "10";
            // 
            // label_medicine_code
            // 
            this.label_medicine_code.AutoSize = true;
            this.label_medicine_code.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_medicine_code.Location = new System.Drawing.Point(223, 130);
            this.label_medicine_code.Name = "label_medicine_code";
            this.label_medicine_code.Size = new System.Drawing.Size(130, 21);
            this.label_medicine_code.TabIndex = 97;
            this.label_medicine_code.Text = "Medicine Code";
            // 
            // label_order_price
            // 
            this.label_order_price.AutoSize = true;
            this.label_order_price.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_order_price.Location = new System.Drawing.Point(223, 165);
            this.label_order_price.Name = "label_order_price";
            this.label_order_price.Size = new System.Drawing.Size(59, 21);
            this.label_order_price.TabIndex = 95;
            this.label_order_price.Text = "500.00";
            // 
            // label_medicine_name
            // 
            this.label_medicine_name.AutoSize = true;
            this.label_medicine_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_medicine_name.Location = new System.Drawing.Point(223, 96);
            this.label_medicine_name.Name = "label_medicine_name";
            this.label_medicine_name.Size = new System.Drawing.Size(134, 21);
            this.label_medicine_name.TabIndex = 94;
            this.label_medicine_name.Text = "Medicine Name";
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            this.divider.Location = new System.Drawing.Point(29, 63);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(480, 2);
            this.divider.TabIndex = 93;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(24, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 32);
            this.label8.TabIndex = 92;
            this.label8.Text = "Order Summary";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 84;
            this.label6.Text = "Order Status :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 25);
            this.label5.TabIndex = 83;
            this.label5.Text = "Order Quantity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 82;
            this.label4.Text = "Order Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 81;
            this.label3.Text = "Medicine Code :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 80;
            this.label1.Text = "Medicine Name :";
            // 
            // showCustomersOrdersDataGrid
            // 
            this.showCustomersOrdersDataGrid.AllowUserToAddRows = false;
            this.showCustomersOrdersDataGrid.AllowUserToDeleteRows = false;
            this.showCustomersOrdersDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showCustomersOrdersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.showCustomersOrdersDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.showCustomersOrdersDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showCustomersOrdersDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.showCustomersOrdersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.showCustomersOrdersDataGrid.ColumnHeadersHeight = 35;
            this.showCustomersOrdersDataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.showCustomersOrdersDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.showCustomersOrdersDataGrid.EnableHeadersVisualStyles = false;
            this.showCustomersOrdersDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(80)))), ((int)(((byte)(247)))));
            this.showCustomersOrdersDataGrid.Location = new System.Drawing.Point(659, 96);
            this.showCustomersOrdersDataGrid.Name = "showCustomersOrdersDataGrid";
            this.showCustomersOrdersDataGrid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showCustomersOrdersDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.showCustomersOrdersDataGrid.RowHeadersVisible = false;
            this.showCustomersOrdersDataGrid.RowHeadersWidth = 40;
            this.showCustomersOrdersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showCustomersOrdersDataGrid.Size = new System.Drawing.Size(409, 277);
            this.showCustomersOrdersDataGrid.TabIndex = 105;
            this.showCustomersOrdersDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showCustomersOrdersDataGrid_CellClick);
            // 
            // btn_printInvoice
            // 
            this.btn_printInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            this.btn_printInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_printInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_printInvoice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printInvoice.ForeColor = System.Drawing.Color.White;
            this.btn_printInvoice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_printInvoice.Location = new System.Drawing.Point(30, 335);
            this.btn_printInvoice.Name = "btn_printInvoice";
            this.btn_printInvoice.Size = new System.Drawing.Size(127, 38);
            this.btn_printInvoice.TabIndex = 107;
            this.btn_printInvoice.Text = "Print Invoice";
            this.btn_printInvoice.UseVisualStyleBackColor = false;
            this.btn_printInvoice.Visible = false;
            // 
            // label_order_date
            // 
            this.label_order_date.AutoSize = true;
            this.label_order_date.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_order_date.Location = new System.Drawing.Point(222, 273);
            this.label_order_date.Name = "label_order_date";
            this.label_order_date.Size = new System.Drawing.Size(94, 21);
            this.label_order_date.TabIndex = 132;
            this.label_order_date.Text = "order date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 25);
            this.label7.TabIndex = 131;
            this.label7.Text = "Order Date :";
            // 
            // customerOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.label_order_date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_printInvoice);
            this.Controls.Add(this.showCustomersOrdersDataGrid);
            this.Controls.Add(this.btn_cancelOrder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label_order_status);
            this.Controls.Add(this.label_order_quantity);
            this.Controls.Add(this.label_medicine_code);
            this.Controls.Add(this.label_order_price);
            this.Controls.Add(this.label_medicine_name);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "customerOrders";
            this.Text = "customerOrders";
            this.Load += new System.EventHandler(this.customerOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showCustomersOrdersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cancelOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label_order_status;
        private System.Windows.Forms.Label label_order_quantity;
        private System.Windows.Forms.Label label_medicine_code;
        private System.Windows.Forms.Label label_order_price;
        private System.Windows.Forms.Label label_medicine_name;
        private System.Windows.Forms.Panel divider;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView showCustomersOrdersDataGrid;
        private System.Windows.Forms.Button btn_printInvoice;
        private System.Windows.Forms.Label label_order_date;
        private System.Windows.Forms.Label label7;
    }
}