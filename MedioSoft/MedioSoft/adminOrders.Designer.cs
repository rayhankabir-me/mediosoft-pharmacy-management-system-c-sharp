
namespace MedioSoft
{
    partial class adminOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminOrders));
            this.btn_printInvoice = new System.Windows.Forms.Button();
            this.btn_modifyOrder = new System.Windows.Forms.Button();
            this.showCustomersOrdersDataGrid = new System.Windows.Forms.DataGridView();
            this.btn_deleteOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label_order_status = new System.Windows.Forms.Label();
            this.label_order_quantity = new System.Windows.Forms.Label();
            this.label_medicine_code = new System.Windows.Forms.Label();
            this.label_customer_name = new System.Windows.Forms.Label();
            this.label_order_price = new System.Windows.Forms.Label();
            this.label_medicine_name = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userSearchBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_order_date = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.showCustomersOrdersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_printInvoice
            // 
            this.btn_printInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            this.btn_printInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_printInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_printInvoice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printInvoice.ForeColor = System.Drawing.Color.White;
            this.btn_printInvoice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_printInvoice.Location = new System.Drawing.Point(33, 365);
            this.btn_printInvoice.Name = "btn_printInvoice";
            this.btn_printInvoice.Size = new System.Drawing.Size(127, 38);
            this.btn_printInvoice.TabIndex = 127;
            this.btn_printInvoice.Text = "Print Invoice";
            this.btn_printInvoice.UseVisualStyleBackColor = false;
            this.btn_printInvoice.Visible = false;
            // 
            // btn_modifyOrder
            // 
            this.btn_modifyOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            this.btn_modifyOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_modifyOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifyOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifyOrder.ForeColor = System.Drawing.Color.White;
            this.btn_modifyOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_modifyOrder.Location = new System.Drawing.Point(812, 388);
            this.btn_modifyOrder.Name = "btn_modifyOrder";
            this.btn_modifyOrder.Size = new System.Drawing.Size(127, 38);
            this.btn_modifyOrder.TabIndex = 126;
            this.btn_modifyOrder.Text = "Update Order";
            this.btn_modifyOrder.UseVisualStyleBackColor = false;
            this.btn_modifyOrder.Visible = false;
            this.btn_modifyOrder.Click += new System.EventHandler(this.btn_modifyOrder_Click);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.showCustomersOrdersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.showCustomersOrdersDataGrid.ColumnHeadersHeight = 35;
            this.showCustomersOrdersDataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.showCustomersOrdersDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.showCustomersOrdersDataGrid.EnableHeadersVisualStyles = false;
            this.showCustomersOrdersDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(80)))), ((int)(((byte)(247)))));
            this.showCustomersOrdersDataGrid.Location = new System.Drawing.Point(663, 97);
            this.showCustomersOrdersDataGrid.Name = "showCustomersOrdersDataGrid";
            this.showCustomersOrdersDataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showCustomersOrdersDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.showCustomersOrdersDataGrid.RowHeadersVisible = false;
            this.showCustomersOrdersDataGrid.RowHeadersWidth = 40;
            this.showCustomersOrdersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showCustomersOrdersDataGrid.Size = new System.Drawing.Size(409, 277);
            this.showCustomersOrdersDataGrid.TabIndex = 125;
            this.showCustomersOrdersDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showCustomersOrdersDataGrid_CellClick);
            // 
            // btn_deleteOrder
            // 
            this.btn_deleteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            this.btn_deleteOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_deleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteOrder.ForeColor = System.Drawing.Color.White;
            this.btn_deleteOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_deleteOrder.Location = new System.Drawing.Point(945, 388);
            this.btn_deleteOrder.Name = "btn_deleteOrder";
            this.btn_deleteOrder.Size = new System.Drawing.Size(127, 38);
            this.btn_deleteOrder.TabIndex = 124;
            this.btn_deleteOrder.Text = "Delete Order";
            this.btn_deleteOrder.UseVisualStyleBackColor = false;
            this.btn_deleteOrder.Visible = false;
            this.btn_deleteOrder.Click += new System.EventHandler(this.btn_deleteOrder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            this.panel1.Location = new System.Drawing.Point(663, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 2);
            this.panel1.TabIndex = 123;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(658, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 32);
            this.label16.TabIndex = 122;
            this.label16.Text = "All Orders";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_order_status
            // 
            this.label_order_status.AutoSize = true;
            this.label_order_status.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_order_status.Location = new System.Drawing.Point(227, 271);
            this.label_order_status.Name = "label_order_status";
            this.label_order_status.Size = new System.Drawing.Size(92, 21);
            this.label_order_status.TabIndex = 121;
            this.label_order_status.Text = "processing";
            // 
            // label_order_quantity
            // 
            this.label_order_quantity.AutoSize = true;
            this.label_order_quantity.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_order_quantity.Location = new System.Drawing.Point(227, 236);
            this.label_order_quantity.Name = "label_order_quantity";
            this.label_order_quantity.Size = new System.Drawing.Size(28, 21);
            this.label_order_quantity.TabIndex = 120;
            this.label_order_quantity.Text = "10";
            // 
            // label_medicine_code
            // 
            this.label_medicine_code.AutoSize = true;
            this.label_medicine_code.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_medicine_code.Location = new System.Drawing.Point(227, 166);
            this.label_medicine_code.Name = "label_medicine_code";
            this.label_medicine_code.Size = new System.Drawing.Size(130, 21);
            this.label_medicine_code.TabIndex = 119;
            this.label_medicine_code.Text = "Medicine Code";
            // 
            // label_customer_name
            // 
            this.label_customer_name.AutoSize = true;
            this.label_customer_name.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_customer_name.Location = new System.Drawing.Point(227, 131);
            this.label_customer_name.Name = "label_customer_name";
            this.label_customer_name.Size = new System.Drawing.Size(138, 21);
            this.label_customer_name.TabIndex = 118;
            this.label_customer_name.Text = "Customer Name";
            // 
            // label_order_price
            // 
            this.label_order_price.AutoSize = true;
            this.label_order_price.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_order_price.Location = new System.Drawing.Point(227, 201);
            this.label_order_price.Name = "label_order_price";
            this.label_order_price.Size = new System.Drawing.Size(59, 21);
            this.label_order_price.TabIndex = 117;
            this.label_order_price.Text = "500.00";
            // 
            // label_medicine_name
            // 
            this.label_medicine_name.AutoSize = true;
            this.label_medicine_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_medicine_name.Location = new System.Drawing.Point(227, 97);
            this.label_medicine_name.Name = "label_medicine_name";
            this.label_medicine_name.Size = new System.Drawing.Size(134, 21);
            this.label_medicine_name.TabIndex = 116;
            this.label_medicine_name.Text = "Medicine Name";
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            this.divider.Location = new System.Drawing.Point(33, 64);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(480, 2);
            this.divider.TabIndex = 115;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(28, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 32);
            this.label8.TabIndex = 114;
            this.label8.Text = "Order Summary";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 112;
            this.label6.Text = "Order Status :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 25);
            this.label5.TabIndex = 111;
            this.label5.Text = "Order Quantity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 110;
            this.label4.Text = "Order Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 109;
            this.label3.Text = "Medicine Code :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 113;
            this.label2.Text = "Customer Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 108;
            this.label1.Text = "Medicine Name :";
            // 
            // userSearchBox
            // 
            this.userSearchBox.BackColor = System.Drawing.Color.White;
            this.userSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userSearchBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSearchBox.Location = new System.Drawing.Point(882, 32);
            this.userSearchBox.Name = "userSearchBox";
            this.userSearchBox.Size = new System.Drawing.Size(190, 25);
            this.userSearchBox.TabIndex = 128;
            this.userSearchBox.Text = "Search by Username . . . . .";
            this.userSearchBox.TextChanged += new System.EventHandler(this.userSearchBox_TextChanged);
            this.userSearchBox.Enter += new System.EventHandler(this.userSearchBox_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 25);
            this.label7.TabIndex = 129;
            this.label7.Text = "Order Date :";
            // 
            // label_order_date
            // 
            this.label_order_date.AutoSize = true;
            this.label_order_date.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_order_date.Location = new System.Drawing.Point(227, 309);
            this.label_order_date.Name = "label_order_date";
            this.label_order_date.Size = new System.Drawing.Size(94, 21);
            this.label_order_date.TabIndex = 130;
            this.label_order_date.Text = "order date";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(794, 32);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 131;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // adminOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label_order_date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.userSearchBox);
            this.Controls.Add(this.btn_printInvoice);
            this.Controls.Add(this.btn_modifyOrder);
            this.Controls.Add(this.showCustomersOrdersDataGrid);
            this.Controls.Add(this.btn_deleteOrder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label_order_status);
            this.Controls.Add(this.label_order_quantity);
            this.Controls.Add(this.label_medicine_code);
            this.Controls.Add(this.label_customer_name);
            this.Controls.Add(this.label_order_price);
            this.Controls.Add(this.label_medicine_name);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "adminOrders";
            this.Text = "adminOrders";
            this.Load += new System.EventHandler(this.adminOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showCustomersOrdersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_printInvoice;
        private System.Windows.Forms.Button btn_modifyOrder;
        private System.Windows.Forms.DataGridView showCustomersOrdersDataGrid;
        private System.Windows.Forms.Button btn_deleteOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label_order_status;
        private System.Windows.Forms.Label label_order_quantity;
        private System.Windows.Forms.Label label_medicine_code;
        private System.Windows.Forms.Label label_customer_name;
        private System.Windows.Forms.Label label_order_price;
        private System.Windows.Forms.Label label_medicine_name;
        private System.Windows.Forms.Panel divider;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userSearchBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_order_date;
        private System.Windows.Forms.PictureBox btnRefresh;
    }
}