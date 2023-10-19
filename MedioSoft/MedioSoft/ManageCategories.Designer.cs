
namespace MedioSoft
{
    partial class ManageCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCategories));
            this.btn_editCategory = new System.Windows.Forms.Button();
            this.btn_deleteCategory = new System.Windows.Forms.Button();
            this.catSearchBox = new System.Windows.Forms.TextBox();
            this.showCategoryDataGrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btn_addCategory = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.category_name = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.showCategoryDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_editCategory
            // 
            this.btn_editCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            this.btn_editCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_editCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editCategory.ForeColor = System.Drawing.Color.White;
            this.btn_editCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_editCategory.Location = new System.Drawing.Point(797, 390);
            this.btn_editCategory.Name = "btn_editCategory";
            this.btn_editCategory.Size = new System.Drawing.Size(141, 40);
            this.btn_editCategory.TabIndex = 52;
            this.btn_editCategory.Text = "Modify Category";
            this.btn_editCategory.UseVisualStyleBackColor = false;
            this.btn_editCategory.Visible = false;
            this.btn_editCategory.Click += new System.EventHandler(this.btn_editCategory_Click);
            // 
            // btn_deleteCategory
            // 
            this.btn_deleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            this.btn_deleteCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_deleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteCategory.ForeColor = System.Drawing.Color.White;
            this.btn_deleteCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_deleteCategory.Location = new System.Drawing.Point(944, 390);
            this.btn_deleteCategory.Name = "btn_deleteCategory";
            this.btn_deleteCategory.Size = new System.Drawing.Size(134, 40);
            this.btn_deleteCategory.TabIndex = 51;
            this.btn_deleteCategory.Text = " Delete Category";
            this.btn_deleteCategory.UseVisualStyleBackColor = false;
            this.btn_deleteCategory.Visible = false;
            this.btn_deleteCategory.Click += new System.EventHandler(this.btn_deleteCategory_Click);
            // 
            // catSearchBox
            // 
            this.catSearchBox.BackColor = System.Drawing.Color.White;
            this.catSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.catSearchBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catSearchBox.Location = new System.Drawing.Point(848, 25);
            this.catSearchBox.Name = "catSearchBox";
            this.catSearchBox.Size = new System.Drawing.Size(230, 25);
            this.catSearchBox.TabIndex = 50;
            this.catSearchBox.Text = "Search Category. . . . .";
            this.catSearchBox.TextChanged += new System.EventHandler(this.catSearchBox_TextChanged_2);
            this.catSearchBox.Enter += new System.EventHandler(this.catSearchBox_Enter);
            // 
            // showCategoryDataGrid
            // 
            this.showCategoryDataGrid.AllowUserToAddRows = false;
            this.showCategoryDataGrid.AllowUserToDeleteRows = false;
            this.showCategoryDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showCategoryDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showCategoryDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.showCategoryDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showCategoryDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.showCategoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.showCategoryDataGrid.ColumnHeadersHeight = 35;
            this.showCategoryDataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.showCategoryDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.showCategoryDataGrid.EnableHeadersVisualStyles = false;
            this.showCategoryDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(80)))), ((int)(((byte)(247)))));
            this.showCategoryDataGrid.Location = new System.Drawing.Point(423, 61);
            this.showCategoryDataGrid.Name = "showCategoryDataGrid";
            this.showCategoryDataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showCategoryDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.showCategoryDataGrid.RowHeadersVisible = false;
            this.showCategoryDataGrid.RowHeadersWidth = 40;
            this.showCategoryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showCategoryDataGrid.Size = new System.Drawing.Size(655, 310);
            this.showCategoryDataGrid.TabIndex = 49;
            this.showCategoryDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showCategoryDataGrid_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(417, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 32);
            this.label9.TabIndex = 48;
            this.label9.Text = "All Categories";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 32);
            this.label3.TabIndex = 42;
            this.label3.Text = " Add Categories";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(136, 122);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 40);
            this.btnReset.TabIndex = 41;
            this.btnReset.Text = "Reset Field";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            this.btn_addCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_addCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCategory.ForeColor = System.Drawing.Color.White;
            this.btn_addCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_addCategory.Location = new System.Drawing.Point(17, 122);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(113, 40);
            this.btn_addCategory.TabIndex = 40;
            this.btn_addCategory.Text = "Add Category";
            this.btn_addCategory.UseVisualStyleBackColor = false;
            this.btn_addCategory.Click += new System.EventHandler(this.btn_addCategory_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Category Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // category_name
            // 
            this.category_name.BackColor = System.Drawing.Color.White;
            this.category_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_name.Location = new System.Drawing.Point(17, 84);
            this.category_name.Name = "category_name";
            this.category_name.Size = new System.Drawing.Size(327, 25);
            this.category_name.TabIndex = 31;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(597, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 132;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btn_editCategory);
            this.Controls.Add(this.btn_deleteCategory);
            this.Controls.Add(this.catSearchBox);
            this.Controls.Add(this.showCategoryDataGrid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btn_addCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.category_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ManageCategories";
            this.Text = "ManageCategories";
            this.Load += new System.EventHandler(this.ManageCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showCategoryDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_editCategory;
        private System.Windows.Forms.Button btn_deleteCategory;
        private System.Windows.Forms.TextBox catSearchBox;
        private System.Windows.Forms.DataGridView showCategoryDataGrid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btn_addCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox category_name;
        private System.Windows.Forms.PictureBox btnRefresh;
    }
}