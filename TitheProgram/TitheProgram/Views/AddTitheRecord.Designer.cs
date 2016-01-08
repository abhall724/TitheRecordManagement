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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMember = new System.Windows.Forms.ComboBox();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titheDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titheDataSet = new TitheProgram.titheDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.rdoCheck = new System.Windows.Forms.RadioButton();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoMisc = new System.Windows.Forms.RadioButton();
            this.rdoTithes = new System.Windows.Forms.RadioButton();
            this.rdoMissions = new System.Windows.Forms.RadioButton();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.membersTableAdapter = new TitheProgram.titheDataSetTableAdapters.MembersTableAdapter();
            this.titheRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titheRecordTableAdapter = new TitheProgram.titheDataSetTableAdapters.TitheRecordTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCheckNumb = new System.Windows.Forms.TextBox();
            this.membersTitheRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titheDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titheDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titheRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersTitheRecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MemberID:";
            // 
            // cmbMember
            // 
            this.cmbMember.FormattingEnabled = true;
            this.cmbMember.Location = new System.Drawing.Point(84, 16);
            this.cmbMember.Name = "cmbMember";
            this.cmbMember.Size = new System.Drawing.Size(115, 21);
            this.cmbMember.TabIndex = 1;
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.titheDataSetBindingSource;
            // 
            // titheDataSetBindingSource
            // 
            this.titheDataSetBindingSource.DataSource = this.titheDataSet;
            this.titheDataSetBindingSource.Position = 0;
            // 
            // titheDataSet
            // 
            this.titheDataSet.DataSetName = "titheDataSet";
            this.titheDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(84, 53);
            this.dtpDate.MinDate = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(104, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // rdoCheck
            // 
            this.rdoCheck.AutoSize = true;
            this.rdoCheck.Location = new System.Drawing.Point(10, 19);
            this.rdoCheck.Name = "rdoCheck";
            this.rdoCheck.Size = new System.Drawing.Size(56, 17);
            this.rdoCheck.TabIndex = 4;
            this.rdoCheck.TabStop = true;
            this.rdoCheck.Text = "Check";
            this.rdoCheck.UseVisualStyleBackColor = true;
            // 
            // rdoCash
            // 
            this.rdoCash.AutoSize = true;
            this.rdoCash.Location = new System.Drawing.Point(10, 53);
            this.rdoCash.Name = "rdoCash";
            this.rdoCash.Size = new System.Drawing.Size(49, 17);
            this.rdoCash.TabIndex = 5;
            this.rdoCash.TabStop = true;
            this.rdoCash.Text = "Cash";
            this.rdoCash.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoCash);
            this.groupBox1.Controls.Add(this.rdoCheck);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 90);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoMisc);
            this.groupBox2.Controls.Add(this.rdoTithes);
            this.groupBox2.Controls.Add(this.rdoMissions);
            this.groupBox2.Location = new System.Drawing.Point(132, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 90);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type";
            // 
            // rdoMisc
            // 
            this.rdoMisc.AutoSize = true;
            this.rdoMisc.Location = new System.Drawing.Point(6, 59);
            this.rdoMisc.Name = "rdoMisc";
            this.rdoMisc.Size = new System.Drawing.Size(50, 17);
            this.rdoMisc.TabIndex = 2;
            this.rdoMisc.TabStop = true;
            this.rdoMisc.Text = "Misc.";
            this.rdoMisc.UseVisualStyleBackColor = true;
            // 
            // rdoTithes
            // 
            this.rdoTithes.AutoSize = true;
            this.rdoTithes.Location = new System.Drawing.Point(6, 36);
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
            this.rdoMissions.Location = new System.Drawing.Point(6, 13);
            this.rdoMissions.Name = "rdoMissions";
            this.rdoMissions.Size = new System.Drawing.Size(65, 17);
            this.rdoMissions.TabIndex = 0;
            this.rdoMissions.TabStop = true;
            this.rdoMissions.Text = "Missions";
            this.rdoMissions.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(259, 16);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Amount:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 202);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(147, 202);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(284, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Ca&ncel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // titheRecordBindingSource
            // 
            this.titheRecordBindingSource.DataMember = "TitheRecord";
            this.titheRecordBindingSource.DataSource = this.titheDataSet;
            // 
            // titheRecordTableAdapter
            // 
            this.titheRecordTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Check #:";
            // 
            // txtCheckNumb
            // 
            this.txtCheckNumb.Location = new System.Drawing.Point(259, 54);
            this.txtCheckNumb.Name = "txtCheckNumb";
            this.txtCheckNumb.Size = new System.Drawing.Size(100, 20);
            this.txtCheckNumb.TabIndex = 16;
            // 
            // membersTitheRecordBindingSource
            // 
            this.membersTitheRecordBindingSource.DataMember = "MembersTitheRecord";
            this.membersTitheRecordBindingSource.DataSource = this.membersBindingSource;
            // 
            // AddTitheRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 255);
            this.Controls.Add(this.txtCheckNumb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMember);
            this.Controls.Add(this.label1);
            this.Name = "AddTitheRecord";
            this.Text = "TitheRecord";
            this.Load += new System.EventHandler(this.TitheRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titheDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titheDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titheRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersTitheRecordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RadioButton rdoCheck;
        private System.Windows.Forms.RadioButton rdoCash;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoMisc;
        private System.Windows.Forms.RadioButton rdoTithes;
        private System.Windows.Forms.RadioButton rdoMissions;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource titheDataSetBindingSource;
        private titheDataSet titheDataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private titheDataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private System.Windows.Forms.BindingSource titheRecordBindingSource;
        private titheDataSetTableAdapters.TitheRecordTableAdapter titheRecordTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCheckNumb;
        private System.Windows.Forms.BindingSource membersTitheRecordBindingSource;
    }
}