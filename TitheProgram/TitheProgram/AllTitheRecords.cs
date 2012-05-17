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
    public partial class AllTitheRecords : Form
    {
        public AllTitheRecords()
        {
            InitializeComponent();
        }

        private void AllTitheRecords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'titheDataSet.TitheRecord' table. You can move, or remove it, as needed.
            this.titheRecordTableAdapter.Fill(this.titheDataSet.TitheRecord);

        }
    }
}
