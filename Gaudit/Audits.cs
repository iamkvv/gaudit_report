using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

using Gaudit.DataSet1TableAdapters;

namespace Gaudit
{
    public partial class Audits : Form
    {
        AuditTableAdapter auditAdapter;

        DataSet1 ds;
        ElHouseTableAdapter elHouseAdapter;
        ElHouseParamsTableAdapter elHouseParamAdapter;

        GilFondObjectTableAdapter gfObjectsAdapter;
        PorchGilFondОbjectsTableAdapter porchAdapter;
        PomeschGilFondОbsTableAdapter pomeschAdapter;

        LicSchetTableAdapter licSchetAdapter;

        PerechRabUslugTableAdapter pereschRabUslAdapter;

        VotingTableAdapter votingAdapter;

        DogUpravlTableAdapter dogUprAdapter;

        LicenseTableAdapter licenseAdapter;

        LicenseHousesTableAdapter lichouseAdapter;

        PerechRabUslugTableAdapter rabuslAdapter;

        qrLicSchet_PlatDocsTableAdapter qrLSPlatDocsAdapter;


        List<repElHouse> repElHouses = new List<repElHouse>();
        List<repGilFondObj> repGFObj = new List<repGilFondObj>();


        public Audits()
        {
            InitializeComponent();
            auditAdapter = new AuditTableAdapter();

            ds = new DataSet1();
            elHouseAdapter = new ElHouseTableAdapter();
            elHouseParamAdapter = new ElHouseParamsTableAdapter();

            gfObjectsAdapter = new GilFondObjectTableAdapter();
            porchAdapter = new PorchGilFondОbjectsTableAdapter();
            pomeschAdapter = new PomeschGilFondОbsTableAdapter();

            licSchetAdapter = new LicSchetTableAdapter();

            pereschRabUslAdapter = new PerechRabUslugTableAdapter();
            votingAdapter = new VotingTableAdapter();

            dogUprAdapter = new DogUpravlTableAdapter();

            licenseAdapter = new LicenseTableAdapter();
            lichouseAdapter = new LicenseHousesTableAdapter();

            rabuslAdapter = new PerechRabUslugTableAdapter();

            qrLSPlatDocsAdapter = new qrLicSchet_PlatDocsTableAdapter();
        }

        private void btnAddAudit_Click(object sender, EventArgs e)
        {
            addAudit addAudDialog = new addAudit(); //форма добавления аудита
            try
            {
                addAudDialog.StartPosition = FormStartPosition.CenterParent;

                if (addAudDialog.ShowDialog(this) == DialogResult.OK)
                {
                    DataSet1.CompaniesRow selCompany = (DataSet1.CompaniesRow)((System.Data.DataRowView)addAudDialog.cmbCompanies.SelectedItem).Row;

                    auditAdapter.Insert(
                            selCompany.ID,
                            addAudDialog.txtAudit.Text,
                            addAudDialog.txtUser.Text,
                            DateTime.Now,
                            selCompany.CompanyName);

                    DataSet1.AuditDataTable auddata = auditAdapter.GetData();
                    auddata.Rows[auddata.Count - 1].SetAdded();
                    int lastId = ((DataSet1.AuditRow)auddata.Rows[auddata.Count - 1]).ID_Audit;

                    auditAdapter.Fill(this.dataSet1.Audit);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                addAudDialog.Dispose();
            }
        }

        private void Audits_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Audit". При необходимости она может быть перемещена или удалена.
            this.auditTableAdapter.Fill(this.dataSet1.Audit);
        }

        private void grdSelectAudit_SelectionChanged(object sender, EventArgs e)
        {//если не пустая  -- ???????
            if (grdSelectAudit.CurrentRow != null)
            {
                Console.WriteLine(dataSet1.Audit.Rows[grdSelectAudit.CurrentRow.Index]);
            }
        }

        private void grdSelectAudit_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {//Удаление аудита
            if (Convert.ToInt32(grdSelectAudit.SelectedRows[0].Cells[0].Value) == ActiveAudit.ID)
            {
                e.Cancel = true;
                MessageBox.Show("Активный аудит удалить нельзя");
                return;
            }

            if (MessageBox.Show("Удалить аудит компании " +
                grdSelectAudit.SelectedRows[0].Cells[2].Value.ToString() + "\r\n от " +
                grdSelectAudit.SelectedRows[0].Cells[5].Value.ToString() + "?",
               "Удаление аудита",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                auditAdapter.DeleteQuery((Convert.ToInt32(grdSelectAudit.SelectedRows[0].Cells[0].Value)));

                if (auditAdapter.GetData().Rows.Count == 0)
                {
                    ActiveAudit.Clear();
                    ((System.Windows.Forms.StatusStrip)
                    (((MainForm)this.ParentForm).Controls["stsMainStrip"]))
                    .Items[0].Text = "Активного аудита нет";
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnStartAudit_Click(object sender, EventArgs e)
        {//фиксируем активный аудит

            if (DateTime.Now.Month == 7 && DateTime.Now.Day >= 2)
                return;

            if (dataSet1.Audit.Rows[grdSelectAudit.CurrentRow.Index] != null)
            {
                DataSet1.AuditRow curraud = ((DataSet1.AuditRow)dataSet1.Audit.Rows[grdSelectAudit.CurrentRow.Index]);
                ActiveAudit.ID = curraud.ID_Audit;
                ActiveAudit.ID_Company = curraud.ID_Company;
                ActiveAudit.Company = curraud.Company;
                ActiveAudit.Date = curraud.DateTime;
                ActiveAudit.Name = curraud.AuditName;

                ((System.Windows.Forms.StatusStrip)
                (((MainForm)this.ParentForm).Controls["stsMainStrip"]))
                .Items[0].Text = "Активный аудит: " +
                ActiveAudit.ID.ToString() + " - " +
                ActiveAudit.Company + " - " +
                ActiveAudit.Date.ToString();
            }
        }

        private void btnStopAudit_Click(object sender, EventArgs e)
        {
            ActiveAudit.Clear();
            ((System.Windows.Forms.StatusStrip)
                (((MainForm)this.ParentForm).Controls["stsMainStrip"]))
                .Items[0].Text = "Активного аудита нет";
        }

        //ОТЧЕТ
        private void btnReport_Click(object sender, EventArgs e)
        {
            elHouseAdapter.FillByActiveAudit(ds.ElHouse, ActiveAudit.ID, ActiveAudit.ID_Company);
            elHouseParamAdapter.Fill(ds.ElHouseParams);

            gfObjectsAdapter.FillByActiveAudit(ds.GilFondObject, ActiveAudit.ID, ActiveAudit.ID_Company);
            porchAdapter.Fill(ds.PorchGilFondОbjects);
            pomeschAdapter.Fill(ds.PomeschGilFondОbs);

            qrLSPlatDocsAdapter.Fill(ds.qrLicSchet_PlatDocs, ActiveAudit.ID, ActiveAudit.ID_Company); //query LS -> PlatDocs


            repElHouses.Clear();
            repGFObj.Clear();


            //   Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource();


            /*
            Regex rgx = new Regex(@"^(?<=)\d{1,2}\.\s");   //@"^(?<=)\d{1,2}\.\s|^(?<=)\d{1,2}\.\d{1,2}\.");   //<-так точнее //^(?<=)\d{1,2}\.\s
            foreach (DataSet1.ElHouseRow rowHouse in ds.ElHouse.Rows)
            {
                DataSet1.ElHouseParamsRow[] paramsArr = (DataSet1.ElHouseParamsRow[])rowHouse.GetChildRows("ElHouseElHouseParams");
                DataSet1.ElHouseParamsRow[] fltArr = (DataSet1.ElHouseParamsRow[])paramsArr.Where(p => !rgx.IsMatch(p.Param)).ToArray(); //отрезаем типа "3. "

                fltArr = (DataSet1.ElHouseParamsRow[])paramsArr.Where(p => !p.Param.Contains("в том числе")).ToArray(); //и в том числе

                int qemptyPars = fltArr.Where(p => p.ParamValue != "").Count();

                repElHouses.Add(new repElHouse
                {
                    ID = rowHouse.ID_ElHouse,
                    Address = rowHouse.Адрес_дома,
                    quantParams = fltArr.Count(),
                    quantFilledParams = qemptyPars,
                    quantFlats = rowHouse.Количество_квартир == "" ? 0 : Convert.ToInt32(rowHouse.Количество_квартир),
                    quantNoFlats = rowHouse.Нежилых_помещений == "" ? 0 : Convert.ToInt32(rowHouse.Нежилых_помещений)
                });
            }
            */

            foreach (DataSet1.GilFondObjectRow gfoRow in ds.GilFondObject.Rows)
            {

                repGFObj.Add(new repGilFondObj
                {
                    ID_GilFondObject = gfoRow.ID_GilFondObject,
                    ID_Audit = ActiveAudit.ID,
                    ID_Company = ActiveAudit.ID_Company,
                    Company = ActiveAudit.Company,
                    Address = gfoRow.Адрес,
                    quantGilPom = gfoRow._Кол_во_помещений.Split('/')[0] == "-" ? 0 : Convert.ToInt32(gfoRow._Кол_во_помещений.Split('/')[0]),
                    quantNoGilPom = gfoRow._Кол_во_помещений.Split('/')[1] == "- " ? 0 : Convert.ToInt32(gfoRow._Кол_во_помещений.Split('/')[1])
                });


                DataSet1.PorchGilFondОbjectsRow[] arr = (DataSet1.PorchGilFondОbjectsRow[])gfoRow.GetChildRows("GilFondObjectPorchGilFondОbjects");
                foreach (DataSet1.PorchGilFondОbjectsRow porch in arr)
                {
                    DataSet1.PomeschGilFondОbsRow[] pomscharr = (DataSet1.PomeschGilFondОbsRow[])porch.GetChildRows("PorchGilFondОbjectsPomeschGilFondОbs");
                    Console.WriteLine(pomscharr);
                }

                Console.WriteLine(arr);
            }

            //int quantLS = licSchetAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company).Count();
            //DataRowCollection LSColl = licSchetAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company).Rows;


            //Лицевые счета
            licSchetAdapter.FillByActiveAudit(ds.LicSchet, ActiveAudit.ID, ActiveAudit.ID_Company);
            DataSet1.LicSchetRow[] lsArr = ds.LicSchet.ToArray();
            int quantLS = lsArr.Count(); //общее кол-во ЛС
                                         //???? DateTime tls = Convert.ToDateTime(lsArr.Max(l => Convert.ToDateTime(l.Дата_события))); //Макс дата выгрузки ЛС

            //Перечень работ и услуг
            pereschRabUslAdapter.FillByActiveAudit(ds.PerechRabUslug, ActiveAudit.ID, ActiveAudit.ID_Company);
            DataSet1.PerechRabUslugRow[] perArr = ds.PerechRabUslug.ToArray();

            //Голосования
            votingAdapter.FillByActiveAudit(ds.Voting, ActiveAudit.ID, ActiveAudit.ID_Company);
            DataSet1.VotingRow[] votingArr = ds.Voting.ToArray();

            DataSet1.qrLicSchet_PlatDocsRow[] qrLSDocsArr = ds.qrLicSchet_PlatDocs.ToArray();

            foreach (repGilFondObj gfo in repGFObj)
            {
                DataSet1.PerechRabUslugRow x = perArr.Where(p => p.Адрес == gfo.Address).FirstOrDefault();
                if (x != null)
                {
                    gfo.perechRabUsl = x.Перечень;
                }
                else
                {
                    gfo.perechRabUsl = "отсутствует";
                }

                Tuple<int, DateTime> ls = LS_Quant_Date(lsArr, gfo.Address); //Кол-во и дата ЛС по объекту
                gfo.quantLS = ls.Item1;
                gfo.maxDateLS = ls.Item2;

                Tuple<int, DateTime?> vot = Voting_Qiant_Date(votingArr, gfo.Address);
                gfo.quantVoting = vot.Item1;
                gfo.maxDateVoting = vot.Item2;

                //////// Платежные док-ты со статусами Размещен и Проект
                gfo.quantPlatDocsRazm = qrLSDocsArr
                    .Where(d => !d.IsСтатус_документаNull())
                    .Where(d => d.Адрес.Contains(gfo.Address))
                    .Where(s => s.Статус_документа == "Размещен")
                    .Count();

                gfo.quantPlatDocsNoRazm = qrLSDocsArr
                    .Where(d => !d.IsСтатус_документаNull())
                    .Where(d => d.Адрес.Contains(gfo.Address))
                    .Where(s => s.Статус_документа == "Проект")
                    .Count();
            }

            Console.WriteLine(repGFObj);
            // Console.WriteLine(repElHouses);

            frmReport ft = new frmReport(repGFObj);
            ft.Show();
        }

        //кол-во и max дата лицевых счетов
        private Tuple<int, DateTime> LS_Quant_Date(DataSet1.LicSchetRow[] lsarr, string addr)
        {
            DataSet1.LicSchetRow[] lsbyGFO = lsarr.Where(l => l.Адрес.Contains(addr)).ToArray();   //Кол-во лс по объекту   
            DateTime tls = Convert.ToDateTime(lsbyGFO.Max(l => Convert.ToDateTime(l.Дата_события))); //Макс дата выгрузки ЛС

            return Tuple.Create(lsbyGFO.Count(),
                tls);
        }


        //кол-во и max дата голосований
        private Tuple<int, DateTime?> Voting_Qiant_Date(DataSet1.VotingRow[] votingarr, string addr)
        {

            addr = addr.Replace("г ", "г. ");
            addr = addr.Replace("п ", "п. ");
            addr = addr.Replace("ш ", "ш. ");
            addr = addr.Replace("ул ", "ул. ");
            addr = addr.Replace("пр-кт ", "пр-кт. ");
            addr = addr.Replace("пер ", "пер. ");
            addr = addr.Replace("обл Челябинская", "Челябинская обл");


            DateTime? tvot;
            DataSet1.VotingRow[] votingbyGFO = votingarr.Where(v => v.Адрес_дома == addr).ToArray(); //Кол-во голосований по объекту   
            if (votingbyGFO.Count() > 0)
            {
                tvot = Convert.ToDateTime(votingbyGFO.Max(v => Convert.ToDateTime(v.Время_изменения))); //Макс дата голосований
            }
            else
            {
                tvot = null;
            }

            return Tuple.Create(votingbyGFO.Count(), tvot);
        }

        private void btnCorrectAddr_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                votingAdapter.Fill(ds.Voting);//    
                DataSet1.VotingRow[] votingArr = ds.Voting.ToArray();

                dogUprAdapter.Fill(ds.DogUpravl);
                DataSet1.DogUpravlRow[] doguprArr = ds.DogUpravl.ToArray();

                licenseAdapter.Fill(ds.License);
                DataSet1.LicenseRow[] licArr = ds.License.ToArray();

                lichouseAdapter.Fill(ds.LicenseHouses);
                DataSet1.LicenseHousesRow[] lichouseArr = ds.LicenseHouses.ToArray();

                rabuslAdapter.Fill(ds.PerechRabUslug);
                DataSet1.PerechRabUslugRow[] rabuslArr = ds.PerechRabUslug.ToArray();

                foreach (DataSet1.VotingRow dr in votingArr)
                {
                    string addr = ReplAddr(dr.Адрес_дома);
                    votingAdapter.UpdateAddress(addr, dr.ID_Voting);
                }
                ds.AcceptChanges();

                foreach (DataSet1.DogUpravlRow dr in doguprArr)
                {
                    string addr = ReplAddr(dr.Управляемые_объекты);
                    dogUprAdapter.UpdateAddress(addr, dr.ID_DogUpravl);
                }
                ds.AcceptChanges();

                foreach (DataSet1.LicenseRow dr in licArr)
                {
                    string addr = ReplAddr(dr.Адрес);
                    licenseAdapter.UpdateAddress(addr, dr.ID_License);
                }
                ds.AcceptChanges();

                foreach (DataSet1.LicenseHousesRow dr in lichouseArr)
                {
                    string addr = ReplAddr(dr.Адрес);
                    lichouseAdapter.UpdateAddress(addr, dr.ID_LicenseHouses);
                }
                ds.AcceptChanges();

                foreach (DataSet1.PerechRabUslugRow dr in rabuslArr)
                {
                    string addr = ReplAddr(dr.Адрес);
                    rabuslAdapter.UpdateAddress(addr, dr.ID_PerechRabUslug);
                }
                ds.AcceptChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Cursor.Current = Cursors.WaitCursor;

        }

        private string ReplAddr(string addr)
        {
            string res = addr.Replace("Челябинская обл", "обл Челябинская")
                    .Replace("г. ", "г ")
                    .Replace("ул. ", "ул ")
                    .Replace("пер. ", "пер ")
                    .Replace("пр-кт. ", "пр-кт ")
                    .Replace("б-р. ", "б-р ")
                    .Replace("проезд. ", "проезд ")
                    .Replace("ш. ", "ш ");

            return res;
        }

    }
}
