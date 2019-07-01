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
    public partial class PlatDocs : Form
    {

        DataSet1 ds;
        PlatDocsTableAdapter platDocsAdapter;

        public PlatDocs()
        {
            InitializeComponent();

            ds = new DataSet1();
            platDocsAdapter = new PlatDocsTableAdapter();
        }

        private void btnGetClipBoard_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string[] cliparr = ActiveAudit.GetClipBoard("//my.dom.gosuslugi.ru/organization-cabinet/#!/payment/documents");

                if (cliparr == null) return;

                string[] data = cliparr.Skip(10).ToArray();

                if (cliparr.Any(s => s == "(UTC+3)")) //Item данных содержит 5 строк
                {
                    if (cliparr.Count() % 5 != 0)
                    {
                        MessageBox.Show("Данные платежных документов скопированы некорректно.");
                        return;
                    }
                    int skip = 0;
                    string[] arr;
                    //string[] data = cliparr.Skip(10).ToArray();

                    while ((arr = data.Skip(skip).Take(5).ToArray()).Count() != 0)
                    {
                        skip += 5;
                        string[] vals = arr[0].Split('\t');

                        platDocsAdapter.Insert(
                            ActiveAudit.ID,
                            ActiveAudit.ID_Company,
                            vals[0], //лицевой счет
                            vals[1], //идентификатор
                            vals[2], //статус
                            vals[3], //дата статуса
                            vals[4], //сумма
                            vals[5], // c задолжн
                            vals[6], //оплачено
                            vals[7], //остаток
                            arr[1] + " " + arr[2],
                            arr[4]
                            );
                    }

                
                }
                else //Данные содержат 1 строку
                {
                    foreach(string d in data)
                    {
                        string[] vals = d.Split('\t');

                        platDocsAdapter.Insert(
                            ActiveAudit.ID,
                            ActiveAudit.ID_Company,
                            vals[0], //лицевой счет
                            vals[1], //идентификатор
                            vals[2], //статус
                            vals[3], //дата статуса
                            vals[4], //сумма
                            vals[5], // c задолжн
                            vals[6], //оплачено
                            vals[7], //остаток
                            "" ,
                            ""
                            );
                    }
                }


                platDocsAdapter.FillByActiveAudit(ds.PlatDocs, ActiveAudit.ID, ActiveAudit.ID_Company); //??
                grdPlatDocs.DataSource = platDocsAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Clipboard.Clear();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить платежные документы?",
                                 "Платежные документы",
                                  MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                platDocsAdapter.DeleteByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);
                grdPlatDocs.DataSource = platDocsAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);
            }
        }


        private void PlatDocs_Load(object sender, EventArgs e)
        {
            platDocsAdapter.FillByActiveAudit(ds.PlatDocs, ActiveAudit.ID, ActiveAudit.ID_Company);
            grdPlatDocs.DataSource = platDocsAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);

            grdPlatDocs.Columns[0].Visible = false;
            grdPlatDocs.Columns[1].Visible = false;
            grdPlatDocs.Columns[2].Visible = false;

            grdPlatDocs.Columns[3].Width = grdPlatDocs.Width / 10;
            grdPlatDocs.Columns[4].Width = grdPlatDocs.Width / 10;
            grdPlatDocs.Columns[5].Width = grdPlatDocs.Width / 10;
            grdPlatDocs.Columns[6].Width = grdPlatDocs.Width / 10;
            grdPlatDocs.Columns[7].Width = grdPlatDocs.Width / 10;

            grdPlatDocs.Columns[8].Width = grdPlatDocs.Width / 10;
            grdPlatDocs.Columns[9].Width = grdPlatDocs.Width / 10;
            grdPlatDocs.Columns[10].Width = grdPlatDocs.Width / 10;
            grdPlatDocs.Columns[11].Width = grdPlatDocs.Width / 10;
            grdPlatDocs.Columns[12].Width = grdPlatDocs.Width / 10;
        }

        private void PlatDocs_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

      
    }
}
