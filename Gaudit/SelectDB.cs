using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.OleDb;

namespace Gaudit
{
    public partial class SelectDB : Form
    {
        public SelectDB()
        {
            InitializeComponent();
        }

        private void btnSelectBD_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            using (openFileDialog1)
            {
                //ldb — копия_be.accdb
                openFileDialog1.Filter = "файл MS Access (*.accdb)|*.accdb";
                openFileDialog1.Multiselect = false;
                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string name = "Gaudit.Properties.Settings.gisdbConnectionString";
                    //System.Data.OleDb.OleDbConnection ole = new System.Data.OleDb.OleDbConnection();
                    string cs = System.Configuration.ConfigurationManager.ConnectionStrings[name].ConnectionString;//= @"Provider = Microsoft.ACE.OLEDB.16.0; Data Source = C:\Learn\Access\ldb — копия_be.accdb ";

                    System.Data.OleDb.OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder(cs);
                    builder.DataSource = openFileDialog1.FileName;//   @"C:\Work\Access\ldb — копия_be.accdb";

                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.ConnectionStrings.ConnectionStrings[name].ConnectionString = builder.ConnectionString;
                    config.Save(ConfigurationSaveMode.Modified, true);
                    ConfigurationManager.RefreshSection("connectionStrings");

                    Application.Exit();
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                }
            }

            Cursor.Current = Cursors.Default;
        }
    }
}
