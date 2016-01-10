using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TitheProgram.Controllers;
using TitheProgram.Interfaces;

namespace TitheProgram
{
    public partial class MainForm : Form, IView
    {
        private MainFormController controller;

        public MainForm()
        {
            this.InitializeComponent();
            this.controller = Program.controllerFactory.getMainFormController();
            this.InitializeController();
        }

        public void SetTotalMembers(string total)
        {
            this.lblMemOut.Text = total;
        }

        public void SetTotalDonations(string total)
        {
            this.lblDonOut.Text = total;
        }

        private void InitializeController()
        {
            this.controller.SetView(this);
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
