
namespace MedioSoft
{
    partial class medicineValidationCheck
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
            this.divider = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_btnCheck = new System.Windows.Forms.Button();
            this.validationBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_valid_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(210)))), ((int)(((byte)(46)))));
            this.divider.Location = new System.Drawing.Point(367, 185);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(371, 2);
            this.divider.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(395, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(316, 32);
            this.label8.TabIndex = 60;
            this.label8.Text = "Check Medicine Validation";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_btnCheck
            // 
            this.btn_btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(210)))), ((int)(((byte)(46)))));
            this.btn_btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_btnCheck.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_btnCheck.ForeColor = System.Drawing.Color.White;
            this.btn_btnCheck.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_btnCheck.Location = new System.Drawing.Point(602, 223);
            this.btn_btnCheck.Name = "btn_btnCheck";
            this.btn_btnCheck.Size = new System.Drawing.Size(136, 31);
            this.btn_btnCheck.TabIndex = 79;
            this.btn_btnCheck.Text = "Check";
            this.btn_btnCheck.UseVisualStyleBackColor = false;
            this.btn_btnCheck.Click += new System.EventHandler(this.btn_btnCheck_Click);
            // 
            // validationBox
            // 
            this.validationBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.validationBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationBox.Location = new System.Drawing.Point(367, 225);
            this.validationBox.Name = "validationBox";
            this.validationBox.Size = new System.Drawing.Size(215, 27);
            this.validationBox.TabIndex = 81;
            this.validationBox.Text = "Enter Medicine Code";
            this.validationBox.Enter += new System.EventHandler(this.validationBox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(452, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 82;
            this.label1.Text = "This Medicine Is :";
            // 
            // label_valid_result
            // 
            this.label_valid_result.AutoSize = true;
            this.label_valid_result.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_valid_result.Location = new System.Drawing.Point(598, 283);
            this.label_valid_result.Name = "label_valid_result";
            this.label_valid_result.Size = new System.Drawing.Size(50, 19);
            this.label_valid_result.TabIndex = 83;
            this.label_valid_result.Text = "Valid";
            this.label_valid_result.Visible = false;
            // 
            // medicineValidationCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.label_valid_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.validationBox);
            this.Controls.Add(this.btn_btnCheck);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "medicineValidationCheck";
            this.Text = "medicineValidationCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel divider;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_btnCheck;
        private System.Windows.Forms.TextBox validationBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_valid_result;
    }
}