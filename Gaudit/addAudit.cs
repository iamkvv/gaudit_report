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
    public partial class addAudit : Form
    {
        public addAudit()
        {
            InitializeComponent();
        }

   

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void addAudit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Companies". При необходимости она может быть перемещена или удалена.
            this.companiesTableAdapter.Fill(this.dataSet1.Companies);

        }

        private void txtAudit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
