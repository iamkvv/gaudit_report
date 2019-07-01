namespace Gaudit
{
    partial class Pribors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pribors));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGetClipBoard = new System.Windows.Forms.Button();
            this.lblInstruct = new System.Windows.Forms.Label();
            this.grdPribors = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.grdPribors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.Image = global::Gaudit.Properties.Resources.ChangeQueryType_deletequery_274_32;
            this.btnDelete.Location = new System.Drawing.Point(835, 68);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 45);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить приборы   учета";
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
            this.btnGetClipBoard.Location = new System.Drawing.Point(835, 18);
            this.btnGetClipBoard.Name = "btnGetClipBoard";
            this.btnGetClipBoard.Size = new System.Drawing.Size(170, 45);
            this.btnGetClipBoard.TabIndex = 5;
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
            this.lblInstruct.Location = new System.Drawing.Point(9, 13);
            this.lblInstruct.Name = "lblInstruct";
            this.lblInstruct.Padding = new System.Windows.Forms.Padding(12);
            this.lblInstruct.Size = new System.Drawing.Size(608, 120);
            this.lblInstruct.TabIndex = 3;
            this.lblInstruct.Text = resources.GetString("lblInstruct.Text");
            // 
            // grdPribors
            // 
            this.grdPribors.AllowUserToAddRows = false;
            this.grdPribors.AllowUserToDeleteRows = false;
            this.grdPribors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPribors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPribors.Location = new System.Drawing.Point(0, 3);
            this.grdPribors.Name = "grdPribors";
            this.grdPribors.ReadOnly = true;
            this.grdPribors.Size = new System.Drawing.Size(1025, 343);
            this.grdPribors.TabIndex = 0;
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
            this.splitContainer1.Panel1.Controls.Add(this.lblInstruct);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnGetClipBoard);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grdPribors);
            this.splitContainer1.Size = new System.Drawing.Size(1028, 504);
            this.splitContainer1.SplitterDistance = 139;
            this.splitContainer1.TabIndex = 7;
            // 
            // Pribors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1058, 567);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Pribors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приборы учета";
            this.Load += new System.EventHandler(this.Pribors_Load);
            this.Resize += new System.EventHandler(this.Pribors_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.grdPribors)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblInstruct;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetClipBoard;
        private System.Windows.Forms.DataGridView grdPribors;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}