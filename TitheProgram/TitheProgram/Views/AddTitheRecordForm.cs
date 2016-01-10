using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TitheProgram.Models;
using TitheProgram.Controllers;


namespace TitheProgram
{
    public partial class AddTitheRecord : Form
    {
        private AddTitheRecordController controller;

        public AddTitheRecord()
        {
            this.InitializeComponent();
            this.controller = Program.controllerFactory.getAddTitheRecordController();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearFields();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void ClearFields()
        {
            txtAmount.Clear();
            txtCheckNumb.Clear();
            cmbMember.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Add Tithe Record", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
