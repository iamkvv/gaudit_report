namespace Gaudit
{
    partial class PassportMKD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassportMKD));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grdElHouse = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.grdParams = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetPomesch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdPomesch = new System.Windows.Forms.DataGridView();
            this.grdPorch = new System.Windows.Forms.DataGridView();
            this.btnDeletePorch = new System.Windows.Forms.Button();
            this.btnGetPorch = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.grdFlats = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.grdNoflats = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdElHouse)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdParams)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPomesch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPorch)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFlats)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNoflats)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1057, 551);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.grdElHouse);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1049, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Паспорт дома";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(857, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 50);
            this.button2.TabIndex = 25;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Электронный паспорт";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Image = global::Gaudit.Properties.Resources.ChangeQueryType_deletequery_274_32;
            this.btnDelete.Location = new System.Drawing.Point(856, 116);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 45);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Удалить выбранный паспорт";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(856, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 45);
            this.button1.TabIndex = 16;
            this.button1.Text = "Получить и сохранить данные из буфера";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGetClipBoard_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(10, 5);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 1, 1, 1);
            this.label2.Size = new System.Drawing.Size(1025, 37);
            this.label2.TabIndex = 15;
            this.label2.Text = "Паспорт МКД: https://my.dom.gosuslugi.ru/organization-cabinet/#!/passport/show?ho" +
    "useGuid...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grdElHouse
            // 
            this.grdElHouse.AllowUserToAddRows = false;
            this.grdElHouse.AllowUserToDeleteRows = false;
            this.grdElHouse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdElHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdElHouse.Location = new System.Drawing.Point(9, 65);
            this.grdElHouse.MultiSelect = false;
            this.grdElHouse.Name = "grdElHouse";
            this.grdElHouse.ReadOnly = true;
            this.grdElHouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdElHouse.Size = new System.Drawing.Size(831, 454);
            this.grdElHouse.TabIndex = 0;
            this.grdElHouse.SelectionChanged += new System.EventHandler(this.grdElHouse_SelectionChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.grdParams);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1049, 525);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Параметры";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Характеристики дома";
            // 
            // grdParams
            // 
            this.grdParams.AllowUserToAddRows = false;
            this.grdParams.AllowUserToDeleteRows = false;
            this.grdParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdParams.Location = new System.Drawing.Point(17, 29);
            this.grdParams.MultiSelect = false;
            this.grdParams.Name = "grdParams";
            this.grdParams.ReadOnly = true;
            this.grdParams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdParams.ShowCellErrors = false;
            this.grdParams.ShowCellToolTips = false;
            this.grdParams.ShowEditingIcon = false;
            this.grdParams.ShowRowErrors = false;
            this.grdParams.Size = new System.Drawing.Size(1023, 492);
            this.grdParams.TabIndex = 2;
            this.grdParams.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdParams_CellContentClick);
            this.grdParams.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdParams_CellFormatting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnGetPomesch);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.grdPomesch);
            this.tabPage1.Controls.Add(this.grdPorch);
            this.tabPage1.Controls.Add(this.btnDeletePorch);
            this.tabPage1.Controls.Add(this.btnGetPorch);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1049, 525);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Подъезды и квартиры";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(12, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(15, 1, 1, 1);
            this.label4.Size = new System.Drawing.Size(1028, 37);
            this.label4.TabIndex = 27;
            this.label4.Text = "Подъезды и квартиры: https://my.dom.gosuslugi.ru/organization-cabinet/#!/house/ca" +
    "rd?houseCardGuid...";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGetPomesch
            // 
            this.btnGetPomesch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGetPomesch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetPomesch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetPomesch.Image = ((System.Drawing.Image)(resources.GetObject("btnGetPomesch.Image")));
            this.btnGetPomesch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetPomesch.Location = new System.Drawing.Point(858, 272);
            this.btnGetPomesch.Name = "btnGetPomesch";
            this.btnGetPomesch.Size = new System.Drawing.Size(170, 45);
            this.btnGetPomesch.TabIndex = 26;
            this.btnGetPomesch.Text = "Получить и сохранить данные  помещений";
            this.btnGetPomesch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetPomesch.UseVisualStyleBackColor = true;
            this.btnGetPomesch.Click += new System.EventHandler(this.btnGetPomesch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(855, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Выбран дом:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Квартиры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Подъезды";
            // 
            // grdPomesch
            // 
            this.grdPomesch.AllowDrop = true;
            this.grdPomesch.AllowUserToAddRows = false;
            this.grdPomesch.AllowUserToDeleteRows = false;
            this.grdPomesch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPomesch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPomesch.Location = new System.Drawing.Point(12, 266);
            this.grdPomesch.Name = "grdPomesch";
            this.grdPomesch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPomesch.Size = new System.Drawing.Size(824, 255);
            this.grdPomesch.TabIndex = 21;
            // 
            // grdPorch
            // 
            this.grdPorch.AllowUserToAddRows = false;
            this.grdPorch.AllowUserToDeleteRows = false;
            this.grdPorch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPorch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPorch.Location = new System.Drawing.Point(12, 61);
            this.grdPorch.Name = "grdPorch";
            this.grdPorch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPorch.Size = new System.Drawing.Size(824, 180);
            this.grdPorch.TabIndex = 20;
            this.grdPorch.SelectionChanged += new System.EventHandler(this.grdPorch_SelectionChanged);
            // 
            // btnDeletePorch
            // 
            this.btnDeletePorch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeletePorch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeletePorch.Image = global::Gaudit.Properties.Resources.ChangeQueryType_deletequery_274_32;
            this.btnDeletePorch.Location = new System.Drawing.Point(858, 122);
            this.btnDeletePorch.Name = "btnDeletePorch";
            this.btnDeletePorch.Size = new System.Drawing.Size(170, 45);
            this.btnDeletePorch.TabIndex = 19;
            this.btnDeletePorch.Text = "Удалить выбранный подъезд";
            this.btnDeletePorch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeletePorch.UseVisualStyleBackColor = true;
            this.btnDeletePorch.Click += new System.EventHandler(this.btnDeletePorch_Click);
            // 
            // btnGetPorch
            // 
            this.btnGetPorch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGetPorch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetPorch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetPorch.Image = ((System.Drawing.Image)(resources.GetObject("btnGetPorch.Image")));
            this.btnGetPorch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetPorch.Location = new System.Drawing.Point(858, 61);
            this.btnGetPorch.Name = "btnGetPorch";
            this.btnGetPorch.Size = new System.Drawing.Size(170, 45);
            this.btnGetPorch.TabIndex = 18;
            this.btnGetPorch.Text = "Получить и сохранить данные  подъездов";
            this.btnGetPorch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetPorch.UseVisualStyleBackColor = true;
            this.btnGetPorch.Click += new System.EventHandler(this.btnGetPorch_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1049, 525);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Нежилые помещения";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage4.Controls.Add(this.grdFlats);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1049, 525);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Квартиры";
            // 
            // grdFlats
            // 
            this.grdFlats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFlats.Location = new System.Drawing.Point(22, 35);
            this.grdFlats.Name = "grdFlats";
            this.grdFlats.Size = new System.Drawing.Size(1018, 486);
            this.grdFlats.TabIndex = 0;
            this.grdFlats.Visible = false;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage5.Controls.Add(this.grdNoflats);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1049, 525);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Нежилые помещения";
            // 
            // grdNoflats
            // 
            this.grdNoflats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNoflats.Location = new System.Drawing.Point(63, 32);
            this.grdNoflats.Name = "grdNoflats";
            this.grdNoflats.Size = new System.Drawing.Size(787, 392);
            this.grdNoflats.TabIndex = 0;
            this.grdNoflats.Visible = false;
            // 
            // PassportMKD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1058, 567);
            this.Controls.Add(this.tabControl1);
            this.Name = "PassportMKD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронные паспорта МКД";
            this.Load += new System.EventHandler(this.PassportMKD_Load);
            this.Resize += new System.EventHandler(this.PassportMKD_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdElHouse)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdParams)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPomesch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPorch)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFlats)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNoflats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView grdElHouse;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView grdParams;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView grdFlats;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView grdNoflats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdPomesch;
        private System.Windows.Forms.DataGridView grdPorch;
        private System.Windows.Forms.Button btnDeletePorch;
        private System.Windows.Forms.Button btnGetPorch;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetPomesch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}