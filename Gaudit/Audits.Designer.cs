namespace Gaudit
{
    partial class Audits
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
            this.grdSelectAudit = new System.Windows.Forms.DataGridView();
            this.btnAddAudit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartAudit = new System.Windows.Forms.Button();
            this.btnStopAudit = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnCorrectAddr = new System.Windows.Forms.Button();
            this.iDAuditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Gaudit.DataSet1();
            this.auditTableAdapter = new Gaudit.DataSet1TableAdapters.AuditTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelectAudit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSelectAudit
            // 
            this.grdSelectAudit.AllowUserToAddRows = false;
            this.grdSelectAudit.AutoGenerateColumns = false;
            this.grdSelectAudit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSelectAudit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAuditDataGridViewTextBoxColumn,
            this.iDCompanyDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.auditNameDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn});
            this.grdSelectAudit.DataSource = this.auditBindingSource;
            this.grdSelectAudit.Location = new System.Drawing.Point(43, 37);
            this.grdSelectAudit.MultiSelect = false;
            this.grdSelectAudit.Name = "grdSelectAudit";
            this.grdSelectAudit.ReadOnly = true;
            this.grdSelectAudit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSelectAudit.Size = new System.Drawing.Size(596, 336);
            this.grdSelectAudit.TabIndex = 0;
            this.grdSelectAudit.SelectionChanged += new System.EventHandler(this.grdSelectAudit_SelectionChanged);
            this.grdSelectAudit.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.grdSelectAudit_UserDeletingRow);
            // 
            // btnAddAudit
            // 
            this.btnAddAudit.Location = new System.Drawing.Point(663, 37);
            this.btnAddAudit.Name = "btnAddAudit";
            this.btnAddAudit.Size = new System.Drawing.Size(107, 40);
            this.btnAddAudit.TabIndex = 2;
            this.btnAddAudit.Text = "Добавить аудит";
            this.btnAddAudit.UseVisualStyleBackColor = true;
            this.btnAddAudit.Click += new System.EventHandler(this.btnAddAudit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите аудит:";
            // 
            // btnStartAudit
            // 
            this.btnStartAudit.Location = new System.Drawing.Point(663, 105);
            this.btnStartAudit.Name = "btnStartAudit";
            this.btnStartAudit.Size = new System.Drawing.Size(107, 36);
            this.btnStartAudit.TabIndex = 4;
            this.btnStartAudit.Text = "Начать аудит";
            this.btnStartAudit.UseVisualStyleBackColor = true;
            this.btnStartAudit.Click += new System.EventHandler(this.btnStartAudit_Click);
            // 
            // btnStopAudit
            // 
            this.btnStopAudit.Location = new System.Drawing.Point(663, 231);
            this.btnStopAudit.Name = "btnStopAudit";
            this.btnStopAudit.Size = new System.Drawing.Size(107, 36);
            this.btnStopAudit.TabIndex = 5;
            this.btnStopAudit.Text = "Закончить аудит";
            this.btnStopAudit.UseVisualStyleBackColor = true;
            this.btnStopAudit.Click += new System.EventHandler(this.btnStopAudit_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(663, 168);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(107, 36);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Отчет по аудиту";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnCorrectAddr
            // 
            this.btnCorrectAddr.Location = new System.Drawing.Point(663, 291);
            this.btnCorrectAddr.Name = "btnCorrectAddr";
            this.btnCorrectAddr.Size = new System.Drawing.Size(107, 36);
            this.btnCorrectAddr.TabIndex = 7;
            this.btnCorrectAddr.Text = "Корректоровать адреса";
            this.btnCorrectAddr.UseVisualStyleBackColor = true;
            this.btnCorrectAddr.Click += new System.EventHandler(this.btnCorrectAddr_Click);
            // 
            // iDAuditDataGridViewTextBoxColumn
            // 
            this.iDAuditDataGridViewTextBoxColumn.DataPropertyName = "ID_Audit";
            this.iDAuditDataGridViewTextBoxColumn.HeaderText = "ID_Audit";
            this.iDAuditDataGridViewTextBoxColumn.Name = "iDAuditDataGridViewTextBoxColumn";
            this.iDAuditDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDAuditDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDCompanyDataGridViewTextBoxColumn
            // 
            this.iDCompanyDataGridViewTextBoxColumn.DataPropertyName = "ID_Company";
            this.iDCompanyDataGridViewTextBoxColumn.HeaderText = "ID_Company";
            this.iDCompanyDataGridViewTextBoxColumn.Name = "iDCompanyDataGridViewTextBoxColumn";
            this.iDCompanyDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCompanyDataGridViewTextBoxColumn.Visible = false;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Компания";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.companyDataGridViewTextBoxColumn.Width = 180;
            // 
            // auditNameDataGridViewTextBoxColumn
            // 
            this.auditNameDataGridViewTextBoxColumn.DataPropertyName = "AuditName";
            this.auditNameDataGridViewTextBoxColumn.HeaderText = "Имя аудита";
            this.auditNameDataGridViewTextBoxColumn.Name = "auditNameDataGridViewTextBoxColumn";
            this.auditNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.auditNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.auditNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            this.userDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.userDataGridViewTextBoxColumn.Width = 130;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dateTimeDataGridViewTextBoxColumn.Width = 110;
            // 
            // auditBindingSource
            // 
            this.auditBindingSource.DataMember = "Audit";
            this.auditBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auditTableAdapter
            // 
            this.auditTableAdapter.ClearBeforeFill = true;
            // 
            // Audits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCorrectAddr);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnStopAudit);
            this.Controls.Add(this.btnStartAudit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdSelectAudit);
            this.Controls.Add(this.btnAddAudit);
            this.Name = "Audits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подготовка аудита";
            this.Load += new System.EventHandler(this.Audits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSelectAudit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddAudit;
        private System.Windows.Forms.DataGridView grdSelectAudit;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource auditBindingSource;
        private DataSet1TableAdapters.AuditTableAdapter auditTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAuditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartAudit;
        private System.Windows.Forms.Button btnStopAudit;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnCorrectAddr;
    }
}