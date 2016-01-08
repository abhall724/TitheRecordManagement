using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace TitheProgram
{
    public partial class BackUpAndRestoreFrm : Form
    {
        titheFile tf = new titheFile();

        public BackUpAndRestoreFrm()
        {
            InitializeComponent();
        }

        private void BackUpAndRestoreFrm_Load(object sender, EventArgs e)
        {

            if (tf.fileExist())
            {
                grpBackup.Enabled = true;
            }

        }

        private void btnChooseRest_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdRestore.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filename = ofdRestore.FileName;
                lblFileNameOutRestore.Text = filename;

            }
            else
            {
                MessageBox.Show("File IO Error!");
            }

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (ofdRestore.FileName.Length > 0)
            {
                try
                {
                    File.Copy(ofdRestore.FileName, "C:\\TitheProgram\\tithe.accdb");
                    MessageBox.Show("File restored successfully!", "Success!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!");
                }
            }

            else
            {
                MessageBox.Show("Please select a file!");
            }
        }

        private void btnChooseBack_Click(object sender, EventArgs e)
        {
            DialogResult result = sfdChooseBackup.ShowDialog();
        }

        private void sfdChooseBackup_FileOk(object sender, CancelEventArgs e)
        {
            string filename = sfdChooseBackup.FileName;

            lblFileNameOutBack.Text = filename;

        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (sfdChooseBackup.FileName.Length > 0)
            {
                try
                {
                    File.Copy("C:\\TitheProgram\\tithe.accdb", sfdChooseBackup.FileName);
                    MessageBox.Show("File backed up successfully!", "Success!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!");
                }
            }
            else
            {
                MessageBox.Show("Please choose a file!");
            }

        }
   
    }
}
