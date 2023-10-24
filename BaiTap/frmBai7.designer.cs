namespace Bai7
{
    partial class frmBai7
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
            this.cboNumber = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsUocSo = new System.Windows.Forms.ListBox();
            this.btnTongUoc = new System.Windows.Forms.Button();
            this.btnSoLuongSoChan = new System.Windows.Forms.Button();
            this.btnSoLuongUocNguyenTo = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboNumber);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.txtNhapSo);
            this.groupBox1.Location = new System.Drawing.Point(31, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Số";
            // 
            // cboNumber
            // 
            this.cboNumber.FormattingEnabled = true;
            this.cboNumber.Location = new System.Drawing.Point(6, 69);
            this.cboNumber.Name = "cboNumber";
            this.cboNumber.Size = new System.Drawing.Size(188, 21);
            this.cboNumber.TabIndex = 2;
            this.cboNumber.SelectedIndexChanged += new System.EventHandler(this.cboNumber_SelectedIndexChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(119, 28);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "&Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(6, 31);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(100, 20);
            this.txtNhapSo.TabIndex = 0;
            this.txtNhapSo.TextChanged += new System.EventHandler(this.txtNhapSo_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsUocSo);
            this.groupBox2.Location = new System.Drawing.Point(270, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách ";
            // 
            // lsUocSo
            // 
            this.lsUocSo.FormattingEnabled = true;
            this.lsUocSo.Location = new System.Drawing.Point(6, 19);
            this.lsUocSo.Name = "lsUocSo";
            this.lsUocSo.Size = new System.Drawing.Size(188, 69);
            this.lsUocSo.TabIndex = 0;
            this.lsUocSo.SelectedIndexChanged += new System.EventHandler(this.lsUocSo_SelectedIndexChanged);
            // 
            // btnTongUoc
            // 
            this.btnTongUoc.Location = new System.Drawing.Point(276, 180);
            this.btnTongUoc.Name = "btnTongUoc";
            this.btnTongUoc.Size = new System.Drawing.Size(188, 23);
            this.btnTongUoc.TabIndex = 2;
            this.btnTongUoc.Text = "&Tổng các ước số";
            this.btnTongUoc.UseVisualStyleBackColor = true;
            this.btnTongUoc.Click += new System.EventHandler(this.btnTongUoc_Click);
            // 
            // btnSoLuongSoChan
            // 
            this.btnSoLuongSoChan.Location = new System.Drawing.Point(276, 209);
            this.btnSoLuongSoChan.Name = "btnSoLuongSoChan";
            this.btnSoLuongSoChan.Size = new System.Drawing.Size(188, 23);
            this.btnSoLuongSoChan.TabIndex = 2;
            this.btnSoLuongSoChan.Text = "Số lượng các số chẵn";
            this.btnSoLuongSoChan.UseVisualStyleBackColor = true;
            this.btnSoLuongSoChan.Click += new System.EventHandler(this.btnSoLuongSoChan_Click);
            // 
            // btnSoLuongUocNguyenTo
            // 
            this.btnSoLuongUocNguyenTo.Location = new System.Drawing.Point(276, 238);
            this.btnSoLuongUocNguyenTo.Name = "btnSoLuongUocNguyenTo";
            this.btnSoLuongUocNguyenTo.Size = new System.Drawing.Size(188, 23);
            this.btnSoLuongUocNguyenTo.TabIndex = 2;
            this.btnSoLuongUocNguyenTo.Text = "Số lượng các ước số &nguyên tố";
            this.btnSoLuongUocNguyenTo.UseVisualStyleBackColor = true;
            this.btnSoLuongUocNguyenTo.Click += new System.EventHandler(this.btnSoLuongUocNguyenTo_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(150, 238);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmBai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSoLuongUocNguyenTo);
            this.Controls.Add(this.btnSoLuongSoChan);
            this.Controls.Add(this.btnTongUoc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBai7";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboNumber;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lsUocSo;
        private System.Windows.Forms.Button btnTongUoc;
        private System.Windows.Forms.Button btnSoLuongSoChan;
        private System.Windows.Forms.Button btnSoLuongUocNguyenTo;
        private System.Windows.Forms.Button button5;
    }
}

