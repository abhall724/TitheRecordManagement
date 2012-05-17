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

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showAllRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AllTitheRecords = new AllTitheRecords();
            AllTitheRecords.Show();
        }

    }

}
