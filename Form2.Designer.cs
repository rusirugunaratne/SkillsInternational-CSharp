namespace Skills
{
    partial class Form2
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnRegister = new Button();
            groupBox4 = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            txtContactNumber = new TextBox();
            txtNIC = new TextBox();
            txtParentname = new TextBox();
            groupBox3 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            txtHomeNumber = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            label7 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            dtimePicker = new DateTimePicker();
            txtLastname = new TextBox();
            txtFirstname = new TextBox();
            radioFemale = new RadioButton();
            radioMale = new RadioButton();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbRegNo = new ComboBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(179, 12);
            label1.Name = "label1";
            label1.Size = new Size(284, 41);
            label1.TabIndex = 0;
            label1.Text = "Skills International";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cmbRegNo);
            groupBox1.Location = new Point(12, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(608, 621);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Registration";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(508, 579);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(408, 579);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(106, 579);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(6, 579);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(txtContactNumber);
            groupBox4.Controls.Add(txtNIC);
            groupBox4.Controls.Add(txtParentname);
            groupBox4.Location = new Point(6, 440);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(596, 133);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Parent Details";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 93);
            label12.Name = "label12";
            label12.Size = new Size(118, 20);
            label12.TabIndex = 0;
            label12.Text = "Contact Number";
            label12.Click += label6_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 64);
            label11.Name = "label11";
            label11.Size = new Size(33, 20);
            label11.TabIndex = 0;
            label11.Text = "NIC";
            label11.Click += label6_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 32);
            label10.Name = "label10";
            label10.Size = new Size(94, 20);
            label10.TabIndex = 0;
            label10.Text = "Parent Name";
            label10.Click += label6_Click;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(128, 90);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(161, 27);
            txtContactNumber.TabIndex = 2;
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(128, 58);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(161, 27);
            txtNIC.TabIndex = 2;
            // 
            // txtParentname
            // 
            txtParentname.Location = new Point(128, 25);
            txtParentname.Name = "txtParentname";
            txtParentname.Size = new Size(462, 27);
            txtParentname.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtHomeNumber);
            groupBox3.Controls.Add(txtPhoneNumber);
            groupBox3.Controls.Add(txtEmail);
            groupBox3.Controls.Add(txtAddress);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(6, 289);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(596, 145);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Contact Details";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(305, 98);
            label9.Name = "label9";
            label9.Size = new Size(95, 20);
            label9.TabIndex = 0;
            label9.Text = "Home Phone";
            label9.Click += label6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 98);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 0;
            label8.Text = "Mobile Phone";
            label8.Click += label6_Click;
            // 
            // txtHomeNumber
            // 
            txtHomeNumber.Location = new Point(406, 95);
            txtHomeNumber.Name = "txtHomeNumber";
            txtHomeNumber.Size = new Size(184, 27);
            txtHomeNumber.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(128, 95);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(161, 27);
            txtPhoneNumber.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(128, 62);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(462, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(128, 29);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(462, 27);
            txtAddress.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 65);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 0;
            label7.Text = "Email";
            label7.Click += label6_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 32);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 0;
            label6.Text = "Address";
            label6.Click += label6_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtimePicker);
            groupBox2.Controls.Add(txtLastname);
            groupBox2.Controls.Add(txtFirstname);
            groupBox2.Controls.Add(radioFemale);
            groupBox2.Controls.Add(radioMale);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(6, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(596, 211);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Basic Details";
            // 
            // dtimePicker
            // 
            dtimePicker.Location = new Point(128, 107);
            dtimePicker.Name = "dtimePicker";
            dtimePicker.Size = new Size(250, 27);
            dtimePicker.TabIndex = 3;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(128, 67);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(462, 27);
            txtLastname.TabIndex = 2;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(128, 33);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(462, 27);
            txtFirstname.TabIndex = 2;
            // 
            // radioFemale
            // 
            radioFemale.AutoSize = true;
            radioFemale.Location = new Point(211, 140);
            radioFemale.Name = "radioFemale";
            radioFemale.Size = new Size(78, 24);
            radioFemale.TabIndex = 1;
            radioFemale.TabStop = true;
            radioFemale.Text = "Female";
            radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            radioMale.AutoSize = true;
            radioMale.Location = new Point(128, 140);
            radioMale.Name = "radioMale";
            radioMale.Size = new Size(63, 24);
            radioMale.TabIndex = 1;
            radioMale.TabStop = true;
            radioMale.Text = "Male";
            radioMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 144);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 0;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 107);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 0;
            label4.Text = "Date of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 70);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 0;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 36);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 0;
            label2.Text = "First Name";
            // 
            // cmbRegNo
            // 
            cmbRegNo.FormattingEnabled = true;
            cmbRegNo.Location = new Point(6, 26);
            cmbRegNo.Name = "cmbRegNo";
            cmbRegNo.Size = new Size(151, 28);
            cmbRegNo.TabIndex = 0;
            cmbRegNo.Text = "Reg No";
            cmbRegNo.SelectedIndexChanged += cmbRegNo_SelectedIndexChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 12);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(56, 20);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Logout";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(581, 709);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(33, 20);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Exit";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 738);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Student Registration - Skills International";
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtFirstname;
        private RadioButton radioFemale;
        private RadioButton radioMale;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbRegNo;
        private GroupBox groupBox3;
        private Label label6;
        private DateTimePicker dtimePicker;
        private TextBox txtLastname;
        private Label label9;
        private Label label8;
        private TextBox txtHomeNumber;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private Label label7;
        private Button btnDelete;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnRegister;
        private GroupBox groupBox4;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox txtContactNumber;
        private TextBox txtNIC;
        private TextBox txtParentname;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}