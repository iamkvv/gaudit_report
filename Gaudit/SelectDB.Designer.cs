namespace Gaudit
{
    partial class SelectDB
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
            this.btnSelectBD = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnSelectBD
            // 
            this.btnSelectBD.Location = new System.Drawing.Point(163, 56);
            this.btnSelectBD.Name = "btnSelectBD";
            this.btnSelectBD.Size = new System.Drawing.Size(137, 48);
            this.btnSelectBD.TabIndex = 0;
            this.btnSelectBD.Text = "Выбор базы данных";
            this.btnSelectBD.UseVisualStyleBackColor = true;
            this.btnSelectBD.Click += new System.EventHandler(this.btnSelectBD_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SelectDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 192);
            this.Controls.Add(this.btnSelectBD);
            this.Name = "SelectDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор базы данных";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectBD;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}