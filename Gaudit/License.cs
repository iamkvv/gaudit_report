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
    public partial class License : Form
    {
        DataSet1 ds;
        LicenseTableAdapter licenseAdapter;
        LicenseHousesTableAdapter licenseHousesAdapter;

        public License()
        {
            InitializeComponent();

            ds = new DataSet1();
            licenseAdapter = new LicenseTableAdapter();
            licenseHousesAdapter = new LicenseHousesTableAdapter();
        }

        private void btnGetClipBoard_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string[] cliparr = ActiveAudit.GetClipBoard("//dom.gosuslugi.ru/#!/licenses");

                if (cliparr == null) return;

                string[] data = cliparr.Where(l => !(l == "Информация о лицензиате")).ToArray();
                licenseAdapter.Insert(
                    ActiveAudit.ID,
                    ActiveAudit.ID_Company,
                    data[1], //вид
                    data[3], // лицензия
                    data[5], //документ
                    data[7], //орган
                    data[9], //адрес
                    data[11], //дполнит-но
                    data[13], //лицензиат
                    data[14].Split(' ')[data[14].Split(' ').Length - 1], //ОГРН
                    data[15].Split(' ')[data[14].Split(' ').Length - 1], //ИНН
                    data[17] //место
                    );

                licenseAdapter.FillByActiveAudit(ds.License, ActiveAudit.ID, ActiveAudit.ID_Company);
                grdLicense.DataSource = licenseAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);
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

        private void License_Load(object sender, EventArgs e)
        {
            licenseAdapter.FillByActiveAudit(ds.License, ActiveAudit.ID, ActiveAudit.ID_Company);
            grdLicense.DataSource = licenseAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);


            int currID = 0;
            if (grdLicense.CurrentRow != null)
            {
                 currID = (int)grdLicense.CurrentRow.Cells[0].Value;
            }

            licenseHousesAdapter.FillByCurrentLicense(ds.LicenseHouses, currID, ActiveAudit.ID, ActiveAudit.ID_Company);
            grdLicHouses.DataSource = licenseHousesAdapter.GetDataByCurrentLicense(currID, ActiveAudit.ID, ActiveAudit.ID_Company);

            grdLicense.Columns[0].Visible = false;
            grdLicense.Columns[1].Visible = false;
            grdLicense.Columns[2].Visible = false;

            grdLicense.Columns[3].Width = grdLicense.Width / 10;
            grdLicense.Columns[4].Width = grdLicense.Width / 10;
            grdLicense.Columns[5].Width = grdLicense.Width / 10;
            grdLicense.Columns[6].Width = grdLicense.Width / 10;
            grdLicense.Columns[7].Width = grdLicense.Width / 10;

            grdLicense.Columns[8].Width = grdLicense.Width / 10;
            grdLicense.Columns[8].Width = grdLicense.Width / 10;
            grdLicense.Columns[10].Width = grdLicense.Width / 10;
            grdLicense.Columns[11].Width = grdLicense.Width / 10;
            grdLicense.Columns[12].Width = grdLicense.Width / 10;

            grdLicHouses.Columns[0].Visible = false;
            grdLicHouses.Columns[1].Visible = false;
            grdLicHouses.Columns[2].Visible = false;
            grdLicHouses.Columns[3].Visible = false;

            grdLicHouses.Columns[4].Width = grdLicHouses.Width / 5;
            grdLicHouses.Columns[5].Width = grdLicHouses.Width / 5;
            grdLicHouses.Columns[6].Width = grdLicHouses.Width / 5;
            grdLicHouses.Columns[7].Width = grdLicHouses.Width / 6;
            grdLicHouses.Columns[8].Width = grdLicHouses.Width / 6;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить лицензию?",
                                   "Лицензии",
                                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int currID = (int)grdLicense.CurrentRow.Cells[0].Value;
                licenseAdapter.DeleteByCurrentLicense(currID, ActiveAudit.ID, ActiveAudit.ID_Company);
                grdLicense.DataSource = licenseAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);

                grdLicHouses.DataSource = licenseHousesAdapter.GetDataByCurrentLicense(currID, ActiveAudit.ID, ActiveAudit.ID_Company);
            }
        }

        private void btnGetLicHouses_Click(object sender, EventArgs e)
        {
            try
            {
                string[] cliparr = ActiveAudit.GetClipBoard("//dom.gosuslugi.ru/#!/licenses/");

                if (cliparr == null) return;

                string[] data = cliparr.Skip(3).ToArray();

                int currLicID = (int)grdLicense.CurrentRow.Cells[0].Value;

                foreach (string str in data)
                {
                    string[] vals = str.Split('\t');
                    licenseHousesAdapter.Insert(
                        currLicID,
                        ActiveAudit.ID, 
                        ActiveAudit.ID_Company,
                        vals[0], //Адрес
                        vals[1], //Начало
                        vals[2], //Окончание
                        vals[3], //реестр
                        vals[4]  //сведения
                        );
                }

          grdLicHouses.DataSource = licenseHousesAdapter.GetDataByCurrentLicense(currLicID, ActiveAudit.ID, ActiveAudit.ID_Company);

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

        private void License_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void grdLicense_SelectionChanged(object sender, EventArgs e)
        {
            if (grdLicense.CurrentRow != null)
            {
                int currLicID = (int)grdLicense.CurrentRow.Cells[0].Value;
                grdLicHouses.DataSource = licenseHousesAdapter.GetDataByCurrentLicense(currLicID, ActiveAudit.ID, ActiveAudit.ID_Company);
            }
        }
    }
}
