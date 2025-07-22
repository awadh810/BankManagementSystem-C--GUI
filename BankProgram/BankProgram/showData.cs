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
    public partial class showData : Form
    {
        showDataAccount SDA = new showDataAccount();
        modifyAccountData MAD = new modifyAccountData();
        string saveValue = null;

        public  int  accTot , actAcco, defrAcco, accOpeTod, accDepo, accMis;

        public showData()
        {
            InitializeComponent();
        }

        private void showData_Load(object sender, EventArgs e)
        {

        }

        public void setValue(string name, string address, string gender, string phoneNumber, string IDNum, string accountNum, string accountType, string lastDeposit, string lastMist, string amount, string t, string stateAccount, string Note, int counter)
        {
            lvData.Items.Add(name);
            lvData.Items[counter].SubItems.Add(address);
            lvData.Items[counter].SubItems.Add(gender);
            lvData.Items[counter].SubItems.Add(phoneNumber);
            lvData.Items[counter].SubItems.Add(IDNum);
            lvData.Items[counter].SubItems.Add(accountNum);
            lvData.Items[counter].SubItems.Add(accountType);
            lvData.Items[counter].SubItems.Add(lastDeposit);
            lvData.Items[counter].SubItems.Add(lastMist);
            lvData.Items[counter].SubItems.Add(amount);
            lvData.Items[counter].SubItems.Add(t);
            lvData.Items[counter].SubItems.Add(stateAccount);
            if (Note == "هنا قم بإدخال أي ملاحظات حول الحساب (حقل غير إلزامي) ")
                Note = "";
            lvData.Items[counter].SubItems.Add(Note);

        } // end setValue method ;


        public void searchAboutAccount(string itemSearch)
        {
            bool isFound = false;
            if (lvData.Items.Count != 0)
            {
                foreach (ListViewItem item in lvData.Items)
                {
                    if (item.Text.ToLower().Equals(itemSearch.ToLower()))
                    {
                        //MessageBox.Show( "your search is found" );
                        SDA.getTheValueFromeLVData(item.SubItems[0].Text.ToString(), item.SubItems[1].Text.ToString(), item.SubItems[2].Text.ToString(), item.SubItems[3].Text.ToString(), item.SubItems[4].Text.ToString(), item.SubItems[5].Text.ToString(), item.SubItems[6].Text.ToString(), item.SubItems[7].Text.ToString(), item.SubItems[8].Text.ToString(), item.SubItems[9].Text.ToString(), item.SubItems[10].Text.ToString(), item.SubItems[11].Text.ToString(), item.SubItems[12].Text.ToString());
                        isFound = true;
                        break;
                    }
                }      // end foreach

                if (isFound == false)
                    MessageBox.Show("لاتوجد بيانات مطابقة بهذا الاسم في النظام", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }      // end if check listview have data;

            else
                MessageBox.Show("لا توجد اي حسابات في النظام ", "إشعار", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }       // end searchAboutAccount method ;


        public void deleteAccount(string itemDelete)
        {
            ExplainTheOperation ETO = new ExplainTheOperation();
            bool isDelete = false;
            if (lvData.Items.Count != 0)
            {
                foreach (ListViewItem item in lvData.Items)
                {
                    if (item.Text.ToLower().Equals(itemDelete.ToLower()))
                    {
                        lvData.Items.Remove(item);
                        ETO.Show();
                        //MessageBox.Show("your search is deleted" );
                        isDelete = true;
                        break;
                    }
                }           // end foreach

                if (isDelete == false)
                    MessageBox.Show("لاتوجد بيانات مطابقة بهذا الاسم في النظام", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }       // end if check listview have data;

            else
                MessageBox.Show("لا توجد اي حسابات في النظام ", "إشعار", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }       // end deleteAccount method ;


        public void modifyRecord(string itemModify)
        {
            saveValue = itemModify;
            bool isModify = false;
            if (lvData.Items.Count != 0)
            {
                foreach (ListViewItem item in lvData.Items)
                {
                    if (item.Text.ToLower().Equals(itemModify.ToLower()))
                    {
                        MAD.getTheValueFromeLVData(item.SubItems[0].Text.ToString(), item.SubItems[1].Text.ToString(), item.SubItems[2].Text.ToString(), item.SubItems[3].Text.ToString(), item.SubItems[4].Text.ToString(), item.SubItems[5].Text.ToString(), item.SubItems[6].Text.ToString(), item.SubItems[7].Text.ToString(), item.SubItems[8].Text.ToString(), item.SubItems[9].Text.ToString(), item.SubItems[10].Text.ToString(), item.SubItems[11].Text.ToString(), item.SubItems[12].Text.ToString(),  this);
                       // ExplainTheOperation ETO = new ExplainTheOperation();
                       // ETO.ShowDialog();
                        isModify = true;
                        break;
                    }
                }       // end foreach

                if (isModify == false)
                    MessageBox.Show("لاتوجد بيانات مطابقة بهذا الاسم في النظام", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }       // end if check listview have data;

            else
                MessageBox.Show("لا توجد اي حسابات في النظام ", "إشعار", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }       // end modifyREcord method ; 



        private void lvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvData.SelectedItems.Count > 0)
            {
                SDA.getTheValueFromeLVData(lvData.SelectedItems[0].Text.ToString(), lvData.SelectedItems[0].SubItems[1].Text.ToString(), lvData.SelectedItems[0].SubItems[2].Text.ToString(), lvData.SelectedItems[0].SubItems[3].Text.ToString(), lvData.SelectedItems[0].SubItems[4].Text.ToString(), lvData.SelectedItems[0].SubItems[5].Text.ToString(), lvData.SelectedItems[0].SubItems[6].Text.ToString(), lvData.SelectedItems[0].SubItems[7].Text.ToString(), lvData.SelectedItems[0].SubItems[8].Text.ToString(), lvData.SelectedItems[0].SubItems[9].Text.ToString(), lvData.SelectedItems[0].SubItems[10].Text.ToString(), lvData.SelectedItems[0].SubItems[11].Text.ToString(), lvData.SelectedItems[0].SubItems[12].Text.ToString());
            }
        }

        public void saveTheModifyOnAccountsData(string name  , string address ,string gender , string phoneNum , string IDNum , string accountNum , string accountType , string lastDeposite , string lastMist , string amount , string type , string state , string Note )
        {
            foreach (ListViewItem item in lvData.Items)
            {
                if (item.Text.ToLower().Equals(saveValue.ToLower()))
                {
                    item.SubItems[0].Text = name;
                    item.SubItems[1].Text = address;
                    item.SubItems[2].Text = gender;
                    item.SubItems[3].Text = phoneNum;
                    item.SubItems[4].Text = IDNum;
                    item.SubItems[5].Text = accountNum;
                    item.SubItems[6].Text = accountType;
                    item.SubItems[7].Text = lastDeposite;
                    item.SubItems[8].Text = lastMist;
                    item.SubItems[9].Text = amount;
                    item.SubItems[10].Text = type;
                    item.SubItems[11].Text = state;
                    item.SubItems[12].Text = Note;
                    break;
                }
            }       // end foreach

        }          // end saveTheModifyOnaccountData method ; 


        public void aoutmaticRun ()
        {
            accTot = 0; actAcco = 0; defrAcco = 0; accOpeTod = 0; accDepo = 0; accMis = 0;
            foreach (ListViewItem item in lvData.Items)
            {
                accTot += 1;
                if (item.SubItems[11].Text.ToLower().Equals("مفعل"))
                    actAcco += 1;
                else
                    defrAcco += 1;

                double c1 = Convert.ToDouble(item.SubItems[7].Text.ToLower());
                if ( c1 > 0.00 || c1 > 0 )
                    accDepo += 1;

                double c2 = Convert.ToDouble(item.SubItems[8].Text.ToLower());       
                if ( c2 > 0.00 || c2 > 0)       
                    accMis += 1;
               
            }       // end foreach
        }



    }       // end class

}       // end namespace 

