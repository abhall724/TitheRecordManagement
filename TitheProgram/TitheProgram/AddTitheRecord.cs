using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TitheProgram
{
    public partial class AddTitheRecord : Form
    {

        string memberID;
        Boolean boolCash;
        bool boolCheck;
        string strType;
        string strCheckNumb = "NA";
        decimal decAmount = 0.0M;

        TitheRecord myRecord = new TitheRecord();


        public AddTitheRecord()
        {
            InitializeComponent();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {

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
            memberID = cmbMember.Text; 

            if(rdoCash.Checked)
            {
                boolCash = true;
                boolCheck = false;
            }
            else if(rdoCheck.Checked)
            {
                boolCheck = true;
                boolCash = false;
            }
            else
            {
                MessageBox.Show("There was a problem with your selection.", "Error!");
                
            }
            if (rdoMissions.Checked)
            {
                strType = "Missions";
            }
            else if(rdoTithes.Checked)
                strType = "Tithes";
            else
                strType = "Misc.";

           }

    }
}
