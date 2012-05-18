using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TitheProgram
{
    public partial class AddTitheRecord : Form
    {

        string memberID;
        Boolean boolCash;
        bool boolCheck;
        string strType;
        string strCheckNumb = "000";
        decimal decAmount = 0.0M;
        //DateTime myDate;
        //TextWriter tw = new StreamWriter("test.txt");
       

        TitheRecord myRecord = new TitheRecord();


        public AddTitheRecord()
        {
            InitializeComponent();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TitheRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'titheDataSet.TitheRecord' table. You can move, or remove it, as needed.
            this.titheRecordTableAdapter.Fill(this.titheDataSet.TitheRecord);
            // TODO: This line of code loads data into the 'titheDataSet.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.titheDataSet.Members);
            this.membersTableAdapter.FillByFullName(this.titheDataSet.Members);
            cmbMember.DataSource = membersBindingSource;
            cmbMember.ValueMember = "MemberID";
            cmbMember.DisplayMember = "FullName";

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.membersTableAdapter.FillBy(this.titheDataSet.Members);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            myRecord.MemberId = cmbMember.SelectedValue.ToString(); 

            if(rdoCash.Checked)
            {
                boolCash = true;
                myRecord.boolCash = true;
                boolCheck = false;
                myRecord.boolCheck = false;
            }
            else if(rdoCheck.Checked)
            {
                boolCheck = true;
                myRecord.boolCheck = true;
                boolCash = false;
                myRecord.boolCash = false;
            }
            else
            {
                MessageBox.Show("There was a problem with your selection.", "Error!");
                boolCash = false;
                boolCheck = false;
            }
            if (rdoMissions.Checked)
            {
                strType = "missions";
                myRecord.Type = "missions";
            }
            else if (rdoTithes.Checked)
            {
                strType = "tithes";
                myRecord.Type = "tithes";
            }
            else
            {
                strType = "misc.";
                myRecord.Type = "misc.";
            }

            if (txtCheckNumb.TextLength > 0)
            {
                strCheckNumb = txtCheckNumb.Text;
                myRecord.CheckNumb = txtCheckNumb.Text;
            }
            else
            {
                strCheckNumb = "000";
                myRecord.CheckNumb = "000";
            }
            if (!decimal.TryParse(txtAmount.Text, out decAmount))
            {
                MessageBox.Show("Please enter a decimal amount!!", "Error!");
            }

            myRecord.Amount = decAmount;
            myRecord.TitheDate = dtpDate.Value;

            try
            {
                myRecord.InsertNewRecord();

            }
            catch (Exception ex)
            {
                //tw.Write(ex);
                MessageBox.Show(ex.ToString());
                //.Close();
            }
            finally
            {
                clearFields();
                cmbMember.Focus();

            }
          }

        private void fillByFullNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.membersTableAdapter.FillByFullName(this.titheDataSet.Members);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByFullNameToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.membersTableAdapter.FillByFullName(this.titheDataSet.Members);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByFullNameToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.membersTableAdapter.FillByFullName(this.titheDataSet.Members);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void clearFields()
        {
            txtAmount.Clear();
            txtCheckNumb.Clear();
            cmbMember.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
        }


    }
}
