namespace Gaudit
{
    partial class DictWorkService
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
            this.grdWorkServ = new System.Windows.Forms.DataGridView();
            this.btnWorksServ = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdWorkServ)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdWorkServ
            // 
            this.grdWorkServ.AllowUserToAddRows = false;
            this.grdWorkServ.AllowUserToDeleteRows = false;
            this.grdWorkServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdWorkServ.Location = new System.Drawing.Point(22, 72);
            this.grdWorkServ.Name = "grdWorkServ";
            this.grdWorkServ.ReadOnly = true;
            this.grdWorkServ.Size = new System.Drawing.Size(822, 469);
            this.grdWorkServ.TabIndex = 0;
            // 
            // btnWorksServ
            // 
            this.btnWorksServ.Image = global::Gaudit.Properties.Resources.ResultstoGrid_9947_32;
            this.btnWorksServ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorksServ.Location = new System.Drawing.Point(861, 72);
            this.btnWorksServ.Name = "btnWorksServ";
            this.btnWorksServ.Size = new System.Drawing.Size(169, 48);
            this.btnWorksServ.TabIndex = 1;
            this.btnWorksServ.Text = "Получить   и сохранить справочник";
            this.btnWorksServ.UseVisualStyleBackColor = true;
            this.btnWorksServ.Click += new System.EventHandler(this.btnWorksServ_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnWorksServ);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.grdWorkServ);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 551);
            this.panel1.TabIndex = 18;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Gaudit.Properties.Resources.ChangeQueryType_deletequery_274_32;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(861, 141);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(169, 48);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Удалить справочник";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Работы и услуги";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 1, 1, 1);
            this.label2.Size = new System.Drawing.Size(1039, 35);
            this.label2.TabIndex = 14;
            this.label2.Text = "Справочник работ и услуг: https://my.dom.gosuslugi.ru/organization-cabinet/#!/org" +
    "-nsi/OrganizationWork";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DictWorkService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1058, 567);
            this.Controls.Add(this.panel1);
            this.Name = "DictWorkService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работы и услуги организации";
            this.Load += new System.EventHandler(this.DictWorkService_Load);
            this.Resize += new System.EventHandler(this.DictWorkService_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.grdWorkServ)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdWorkServ;
        private System.Windows.Forms.Button btnWorksServ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
    }
}