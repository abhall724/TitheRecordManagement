using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TitheProgram.Controllers;

namespace TitheProgram
{
    public partial class MainForm : Form
    {
        private MainFormController controller;

        public MainForm(MainFormController controller)
        {
            this.InitializeComponent();
            this.controller = controller;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.controller.Setup();
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
