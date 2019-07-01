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
    public partial class FormTest : Form
    {
        List<repGilFondObj> repData;

        public FormTest(List<repGilFondObj> rep_Data)
        {
            repData = rep_Data;

            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            //AudRep rep = new AudRep();

            //rep.Data = new List<repGilFondObj>();

            //rep.Data.Add(
            //    new repGilFondObj { Company ="Первая", ID_GilFondObject = 1, Address = "Addres 1", quantGilPom=50, quantNoGilPom = 5,    quantLS = 100, maxDateLS = DateTime.Now.AddDays(1) }
            //    );

            //rep.Data.Add(
            //    new repGilFondObj { Company = "Первая", ID_GilFondObject = 2, Address = "Addres 2", quantGilPom = 40, quantNoGilPom = 4, quantLS = 102, maxDateLS = DateTime.Now.AddDays(2) }
            //    );

            //rep.Data.Add(
            //    new repGilFondObj { Company = "Первая", ID_GilFondObject = 3, Address = "Addres 3", quantGilPom = 30, quantNoGilPom = 3, quantLS = 103,maxDateLS = DateTime.Now.AddDays(1) }
            //    );

            //rep.Data.Add(
            //    new repGilFondObj { Company = "Первая", ID_GilFondObject = 4, Address = "Addres 4", quantGilPom = 20, quantNoGilPom = 2, quantLS = 104, maxDateLS = DateTime.Now.AddDays(-1) }
            //    );

            //??!!  this.AudRepBindingSource.DataSource = repData;

            //  this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
