using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaudit
{
    public partial class frmReport : Form
    {
        List<repGilFondObj> repData;

        public frmReport(List<repGilFondObj> rep_data )
        {
            InitializeComponent();
            repData = rep_data;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            repViewer.LocalReport.DataSources.Clear();
            BindingSource bs = new BindingSource();
            bs.DataSource = repData;
   
            repViewer.LocalReport.ReportEmbeddedResource = "Gaudit.GReport.rdlc";
            repViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Myreport", bs));

            this.repViewer.RefreshReport();
        }
    }
}
