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
    public partial class MistAndDepositeForm : Form
    {
        public bool isMoney = false;
        string totalAmount; 
       
        public MistAndDepositeForm()
        {
            InitializeComponent();
        }

       
        private void MistAndDepositeForm_Load(object sender, EventArgs e)
        {
            txtmoney.Clear();
        }

        private void closeSendMoneyForm_Click(object sender, EventArgs e)
        {
            //txtmoney.Text = "";           
            this.Close();
        }

        private void sendTheMoney_Click(object sender, EventArgs e)
        {
            if (txtmoney.Text.Equals(totalAmount))
            {
                MessageBox.Show("العملية غير ممكنة , انت  تحاول سحب ما في الحساب من رصيد\r\n يجب ان يتبقى في الحساب مبلغ حتى يكون فعال ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if ( Convert.ToDouble(txtmoney.Text) > Convert.ToDouble(totalAmount) )
            {
                MessageBox.Show("رصيد الحساب لايتعدى المبلغ الذي قمت بأدخاله ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtmoney.Text != "")
            {
                isMoney = true;   
                this.Close();             
            }
           
            else
                MessageBox.Show("قم بأدخال المبلغ أولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);       
        }
       
        public string getLastModify(string amount)
        {
            totalAmount = amount; 
            this.ShowDialog();

            if (isMoney == false)
                txtmoney.Text = "";

            return txtmoney.Text;
        }


    }       // end class ; 

}           // end namespace ; 
