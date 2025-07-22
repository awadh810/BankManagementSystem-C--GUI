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
    public partial class showDataAccount : Form
    {
        public showDataAccount()
        {
            InitializeComponent();
        }

        public void getTheValueFromeLVData(string name , string address , string gender , string phoneNum , string IDNum , string accountNum , string accountType , string lastDeposit , string lastMist , string totalAmount , string type , string state , string Note)
        {
            txtName.Text = name;
            txtAddress.Text = address;
            txtGender.Text = gender;
            txtPhoneNum.Text = phoneNum;
            txtIDNum.Text = IDNum;
            txtAccountNum.Text = accountNum;
            txtType.Text = accountType;
            txtDeposit.Text = lastDeposit;
            txtMist.Text = lastMist;
            txtAmount.Text = totalAmount;
            txtAmoutType.Text = type;
            txtState.Text = state;
            NoteAboutAccount.Text = Note;
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
