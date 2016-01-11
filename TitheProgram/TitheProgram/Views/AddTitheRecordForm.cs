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
            this.controller.SetView(this);
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
            var record = new TitheRecord();

            record.memberId = this.GetSelectedMember().id;
            record.recordDate = this.dtpDate.Value;
            record.amount = this.ParseDecimalFromAmount();
            record.checkNum = this.txtCheckNumb.Text;
            record.pamyentType = this.GetSelectedType().id;
            record.type = this.ParseTitheType();

            this.controller.AddTitheRecord(record);
        }

        private Member GetSelectedMember()
        {
            int index = this.cmbMember.SelectedIndex;

            return (Member)this.cmbMember.Items[index];
        }

        private PaymentType GetSelectedType()
        {
            int index = this.cmbPaymentType.SelectedIndex;

            return (PaymentType)this.cmbPaymentType.Items[index];
        }

        private string ParseTitheType()
        {
            if (this.rdoTithes.Checked)
            {
                return "Tithes";
            }
            else if (this.rdoMissions.Checked)
            {
                return "Missions";
            }
            else
            {
                return "Misc";
            }
        }

        private decimal ParseDecimalFromAmount()
        {
            decimal amount;

            if (decimal.TryParse(this.txtAmount.Text, out amount))
            {
                return amount;
            }
            else
            {
                return 0;
            }
        }

        private void ClearFields()
        {
            this.txtAmount.Clear();
            this.txtCheckNumb.Clear();
            this.cmbMember.SelectedIndex = -1;
            this.dtpDate.Value = DateTime.Now;
            this.cmbPaymentType.SelectedIndex = 0;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Add Tithe Record", MessageBoxButtons.OK);
            this.Close();
        }

        public void SetMembers(List<Member> members)
        {
            this.cmbMember.Items.AddRange(members.ToArray());
        }

        public void SetPaymentTypes(List<PaymentType> types)
        {
            this.cmbPaymentType.Items.AddRange(types.ToArray());
        }
    }
}
