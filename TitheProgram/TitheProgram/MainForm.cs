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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            titheFile tf = new titheFile();

            if (tf.TitheDirectory())
            {
                if (!tf.fileExist())
                {
                    var results = MessageBox.Show("Please restore database to continue!", "Error!", MessageBoxButtons.OKCancel);
                    if (results == DialogResult.OK)
                    {
                        BackUpAndRestoreFrm brFrm = new BackUpAndRestoreFrm();
                        brFrm.ShowDialog();    
                    }
                    else
                    {
                        this.Close();
                    }
                }
                

            }
            else
            {
                MessageBox.Show("Error: File IO Error!");
                this.Close();
            }
            TitheRecord genRecord = new TitheRecord();
            Member memRecord = new Member();
            lblMemOut.Text = memRecord.totalMembers();
            lblDonOut.Text = genRecord.totalDonations();
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMemberForm addMemberForm = new AddMemberForm();
            addMemberForm.ShowDialog();
        }

        private void newRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTitheRecord addRecordForm = new AddTitheRecord();
            addRecordForm.ShowDialog();

        }

        /*private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/

        private void showAllRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AllTitheRecords = new AllTitheRecords();
            AllTitheRecords.ShowDialog();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuDatabaseBackup_Click(object sender, EventArgs e)
        {
            BackUpAndRestoreFrm brFrm = new BackUpAndRestoreFrm();
            brFrm.ShowDialog();
        }

    }

}
