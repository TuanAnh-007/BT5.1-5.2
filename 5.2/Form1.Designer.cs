namespace Bai4_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Khóa học:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(130, 27);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 20);
            this.txtFullName.TabIndex = 5;
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Location = new System.Drawing.Point(130, 67);
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(200, 20);
            this.mtxtPhone.TabIndex = 6;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(130, 107);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthDate.TabIndex = 7;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.Location = new System.Drawing.Point(130, 148);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(47, 17);
            this.radMale.TabIndex = 8;
            this.radMale.TabStop = true;
            this.radMale.Text = "Nam";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(200, 148);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(39, 17);
            this.radFemale.TabIndex = 9;
            this.radFemale.Text = "Nữ";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // cboCourse
            // 
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(130, 187);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(200, 21);
            this.cboCourse.TabIndex = 10;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(130, 230);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 30);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 290);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cboCourse);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Đăng ký học viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.Button btnRegister;
    }
}