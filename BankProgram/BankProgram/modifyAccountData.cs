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
    public partial class modifyAccountData : Form
    {
        MistAndDepositeForm MADF = new MistAndDepositeForm();        
        public bool isModify = false;
        bool ismodifyAll = false;
                
        public modifyAccountData()
        {
            InitializeComponent();
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            //isModify = false;   ismodifyAll = false;            // what ever ?
            this.Close();  
        }

        private void mistMoney_Click(object sender, EventArgs e)
        {
            if (comState.Text == "مفعل")
            {
                //if (Convert.ToDouble(txtAmount.Text) > Convert.ToDouble(1000))
                //{
                    string mist = MADF.getLastModify(txtAmount.Text);
                    if (mist != "")
                    {
                        txtMist.Text = mist;
                        txtAmount.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(mist));
                        isModify = true;                        
                    }
                                          
                //}
                //else
                 //   MessageBox.Show("العملية غير ممكنة , رصيد الحساب اقل من المبلغ المطلوب لفتح الحساب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("الحساب مجمد لايمكنك إجراء اي تعديل عليه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void depositeMoney_Click(object sender, EventArgs e)
        {
            if (comState.Text == "مفعل")
            {
                string deposite = MADF.getLastModify(txtAmount.Text);
                if (deposite != "")
                {
                    txtDeposit.Text = deposite;
                    txtAmount.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) + Convert.ToDouble(deposite));
                    isModify = true;
                }                   
            }
            else
                MessageBox.Show("الحساب مجمد لايمكنك إجراء اي تعديل عليه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);                
        }

        private void modifyData_Click(object sender, EventArgs e)
        {
            txtName.ReadOnly = false;
            txtAddress.ReadOnly = false;
            rdiMale.Enabled = true;
            rdiFemale.Enabled = true;
            txtPhoneNum.ReadOnly = false;
            txtIDNum.ReadOnly = false;
            comAccount.Enabled = true;
            comType.Enabled = true;
            comState.Enabled = true;
            NoteAboutAccount.ReadOnly = false;
            ismodifyAll = true;
        }

        public void getTheValueFromeLVData(string name, string address, string gender, string phoneNum, string IDNum, string accountNum, string accountType, string lastDeposit, string lastMist, string totalAmount, string type, string state, string Note , showData Object)
        {
            txtName.Text = name;
            txtAddress.Text = address;

            if (gender == "ذكر")
                rdiMale.Checked = true;
            else
                rdiFemale.Checked = true;
          
            txtPhoneNum.Text = phoneNum;
            txtIDNum.Text = IDNum;
            txtAccountNum.Text = accountNum;
            comAccount.Text = accountType;  
            txtDeposit.Text = lastDeposit;
            txtMist.Text = lastMist;
            txtAmount.Text = totalAmount;
            comType.Text = type;
            comState.Text = state;
            NoteAboutAccount.Text = Note;

            this.ShowDialog();

            if (isModify == true  || ismodifyAll == true)
            {
                if (rdiMale.Checked)
                    gender = "ذكر";
                else
                    gender = "أنثى";
                txtName.ReadOnly = true;
                txtAddress.ReadOnly = true;
                rdiMale.Enabled = false;
                rdiFemale.Enabled = false;
                txtPhoneNum.ReadOnly = true;
                txtIDNum.ReadOnly = true;
                comAccount.Enabled = false;
                comType.Enabled = false;
                comState.Enabled = false;
                NoteAboutAccount.ReadOnly = true;

                Object.saveTheModifyOnAccountsData(txtName.Text, txtAddress.Text, gender, txtPhoneNum.Text, txtIDNum.Text, txtAccountNum.Text, comAccount.SelectedItem.ToString(), txtDeposit.Text, txtMist.Text, txtAmount.Text, comType.SelectedItem.ToString(), comState.SelectedItem.ToString(), NoteAboutAccount.Text);
            
               ExplainTheOperation ETO = new ExplainTheOperation();
               ETO.ShowDialog();
         
                ismodifyAll = false;  isModify = false;                 
            }
            
               
        }  // end getTheValueFromLvData method ; 

        
    }   // end class ; 

}  // end namespace ; 
