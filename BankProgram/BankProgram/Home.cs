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
    public partial class Home : Form
    {
        openNewAccount openNewAccount1 = new openNewAccount();

        public Home()
        {
            InitializeComponent();
            showDataToScreen();          
        }
     

        private void CloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maxmizeForm_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void minimizeForm_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseForm_MouseHover(object sender, EventArgs e)
        {
            // عرض كلمة اغلاق عند تمرير الماوس فوق الزر
        }

        private void OpenNewAccount_Click(object sender, EventArgs e)
        {          
            openNewAccount1.ShowDialog();
            this.showDataToScreen();   
        }

      
        private void modifyAccountData_Click(object sender, EventArgs e)
        {
            openNewAccount1.modify();
            this.showDataToScreen();
        }

        private void DeleteAccount_Click(object sender, EventArgs e)
        {
            openNewAccount1.delete();
            this.showDataToScreen();
        }

        private void QueryAboutAccount_Click(object sender, EventArgs e)
        {
            openNewAccount1.search();
            this.showDataToScreen();
            //serviceForm sf = new serviceForm();
            // sf.ShowDialog();
        }

        private void showData_Click(object sender, EventArgs e)
        {
            openNewAccount1.showData();
        }

        private void tvHome_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string strForms = tvHome.SelectedNode.Text;
            
            if (strForms == "الصفحة الرئيسية")
                ActiveForm.Show();

            else if (strForms == "عرض الحسابات")
                openNewAccount1.showData();
            

        }  // end hoem method ; 

        private void Home_Load(object sender, EventArgs e)
        {
            this.showDataToScreen();            
        }

        public void showDataToScreen()
        {
            openNewAccount1.read();
            accountTotal.Text = "                 " + openNewAccount.s6 + "\r\n          إجمالي الحسابات\r\n        \r\n\r\n";
            activeAccount.Text = "                 " + openNewAccount.s1 + "\r\n        الحسابات الفعالة      \r\n        \r\n\r\n";
            defrezeAccount.Text = "                 " + openNewAccount.s2 + "\r\n      الحسابات المجمدة    \r\n        \r\n\r\n";
            accountOpenedToday.Text = "                 " + openNewAccount.s5 + "\r\n      الحسابات المفتوحة اليوم     \r\n        \r\n\r\n";
            accountDepositeToday.Text = "                 " + openNewAccount.s3 + "\r\n   الحسابات المودوع فيها \r\n        \r\n\r\n";
            accountMistToday.Text = "                 " + openNewAccount.s4 + "\r\n    الحسابات المسحوب منها \r\n\r\n        \r\n\r\n";
        }

        private void activeAccount_Click(object sender, EventArgs e)
        {

        }
    } // end class

} // end namespace
