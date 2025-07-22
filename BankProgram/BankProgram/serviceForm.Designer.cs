namespace BankProgram
{
    partial class serviceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serviceForm));
            this.search = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeServiceForm = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeServiceForm)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.search.Font = new System.Drawing.Font("PT Bold Heading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.search.ForeColor = System.Drawing.Color.SeaGreen;
            this.search.Location = new System.Drawing.Point(81, 152);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(162, 46);
            this.search.TabIndex = 43;
            this.search.Text = "بحث";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.closeServiceForm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 47);
            this.panel2.TabIndex = 44;
            // 
            // closeServiceForm
            // 
            this.closeServiceForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.closeServiceForm.Image = ((System.Drawing.Image)(resources.GetObject("closeServiceForm.Image")));
            this.closeServiceForm.Location = new System.Drawing.Point(3, 3);
            this.closeServiceForm.Name = "closeServiceForm";
            this.closeServiceForm.Size = new System.Drawing.Size(44, 39);
            this.closeServiceForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeServiceForm.TabIndex = 0;
            this.closeServiceForm.TabStop = false;
            this.closeServiceForm.Click += new System.EventHandler(this.closeServiceForm_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(11, 82);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(178, 29);
            this.txtSearch.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("PT Bold Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(195, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "أدخل أسم الحساب :";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 285);
            this.panel1.TabIndex = 0;
            // 
            // serviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 285);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "serviceForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeServiceForm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox closeServiceForm;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}