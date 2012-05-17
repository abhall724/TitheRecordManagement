namespace TitheProgram
{
    partial class AllTitheRecords
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titheDataSet = new TitheProgram.titheDataSet();
            this.titheRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titheRecordTableAdapter = new TitheProgram.titheDataSetTableAdapters.TitheRecordTableAdapter();
            this.titheRecordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titheRecordDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkYesOrNoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashYesOrNoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.titheTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titheDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titheRecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titheRecordIDDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn,
            this.titheRecordDateDataGridViewTextBoxColumn,
            this.checkYesOrNoDataGridViewCheckBoxColumn,
            this.checkNumberDataGridViewTextBoxColumn,
            this.recordAmtDataGridViewTextBoxColumn,
            this.cashYesOrNoDataGridViewCheckBoxColumn,
            this.titheTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.titheRecordBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(839, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // titheDataSet
            // 
            this.titheDataSet.DataSetName = "titheDataSet";
            this.titheDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // titheRecordIDDataGridViewTextBoxColumn
            // 
            this.titheRecordIDDataGridViewTextBoxColumn.DataPropertyName = "TitheRecordID";
            this.titheRecordIDDataGridViewTextBoxColumn.HeaderText = "TitheRecordID";
            this.titheRecordIDDataGridViewTextBoxColumn.Name = "titheRecordIDDataGridViewTextBoxColumn";
            this.titheRecordIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titheRecordDateDataGridViewTextBoxColumn
            // 
            this.titheRecordDateDataGridViewTextBoxColumn.DataPropertyName = "TitheRecordDate";
            this.titheRecordDateDataGridViewTextBoxColumn.HeaderText = "TitheRecordDate";
            this.titheRecordDateDataGridViewTextBoxColumn.Name = "titheRecordDateDataGridViewTextBoxColumn";
            this.titheRecordDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkYesOrNoDataGridViewCheckBoxColumn
            // 
            this.checkYesOrNoDataGridViewCheckBoxColumn.DataPropertyName = "Check(YesOrNo)";
            this.checkYesOrNoDataGridViewCheckBoxColumn.HeaderText = "Check(YesOrNo)";
            this.checkYesOrNoDataGridViewCheckBoxColumn.Name = "checkYesOrNoDataGridViewCheckBoxColumn";
            this.checkYesOrNoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // checkNumberDataGridViewTextBoxColumn
            // 
            this.checkNumberDataGridViewTextBoxColumn.DataPropertyName = "CheckNumber";
            this.checkNumberDataGridViewTextBoxColumn.HeaderText = "CheckNumber";
            this.checkNumberDataGridViewTextBoxColumn.Name = "checkNumberDataGridViewTextBoxColumn";
            this.checkNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recordAmtDataGridViewTextBoxColumn
            // 
            this.recordAmtDataGridViewTextBoxColumn.DataPropertyName = "RecordAmt";
            this.recordAmtDataGridViewTextBoxColumn.HeaderText = "RecordAmt";
            this.recordAmtDataGridViewTextBoxColumn.Name = "recordAmtDataGridViewTextBoxColumn";
            this.recordAmtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cashYesOrNoDataGridViewCheckBoxColumn
            // 
            this.cashYesOrNoDataGridViewCheckBoxColumn.DataPropertyName = "Cash(YesOrNo)";
            this.cashYesOrNoDataGridViewCheckBoxColumn.HeaderText = "Cash(YesOrNo)";
            this.cashYesOrNoDataGridViewCheckBoxColumn.Name = "cashYesOrNoDataGridViewCheckBoxColumn";
            this.cashYesOrNoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // titheTypeDataGridViewTextBoxColumn
            // 
            this.titheTypeDataGridViewTextBoxColumn.DataPropertyName = "TitheType";
            this.titheTypeDataGridViewTextBoxColumn.HeaderText = "TitheType";
            this.titheTypeDataGridViewTextBoxColumn.Name = "titheTypeDataGridViewTextBoxColumn";
            this.titheTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AllTitheRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 262);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AllTitheRecords";
            this.Text = "AllTitheRecords";
            this.Load += new System.EventHandler(this.AllTitheRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titheDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titheRecordBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private titheDataSet titheDataSet;
        private System.Windows.Forms.BindingSource titheRecordBindingSource;
        private titheDataSetTableAdapters.TitheRecordTableAdapter titheRecordTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titheRecordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titheRecordDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkYesOrNoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordAmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cashYesOrNoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titheTypeDataGridViewTextBoxColumn;
    }
}