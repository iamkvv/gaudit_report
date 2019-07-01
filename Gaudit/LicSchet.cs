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
    public partial class LicSchet : Form
    {
        LicSchetTableAdapter licSchetAdapter;
        DataSet1 ds;

        public LicSchet()
        {
            InitializeComponent();

            ds = new DataSet1();
            licSchetAdapter = new LicSchetTableAdapter();
        }

        private void btnGetClipBoard_Click(object sender, EventArgs e)
        {
            int cnt = 0;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                IDataObject iData = Clipboard.GetDataObject();

                if (iData.GetDataPresent(DataFormats.Html))
                {
                    string html = ((String)iData.GetData(DataFormats.Html));

                    string[] htmlarr = html.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                    if (String.IsNullOrEmpty(html) ||
                        htmlarr.Count() < 5 ||
                        htmlarr[5].Split(':')[2] != @"//my.dom.gosuslugi.ru/organization-cabinet/#!/account/list")
                    {
                        MessageBox.Show("Для работы с лицевыми счетами перейдите на страницу \n\r" +
                            "https://my.dom.gosuslugi.ru/organization-cabinet/#!/account/list \n\r" +
                            "и скопируйте в буфер таблицу лицевых счетов. ",
                            "Ошибка", MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("В буфере не обнаружены корректные данные.");
                    return;
                }

                if (iData.GetDataPresent(DataFormats.UnicodeText)) //получим массив строк
                {
                    string cliptxt = (String)iData.GetData(DataFormats.UnicodeText);
                    string[] cliparr = cliptxt.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                    int skip = 0;
                    string[] z;
                    string[] data = cliparr.Skip(7).ToArray();

                    data = data.Where(d => !System.Text.RegularExpressions.Regex.IsMatch(d, @"\(\d{1,2}\.\d{1,2}\.\d{2,4}\)")).ToArray();

                    data = data.Where(d => !d.Contains("КПП")).ToArray(); //!d.Contains("ИНН") && 

                    while ((z = data.Skip(skip).Take(6).ToArray()).Count() != 0)
                    {
                        
                        if (z[2].Contains(z[1].Substring(0, 25)))
                        {
                            skip += 7;

                            licSchetAdapter.Insert(
                                    ActiveAudit.ID,
                                    ActiveAudit.ID_Company,
                                    z[0].Split('\t')[0], //номер
                                    "сдублирован адрес",
                                    z[1] + " --- " + z[2].Split('\t')[0] ,//аДРЕС
                                    "",//z[1].Split('\t')[0], //Адрес
                                                        "--",//z[1].Split('\t')[1],//Дата Закрытия
                                                        //"--",//z[1].Split('\t')[2],//Причина
                                                        "--", //z[2] + " " + z[3], //Дата время
                                    "??" //организация
                                );

                            licSchetAdapter.Insert(
                                    ActiveAudit.ID,
                                    ActiveAudit.ID_Company,
                                    z[0].Split('\t')[0], //номер
                                    "сдублирован адрес",
                                    z[1] + " --- " + z[2].Split('\t')[0],//аДРЕС
                                    "",//z[1].Split('\t')[0], //Адрес
                                                        "--",//z[1].Split('\t')[1],//Дата Закрытия
                                                             //"--",//z[1].Split('\t')[2],//Причина
                                                        "--", //z[2] + " " + z[3], //Дата время
                                    "??" //организация
                                );
                        }
                        else
                        {
                            skip += 6;

                            licSchetAdapter.Insert(
                                    ActiveAudit.ID,
                                    ActiveAudit.ID_Company,
                                    z[0].Split('\t')[0], //номер
                                    z[0].Split('\t')[1], //Плательщик
                                    z[1].Split('\t')[0], //Адрес
                                    z[1].Split('\t')[1],//Дата Закрытия
                                    z[1].Split('\t')[2],//Причина
                                    z[2] + " " + z[3], //Дата время
                                    z[5] //организация
                                );
                        }

                        cnt = cnt + 1;

                    }

                    grdLicSchet.DataSource = licSchetAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(cnt.ToString() + " --- " + ex.Message);
            }
            finally
            {
                Clipboard.Clear();
                Cursor.Current = Cursors.Default;
            }
        }

        private void LicSchet_Load(object sender, EventArgs e)
        {
            licSchetAdapter.FillByActiveAudit(ds.LicSchet, ActiveAudit.ID, ActiveAudit.ID_Company);
            grdLicSchet.DataSource = licSchetAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);

            grdLicSchet.Columns[0].Visible = false;
            grdLicSchet.Columns[1].Visible = false;
            grdLicSchet.Columns[2].Visible = false;

            grdLicSchet.Columns[3].Width = grdLicSchet.Width / 7;
            grdLicSchet.Columns[4].Width = grdLicSchet.Width / 7;
            grdLicSchet.Columns[5].Width = grdLicSchet.Width / 7;
            grdLicSchet.Columns[6].Width = grdLicSchet.Width / 7;
            grdLicSchet.Columns[7].Width = grdLicSchet.Width / 8;
            grdLicSchet.Columns[8].Width = grdLicSchet.Width / 8;
            grdLicSchet.Columns[9].Width = grdLicSchet.Width / 8;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ActiveAudit.ID != 0)
            {
                if (MessageBox.Show("Удалить данные лицевых счетов?",
                                     "Лицевые счета",
                                      MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    licSchetAdapter.DeleteQueryCurrents(ActiveAudit.ID, ActiveAudit.ID_Company);

                    licSchetAdapter.FillByActiveAudit(ds.LicSchet, ActiveAudit.ID, ActiveAudit.ID_Company);
                    grdLicSchet.DataSource = licSchetAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);
                }
            }
        }


        private void LicSchet_Resize(object sender, EventArgs e)
        {
            splitContainer1.Left = (this.ClientSize.Width - splitContainer1.Width) / 2;
            splitContainer1.Top = (this.ClientSize.Height - splitContainer1.Height) / 2;
        }
    }
}
