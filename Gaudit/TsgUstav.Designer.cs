namespace Gaudit
{
    partial class TsgUstav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TsgUstav));
            this.grdUstav = new System.Windows.Forms.DataGridView();
            this.grdHouse = new System.Windows.Forms.DataGridView();
            this.grdUslugi = new System.Windows.Forms.DataGridView();
            this.btnGetClipBoard = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUsl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdUstav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUslugi)).BeginInit();
            this.SuspendLayout();
            // 
            // grdUstav
            // 
            this.grdUstav.AllowUserToAddRows = false;
            this.grdUstav.AllowUserToDeleteRows = false;
            this.grdUstav.AllowUserToOrderColumns = true;
            this.grdUstav.AllowUserToResizeRows = false;
            this.grdUstav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdUstav.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdUstav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUstav.Location = new System.Drawing.Point(10, 29);
            this.grdUstav.MultiSelect = false;
            this.grdUstav.Name = "grdUstav";
            this.grdUstav.ReadOnly = true;
            this.grdUstav.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUstav.Size = new System.Drawing.Size(936, 100);
            this.grdUstav.TabIndex = 0;
            this.grdUstav.SelectionChanged += new System.EventHandler(this.grdUstav_SelectionChanged);
            // 
            // grdHouse
            // 
            this.grdHouse.AllowUserToAddRows = false;
            this.grdHouse.AllowUserToDeleteRows = false;
            this.grdHouse.AllowUserToOrderColumns = true;
            this.grdHouse.AllowUserToResizeRows = false;
            this.grdHouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdHouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHouse.Location = new System.Drawing.Point(10, 154);
            this.grdHouse.MultiSelect = false;
            this.grdHouse.Name = "grdHouse";
            this.grdHouse.ReadOnly = true;
            this.grdHouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHouse.Size = new System.Drawing.Size(936, 153);
            this.grdHouse.TabIndex = 2;
            this.grdHouse.SelectionChanged += new System.EventHandler(this.grdHouse_SelectionChanged);
            // 
            // grdUslugi
            // 
            this.grdUslugi.AllowUserToAddRows = false;
            this.grdUslugi.AllowUserToDeleteRows = false;
            this.grdUslugi.AllowUserToOrderColumns = true;
            this.grdUslugi.AllowUserToResizeRows = false;
            this.grdUslugi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdUslugi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdUslugi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUslugi.Location = new System.Drawing.Point(10, 331);
            this.grdUslugi.MultiSelect = false;
            this.grdUslugi.Name = "grdUslugi";
            this.grdUslugi.ReadOnly = true;
            this.grdUslugi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUslugi.Size = new System.Drawing.Size(936, 198);
            this.grdUslugi.TabIndex = 3;
            // 
            // btnGetClipBoard
            // 
            this.btnGetClipBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetClipBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetClipBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnGetClipBoard.Image")));
            this.btnGetClipBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetClipBoard.Location = new System.Drawing.Point(971, 29);
            this.btnGetClipBoard.Name = "btnGetClipBoard";
            this.btnGetClipBoard.Size = new System.Drawing.Size(170, 45);
            this.btnGetClipBoard.TabIndex = 6;
            this.btnGetClipBoard.Text = "Получить и сохранить данные устава";
            this.btnGetClipBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetClipBoard.UseVisualStyleBackColor = true;
            this.btnGetClipBoard.Click += new System.EventHandler(this.btnGetClipBoard_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = global::Gaudit.Properties.Resources.ChangeQueryType_deletequery_274_32;
            this.btnDelete.Location = new System.Drawing.Point(971, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 45);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Удалить устав";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Устав";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Дом";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Услуги";
            // 
            // btnUsl
            // 
            this.btnUsl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsl.Image = ((System.Drawing.Image)(resources.GetObject("btnUsl.Image")));
            this.btnUsl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsl.Location = new System.Drawing.Point(971, 159);
            this.btnUsl.Name = "btnUsl";
            this.btnUsl.Size = new System.Drawing.Size(170, 45);
            this.btnUsl.TabIndex = 11;
            this.btnUsl.Text = "Получить и сохранить данные домов и услуг";
            this.btnUsl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsl.UseVisualStyleBackColor = true;
            this.btnUsl.Click += new System.EventHandler(this.btnUsl_Click);
            // 
            // TsgUstav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 547);
            this.Controls.Add(this.btnUsl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnGetClipBoard);
            this.Controls.Add(this.grdUslugi);
            this.Controls.Add(this.grdHouse);
            this.Controls.Add(this.grdUstav);
            this.Name = "TsgUstav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Устав ТСЖ";
            this.Load += new System.EventHandler(this.TsgUstav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUstav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUslugi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdUstav;
        private System.Windows.Forms.DataGridView grdHouse;
        private System.Windows.Forms.DataGridView grdUslugi;
        private System.Windows.Forms.Button btnGetClipBoard;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUsl;
    }
}