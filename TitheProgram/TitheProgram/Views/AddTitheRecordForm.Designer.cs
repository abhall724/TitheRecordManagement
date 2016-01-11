namespace TitheProgram
{
    partial class AddTitheRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMember = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.rdoMisc = new System.Windows.Forms.RadioButton();
            this.rdoTithes = new System.Windows.Forms.RadioButton();
            this.rdoMissions = new System.Windows.Forms.RadioButton();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCheckNumb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.grpType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member";
            // 
            // cmbMember
            // 
            this.cmbMember.FormattingEnabled = true;
            this.cmbMember.Location = new System.Drawing.Point(96, 16);
            this.cmbMember.Name = "cmbMember";
            this.cmbMember.Size = new System.Drawing.Size(180, 21);
            this.cmbMember.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(96, 47);
            this.dtpDate.MinDate = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(180, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.rdoMisc);
            this.grpType.Controls.Add(this.rdoTithes);
            this.grpType.Controls.Add(this.rdoMissions);
            this.grpType.Location = new System.Drawing.Point(343, 95);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(176, 90);
            this.grpType.TabIndex = 8;
            this.grpType.TabStop = false;
            this.grpType.Text = "Type";
            // 
            // rdoMisc
            // 
            this.rdoMisc.AutoSize = true;
            this.rdoMisc.Location = new System.Drawing.Point(6, 65);
            this.rdoMisc.Name = "rdoMisc";
            this.rdoMisc.Size = new System.Drawing.Size(50, 17);
            this.rdoMisc.TabIndex = 2;
            this.rdoMisc.Text = "Misc.";
            this.rdoMisc.UseVisualStyleBackColor = true;
            // 
            // rdoTithes
            // 
            this.rdoTithes.AutoSize = true;
            this.rdoTithes.Checked = true;
            this.rdoTithes.Location = new System.Drawing.Point(6, 42);
            this.rdoTithes.Name = "rdoTithes";
            this.rdoTithes.Size = new System.Drawing.Size(54, 17);
            this.rdoTithes.TabIndex = 1;
            this.rdoTithes.TabStop = true;
            this.rdoTithes.Text = "Tithes";
            this.rdoTithes.UseVisualStyleBackColor = true;
            // 
            // rdoMissions
            // 
            this.rdoMissions.AutoSize = true;
            this.rdoMissions.Location = new System.Drawing.Point(6, 19);
            this.rdoMissions.Name = "rdoMissions";
            this.rdoMissions.Size = new System.Drawing.Size(65, 17);
            this.rdoMissions.TabIndex = 0;
            this.rdoMissions.Text = "Missions";
            this.rdoMissions.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(392, 16);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Amount:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(74, 215);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(206, 215);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(343, 215);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Ca&ncel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Check #:";
            // 
            // txtCheckNumb
            // 
            this.txtCheckNumb.Location = new System.Drawing.Point(392, 46);
            this.txtCheckNumb.Name = "txtCheckNumb";
            this.txtCheckNumb.Size = new System.Drawing.Size(100, 20);
            this.txtCheckNumb.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Payment Type:";
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Location = new System.Drawing.Point(96, 79);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(180, 21);
            this.cmbPaymentType.TabIndex = 18;
            // 
            // AddTitheRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 267);
            this.Controls.Add(this.cmbPaymentType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCheckNumb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMember);
            this.Controls.Add(this.label1);
            this.Name = "AddTitheRecord";
            this.Text = "TitheRecord";
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.RadioButton rdoMisc;
        private System.Windows.Forms.RadioButton rdoTithes;
        private System.Windows.Forms.RadioButton rdoMissions;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCheckNumb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPaymentType;
    }
}