namespace TitheProgram
{
    partial class BackUpAndRestoreFrm
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
            this.grpBackup = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sfdChooseBackup = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFileNameOutBack = new System.Windows.Forms.Label();
            this.btnChooseBack = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFileNameOutRestore = new System.Windows.Forms.Label();
            this.btnChooseRest = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.ofdRestore = new System.Windows.Forms.OpenFileDialog();
            this.grpBackup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBackup
            // 
            this.grpBackup.Controls.Add(this.btnBackup);
            this.grpBackup.Controls.Add(this.btnChooseBack);
            this.grpBackup.Controls.Add(this.lblFileNameOutBack);
            this.grpBackup.Controls.Add(this.label1);
            this.grpBackup.Enabled = false;
            this.grpBackup.Location = new System.Drawing.Point(14, 10);
            this.grpBackup.Name = "grpBackup";
            this.grpBackup.Size = new System.Drawing.Size(500, 143);
            this.grpBackup.TabIndex = 0;
            this.grpBackup.TabStop = false;
            this.grpBackup.Text = "BackupDatabase";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRestore);
            this.groupBox2.Controls.Add(this.btnChooseRest);
            this.groupBox2.Controls.Add(this.lblFileNameOutRestore);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restore Database";
            // 
            // sfdChooseBackup
            // 
            this.sfdChooseBackup.DefaultExt = "accdb";
            this.sfdChooseBackup.FileName = "titheBackup";
            this.sfdChooseBackup.Filter = "Access files | *.accdb";
            this.sfdChooseBackup.InitialDirectory = "F:\\";
            this.sfdChooseBackup.Title = "Choose Database file:";
            this.sfdChooseBackup.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdChooseBackup_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filename:";
            // 
            // lblFileNameOutBack
            // 
            this.lblFileNameOutBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFileNameOutBack.Location = new System.Drawing.Point(80, 36);
            this.lblFileNameOutBack.Name = "lblFileNameOutBack";
            this.lblFileNameOutBack.Size = new System.Drawing.Size(391, 23);
            this.lblFileNameOutBack.TabIndex = 1;
            // 
            // btnChooseBack
            // 
            this.btnChooseBack.Location = new System.Drawing.Point(80, 82);
            this.btnChooseBack.Name = "btnChooseBack";
            this.btnChooseBack.Size = new System.Drawing.Size(75, 23);
            this.btnChooseBack.TabIndex = 2;
            this.btnChooseBack.Text = "Choose &File";
            this.btnChooseBack.UseVisualStyleBackColor = true;
            this.btnChooseBack.Click += new System.EventHandler(this.btnChooseBack_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(396, 82);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "&Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filename:";
            // 
            // lblFileNameOutRestore
            // 
            this.lblFileNameOutRestore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFileNameOutRestore.Location = new System.Drawing.Point(82, 39);
            this.lblFileNameOutRestore.Name = "lblFileNameOutRestore";
            this.lblFileNameOutRestore.Size = new System.Drawing.Size(391, 23);
            this.lblFileNameOutRestore.TabIndex = 1;
            // 
            // btnChooseRest
            // 
            this.btnChooseRest.Location = new System.Drawing.Point(82, 94);
            this.btnChooseRest.Name = "btnChooseRest";
            this.btnChooseRest.Size = new System.Drawing.Size(75, 23);
            this.btnChooseRest.TabIndex = 2;
            this.btnChooseRest.Text = "&Choose File";
            this.btnChooseRest.UseVisualStyleBackColor = true;
            this.btnChooseRest.Click += new System.EventHandler(this.btnChooseRest_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(398, 94);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 4;
            this.btnRestore.Text = "&Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // ofdRestore
            // 
            this.ofdRestore.Filter = "Access database | *.accdb";
            this.ofdRestore.InitialDirectory = "F:\\";
            this.ofdRestore.Title = "Restore database file:";
            // 
            // BackUpAndRestoreFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 315);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpBackup);
            this.Name = "BackUpAndRestoreFrm";
            this.Text = "Backup Or Restore";
            this.Load += new System.EventHandler(this.BackUpAndRestoreFrm_Load);
            this.grpBackup.ResumeLayout(false);
            this.grpBackup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBackup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnChooseBack;
        private System.Windows.Forms.Label lblFileNameOutBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog sfdChooseBackup;
        private System.Windows.Forms.Label lblFileNameOutRestore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnChooseRest;
        private System.Windows.Forms.OpenFileDialog ofdRestore;
    }
}