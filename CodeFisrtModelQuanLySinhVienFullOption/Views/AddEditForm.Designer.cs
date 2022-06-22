namespace CodeFisrtModelQuanLySinhVienFullOption
{
    partial class AddEditForm
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
            this.btCc = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.HoSo = new System.Windows.Forms.GroupBox();
            this.cbCMND = new System.Windows.Forms.CheckBox();
            this.cbHocBa = new System.Windows.Forms.CheckBox();
            this.cbAnh = new System.Windows.Forms.CheckBox();
            this.Gender = new System.Windows.Forms.GroupBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.cbbLopSH = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HoSo.SuspendLayout();
            this.Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCc
            // 
            this.btCc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCc.Location = new System.Drawing.Point(373, 327);
            this.btCc.Name = "btCc";
            this.btCc.Size = new System.Drawing.Size(110, 40);
            this.btCc.TabIndex = 44;
            this.btCc.Text = "Cancel";
            this.btCc.UseVisualStyleBackColor = true;
            this.btCc.Click += new System.EventHandler(this.btCc_Click);
            // 
            // btOk
            // 
            this.btOk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Location = new System.Drawing.Point(161, 327);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(110, 40);
            this.btOk.TabIndex = 43;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // HoSo
            // 
            this.HoSo.Controls.Add(this.cbCMND);
            this.HoSo.Controls.Add(this.cbHocBa);
            this.HoSo.Controls.Add(this.cbAnh);
            this.HoSo.Location = new System.Drawing.Point(337, 176);
            this.HoSo.Name = "HoSo";
            this.HoSo.Size = new System.Drawing.Size(288, 126);
            this.HoSo.TabIndex = 42;
            this.HoSo.TabStop = false;
            this.HoSo.Text = "Hồ sơ nộp";
            // 
            // cbCMND
            // 
            this.cbCMND.AutoSize = true;
            this.cbCMND.Location = new System.Drawing.Point(27, 92);
            this.cbCMND.Name = "cbCMND";
            this.cbCMND.Size = new System.Drawing.Size(58, 17);
            this.cbCMND.TabIndex = 2;
            this.cbCMND.Text = "CMND";
            this.cbCMND.UseVisualStyleBackColor = true;
            // 
            // cbHocBa
            // 
            this.cbHocBa.AutoSize = true;
            this.cbHocBa.Location = new System.Drawing.Point(27, 53);
            this.cbHocBa.Name = "cbHocBa";
            this.cbHocBa.Size = new System.Drawing.Size(61, 17);
            this.cbHocBa.TabIndex = 1;
            this.cbHocBa.Text = "Học bạ";
            this.cbHocBa.UseVisualStyleBackColor = true;
            // 
            // cbAnh
            // 
            this.cbAnh.AutoSize = true;
            this.cbAnh.Location = new System.Drawing.Point(27, 19);
            this.cbAnh.Name = "cbAnh";
            this.cbAnh.Size = new System.Drawing.Size(45, 17);
            this.cbAnh.TabIndex = 0;
            this.cbAnh.Text = "Ảnh";
            this.cbAnh.UseVisualStyleBackColor = true;
            // 
            // Gender
            // 
            this.Gender.Controls.Add(this.rbNu);
            this.Gender.Controls.Add(this.rbNam);
            this.Gender.Location = new System.Drawing.Point(41, 176);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(255, 126);
            this.Gender.TabIndex = 41;
            this.Gender.TabStop = false;
            this.Gender.Text = "Giới tính";
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(32, 75);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(39, 17);
            this.rbNu.TabIndex = 1;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(32, 31);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 0;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(444, 63);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(200, 20);
            this.txtDTB.TabIndex = 40;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(444, 19);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 20);
            this.Date.TabIndex = 39;
            // 
            // cbbLopSH
            // 
            this.cbbLopSH.FormattingEnabled = true;
            this.cbbLopSH.Location = new System.Drawing.Point(129, 114);
            this.cbbLopSH.Name = "cbbLopSH";
            this.cbbLopSH.Size = new System.Drawing.Size(167, 21);
            this.cbbLopSH.TabIndex = 38;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 20);
            this.txtName.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(333, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "DTB";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(129, 21);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(167, 20);
            this.txtMSSV.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Lớp SH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "MSSV";
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 387);
            this.Controls.Add(this.btCc);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.HoSo);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.cbbLopSH);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEditForm";
            this.Text = "AddEditForm";
            this.HoSo.ResumeLayout(false);
            this.HoSo.PerformLayout();
            this.Gender.ResumeLayout(false);
            this.Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCc;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.GroupBox HoSo;
        private System.Windows.Forms.CheckBox cbCMND;
        private System.Windows.Forms.CheckBox cbHocBa;
        private System.Windows.Forms.CheckBox cbAnh;
        private System.Windows.Forms.GroupBox Gender;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.ComboBox cbbLopSH;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}