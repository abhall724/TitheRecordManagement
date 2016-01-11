using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TitheProgram.Interfaces;
using TitheProgram.Controllers;
using TitheProgram.Models;

namespace TitheProgram
{
    public partial class AddMemberForm : Form, IView
    {
        private AddMemberController controller;

        public AddMemberForm()
        {
            this.InitializeComponent();
            this.controller = Program.controllerFactory.getAddMemberController();
            this.controller.SetView(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.firstname = this.txtFirstName.Text;
            member.lastname = this.txtLastName.Text;
            member.middleInitial= this.txtMiddleInt.Text;
            member.address = this.txtAddress.Text;
            member.city = this.txtCity.Text;
            member.state = this.txtState.Text;
            member.zip = this.txtZip.Text;

            this.controller.AddMember(member);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtFirstName.Clear();
            this.txtLastName.Clear();
            this.txtMiddleInt.Clear();
            this.txtAddress.Clear();
            this.txtCity.Clear();
            this.txtState.Clear();
            this.txtZip.Clear();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Add New Member", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
