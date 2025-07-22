using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProgram
{
    public partial class serviceForm : Form
    {
        public bool ischecked = false;
        public serviceForm()
        {
            InitializeComponent();
        }

        private void serviceForm_Load(object sender, EventArgs e)
        {
            txtSearch.Text = " ";                    
        }

        public void search_Click(object sender, EventArgs e)
        {         
            if (txtSearch.Text != "")
            {
                ischecked = true;
                this.Close();              
            }
            else         
                MessageBox.Show("ادخل بيانات البحث" , "خطأ" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
        }
       
        private void closeServiceForm_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.Text = "";            
            this.Close();
        }

        public string getText()
        {
            txtSearch.Clear();
            this.ShowDialog();
            return txtSearch.Text;
        }


    }  // end class 

}  // end namespace ; 
