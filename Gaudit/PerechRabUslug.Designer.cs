namespace Gaudit
{
    partial class PerechRabUslug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerechRabUslug));
            this.grdPerRabUsl = new System.Windows.Forms.DataGridView();
            this.grdPerRabUslDetals = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetClipBoard = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdPerRabUsl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPerRabUslDetals)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdPerRabUsl
            // 
            this.grdPerRabUsl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPerRabUsl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPerRabUsl.Location = new System.Drawing.Point(6, 100);
            this.grdPerRabUsl.Name = "grdPerRabUsl";
            this.grdPerRabUsl.Size = new System.Drawing.Size(816, 175);
            this.grdPerRabUsl.TabIndex = 6;
            this.grdPerRabUsl.SelectionChanged += new System.EventHandler(this.grdPerRabUsl_SelectionChanged);
            // 
            // grdPerRabUslDetals
            // 
            this.grdPerRabUslDetals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPerRabUslDetals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPerRabUslDetals.Location = new System.Drawing.Point(6, 281);
            this.grdPerRabUslDetals.Name = "grdPerRabUslDetals";
            this.grdPerRabUslDetals.Size = new System.Drawing.Size(816, 259);
            this.grdPerRabUslDetals.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(852, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "_";
            // 
            // btnGetClipBoard
            // 
            this.btnGetClipBoard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGetClipBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetClipBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnGetClipBoard.Image")));
            this.btnGetClipBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetClipBoard.Location = new System.Drawing.Point(840, 104);
            this.btnGetClipBoard.Name = "btnGetClipBoard";
            this.btnGetClipBoard.Size = new System.Drawing.Size(170, 55);
            this.btnGetClipBoard.TabIndex = 11;
            this.btnGetClipBoard.Text = "Получить и сохранить данные перечня работ и услуг";
            this.btnGetClipBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetClipBoard.UseVisualStyleBackColor = true;
            this.btnGetClipBoard.Click += new System.EventHandler(this.btnReestrPerRabUsl_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.Image = global::Gaudit.Properties.Resources.ChangeQueryType_deletequery_274_32;
            this.btnDelete.Location = new System.Drawing.Point(840, 176);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 55);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Удалить перечент работ и услуг";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(840, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 55);
            this.button1.TabIndex = 13;
            this.button1.Text = "Получить и сохранить детальные данные\r\n\r\n";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPerRabUslDetails_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 1, 1, 1);
            this.label2.Size = new System.Drawing.Size(1025, 89);
            this.label2.TabIndex = 14;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdPerRabUslDetals);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.grdPerRabUsl);
            this.panel1.Controls.Add(this.btnGetClipBoard);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 543);
            this.panel1.TabIndex = 15;
            // 
            // PerechRabUslug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1058, 567);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "PerechRabUslug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реестр перечней работ и услуг";
            this.Load += new System.EventHandler(this.PerechRabUslug_Load);
            this.Resize += new System.EventHandler(this.PerechRabUslug_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.grdPerRabUsl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPerRabUslDetals)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdPerRabUsl;
        private System.Windows.Forms.DataGridView grdPerRabUslDetals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetClipBoard;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}