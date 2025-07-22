namespace BankProgram
{
    partial class modifyAccountData
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
            this.closeForm = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comAccount = new System.Windows.Forms.ComboBox();
            this.comState = new System.Windows.Forms.ComboBox();
            this.comType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NoteAboutAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMist = new System.Windows.Forms.TextBox();
            this.txtAccountNum = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdiFemale = new System.Windows.Forms.RadioButton();
            this.rdiMale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtIDNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.modifyData = new System.Windows.Forms.Button();
            this.depositeMoney = new System.Windows.Forms.Button();
            this.mistMoney = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeForm
            // 
            this.closeForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeForm.AutoSize = true;
            this.closeForm.BackColor = System.Drawing.Color.Black;
            this.closeForm.Font = new System.Drawing.Font("PT Bold Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.closeForm.ForeColor = System.Drawing.Color.White;
            this.closeForm.Location = new System.Drawing.Point(60, 479);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(142, 39);
            this.closeForm.TabIndex = 39;
            this.closeForm.Text = "إغلاق النافذة";
            this.closeForm.UseVisualStyleBackColor = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(228, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 29);
            this.label10.TabIndex = 38;
            this.label10.Text = "حالة الحساب :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(230, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 29);
            this.label9.TabIndex = 36;
            this.label9.Text = "رقم الحساب :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.comAccount);
            this.groupBox2.Controls.Add(this.comState);
            this.groupBox2.Controls.Add(this.comType);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.NoteAboutAccount);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMist);
            this.groupBox2.Controls.Add(this.txtAccountNum);
            this.groupBox2.Controls.Add(this.txtDeposit);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtAmount);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(481, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 428);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات الحساب";
            // 
            // comAccount
            // 
            this.comAccount.Enabled = false;
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
            this.comAccount.Location = new System.Drawing.Point(10, 194);
            this.comAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comAccount.Name = "comAccount";
            this.comAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comAccount.Size = new System.Drawing.Size(205, 29);
            this.comAccount.TabIndex = 41;
            // 
            // comState
            // 
            this.comState.Enabled = false;
            this.comState.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comState.FormattingEnabled = true;
            this.comState.Items.AddRange(new object[] {
            "مفعل",
            "مجمد"});
            this.comState.Location = new System.Drawing.Point(10, 340);
            this.comState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comState.Name = "comState";
            this.comState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comState.Size = new System.Drawing.Size(205, 29);
            this.comState.TabIndex = 40;
            // 
            // comType
            // 
            this.comType.Enabled = false;
            this.comType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comType.FormattingEnabled = true;
            this.comType.Items.AddRange(new object[] {
            "$",
            "YER",
            "SAR"});
            this.comType.Location = new System.Drawing.Point(10, 145);
            this.comType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comType.Name = "comType";
            this.comType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comType.Size = new System.Drawing.Size(205, 29);
            this.comType.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(230, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 29);
            this.label8.TabIndex = 35;
            this.label8.Text = "آخر إيداع :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoteAboutAccount
            // 
            this.NoteAboutAccount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteAboutAccount.ForeColor = System.Drawing.Color.Black;
            this.NoteAboutAccount.Location = new System.Drawing.Point(9, 383);
            this.NoteAboutAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NoteAboutAccount.Multiline = true;
            this.NoteAboutAccount.Name = "NoteAboutAccount";
            this.NoteAboutAccount.ReadOnly = true;
            this.NoteAboutAccount.Size = new System.Drawing.Size(367, 31);
            this.NoteAboutAccount.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(230, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "آخر سحب :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMist
            // 
            this.txtMist.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMist.ForeColor = System.Drawing.Color.Black;
            this.txtMist.Location = new System.Drawing.Point(10, 294);
            this.txtMist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMist.Multiline = true;
            this.txtMist.Name = "txtMist";
            this.txtMist.ReadOnly = true;
            this.txtMist.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMist.Size = new System.Drawing.Size(205, 30);
            this.txtMist.TabIndex = 33;
            // 
            // txtAccountNum
            // 
            this.txtAccountNum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNum.ForeColor = System.Drawing.Color.Black;
            this.txtAccountNum.Location = new System.Drawing.Point(10, 33);
            this.txtAccountNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccountNum.Multiline = true;
            this.txtAccountNum.Name = "txtAccountNum";
            this.txtAccountNum.ReadOnly = true;
            this.txtAccountNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAccountNum.Size = new System.Drawing.Size(205, 30);
            this.txtAccountNum.TabIndex = 32;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposit.ForeColor = System.Drawing.Color.Black;
            this.txtDeposit.Location = new System.Drawing.Point(10, 243);
            this.txtDeposit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeposit.Multiline = true;
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.ReadOnly = true;
            this.txtDeposit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDeposit.Size = new System.Drawing.Size(205, 30);
            this.txtDeposit.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(232, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 29);
            this.label13.TabIndex = 26;
            this.label13.Text = "نوع الحساب : ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(230, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "مبلغ الحساب : ";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.Black;
            this.txtAmount.Location = new System.Drawing.Point(10, 92);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAmount.Size = new System.Drawing.Size(205, 30);
            this.txtAmount.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(232, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 30);
            this.label7.TabIndex = 18;
            this.label7.Text = "العملة : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.ForeColor = System.Drawing.Color.Black;
            this.txtType.Location = new System.Drawing.Point(137, 400);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtType.Multiline = true;
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtType.Size = new System.Drawing.Size(205, 30);
            this.txtType.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(273, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "الجنس  :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(17, 78);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(234, 37);
            this.txtName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(271, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 29);
            this.label12.TabIndex = 29;
            this.label12.Text = "رقم البطاقة  : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.rdiFemale);
            this.groupBox1.Controls.Add(this.rdiMale);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPhoneNum);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtIDNum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 427);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البيانات الشخصية";
            // 
            // rdiFemale
            // 
            this.rdiFemale.AutoSize = true;
            this.rdiFemale.BackColor = System.Drawing.Color.White;
            this.rdiFemale.Enabled = false;
            this.rdiFemale.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdiFemale.ForeColor = System.Drawing.Color.Black;
            this.rdiFemale.Location = new System.Drawing.Point(17, 200);
            this.rdiFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdiFemale.Name = "rdiFemale";
            this.rdiFemale.Size = new System.Drawing.Size(74, 27);
            this.rdiFemale.TabIndex = 33;
            this.rdiFemale.Text = "أنثى ";
            this.rdiFemale.UseVisualStyleBackColor = false;
            // 
            // rdiMale
            // 
            this.rdiMale.AutoSize = true;
            this.rdiMale.BackColor = System.Drawing.Color.White;
            this.rdiMale.Checked = true;
            this.rdiMale.Enabled = false;
            this.rdiMale.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdiMale.ForeColor = System.Drawing.Color.Black;
            this.rdiMale.Location = new System.Drawing.Point(192, 200);
            this.rdiMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdiMale.Name = "rdiMale";
            this.rdiMale.Size = new System.Drawing.Size(59, 27);
            this.rdiMale.TabIndex = 32;
            this.rdiMale.TabStop = true;
            this.rdiMale.Text = "ذكر";
            this.rdiMale.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(271, 138);
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
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(272, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "رقم الهاتف :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNum.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNum.Location = new System.Drawing.Point(17, 318);
            this.txtPhoneNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneNum.Multiline = true;
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.ReadOnly = true;
            this.txtPhoneNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhoneNum.Size = new System.Drawing.Size(234, 29);
            this.txtPhoneNum.TabIndex = 28;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(17, 137);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.Size = new System.Drawing.Size(234, 37);
            this.txtAddress.TabIndex = 24;
            // 
            // txtIDNum
            // 
            this.txtIDNum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNum.ForeColor = System.Drawing.Color.Black;
            this.txtIDNum.Location = new System.Drawing.Point(17, 258);
            this.txtIDNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDNum.Multiline = true;
            this.txtIDNum.Name = "txtIDNum";
            this.txtIDNum.ReadOnly = true;
            this.txtIDNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIDNum.Size = new System.Drawing.Size(234, 29);
            this.txtIDNum.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(273, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 31);
            this.label6.TabIndex = 26;
            this.label6.Text = "اسم العميل :";
            // 
            // modifyData
            // 
            this.modifyData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modifyData.AutoSize = true;
            this.modifyData.BackColor = System.Drawing.Color.Black;
            this.modifyData.Font = new System.Drawing.Font("PT Bold Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.modifyData.ForeColor = System.Drawing.Color.White;
            this.modifyData.Location = new System.Drawing.Point(681, 479);
            this.modifyData.Name = "modifyData";
            this.modifyData.Size = new System.Drawing.Size(142, 39);
            this.modifyData.TabIndex = 41;
            this.modifyData.Text = "تعديل البيانات";
            this.modifyData.UseVisualStyleBackColor = false;
            this.modifyData.Click += new System.EventHandler(this.modifyData_Click);
            // 
            // depositeMoney
            // 
            this.depositeMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.depositeMoney.AutoSize = true;
            this.depositeMoney.BackColor = System.Drawing.Color.Black;
            this.depositeMoney.Font = new System.Drawing.Font("PT Bold Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.depositeMoney.ForeColor = System.Drawing.Color.White;
            this.depositeMoney.Location = new System.Drawing.Point(474, 479);
            this.depositeMoney.Name = "depositeMoney";
            this.depositeMoney.Size = new System.Drawing.Size(142, 39);
            this.depositeMoney.TabIndex = 42;
            this.depositeMoney.Text = "إيداع مبلغ";
            this.depositeMoney.UseVisualStyleBackColor = false;
            this.depositeMoney.Click += new System.EventHandler(this.depositeMoney_Click);
            // 
            // mistMoney
            // 
            this.mistMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mistMoney.AutoSize = true;
            this.mistMoney.BackColor = System.Drawing.Color.Black;
            this.mistMoney.Font = new System.Drawing.Font("PT Bold Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mistMoney.ForeColor = System.Drawing.Color.White;
            this.mistMoney.Location = new System.Drawing.Point(267, 479);
            this.mistMoney.Name = "mistMoney";
            this.mistMoney.Size = new System.Drawing.Size(142, 39);
            this.mistMoney.TabIndex = 43;
            this.mistMoney.Text = "سحب مبلغ";
            this.mistMoney.UseVisualStyleBackColor = false;
            this.mistMoney.Click += new System.EventHandler(this.mistMoney_Click);
            // 
            // modifyAccountData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(882, 541);
            this.ControlBox = false;
            this.Controls.Add(this.mistMoney);
            this.Controls.Add(this.depositeMoney);
            this.Controls.Add(this.modifyData);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtType);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modifyAccountData";
            this.Opacity = 0.85D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modifyAccountData";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NoteAboutAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMist;
        private System.Windows.Forms.TextBox txtAccountNum;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtIDNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button modifyData;
        private System.Windows.Forms.Button depositeMoney;
        private System.Windows.Forms.Button mistMoney;
        private System.Windows.Forms.ComboBox comType;
        private System.Windows.Forms.ComboBox comState;
        private System.Windows.Forms.ComboBox comAccount;
        private System.Windows.Forms.RadioButton rdiFemale;
        private System.Windows.Forms.RadioButton rdiMale;
    }
}