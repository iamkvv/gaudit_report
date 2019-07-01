using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gaudit.DataSet1TableAdapters; 

namespace Gaudit
{
    public partial class Companies : Form
    {
        public Companies()
        {
            InitializeComponent();
        }

        private void Companies_Load(object sender, EventArgs e)
        {

            this.grdCompanies.ShowRowErrors = true;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Companies". При необходимости она может быть перемещена или удалена.
            this.companiesTableAdapter.Fill(this.dataSet1.Companies);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.companiesBindingSource.EndEdit();
            this.companiesTableAdapter.Update(this.dataSet1);
            this.companiesTableAdapter.Fill(this.dataSet1.Companies);

            this.companiesTableAdapter.Update(dataSet1.Companies);
            this.dataSet1.AcceptChanges();
        }
    }
}
