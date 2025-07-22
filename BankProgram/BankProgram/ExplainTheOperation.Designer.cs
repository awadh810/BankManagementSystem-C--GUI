namespace BankProgram
{
    partial class ExplainTheOperation
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
            this.explain = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // explain
            // 
            this.explain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.explain.AutoSize = true;
            this.explain.BackColor = System.Drawing.Color.Black;
            this.explain.Font = new System.Drawing.Font("PT Bold Heading", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.explain.ForeColor = System.Drawing.Color.White;
            this.explain.Location = new System.Drawing.Point(289, 236);
            this.explain.Name = "explain";
            this.explain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.explain.Size = new System.Drawing.Size(186, 42);
            this.explain.TabIndex = 49;
            this.explain.Text = "تمت العملية بنجاح";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ExplainTheOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(758, 515);
            this.Controls.Add(this.explain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExplainTheOperation";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExplainTheOperation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label explain;
        private System.Windows.Forms.Timer timer1;
    }
}