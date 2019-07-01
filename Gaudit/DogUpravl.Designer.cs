namespace Gaudit
{
    partial class DogUpravl
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
            this.grdDogUpravl = new System.Windows.Forms.DataGridView();
            this.grdUslugi = new System.Windows.Forms.DataGridView();
            this.lblCurrDogovor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPerech = new System.Windows.Forms.Button();
            this.btnClipBoard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdDogUpravl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUslugi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDogUpravl
            // 
            this.grdDogUpravl.AllowUserToAddRows = false;
            this.grdDogUpravl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDogUpravl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDogUpravl.Location = new System.Drawing.Point(6, 69);
            this.grdDogUpravl.MultiSelect = false;
            this.grdDogUpravl.Name = "grdDogUpravl";
            this.grdDogUpravl.ReadOnly = true;
            this.grdDogUpravl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDogUpravl.ShowCellErrors = false;
            this.grdDogUpravl.ShowEditingIcon = false;
            this.grdDogUpravl.ShowRowErrors = false;
            this.grdDogUpravl.Size = new System.Drawing.Size(818, 144);
            this.grdDogUpravl.TabIndex = 0;
            this.grdDogUpravl.SelectionChanged += new System.EventHandler(this.grdDogUpravl_SelectionChanged);
            // 
            // grdUslugi
            // 
            this.grdUslugi.AllowUserToAddRows = false;
            this.grdUslugi.AllowUserToDeleteRows = false;
            this.grdUslugi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdUslugi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUslugi.Location = new System.Drawing.Point(9, 241);
            this.grdUslugi.Name = "grdUslugi";
            this.grdUslugi.ReadOnly = true;
            this.grdUslugi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUslugi.Size = new System.Drawing.Size(815, 301);
            this.grdUslugi.TabIndex = 5;
            // 
            // lblCurrDogovor
            // 
            this.lblCurrDogovor.AutoSize = true;
            this.lblCurrDogovor.Location = new System.Drawing.Point(857, 200);
            this.lblCurrDogovor.Name = "lblCurrDogovor";
            this.lblCurrDogovor.Size = new System.Drawing.Size(35, 13);
            this.lblCurrDogovor.TabIndex = 6;
            this.lblCurrDogovor.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblCurrDogovor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPerech);
            this.panel1.Controls.Add(this.grdUslugi);
            this.panel1.Controls.Add(this.btnClipBoard);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.grdDogUpravl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 550);
            this.panel1.TabIndex = 17;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Gaudit.Properties.Resources.ChangeQueryType_deletequery_274_32;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(860, 142);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 48);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Удалить договоры управления";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Коммунальные и дополнительные услуги";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Договоры управления (устав)";
            // 
            // btnPerech
            // 
            this.btnPerech.Image = global::Gaudit.Properties.Resources.ResultstoGrid_9947_32;
            this.btnPerech.Location = new System.Drawing.Point(860, 241);
            this.btnPerech.Name = "btnPerech";
            this.btnPerech.Size = new System.Drawing.Size(155, 48);
            this.btnPerech.TabIndex = 2;
            this.btnPerech.Text = "Получить и сохранить управляемые объекты";
            this.btnPerech.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerech.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPerech.UseVisualStyleBackColor = true;
            this.btnPerech.Click += new System.EventHandler(this.btnPerech_Click);
            // 
            // btnClipBoard
            // 
            this.btnClipBoard.Image = global::Gaudit.Properties.Resources.ResultstoGrid_9947_32;
            this.btnClipBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClipBoard.Location = new System.Drawing.Point(857, 69);
            this.btnClipBoard.Name = "btnClipBoard";
            this.btnClipBoard.Size = new System.Drawing.Size(155, 48);
            this.btnClipBoard.TabIndex = 1;
            this.btnClipBoard.Text = "Получить и сохранить договоры управления";
            this.btnClipBoard.UseVisualStyleBackColor = true;
            this.btnClipBoard.Click += new System.EventHandler(this.btnClipBoard_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 1, 1, 1);
            this.label2.Size = new System.Drawing.Size(1033, 35);
            this.label2.TabIndex = 14;
            this.label2.Text = "Договоры управления: https://my.dom.gosuslugi.ru/organization-cabinet/#!/agreemen" +
    "ts";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DogUpravl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1058, 567);
            this.Controls.Add(this.panel1);
            this.Name = "DogUpravl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Договоры управления";
            this.Load += new System.EventHandler(this.DogUpravl_Load);
            this.Resize += new System.EventHandler(this.DogUpravl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.grdDogUpravl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUslugi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDogUpravl;
        private System.Windows.Forms.Button btnClipBoard;
        private System.Windows.Forms.Button btnPerech;
        private System.Windows.Forms.DataGridView grdUslugi;
        private System.Windows.Forms.Label lblCurrDogovor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
    }
}