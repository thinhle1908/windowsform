namespace Bai7
{
    partial class frmBai8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lsNumber = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnXoaPhanTuDauCuoi = new System.Windows.Forms.Button();
            this.btnXoaPhanTuDangChon = new System.Windows.Forms.Button();
            this.btnTangGiaTriPhanTu = new System.Windows.Forms.Button();
            this.btnThayBangBinhPhuong = new System.Windows.Forms.Button();
            this.btnChonSoChan = new System.Windows.Forms.Button();
            this.btnChonSoLe = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTBOX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Listbox";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(37, 60);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(141, 20);
            this.txtNhap.TabIndex = 2;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(37, 87);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(141, 23);
            this.btnNhap.TabIndex = 3;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lsNumber
            // 
            this.lsNumber.FormattingEnabled = true;
            this.lsNumber.Location = new System.Drawing.Point(37, 126);
            this.lsNumber.Name = "lsNumber";
            this.lsNumber.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsNumber.Size = new System.Drawing.Size(141, 134);
            this.lsNumber.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChonSoLe);
            this.groupBox1.Controls.Add(this.btnChonSoChan);
            this.groupBox1.Controls.Add(this.btnThayBangBinhPhuong);
            this.groupBox1.Controls.Add(this.btnTangGiaTriPhanTu);
            this.groupBox1.Controls.Add(this.btnXoaPhanTuDangChon);
            this.groupBox1.Controls.Add(this.btnXoaPhanTuDauCuoi);
            this.groupBox1.Controls.Add(this.btnTong);
            this.groupBox1.Location = new System.Drawing.Point(202, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 217);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xử lý listbox";
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(7, 13);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(231, 23);
            this.btnTong.TabIndex = 0;
            this.btnTong.Text = "Tông hợp các phần tử trong list";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnXoaPhanTuDauCuoi
            // 
            this.btnXoaPhanTuDauCuoi.Location = new System.Drawing.Point(6, 42);
            this.btnXoaPhanTuDauCuoi.Name = "btnXoaPhanTuDauCuoi";
            this.btnXoaPhanTuDauCuoi.Size = new System.Drawing.Size(231, 23);
            this.btnXoaPhanTuDauCuoi.TabIndex = 0;
            this.btnXoaPhanTuDauCuoi.Text = "Xóa phần tử đầu và phần tử cuối";
            this.btnXoaPhanTuDauCuoi.UseVisualStyleBackColor = true;
            this.btnXoaPhanTuDauCuoi.Click += new System.EventHandler(this.btnXoaPhanTuDauCuoi_Click);
            // 
            // btnXoaPhanTuDangChon
            // 
            this.btnXoaPhanTuDangChon.Location = new System.Drawing.Point(7, 71);
            this.btnXoaPhanTuDangChon.Name = "btnXoaPhanTuDangChon";
            this.btnXoaPhanTuDangChon.Size = new System.Drawing.Size(231, 23);
            this.btnXoaPhanTuDangChon.TabIndex = 0;
            this.btnXoaPhanTuDangChon.Text = "Xóa Phần Tử Đang Chọn";
            this.btnXoaPhanTuDangChon.UseVisualStyleBackColor = true;
            this.btnXoaPhanTuDangChon.Click += new System.EventHandler(this.btnXoaPhanTuDangChon_Click);
            // 
            // btnTangGiaTriPhanTu
            // 
            this.btnTangGiaTriPhanTu.Location = new System.Drawing.Point(7, 100);
            this.btnTangGiaTriPhanTu.Name = "btnTangGiaTriPhanTu";
            this.btnTangGiaTriPhanTu.Size = new System.Drawing.Size(231, 23);
            this.btnTangGiaTriPhanTu.TabIndex = 0;
            this.btnTangGiaTriPhanTu.Text = "Tăng mỗi phần tử lên 2";
            this.btnTangGiaTriPhanTu.UseVisualStyleBackColor = true;
            this.btnTangGiaTriPhanTu.Click += new System.EventHandler(this.btnTangGiaTriPhanTu_Click);
            // 
            // btnThayBangBinhPhuong
            // 
            this.btnThayBangBinhPhuong.Location = new System.Drawing.Point(7, 129);
            this.btnThayBangBinhPhuong.Name = "btnThayBangBinhPhuong";
            this.btnThayBangBinhPhuong.Size = new System.Drawing.Size(231, 23);
            this.btnThayBangBinhPhuong.TabIndex = 0;
            this.btnThayBangBinhPhuong.Text = "Thay bằng bình phương";
            this.btnThayBangBinhPhuong.UseVisualStyleBackColor = true;
            this.btnThayBangBinhPhuong.Click += new System.EventHandler(this.btnThayBangBinhPhuong_Click);
            // 
            // btnChonSoChan
            // 
            this.btnChonSoChan.Location = new System.Drawing.Point(7, 158);
            this.btnChonSoChan.Name = "btnChonSoChan";
            this.btnChonSoChan.Size = new System.Drawing.Size(231, 23);
            this.btnChonSoChan.TabIndex = 0;
            this.btnChonSoChan.Text = "Chọn số chẵn";
            this.btnChonSoChan.UseVisualStyleBackColor = true;
            this.btnChonSoChan.Click += new System.EventHandler(this.btnChonSoChan_Click);
            // 
            // btnChonSoLe
            // 
            this.btnChonSoLe.Location = new System.Drawing.Point(6, 187);
            this.btnChonSoLe.Name = "btnChonSoLe";
            this.btnChonSoLe.Size = new System.Drawing.Size(231, 23);
            this.btnChonSoLe.TabIndex = 0;
            this.btnChonSoLe.Text = "Chọn số lẻ";
            this.btnChonSoLe.UseVisualStyleBackColor = true;
            this.btnChonSoLe.Click += new System.EventHandler(this.btnChonSoLe_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(37, 276);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(402, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "&Kết thúc";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Bai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsNumber);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai8";
            this.Text = "Bai8";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.ListBox lsNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChonSoLe;
        private System.Windows.Forms.Button btnChonSoChan;
        private System.Windows.Forms.Button btnThayBangBinhPhuong;
        private System.Windows.Forms.Button btnTangGiaTriPhanTu;
        private System.Windows.Forms.Button btnXoaPhanTuDangChon;
        private System.Windows.Forms.Button btnXoaPhanTuDauCuoi;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button button7;
    }
}