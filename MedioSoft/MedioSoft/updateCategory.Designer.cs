
namespace MedioSoft
{
    partial class updateCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateCategory));
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.divider = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_updateCat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.category_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(411, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 29);
            this.btnExit.TabIndex = 71;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.White;
            this.divider.Location = new System.Drawing.Point(22, 54);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(421, 2);
            this.divider.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 32);
            this.label3.TabIndex = 62;
            this.label3.Text = "Update Category";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_updateCat
            // 
            this.btn_updateCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(5)))));
            this.btn_updateCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_updateCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateCat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateCat.ForeColor = System.Drawing.Color.White;
            this.btn_updateCat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_updateCat.Location = new System.Drawing.Point(23, 130);
            this.btn_updateCat.Name = "btn_updateCat";
            this.btn_updateCat.Size = new System.Drawing.Size(133, 30);
            this.btn_updateCat.TabIndex = 61;
            this.btn_updateCat.Text = "Update Category";
            this.btn_updateCat.UseVisualStyleBackColor = false;
            this.btn_updateCat.Click += new System.EventHandler(this.btn_updateCat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "Category Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // category_name
            // 
            this.category_name.BackColor = System.Drawing.Color.White;
            this.category_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_name.Location = new System.Drawing.Point(23, 90);
            this.category_name.Name = "category_name";
            this.category_name.Size = new System.Drawing.Size(218, 25);
            this.category_name.TabIndex = 52;
            // 
            // updateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(460, 338);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_updateCat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.category_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "updateCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updateCategory";
            this.Load += new System.EventHandler(this.updateCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Panel divider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_updateCat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox category_name;
    }
}