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
    public partial class Pribors : Form
    {
        PriborTableAdapter priborAdapter;
        DataSet1 ds;

        public Pribors()
        {
            InitializeComponent();

            ds = new DataSet1();

            priborAdapter = new PriborTableAdapter();
        }

        private void btnGetClipBoard_Click(object sender, EventArgs e)
        {
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
                        htmlarr[5].Split(':')[2] != @"//my.dom.gosuslugi.ru/organization-cabinet/#!/device/list")
                    {
                        MessageBox.Show("Для работы с реестром приборов учета перейдите на страницу \n\r" +
                            "https://my.dom.gosuslugi.ru/organization-cabinet/#!/device/list \n\r" +
                            "и скопируйте в буфер таблицу приборов учета. ",
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
                    string[] data = cliparr.Skip(7).ToArray();  //пропускаем загловок страницы

                    while ((z = data.Skip(skip).Take(7).ToArray()).Count() != 0)
                    {
                        skip += 7;
                        priborAdapter.Insert(
                            ActiveAudit.ID,
                            ActiveAudit.ID_Company,
                            z[0],
                            z[1].Split('\t')[0],
                            z[1].Split('\t')[1],
                            z[2].Split('\t')[0],
                            z[2].Split('\t')[1],
                            z[3] + " " + z[4],
                            z[6]);
                    }

                    grdPribors.DataSource = priborAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);
                }
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

        private void Pribors_Load(object sender, EventArgs e)
        {
            priborAdapter.FillByActiveAudit(ds.Pribor, ActiveAudit.ID, ActiveAudit.ID_Company);
            grdPribors.DataSource = priborAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);

            grdPribors.Columns[0].Visible = false;
            grdPribors.Columns[1].Visible = false;
            grdPribors.Columns[2].Visible = false;

            grdPribors.Columns[3].Width = grdPribors.Width / 7;
            grdPribors.Columns[4].Width = grdPribors.Width / 7;
            grdPribors.Columns[5].Width = grdPribors.Width / 7;
            grdPribors.Columns[6].Width = grdPribors.Width / 7;
            grdPribors.Columns[7].Width = grdPribors.Width / 8;
            grdPribors.Columns[8].Width = grdPribors.Width / 8;
            grdPribors.Columns[9].Width = grdPribors.Width / 8;
        }

        private void Pribors_Resize(object sender, EventArgs e)
        {
            splitContainer1.Left = (this.ClientSize.Width - splitContainer1.Width) / 2;
            splitContainer1.Top = (this.ClientSize.Height - splitContainer1.Height) / 2;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ActiveAudit.ID != 0)
            {
                if (MessageBox.Show("Удалить данные приборов учета?",
                                     "Реестр приборов учета",
                                      MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    priborAdapter.DeleteCurrents(ActiveAudit.ID, ActiveAudit.ID_Company);

                    priborAdapter.FillByActiveAudit(ds.Pribor, ActiveAudit.ID, ActiveAudit.ID_Company);
                    grdPribors.DataSource = priborAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);
                }
            }
        }
    }
}
