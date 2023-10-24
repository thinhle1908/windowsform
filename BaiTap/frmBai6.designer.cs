namespace Bai6
{
    partial class frmBai6
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
            this.grCountry = new System.Windows.Forms.GroupBox();
            this.rdoPhilippine = new System.Windows.Forms.RadioButton();
            this.rdoItalian = new System.Windows.Forms.RadioButton();
            this.rdoUSA = new System.Windows.Forms.RadioButton();
            this.rdoVietNam = new System.Windows.Forms.RadioButton();
            this.pcbimage = new System.Windows.Forms.PictureBox();
            this.grCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbimage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "COUNTRY FLAGS";
            // 
            // grCountry
            // 
            this.grCountry.Controls.Add(this.rdoPhilippine);
            this.grCountry.Controls.Add(this.rdoItalian);
            this.grCountry.Controls.Add(this.rdoUSA);
            this.grCountry.Controls.Add(this.rdoVietNam);
            this.grCountry.Location = new System.Drawing.Point(43, 117);
            this.grCountry.Name = "grCountry";
            this.grCountry.Size = new System.Drawing.Size(200, 185);
            this.grCountry.TabIndex = 1;
            this.grCountry.TabStop = false;
            this.grCountry.Text = "Country";
            // 
            // rdoPhilippine
            // 
            this.rdoPhilippine.AutoSize = true;
            this.rdoPhilippine.Location = new System.Drawing.Point(6, 148);
            this.rdoPhilippine.Name = "rdoPhilippine";
            this.rdoPhilippine.Size = new System.Drawing.Size(70, 17);
            this.rdoPhilippine.TabIndex = 0;
            this.rdoPhilippine.TabStop = true;
            this.rdoPhilippine.Text = "Philippine";
            this.rdoPhilippine.UseVisualStyleBackColor = true;
            // 
            // rdoItalian
            // 
            this.rdoItalian.AutoSize = true;
            this.rdoItalian.Location = new System.Drawing.Point(6, 111);
            this.rdoItalian.Name = "rdoItalian";
            this.rdoItalian.Size = new System.Drawing.Size(47, 17);
            this.rdoItalian.TabIndex = 0;
            this.rdoItalian.TabStop = true;
            this.rdoItalian.Text = "Italia";
            this.rdoItalian.UseVisualStyleBackColor = true;
            // 
            // rdoUSA
            // 
            this.rdoUSA.AutoSize = true;
            this.rdoUSA.Location = new System.Drawing.Point(6, 73);
            this.rdoUSA.Name = "rdoUSA";
            this.rdoUSA.Size = new System.Drawing.Size(47, 17);
            this.rdoUSA.TabIndex = 0;
            this.rdoUSA.TabStop = true;
            this.rdoUSA.Text = "USA";
            this.rdoUSA.UseVisualStyleBackColor = true;
            // 
            // rdoVietNam
            // 
            this.rdoVietNam.AutoSize = true;
            this.rdoVietNam.Location = new System.Drawing.Point(6, 35);
            this.rdoVietNam.Name = "rdoVietNam";
            this.rdoVietNam.Size = new System.Drawing.Size(65, 17);
            this.rdoVietNam.TabIndex = 0;
            this.rdoVietNam.TabStop = true;
            this.rdoVietNam.Text = "VietNam";
            this.rdoVietNam.UseVisualStyleBackColor = true;
            // 
            // pcbimage
            // 
            this.pcbimage.Location = new System.Drawing.Point(335, 152);
            this.pcbimage.Name = "pcbimage";
            this.pcbimage.Size = new System.Drawing.Size(170, 139);
            this.pcbimage.TabIndex = 2;
            this.pcbimage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.pcbimage);
            this.Controls.Add(this.grCountry);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grCountry.ResumeLayout(false);
            this.grCountry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grCountry;
        private System.Windows.Forms.RadioButton rdoPhilippine;
        private System.Windows.Forms.RadioButton rdoItalian;
        private System.Windows.Forms.RadioButton rdoUSA;
        private System.Windows.Forms.RadioButton rdoVietNam;
        private System.Windows.Forms.PictureBox pcbimage;
    }
}

