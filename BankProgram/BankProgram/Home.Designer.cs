namespace BankProgram
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("الصفحة الرئيسية");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("عرض الحسابات", 3, 3);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("الموظفين", 4, 4);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("النظام", 6, 6);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("حول البرنامج", 5, 5);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maxmizeForm = new System.Windows.Forms.PictureBox();
            this.minimizeForm = new System.Windows.Forms.PictureBox();
            this.CloseForm = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.accountMistToday = new System.Windows.Forms.Label();
            this.accountOpenedToday = new System.Windows.Forms.Label();
            this.defrezeAccount = new System.Windows.Forms.Label();
            this.accountDepositeToday = new System.Windows.Forms.Label();
            this.activeAccount = new System.Windows.Forms.Label();
            this.accountTotal = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tvHome = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.modifyAccountData = new System.Windows.Forms.Button();
            this.DeleteAccount = new System.Windows.Forms.Button();
            this.QueryAboutAccount = new System.Windows.Forms.Button();
            this.OpenNewAccount = new System.Windows.Forms.Button();
            this.showData = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxmizeForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseForm)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.maxmizeForm);
            this.panel1.Controls.Add(this.minimizeForm);
            this.panel1.Controls.Add(this.CloseForm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 63);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("PT Bold Heading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(811, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "عوض بن وهلان";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("PT Bold Heading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(949, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = ": اسم المستخدم  ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // maxmizeForm
            // 
            this.maxmizeForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.maxmizeForm.Image = ((System.Drawing.Image)(resources.GetObject("maxmizeForm.Image")));
            this.maxmizeForm.Location = new System.Drawing.Point(68, 12);
            this.maxmizeForm.Name = "maxmizeForm";
            this.maxmizeForm.Size = new System.Drawing.Size(44, 39);
            this.maxmizeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maxmizeForm.TabIndex = 5;
            this.maxmizeForm.TabStop = false;
            this.maxmizeForm.Click += new System.EventHandler(this.maxmizeForm_Click);
            // 
            // minimizeForm
            // 
            this.minimizeForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.minimizeForm.Image = ((System.Drawing.Image)(resources.GetObject("minimizeForm.Image")));
            this.minimizeForm.Location = new System.Drawing.Point(124, 12);
            this.minimizeForm.Name = "minimizeForm";
            this.minimizeForm.Size = new System.Drawing.Size(44, 39);
            this.minimizeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.minimizeForm.TabIndex = 4;
            this.minimizeForm.TabStop = false;
            this.minimizeForm.Click += new System.EventHandler(this.minimizeForm_Click);
            // 
            // CloseForm
            // 
            this.CloseForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CloseForm.Image = ((System.Drawing.Image)(resources.GetObject("CloseForm.Image")));
            this.CloseForm.Location = new System.Drawing.Point(12, 12);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(44, 39);
            this.CloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseForm.TabIndex = 1;
            this.CloseForm.TabStop = false;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            this.CloseForm.MouseHover += new System.EventHandler(this.CloseForm_MouseHover);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("PT Bold Heading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(480, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "برنامج إدارة بنك";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.accountMistToday);
            this.panel3.Controls.Add(this.accountOpenedToday);
            this.panel3.Controls.Add(this.defrezeAccount);
            this.panel3.Controls.Add(this.accountDepositeToday);
            this.panel3.Controls.Add(this.activeAccount);
            this.panel3.Controls.Add(this.accountTotal);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 549);
            this.panel3.TabIndex = 2;
            // 
            // accountMistToday
            // 
            this.accountMistToday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accountMistToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.accountMistToday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.accountMistToday.ForeColor = System.Drawing.Color.SeaGreen;
            this.accountMistToday.Location = new System.Drawing.Point(35, 235);
            this.accountMistToday.Name = "accountMistToday";
            this.accountMistToday.Size = new System.Drawing.Size(172, 67);
            this.accountMistToday.TabIndex = 53;
            this.accountMistToday.Text = "                 10\r\n    الحسابات المسحوب منها \r\n\r\n        \r\n\r\n";
            // 
            // accountOpenedToday
            // 
            this.accountOpenedToday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accountOpenedToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.accountOpenedToday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.accountOpenedToday.ForeColor = System.Drawing.Color.SeaGreen;
            this.accountOpenedToday.Location = new System.Drawing.Point(679, 235);
            this.accountOpenedToday.Name = "accountOpenedToday";
            this.accountOpenedToday.Size = new System.Drawing.Size(176, 67);
            this.accountOpenedToday.TabIndex = 52;
            this.accountOpenedToday.Text = "                 10\r\n      الحسابات المفتوحة اليوم     \r\n        \r\n\r\n";
            // 
            // defrezeAccount
            // 
            this.defrezeAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.defrezeAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.defrezeAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.defrezeAccount.ForeColor = System.Drawing.Color.SeaGreen;
            this.defrezeAccount.Location = new System.Drawing.Point(45, 73);
            this.defrezeAccount.Name = "defrezeAccount";
            this.defrezeAccount.Size = new System.Drawing.Size(162, 67);
            this.defrezeAccount.TabIndex = 51;
            this.defrezeAccount.Text = "                 10\r\n      الحسابات المجمدة    \r\n        \r\n\r\n";
            // 
            // accountDepositeToday
            // 
            this.accountDepositeToday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accountDepositeToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.accountDepositeToday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.accountDepositeToday.ForeColor = System.Drawing.Color.SeaGreen;
            this.accountDepositeToday.Location = new System.Drawing.Point(369, 235);
            this.accountDepositeToday.Name = "accountDepositeToday";
            this.accountDepositeToday.Size = new System.Drawing.Size(162, 67);
            this.accountDepositeToday.TabIndex = 50;
            this.accountDepositeToday.Text = "                 10\r\n   الحسابات المودوع فيها \r\n        \r\n\r\n";
            // 
            // activeAccount
            // 
            this.activeAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.activeAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.activeAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.activeAccount.ForeColor = System.Drawing.Color.SeaGreen;
            this.activeAccount.Location = new System.Drawing.Point(369, 73);
            this.activeAccount.Name = "activeAccount";
            this.activeAccount.Size = new System.Drawing.Size(162, 67);
            this.activeAccount.TabIndex = 49;
            this.activeAccount.Text = "                 10\r\n        الحسابات الفعالة      \r\n        \r\n\r\n";
            this.activeAccount.Click += new System.EventHandler(this.activeAccount_Click);
            // 
            // accountTotal
            // 
            this.accountTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accountTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.accountTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.accountTotal.ForeColor = System.Drawing.Color.SeaGreen;
            this.accountTotal.Location = new System.Drawing.Point(693, 73);
            this.accountTotal.Name = "accountTotal";
            this.accountTotal.Size = new System.Drawing.Size(162, 67);
            this.accountTotal.TabIndex = 48;
            this.accountTotal.Text = "                 10\r\n          عدد الحسابات\r\n        \r\n\r\n";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FloralWhite;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.tvHome);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(913, 0);
            this.panel4.Name = "panel4";
            this.panel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel4.Size = new System.Drawing.Size(183, 475);
            this.panel4.TabIndex = 38;
            // 
            // tvHome
            // 
            this.tvHome.Dock = System.Windows.Forms.DockStyle.Right;
            this.tvHome.ImageIndex = 0;
            this.tvHome.ImageList = this.imageList1;
            this.tvHome.Location = new System.Drawing.Point(0, 0);
            this.tvHome.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.tvHome.Name = "tvHome";
            treeNode1.Name = "Node0";
            treeNode1.Text = "الصفحة الرئيسية";
            treeNode2.ImageIndex = 3;
            treeNode2.Name = "Node1";
            treeNode2.SelectedImageIndex = 3;
            treeNode2.Text = "عرض الحسابات";
            treeNode3.ImageIndex = 4;
            treeNode3.Name = "Node2";
            treeNode3.SelectedImageIndex = 4;
            treeNode3.Text = "الموظفين";
            treeNode4.ImageIndex = 6;
            treeNode4.Name = "Node3";
            treeNode4.SelectedImageIndex = 6;
            treeNode4.Text = "النظام";
            treeNode5.ImageIndex = 5;
            treeNode5.Name = "Node4";
            treeNode5.SelectedImageIndex = 5;
            treeNode5.Text = "حول البرنامج";
            this.tvHome.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.tvHome.RightToLeftLayout = true;
            this.tvHome.SelectedImageIndex = 0;
            this.tvHome.Size = new System.Drawing.Size(179, 471);
            this.tvHome.TabIndex = 0;
            this.tvHome.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvHome_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home.gif");
            this.imageList1.Images.SetKeyName(1, "close_b.png");
            this.imageList1.Images.SetKeyName(2, "icon_users.png");
            this.imageList1.Images.SetKeyName(3, "images (6).png");
            this.imageList1.Images.SetKeyName(4, "تنزيل (8).jpeg");
            this.imageList1.Images.SetKeyName(5, "تنزيل (8).png");
            this.imageList1.Images.SetKeyName(6, "تنزيل.png");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.modifyAccountData);
            this.panel2.Controls.Add(this.DeleteAccount);
            this.panel2.Controls.Add(this.QueryAboutAccount);
            this.panel2.Controls.Add(this.OpenNewAccount);
            this.panel2.Controls.Add(this.showData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 475);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1096, 70);
            this.panel2.TabIndex = 37;
            // 
            // modifyAccountData
            // 
            this.modifyAccountData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modifyAccountData.AutoSize = true;
            this.modifyAccountData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.modifyAccountData.ForeColor = System.Drawing.Color.SeaGreen;
            this.modifyAccountData.Location = new System.Drawing.Point(574, 21);
            this.modifyAccountData.Name = "modifyAccountData";
            this.modifyAccountData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.modifyAccountData.Size = new System.Drawing.Size(156, 37);
            this.modifyAccountData.TabIndex = 41;
            this.modifyAccountData.Text = "تعديل بيانات حساب";
            this.modifyAccountData.UseVisualStyleBackColor = false;
            this.modifyAccountData.Click += new System.EventHandler(this.modifyAccountData_Click);
            // 
            // DeleteAccount
            // 
            this.DeleteAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeleteAccount.ForeColor = System.Drawing.Color.SeaGreen;
            this.DeleteAccount.Location = new System.Drawing.Point(390, 21);
            this.DeleteAccount.Name = "DeleteAccount";
            this.DeleteAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DeleteAccount.Size = new System.Drawing.Size(159, 37);
            this.DeleteAccount.TabIndex = 40;
            this.DeleteAccount.Text = "حذف حساب";
            this.DeleteAccount.UseVisualStyleBackColor = false;
            this.DeleteAccount.Click += new System.EventHandler(this.DeleteAccount_Click);
            // 
            // QueryAboutAccount
            // 
            this.QueryAboutAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QueryAboutAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.QueryAboutAccount.ForeColor = System.Drawing.Color.SeaGreen;
            this.QueryAboutAccount.Location = new System.Drawing.Point(206, 20);
            this.QueryAboutAccount.Name = "QueryAboutAccount";
            this.QueryAboutAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QueryAboutAccount.Size = new System.Drawing.Size(159, 37);
            this.QueryAboutAccount.TabIndex = 39;
            this.QueryAboutAccount.Text = "استعلام عن حساب";
            this.QueryAboutAccount.UseVisualStyleBackColor = false;
            this.QueryAboutAccount.Click += new System.EventHandler(this.QueryAboutAccount_Click);
            // 
            // OpenNewAccount
            // 
            this.OpenNewAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpenNewAccount.AutoSize = true;
            this.OpenNewAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OpenNewAccount.ForeColor = System.Drawing.Color.SeaGreen;
            this.OpenNewAccount.Location = new System.Drawing.Point(755, 21);
            this.OpenNewAccount.Name = "OpenNewAccount";
            this.OpenNewAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OpenNewAccount.Size = new System.Drawing.Size(156, 37);
            this.OpenNewAccount.TabIndex = 38;
            this.OpenNewAccount.Text = "فتح حساب جديد";
            this.OpenNewAccount.UseVisualStyleBackColor = false;
            this.OpenNewAccount.Click += new System.EventHandler(this.OpenNewAccount_Click);
            // 
            // showData
            // 
            this.showData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.showData.ForeColor = System.Drawing.Color.SeaGreen;
            this.showData.Location = new System.Drawing.Point(22, 19);
            this.showData.Name = "showData";
            this.showData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.showData.Size = new System.Drawing.Size(159, 37);
            this.showData.TabIndex = 37;
            this.showData.Text = "عرض بيانات الحسابات";
            this.showData.UseVisualStyleBackColor = false;
            this.showData.Click += new System.EventHandler(this.showData_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1100, 612);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("PT Bold Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامج إدارة بنك";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxmizeForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseForm)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CloseForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox maxmizeForm;
        private System.Windows.Forms.PictureBox minimizeForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button QueryAboutAccount;
        private System.Windows.Forms.Button OpenNewAccount;
        private System.Windows.Forms.Button showData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button modifyAccountData;
        private System.Windows.Forms.Button DeleteAccount;
        private System.Windows.Forms.Label accountTotal;
        private System.Windows.Forms.TreeView tvHome;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label accountMistToday;
        private System.Windows.Forms.Label accountOpenedToday;
        private System.Windows.Forms.Label defrezeAccount;
        private System.Windows.Forms.Label accountDepositeToday;
        private System.Windows.Forms.Label activeAccount;
    }
}

