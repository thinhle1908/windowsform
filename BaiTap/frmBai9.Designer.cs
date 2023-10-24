namespace BaiTap
{
    partial class frmBai9
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstGroupA = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstGroupB = new System.Windows.Forms.ListBox();
            this.btnToB = new System.Windows.Forms.Button();
            this.btnToA = new System.Windows.Forms.Button();
            this.btnToAllB = new System.Windows.Forms.Button();
            this.btnToAllA = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(0, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(805, 2);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(140, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "DANH SÁCH SINH VIÊN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(166, 114);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 20);
            this.txtName.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(450, 114);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "&Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstGroupA);
            this.groupBox1.Location = new System.Drawing.Point(69, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 246);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // lstGroupA
            // 
            this.lstGroupA.FormattingEnabled = true;
            this.lstGroupA.Items.AddRange(new object[] {
            "Châu Kiến Trung",
            "Huỳnh Phương Anh",
            "Kiến Tân",
            "Lưu Tấn Trung",
            "Trần Ngọc Đức",
            "Lê Duy Anh",
            "Hoàng Đức Thuận",
            "Lê Hoàng Trung"});
            this.lstGroupA.Location = new System.Drawing.Point(18, 19);
            this.lstGroupA.Name = "lstGroupA";
            this.lstGroupA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstGroupA.Size = new System.Drawing.Size(148, 212);
            this.lstGroupA.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstGroupB);
            this.groupBox2.Location = new System.Drawing.Point(424, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 246);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B";
            // 
            // lstGroupB
            // 
            this.lstGroupB.FormattingEnabled = true;
            this.lstGroupB.Location = new System.Drawing.Point(18, 19);
            this.lstGroupB.MultiColumn = true;
            this.lstGroupB.Name = "lstGroupB";
            this.lstGroupB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstGroupB.Size = new System.Drawing.Size(148, 212);
            this.lstGroupB.TabIndex = 0;
            // 
            // btnToB
            // 
            this.btnToB.Location = new System.Drawing.Point(296, 183);
            this.btnToB.Name = "btnToB";
            this.btnToB.Size = new System.Drawing.Size(75, 23);
            this.btnToB.TabIndex = 6;
            this.btnToB.Text = ">";
            this.btnToB.UseVisualStyleBackColor = true;
            this.btnToB.Click += new System.EventHandler(this.btnToB_Click);
            // 
            // btnToA
            // 
            this.btnToA.Location = new System.Drawing.Point(296, 241);
            this.btnToA.Name = "btnToA";
            this.btnToA.Size = new System.Drawing.Size(75, 23);
            this.btnToA.TabIndex = 6;
            this.btnToA.Text = "<";
            this.btnToA.UseVisualStyleBackColor = true;
            this.btnToA.Click += new System.EventHandler(this.btnToA_Click);
            // 
            // btnToAllB
            // 
            this.btnToAllB.Location = new System.Drawing.Point(296, 212);
            this.btnToAllB.Name = "btnToAllB";
            this.btnToAllB.Size = new System.Drawing.Size(75, 23);
            this.btnToAllB.TabIndex = 6;
            this.btnToAllB.Text = ">>";
            this.btnToAllB.UseVisualStyleBackColor = true;
            this.btnToAllB.Click += new System.EventHandler(this.btnToAllB_Click);
            // 
            // btnToAllA
            // 
            this.btnToAllA.Location = new System.Drawing.Point(296, 270);
            this.btnToAllA.Name = "btnToAllA";
            this.btnToAllA.Size = new System.Drawing.Size(75, 23);
            this.btnToAllA.TabIndex = 6;
            this.btnToAllA.Text = "<<";
            this.btnToAllA.UseVisualStyleBackColor = true;
            this.btnToAllA.Click += new System.EventHandler(this.btnToAllA_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(121, 416);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(484, 416);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 6;
            this.btnEnd.Text = "&Kết thúc";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // frmBai9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btnToAllB);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnToAllA);
            this.Controls.Add(this.btnToA);
            this.Controls.Add(this.btnToB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai9";
            this.Text = "frmBai9";
            this.Load += new System.EventHandler(this.frmBai9_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstGroupA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstGroupB;
        private System.Windows.Forms.Button btnToB;
        private System.Windows.Forms.Button btnToA;
        private System.Windows.Forms.Button btnToAllB;
        private System.Windows.Forms.Button btnToAllA;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnEnd;
    }
}