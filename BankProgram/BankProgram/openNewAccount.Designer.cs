namespace BankProgram
{
    partial class openNewAccount
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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NoteAboutAccount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comAccount = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtIDNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdiFemale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rdiMale = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.showAcountNum = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.combackToMainScreen = new System.Windows.Forms.Button();
            this.saveAccountData = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(22, 92);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.Size = new System.Drawing.Size(234, 37);
            this.txtAddress.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(843, 388);
            this.panel3.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Controls.Add(this.NoteAboutAccount);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.comAccount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtAmount);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comType);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 368);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات الحساب";
            // 
            // NoteAboutAccount
            // 
            this.NoteAboutAccount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteAboutAccount.Location = new System.Drawing.Point(9, 210);
            this.NoteAboutAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NoteAboutAccount.Multiline = true;
            this.NoteAboutAccount.Name = "NoteAboutAccount";
            this.NoteAboutAccount.Size = new System.Drawing.Size(367, 151);
            this.NoteAboutAccount.TabIndex = 28;
            this.NoteAboutAccount.Text = "هنا قم بإدخال أي ملاحظات حول الحساب ( حقل غير إلزامي )";
            this.NoteAboutAccount.Click += new System.EventHandler(this.NoteAboutAccount_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(231, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 29);
            this.label13.TabIndex = 26;
            this.label13.Text = "نوع الحساب : ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comAccount
            // 
            this.comAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comAccount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comAccount.FormattingEnabled = true;
            this.comAccount.Items.AddRange(new object[] {
            "شخصي",
            "مؤسسة خيرية",
            "مؤسسة إجتماعية",
            "جامعة",
            "مرفق حكومي",
            "مرفق اهلي",
            "غير ذلك"});
            this.comAccount.Location = new System.Drawing.Point(9, 147);
            this.comAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comAccount.Name = "comAccount";
            this.comAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comAccount.Size = new System.Drawing.Size(205, 29);
            this.comAccount.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "مبلغ الحساب : ";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(9, 35);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAmount.Size = new System.Drawing.Size(205, 30);
            this.txtAmount.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(231, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 30);
            this.label7.TabIndex = 18;
            this.label7.Text = "العملة : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comType
            // 
            this.comType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comType.FormattingEnabled = true;
            this.comType.Items.AddRange(new object[] {
            "$",
            "YER",
            "SAR"});
            this.comType.Location = new System.Drawing.Point(9, 93);
            this.comType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comType.Name = "comType";
            this.comType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comType.Size = new System.Drawing.Size(205, 29);
            this.comType.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPhoneNum);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtIDNum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rdiFemale);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.rdiMale);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(402, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 368);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البيانات الشخصية";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "عنوان العميل :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "رقم الهاتف :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNum.Location = new System.Drawing.Point(22, 270);
            this.txtPhoneNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneNum.Multiline = true;
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhoneNum.Size = new System.Drawing.Size(234, 29);
            this.txtPhoneNum.TabIndex = 28;
            // 
            // txtIDNum
            // 
            this.txtIDNum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNum.Location = new System.Drawing.Point(22, 210);
            this.txtIDNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDNum.Multiline = true;
            this.txtIDNum.Name = "txtIDNum";
            this.txtIDNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIDNum.Size = new System.Drawing.Size(234, 29);
            this.txtIDNum.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(278, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 31);
            this.label6.TabIndex = 26;
            this.label6.Text = "اسم العميل :";
            // 
            // rdiFemale
            // 
            this.rdiFemale.AutoSize = true;
            this.rdiFemale.BackColor = System.Drawing.Color.White;
            this.rdiFemale.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdiFemale.Location = new System.Drawing.Point(22, 151);
            this.rdiFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdiFemale.Name = "rdiFemale";
            this.rdiFemale.Size = new System.Drawing.Size(74, 27);
            this.rdiFemale.TabIndex = 14;
            this.rdiFemale.TabStop = true;
            this.rdiFemale.Text = "أنثى ";
            this.rdiFemale.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "الجنس  :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(22, 32);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 37);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // rdiMale
            // 
            this.rdiMale.AutoSize = true;
            this.rdiMale.BackColor = System.Drawing.Color.White;
            this.rdiMale.Checked = true;
            this.rdiMale.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdiMale.Location = new System.Drawing.Point(197, 153);
            this.rdiMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdiMale.Name = "rdiMale";
            this.rdiMale.Size = new System.Drawing.Size(59, 27);
            this.rdiMale.TabIndex = 13;
            this.rdiMale.TabStop = true;
            this.rdiMale.Text = "ذكر";
            this.rdiMale.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(276, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 29);
            this.label12.TabIndex = 29;
            this.label12.Text = "رقم البطاقة  : ";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.LightGray;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(96, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 35);
            this.label11.TabIndex = 5;
            this.label11.Text = "رقم الحساب :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showAcountNum
            // 
            this.showAcountNum.AutoSize = true;
            this.showAcountNum.BackColor = System.Drawing.Color.LightGray;
            this.showAcountNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showAcountNum.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAcountNum.Location = new System.Drawing.Point(29, 15);
            this.showAcountNum.Name = "showAcountNum";
            this.showAcountNum.Size = new System.Drawing.Size(2, 27);
            this.showAcountNum.TabIndex = 4;
            this.showAcountNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightGray;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(603, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 27);
            this.label9.TabIndex = 2;
            this.label9.Text = "100";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightGray;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(676, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 35);
            this.label8.TabIndex = 1;
            this.label8.Text = "رقم العميل : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "بيانات  الحساب";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.combackToMainScreen);
            this.panel2.Controls.Add(this.saveAccountData);
            this.panel2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 446);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 75);
            this.panel2.TabIndex = 13;
            // 
            // combackToMainScreen
            // 
            this.combackToMainScreen.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.combackToMainScreen.Location = new System.Drawing.Point(538, 17);
            this.combackToMainScreen.Name = "combackToMainScreen";
            this.combackToMainScreen.Size = new System.Drawing.Size(285, 40);
            this.combackToMainScreen.TabIndex = 31;
            this.combackToMainScreen.Text = "الرجوع إلى القائمة السابقة ";
            this.combackToMainScreen.UseVisualStyleBackColor = false;
            this.combackToMainScreen.Click += new System.EventHandler(this.combackToMainScreen_Click);
            // 
            // saveAccountData
            // 
            this.saveAccountData.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.saveAccountData.Location = new System.Drawing.Point(45, 17);
            this.saveAccountData.Name = "saveAccountData";
            this.saveAccountData.Size = new System.Drawing.Size(285, 40);
            this.saveAccountData.TabIndex = 30;
            this.saveAccountData.Text = "حفظ بيانات الحساب";
            this.saveAccountData.UseVisualStyleBackColor = false;
            this.saveAccountData.Click += new System.EventHandler(this.saveAccountData_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(538, 21);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "الرجوع الى القائمة السابقة";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(104, 21);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "حفظ البيانات";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.showAcountNum);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 58);
            this.panel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(49, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 40);
            this.button1.TabIndex = 27;
            this.button1.Text = "حفظ بيانات العميل";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // openNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 521);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "openNewAccount";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فتح حساب جديد";
            this.Load += new System.EventHandler(this.openNewAccount_Load);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox comType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdiFemale;
        private System.Windows.Forms.RadioButton rdiMale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label showAcountNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIDNum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comAccount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button combackToMainScreen;
        private System.Windows.Forms.Button saveAccountData;
        private System.Windows.Forms.TextBox NoteAboutAccount;
    }
}