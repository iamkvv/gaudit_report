namespace Gaudit
{
    partial class Voting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voting));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGetClipBoard = new System.Windows.Forms.Button();
            this.lblInstruct = new System.Windows.Forms.Label();
            this.grdVoting = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVoting)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 15);
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
            this.splitContainer1.Panel2.Controls.Add(this.grdVoting);
            this.splitContainer1.Size = new System.Drawing.Size(1034, 530);
            this.splitContainer1.SplitterDistance = 134;
            this.splitContainer1.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Image = global::Gaudit.Properties.Resources.ChangeQueryType_deletequery_274_32;
            this.btnDelete.Location = new System.Drawing.Point(840, 70);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 45);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Удалить голосования";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGetClipBoard
            // 
            this.btnGetClipBoard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGetClipBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetClipBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetClipBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnGetClipBoard.Image")));
            this.btnGetClipBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetClipBoard.Location = new System.Drawing.Point(840, 19);
            this.btnGetClipBoard.Name = "btnGetClipBoard";
            this.btnGetClipBoard.Size = new System.Drawing.Size(170, 45);
            this.btnGetClipBoard.TabIndex = 10;
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
            this.lblInstruct.Location = new System.Drawing.Point(7, 7);
            this.lblInstruct.Name = "lblInstruct";
            this.lblInstruct.Padding = new System.Windows.Forms.Padding(12);
            this.lblInstruct.Size = new System.Drawing.Size(608, 120);
            this.lblInstruct.TabIndex = 5;
            this.lblInstruct.Text = resources.GetString("lblInstruct.Text");
            // 
            // grdVoting
            // 
            this.grdVoting.AllowUserToAddRows = false;
            this.grdVoting.AllowUserToDeleteRows = false;
            this.grdVoting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdVoting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVoting.Location = new System.Drawing.Point(3, 3);
            this.grdVoting.Name = "grdVoting";
            this.grdVoting.Size = new System.Drawing.Size(1028, 386);
            this.grdVoting.TabIndex = 1;
            // 
            // Voting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1058, 567);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Voting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Голосование";
            this.Load += new System.EventHandler(this.Voting_Load);
            this.Resize += new System.EventHandler(this.Voting_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVoting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblInstruct;
        private System.Windows.Forms.DataGridView grdVoting;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetClipBoard;
    }
}