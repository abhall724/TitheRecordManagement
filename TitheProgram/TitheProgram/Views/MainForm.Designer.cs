namespace TitheProgram
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyByMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDatabaseBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMemOut = new System.Windows.Forms.Label();
            this.lblDonOut = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.mnuDatabase,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(481, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMemberToolStripMenuItem,
            this.newRecordToolStripMenuItem,
            this.exitToolStripMenuItem2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newMemberToolStripMenuItem
            // 
            this.newMemberToolStripMenuItem.Name = "newMemberToolStripMenuItem";
            this.newMemberToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newMemberToolStripMenuItem.Text = "&New Member";
            this.newMemberToolStripMenuItem.Click += new System.EventHandler(this.newMemberToolStripMenuItem_Click);
            // 
            // newRecordToolStripMenuItem
            // 
            this.newRecordToolStripMenuItem.Name = "newRecordToolStripMenuItem";
            this.newRecordToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newRecordToolStripMenuItem.Text = "&New Record";
            this.newRecordToolStripMenuItem.Click += new System.EventHandler(this.newRecordToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem2.Text = "&Exit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearlyByMemberToolStripMenuItem,
            this.yearlyTotalToolStripMenuItem,
            this.showAllRecordsToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.exitToolStripMenuItem.Text = "&Record";
            // 
            // yearlyByMemberToolStripMenuItem
            // 
            this.yearlyByMemberToolStripMenuItem.Name = "yearlyByMemberToolStripMenuItem";
            this.yearlyByMemberToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.yearlyByMemberToolStripMenuItem.Text = "&Yearly by member";
            // 
            // yearlyTotalToolStripMenuItem
            // 
            this.yearlyTotalToolStripMenuItem.Name = "yearlyTotalToolStripMenuItem";
            this.yearlyTotalToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.yearlyTotalToolStripMenuItem.Text = "&Yearly Total";
            // 
            // showAllRecordsToolStripMenuItem
            // 
            this.showAllRecordsToolStripMenuItem.Name = "showAllRecordsToolStripMenuItem";
            this.showAllRecordsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.showAllRecordsToolStripMenuItem.Text = "&Show all records";
            
            // 
            // mnuDatabase
            // 
            this.mnuDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDatabaseBackup});
            this.mnuDatabase.Name = "mnuDatabase";
            this.mnuDatabase.Size = new System.Drawing.Size(67, 20);
            this.mnuDatabase.Text = "&Database";
            // 
            // mnuDatabaseBackup
            // 
            this.mnuDatabaseBackup.Name = "mnuDatabaseBackup";
            this.mnuDatabaseBackup.Size = new System.Drawing.Size(157, 22);
            this.mnuDatabaseBackup.Text = "&Backup/Restore";
            this.mnuDatabaseBackup.Click += new System.EventHandler(this.mnuDatabaseBackup_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Members:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Donations this Year:";
            // 
            // lblMemOut
            // 
            this.lblMemOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMemOut.Location = new System.Drawing.Point(138, 48);
            this.lblMemOut.Name = "lblMemOut";
            this.lblMemOut.Size = new System.Drawing.Size(74, 20);
            this.lblMemOut.TabIndex = 3;
            this.lblMemOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDonOut
            // 
            this.lblDonOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDonOut.Location = new System.Drawing.Point(366, 48);
            this.lblDonOut.Name = "lblDonOut";
            this.lblDonOut.Size = new System.Drawing.Size(83, 20);
            this.lblDonOut.TabIndex = 4;
            this.lblDonOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(457, 44);
            this.label3.TabIndex = 5;
            this.label3.Text = "Southwood Church";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(481, 149);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDonOut);
            this.Controls.Add(this.lblMemOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyByMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyTotalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllRecordsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMemOut;
        private System.Windows.Forms.Label lblDonOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuDatabase;
        private System.Windows.Forms.ToolStripMenuItem mnuDatabaseBackup;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

