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
    public partial class DictWorkService : Form
    {
        DictWorkServiceTableAdapter dictWorkServAdapter;
        DataSet1 ds;

        public DictWorkService()
        {
            InitializeComponent();

            ds = new DataSet1();
            dictWorkServAdapter = new DictWorkServiceTableAdapter();
        }

        private void btnWorksServ_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string[] cliparr = ActiveAudit.GetClipBoard("//my.dom.gosuslugi.ru/organization-cabinet/#!/org-nsi/OrganizationWork");

                if (cliparr == null) return;

                int skip = 0;
                string[] z;
                string[] data = cliparr.Skip(1).ToArray();

                while ((z = data.Skip(skip).Take(2).ToArray()).Count() != 0)
                {
                    skip += 2;

                    string[] vals = z[1].Split('\t');

                    dictWorkServAdapter.Insert(
                        ActiveAudit.ID,
                        ActiveAudit.ID_Company,
                        z[0],
                        vals[0],
                        vals.Count() == 2 ? vals[1] : ""
                        );
                }

                grdWorkServ.DataSource = dictWorkServAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Clipboard.Clear();
                Cursor.Current = Cursors.Default;
            }
        }

        private void DictWorkService_Load(object sender, EventArgs e)
        {
            dictWorkServAdapter.FillByActiveAudit(ds.DictWorkService, ActiveAudit.ID, ActiveAudit.ID_Company); //??
            grdWorkServ.DataSource = dictWorkServAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);

            grdWorkServ.Columns[0].Visible = false;
            grdWorkServ.Columns[1].Visible = false;
            grdWorkServ.Columns[2].Visible = false;

            grdWorkServ.Columns[3].Width = grdWorkServ.Width / 3;
            grdWorkServ.Columns[4].Width = grdWorkServ.Width / 3;
            grdWorkServ.Columns[5].Width = grdWorkServ.Width / 3;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить справочник работ и услуг?",
                                "Справочник работ и услуг",
                                 MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dictWorkServAdapter.DeleteByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);
                grdWorkServ.DataSource = dictWorkServAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);
            }
        }

        private void DictWorkService_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

    }
}
