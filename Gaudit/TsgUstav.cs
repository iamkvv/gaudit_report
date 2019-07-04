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
using System.Text.RegularExpressions;

namespace Gaudit
{
    public partial class TsgUstav : Form
    {
        UstavTableAdapter ustavAdapter;
        UstavHouseTableAdapter ustavHouseAdapter;
        UstavUslugiTableAdapter ustavUslugiAdapter;

        DataSet1 ds;

        int currUstavId;
        int currHouseId;

        public TsgUstav()
        {
            InitializeComponent();
            ds = new DataSet1();

            ustavAdapter = new UstavTableAdapter();
            ustavHouseAdapter = new UstavHouseTableAdapter();
            ustavUslugiAdapter = new UstavUslugiTableAdapter();
        }

        private void btnGetClipBoard_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string[] cliparr = ActiveAudit.GetClipBoard("my.dom.gosuslugi.ru/organization-cabinet/#!/agreements");

                if (cliparr == null) return;

                if (cliparr.Count() % 7 != 0)
                {
                    MessageBox.Show("Данные устава скопированы некорректно.");
                    return;
                }

                ustavAdapter.Insert(ActiveAudit.ID,
                    ActiveAudit.ID_Company,
                    cliparr[0].Split('\t')[1], //идентификатор
                    cliparr[5], //статус
                    cliparr[1].Split('\t')[1], //сроки передачи показаний по приборам
                    cliparr[2].Split('\t')[1], //Срок представления платежных документов 
                    cliparr[3].Split('\t')[1], //Срок внесения платы 
                    cliparr[6].Split('\t')[1] //Версия
                    );

                //?? ustavAdapter.FillByCurrentAudit(ds.Ustav, ActiveAudit.ID, ActiveAudit.ID_Company);
                grdUstav.DataSource = ustavAdapter.GetDataByCurrentAudit(ActiveAudit.ID, ActiveAudit.ID_Company);

                if (grdUstav.Rows.Count > 0)
                {
                    grdUstav.Rows[grdUstav.Rows.Count - 1].Selected = true;
                }
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

        private void TsgUstav_Load(object sender, EventArgs e)
        {
            grdUstav.DataSource = ustavAdapter.GetDataByCurrentAudit(ActiveAudit.ID, ActiveAudit.ID_Company);
            grdHouse.DataSource = ustavHouseAdapter.GetDataByCurrentUstav(this.currUstavId);
            grdUslugi.DataSource = ustavUslugiAdapter.GetDataByCurrentHouse(this.currHouseId);

            grdUstav.Columns[0].Visible = false;
            grdUstav.Columns[1].Visible = false;
            grdUstav.Columns[2].Visible = false;

            grdUstav.Columns[3].Width = grdUstav.Width / 6;
            grdUstav.Columns[4].Width = grdUstav.Width / 6;
            grdUstav.Columns[5].Width = grdUstav.Width / 6;
            grdUstav.Columns[6].Width = grdUstav.Width / 6;
            grdUstav.Columns[7].Width = grdUstav.Width / 6;
            grdUstav.Columns[8].Width = grdUstav.Width / 6;

            grdHouse.Columns[0].Visible = false;
            grdHouse.Columns[1].Visible = false;
            grdHouse.Columns[2].Visible = false;
            grdHouse.Columns[3].Visible = false;

            grdHouse.Columns[4].Width = grdHouse.Width / 3;
            grdHouse.Columns[5].Width = grdHouse.Width / 3;
            grdHouse.Columns[6].Width = grdHouse.Width / 3;

            grdUslugi.Columns[0].Visible = false;
            grdUslugi.Columns[1].Visible = false;

            grdUslugi.Columns[2].Width = grdUslugi.Width / 4;
            grdUslugi.Columns[3].Width = grdUslugi.Width / 4;
            grdUslugi.Columns[4].Width = grdUslugi.Width / 4;
            grdUslugi.Columns[5].Width = grdUslugi.Width / 4;

        }

        private void grdUstav_SelectionChanged(object sender, EventArgs e)
        {
            if (grdUstav.CurrentRow != null)
            {
                this.currUstavId = (int)grdUstav.CurrentRow.Cells[0].Value;
                grdHouse.DataSource = ustavHouseAdapter.GetDataByCurrentUstav(this.currUstavId);
            }
        }
        private void grdHouse_SelectionChanged(object sender, EventArgs e)
        {
            if (grdHouse.CurrentRow != null)
            {
                this.currHouseId = (int)grdHouse.CurrentRow.Cells[0].Value;
                grdUslugi.DataSource = ustavUslugiAdapter.GetDataByCurrentHouse(this.currHouseId);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить устав?",
                                  "Устав ТСЖ",
                                   MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (grdUstav.CurrentRow != null)
                {
                    ustavAdapter.DeleteCurrentUstav(this.currUstavId);
                    grdUstav.DataSource = ustavAdapter.GetDataByCurrentAudit(ActiveAudit.ID, ActiveAudit.ID_Company);
                }
                //grdLicense.DataSource = licenseAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);
                //grdLicHouses.DataSource = licenseHousesAdapter.GetDataByCurrentLicense(currID, ActiveAudit.ID, ActiveAudit.ID_Company);
            }
        }

        private void btnUsl_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                //сначала проверить устав

                string[] cliparr = ActiveAudit.GetClipBoard("my.dom.gosuslugi.ru/organization-cabinet/#!/charter/view/houses/");
                if (cliparr == null) return;

                Dictionary<string, List<string>> GRItems = new Dictionary<string, List<string>>();

                string[] data = cliparr.Where(s => !s.Contains("Наименование"))
                    .Where(s => !(s == " "))
                    .Where(s => !s.Contains("Вид коммунальных услуг"))
                    .Where(s => !s.Contains("Дополнительные услуги"))
                    .Where(s => !s.Contains("Услуги отсутствуют"))
                    .ToArray();

                //Группируем по адресу (адрес->услуги[])  ^\d{6}\s|^\s{1,3}\d{6}\s
                Regex rgx = new Regex(@"^\d{6},\s|^\s{1,3}\d{6},\s");

                foreach (string s in data)
                {
                    if (!rgx.IsMatch(s))
                    {
                        GRItems.Last().Value.Add(s);
                    }
                    else
                    {
                        GRItems.Add(s, new List<string>());
                    }
                }

                var res = data.GroupBy(x => rgx.IsMatch(x)).Select(grp => new { z = grp.Key, a= grp });

                foreach (string k in GRItems.Keys)
                {
                    string[] usldata = GRItems[k].ToArray();
                    string period = usldata.First<string>(); //период дожен  находиться в 1-й позиции массива услуг

                    int lastSpace = k.LastIndexOf(" ");
                    string addr = k.Substring(0, lastSpace);
                    string status = k.Substring(lastSpace);

                    ustavHouseAdapter.Insert(this.currUstavId, ActiveAudit.ID, ActiveAudit.ID_Company, addr, status, period.Split(':')[1]);

                    //получить id дома и вставить услуги
                    ustavHouseAdapter.FillByCurrentUstav(ds.UstavHouse, this.currUstavId);
                    DataSet1.UstavHouseRow[] houseArr = ds.UstavHouse.ToArray();
                    int id_house = houseArr.Last<DataSet1.UstavHouseRow>().ID_UstavHouse;
                    Console.WriteLine(id_house);

                    string[] uslugi = GRItems[k].Skip(1).ToArray(); //пропускаем период дома

                    if (uslugi.Count() % 3 != 0)
                    {
                        MessageBox.Show("Пересень услуг сформирован некорректно");
                        return;
                    }

                    string[] z;
                    int skip = 0;
                    while ((z = uslugi.Skip(skip).Take(3).ToArray()).Count() != 0)
                    {
                        ustavUslugiAdapter.Insert(id_house,
                            z[0],//Наименование услуги
                            z[1].Split('\t')[0], //дата начала
                            z[1].Split('\t')[1], //дата окончания
                           z[2]); //устав

                        skip += 3;
                    }
                }

                grdHouse.DataSource = ustavHouseAdapter.GetDataByCurrentUstav(this.currUstavId);

                grdHouse.Rows[0].Selected = true;
                grdUslugi.DataSource = ustavUslugiAdapter.GetDataByCurrentHouse((int)grdHouse.Rows[0].Cells[0].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

    }
}
