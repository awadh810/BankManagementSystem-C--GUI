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
    public partial class openNewAccount : Form
    {
        showData save = new showData();
        serviceForm SF = new serviceForm();
        public string name, address , gender, amount, type, phoneNum , IDNum ,  accountType , accountNum , NoteAccount;
        public int counter = 0;
        public static int s1, s2, s3, s4, s5 , s6;

      

        public openNewAccount()
        {
            InitializeComponent();            
            comType.SelectedIndex = 0;
            comAccount.SelectedIndex = 0;
            //toolStripStatusLabel1.Text = Convert.ToString(DateTime.Now.Year);
        }


        private void openNewAccount_Load(object sender, EventArgs e)
        {
            accountNum = (showAcountNum.Text = Convert.ToString(counter + 1));
            NoteAboutAccount.Text = "هنا قم بإدخال أي ملاحظات حول الحساب (حقل غير إلزامي) ";
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.Focus();
        }


        private void saveAccountData_Click(object sender, EventArgs e)
        {
            if (rdiMale.Checked)
                gender = "ذكر";
            else
                gender = "أنثى";

            name = txtName.Text;
            address = txtAddress.Text;
            amount = txtAmount.Text;
            phoneNum = txtPhoneNum.Text;
            IDNum = txtIDNum.Text;
            type = comType.SelectedItem.ToString();
            accountType = comAccount.SelectedItem.ToString();
            NoteAccount = NoteAboutAccount.Text;

            if (txtName.Text != "" && txtAddress.Text != "" && txtPhoneNum.Text != "" && txtIDNum.Text != "" && txtAmount.Text != "")
            {
                txtName.Clear();
                txtAddress.Clear();
                txtAmount.Clear();
                txtPhoneNum.Clear();
                txtIDNum.Clear();
                NoteAboutAccount.Clear();

                save.setValue(this.name, this.address, this.gender, this.phoneNum, this.IDNum, this.accountNum, this.accountType, "0.00", "0.00", this.amount, this.type,  "مفعل"  ,  this.NoteAccount,  counter);
                counter++;
                ExplainTheOperation E = new ExplainTheOperation();
                E.ShowDialog();
                //MessageBox.Show(" تم حفظ بيانات الحساب بنجاح ", " فتح حساب جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                accountNum = (showAcountNum.Text = Convert.ToString(counter + 1));
                NoteAboutAccount.Text = "هنا قم بإدخال أي ملاحظات حول الحساب (حقل غير إلزامي) ";
            } // end if 
            else
                MessageBox.Show("يرجئ تعبة كامل الحقول بالبيانات", "فتح حساب جديد", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                               
        }  // end save account data method ; 


        private void combackToMainScreen_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (txtName.Text != "" || txtAddress.Text != "" || txtPhoneNum.Text != "" || txtIDNum.Text != "" || txtAmount.Text != "")
            {
                result = MessageBox.Show("سيتم حذف البيانات المدخلة في الحقول  ", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    txtName.Clear();
                    txtAddress.Clear();
                    txtAmount.Clear();
                    txtPhoneNum.Clear();
                    txtIDNum.Clear();
                    NoteAboutAccount.Clear();
                    this.Close();
                }
                else
                    ActiveForm.Show();
            }
            else
                this.Close();
        }  // end comback method ;               


        private void NoteAboutAccount_Click(object sender, EventArgs e)
        {
            NoteAboutAccount.Clear();
        }


        // في الاسفل العمليات على الحسابات 
        public void search()
        {            
            string txt = SF.getText();
            if (txt != "")
                save.searchAboutAccount(txt);
        }

        public void delete()
        {
            string txt = SF.getText();
            if (txt != "")
                save.deleteAccount(txt);
        }

        public void modify()
        {
            string txt = SF.getText();
            if (txt != "")
                save.modifyRecord(txt);
        }

        public void showData()
        {
            save.ShowDialog();
        }

        public void read()
        {
            save.aoutmaticRun();
            s1 = save.actAcco;
            s2 = save.defrAcco;
            s3 = save.accDepo;
            s4 = save.accMis;
            // s5 = save.accOpeTod;
            s5 = counter;
            s6 = save.accTot;
        }

               

    } // end class ; 


} // end namespace ; 
