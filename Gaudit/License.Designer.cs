namespace Gaudit
{
    partial class License
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(License));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdLicHouses = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.grdLicense = new System.Windows.Forms.DataGridView();
            this.btnGetClipBoard = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGetLicHouses = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLicHouses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grdLicHouses);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.grdLicense);
            this.panel1.Controls.Add(this.btnGetClipBoard);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnGetLicHouses);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 543);
            this.panel1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Сведения о домах";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Лицензия";
            // 
            // grdLicHouses
            // 
            this.grdLicHouses.AllowUserToAddRows = false;
            this.grdLicHouses.AllowUserToDeleteRows = false;
            this.grdLicHouses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdLicHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLicHouses.Location = new System.Drawing.Point(6, 229);
            this.grdLicHouses.MultiSelect = false;
            this.grdLicHouses.Name = "grdLicHouses";
            this.grdLicHouses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLicHouses.Size = new System.Drawing.Size(816, 311);
            this.grdLicHouses.TabIndex = 7;
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
            this.label2.Size = new System.Drawing.Size(1026, 35);
            this.label2.TabIndex = 14;
            this.label2.Text = "Лицензия: https://dom.gosuslugi.ru/#!/licenses/.../houses";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grdLicense
            // 
            this.grdLicense.AllowUserToAddRows = false;
            this.grdLicense.AllowUserToDeleteRows = false;
            this.grdLicense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLicense.Location = new System.Drawing.Point(6, 64);
            this.grdLicense.MultiSelect = false;
            this.grdLicense.Name = "grdLicense";
            this.grdLicense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLicense.Size = new System.Drawing.Size(816, 140);
            this.grdLicense.TabIndex = 6;
            this.grdLicense.SelectionChanged += new System.EventHandler(this.grdLicense_SelectionChanged);
            // 
            // btnGetClipBoard
            // 
            this.btnGetClipBoard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGetClipBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetClipBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnGetClipBoard.Image")));
            this.btnGetClipBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetClipBoard.Location = new System.Drawing.Point(841, 64);
            this.btnGetClipBoard.Name = "btnGetClipBoard";
            this.btnGetClipBoard.Size = new System.Drawing.Size(170, 55);
            this.btnGetClipBoard.TabIndex = 11;
            this.btnGetClipBoard.Text = "Получить и сохранить данные лицензии";
            this.btnGetClipBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetClipBoard.UseVisualStyleBackColor = true;
            this.btnGetClipBoard.Click += new System.EventHandler(this.btnGetClipBoard_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.Image = global::Gaudit.Properties.Resources.ChangeQueryType_deletequery_274_32;
            this.btnDelete.Location = new System.Drawing.Point(841, 136);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 55);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Удалить лицензию";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGetLicHouses
            // 
            this.btnGetLicHouses.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGetLicHouses.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetLicHouses.Image = ((System.Drawing.Image)(resources.GetObject("btnGetLicHouses.Image")));
            this.btnGetLicHouses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetLicHouses.Location = new System.Drawing.Point(841, 232);
            this.btnGetLicHouses.Name = "btnGetLicHouses";
            this.btnGetLicHouses.Size = new System.Drawing.Size(170, 55);
            this.btnGetLicHouses.TabIndex = 13;
            this.btnGetLicHouses.Text = "Получить и cохранить лицензируемые дома\r\n\r\n";
            this.btnGetLicHouses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetLicHouses.UseVisualStyleBackColor = true;
            this.btnGetLicHouses.Click += new System.EventHandler(this.btnGetLicHouses_Click);
            // 
            // License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1058, 567);
            this.Controls.Add(this.panel1);
            this.Name = "License";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация лицензии";
            this.Load += new System.EventHandler(this.License_Load);
            this.Resize += new System.EventHandler(this.License_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLicHouses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLicense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdLicHouses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdLicense;
        private System.Windows.Forms.Button btnGetClipBoard;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetLicHouses;
    }
}