namespace Gaudit
{
    partial class LicSchet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicSchet));
            this.grdLicSchet = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGetClipBoard = new System.Windows.Forms.Button();
            this.lblInstruct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdLicSchet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdLicSchet
            // 
            this.grdLicSchet.AllowUserToAddRows = false;
            this.grdLicSchet.AllowUserToDeleteRows = false;
            this.grdLicSchet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdLicSchet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLicSchet.Location = new System.Drawing.Point(3, 3);
            this.grdLicSchet.MultiSelect = false;
            this.grdLicSchet.Name = "grdLicSchet";
            this.grdLicSchet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLicSchet.Size = new System.Drawing.Size(1038, 394);
            this.grdLicSchet.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnGetClipBoard);
            this.splitContainer1.Panel1.Controls.Add(this.lblInstruct);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grdLicSchet);
            this.splitContainer1.Size = new System.Drawing.Size(1044, 543);
            this.splitContainer1.SplitterDistance = 124;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.Image = global::Gaudit.Properties.Resources.ChangeQueryType_deletequery_274_32;
            this.btnDelete.Location = new System.Drawing.Point(847, 65);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 45);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Удалить лицевые счета";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGetClipBoard
            // 
            this.btnGetClipBoard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGetClipBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetClipBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnGetClipBoard.Image")));
            this.btnGetClipBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetClipBoard.Location = new System.Drawing.Point(847, 14);
            this.btnGetClipBoard.Name = "btnGetClipBoard";
            this.btnGetClipBoard.Size = new System.Drawing.Size(170, 45);
            this.btnGetClipBoard.TabIndex = 8;
            this.btnGetClipBoard.Text = "Получить и сохранить данные из буфера";
            this.btnGetClipBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetClipBoard.UseVisualStyleBackColor = true;
            this.btnGetClipBoard.Click += new System.EventHandler(this.btnGetClipBoard_Click);
            // 
            // lblInstruct
            // 
            this.lblInstruct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstruct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblInstruct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblInstruct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInstruct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInstruct.Location = new System.Drawing.Point(13, 7);
            this.lblInstruct.Name = "lblInstruct";
            this.lblInstruct.Padding = new System.Windows.Forms.Padding(12);
            this.lblInstruct.Size = new System.Drawing.Size(624, 103);
            this.lblInstruct.TabIndex = 4;
            this.lblInstruct.Text = resources.GetString("lblInstruct.Text");
            // 
            // LicSchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1058, 567);
            this.Controls.Add(this.splitContainer1);
            this.Name = "LicSchet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лицевые счета";
            this.Load += new System.EventHandler(this.LicSchet_Load);
            this.Resize += new System.EventHandler(this.LicSchet_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.grdLicSchet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grdLicSchet;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblInstruct;
        private System.Windows.Forms.Button btnGetClipBoard;
        private System.Windows.Forms.Button btnDelete;
    }
}