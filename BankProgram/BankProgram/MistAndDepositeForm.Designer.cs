namespace BankProgram
{
    partial class MistAndDepositeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MistAndDepositeForm));
            this.txtmoney = new System.Windows.Forms.TextBox();
            this.sendTheMoney = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeSendMoneyForm = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeSendMoneyForm)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmoney
            // 
            this.txtmoney.Location = new System.Drawing.Point(226, 90);
            this.txtmoney.Multiline = true;
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.Size = new System.Drawing.Size(179, 32);
            this.txtmoney.TabIndex = 1;
            // 
            // sendTheMoney
            // 
            this.sendTheMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sendTheMoney.AutoSize = true;
            this.sendTheMoney.BackColor = System.Drawing.Color.Black;
            this.sendTheMoney.Font = new System.Drawing.Font("PT Bold Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sendTheMoney.ForeColor = System.Drawing.Color.White;
            this.sendTheMoney.Location = new System.Drawing.Point(166, 170);
            this.sendTheMoney.Name = "sendTheMoney";
            this.sendTheMoney.Size = new System.Drawing.Size(142, 39);
            this.sendTheMoney.TabIndex = 40;
            this.sendTheMoney.Text = "موافق ";
            this.sendTheMoney.UseVisualStyleBackColor = false;
            this.sendTheMoney.Click += new System.EventHandler(this.sendTheMoney_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 31);
            this.label6.TabIndex = 41;
            this.label6.Text = "أدخل مبلغ العملية :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.closeSendMoneyForm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 47);
            this.panel2.TabIndex = 45;
            // 
            // closeSendMoneyForm
            // 
            this.closeSendMoneyForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.closeSendMoneyForm.Image = ((System.Drawing.Image)(resources.GetObject("closeSendMoneyForm.Image")));
            this.closeSendMoneyForm.Location = new System.Drawing.Point(3, 3);
            this.closeSendMoneyForm.Name = "closeSendMoneyForm";
            this.closeSendMoneyForm.Size = new System.Drawing.Size(44, 39);
            this.closeSendMoneyForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeSendMoneyForm.TabIndex = 0;
            this.closeSendMoneyForm.TabStop = false;
            this.closeSendMoneyForm.Click += new System.EventHandler(this.closeSendMoneyForm_Click);
            // 
            // MistAndDepositeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(428, 292);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sendTheMoney);
            this.Controls.Add(this.txtmoney);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MistAndDepositeForm";
            this.Opacity = 0.85D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MistAndDepositeForm";
            this.Load += new System.EventHandler(this.MistAndDepositeForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeSendMoneyForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmoney;
        private System.Windows.Forms.Button sendTheMoney;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox closeSendMoneyForm;
    }
}