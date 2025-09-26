namespace B3_BTTH1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.cbbox = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ltBox = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSumOdd = new System.Windows.Forms.Button();
            this.btnSumEven = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhap);
            this.groupBox1.Controls.Add(this.cbbox);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(84, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(302, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số:";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(16, 47);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(177, 30);
            this.txtNhap.TabIndex = 2;
            // 
            // cbbox
            // 
            this.cbbox.FormattingEnabled = true;
            this.cbbox.Location = new System.Drawing.Point(16, 89);
            this.cbbox.Name = "cbbox";
            this.cbbox.Size = new System.Drawing.Size(265, 31);
            this.cbbox.TabIndex = 1;
            this.cbbox.SelectedIndexChanged += new System.EventHandler(this.cbbox_SelectedIndexChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(199, 42);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(82, 41);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ltBox);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(449, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(302, 140);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số:";
            // 
            // ltBox
            // 
            this.ltBox.FormattingEnabled = true;
            this.ltBox.ItemHeight = 23;
            this.ltBox.Location = new System.Drawing.Point(19, 42);
            this.ltBox.Name = "ltBox";
            this.ltBox.Size = new System.Drawing.Size(277, 73);
            this.ltBox.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(283, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 41);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.Location = new System.Drawing.Point(449, 262);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(302, 41);
            this.btnSum.TabIndex = 0;
            this.btnSum.Text = "Tổng các ước số";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnSumOdd
            // 
            this.btnSumOdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumOdd.Location = new System.Drawing.Point(449, 356);
            this.btnSumOdd.Name = "btnSumOdd";
            this.btnSumOdd.Size = new System.Drawing.Size(302, 41);
            this.btnSumOdd.TabIndex = 0;
            this.btnSumOdd.Text = "Số lượng các ước số lẻ";
            this.btnSumOdd.UseVisualStyleBackColor = true;
            this.btnSumOdd.Click += new System.EventHandler(this.btnSumOdd_Click);
            // 
            // btnSumEven
            // 
            this.btnSumEven.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumEven.Location = new System.Drawing.Point(449, 309);
            this.btnSumEven.Name = "btnSumEven";
            this.btnSumEven.Size = new System.Drawing.Size(302, 41);
            this.btnSumEven.TabIndex = 0;
            this.btnSumEven.Text = "Số lượng các ước số chẵn";
            this.btnSumEven.UseVisualStyleBackColor = true;
            this.btnSumEven.Click += new System.EventHandler(this.btnSumEven_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSumOdd);
            this.Controls.Add(this.btnSumEven);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ComboBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.ComboBox cbbox;
        private System.Windows.Forms.ListBox ltBox;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnSumOdd;
        private System.Windows.Forms.Button btnSumEven;
    }
}
