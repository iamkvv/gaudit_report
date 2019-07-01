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
    public partial class PerechRabUslug : Form
    {

        DataSet1 ds;
        PerechRabUslugTableAdapter pereschRabUslAdapter;
        PerechRabUslugDetailsTableAdapter perechRabUslDetailsAdapter;

        int currPerechID = 0;


        public PerechRabUslug()
        {
            InitializeComponent();
            ds = new DataSet1();
            pereschRabUslAdapter = new PerechRabUslugTableAdapter();
            perechRabUslDetailsAdapter = new PerechRabUslugDetailsTableAdapter();
        }

        private void btnReestrPerRabUsl_Click(object sender, EventArgs e)
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
                        htmlarr[5].Split(':')[2] != @"//my.dom.gosuslugi.ru/organization-cabinet/#!/workplanning?mainForm=true")
                    {
                        MessageBox.Show("Для работы с перечнем работ и услуг перейдите на страницу \n\r" +
                            "https://my.dom.gosuslugi.ru/organization-cabinet/#!/workplanning?mainForm=true \n\r" +
                            "и скопируйте в буфер таблицу перечней работ и услуг. ",
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

                    while ((z = cliparr.Skip(skip).Take(6).ToArray()).Count() != 0)
                    {
                        skip += 6;

                        pereschRabUslAdapter.Insert(
                                ActiveAudit.ID,
                                ActiveAudit.ID_Company,
                                z[0], //перечень
                                z[1].Split('\t')[1], //адрес
                                z[2].Split('\t')[1], //кол-во работ
                                z[3].Split('\t')[0] + " " + z[4], //организация
                                z[5].Split('\t')[1]  //стоимость
                                );
                    }

                    grdPerRabUsl.DataSource = pereschRabUslAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);
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

        private void PerechRabUslug_Load(object sender, EventArgs e)
        {
            pereschRabUslAdapter.FillByActiveAudit(ds.PerechRabUslug, ActiveAudit.ID, ActiveAudit.ID_Company);
            perechRabUslDetailsAdapter.FillBySelectedRabUsl(ds.PerechRabUslugDetails, this.currPerechID, ActiveAudit.ID, ActiveAudit.ID_Company);

            grdPerRabUsl.DataSource = pereschRabUslAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company); //???
            grdPerRabUslDetals.DataSource = perechRabUslDetailsAdapter.GetDataBySelectedRabUsl(this.currPerechID, ActiveAudit.ID, ActiveAudit.ID_Company); //???

            grdPerRabUsl.Columns[0].Visible = false;
            grdPerRabUsl.Columns[1].Visible = false;
            grdPerRabUsl.Columns[2].Visible = false;

            grdPerRabUsl.Columns[3].Width = grdPerRabUsl.Width / 6;
            grdPerRabUsl.Columns[4].Width = grdPerRabUsl.Width / 6;
            grdPerRabUsl.Columns[5].Width = grdPerRabUsl.Width / 6;
            grdPerRabUsl.Columns[6].Width = grdPerRabUsl.Width / 5;
            grdPerRabUsl.Columns[7].Width = grdPerRabUsl.Width / 5;


            //grdPerRabUsl.Columns[8].Width = grdPerRabUsl.Width / 8;
            //grdPerRabUsl.Columns[9].Width = grdPerRabUsl.Width / 8;            //grdPerRabUsl.Columns[0].Visible = false;
            //grdPerRabUsl.Columns[1].Visible = false;
            //grdPerRabUsl.Columns[2].Visible = false;

            //grdPerRabUsl.Columns[3].Width = grdPerRabUsl.Width / 7;
            //grdPerRabUsl.Columns[4].Width = grdPerRabUsl.Width / 7;
            //grdPerRabUsl.Columns[5].Width = grdPerRabUsl.Width / 7;
            //grdPerRabUsl.Columns[6].Width = grdPerRabUsl.Width / 7;
            //grdPerRabUsl.Columns[7].Width = grdPerRabUsl.Width / 8;
            //grdPerRabUsl.Columns[8].Width = grdPerRabUsl.Width / 8;
            //grdPerRabUsl.Columns[9].Width = grdPerRabUsl.Width / 8;

            ////////////
            ///
            grdPerRabUslDetals.Columns[0].Visible = false;
            grdPerRabUslDetals.Columns[1].Visible = false;
            grdPerRabUslDetals.Columns[2].Visible = false;
            grdPerRabUslDetals.Columns[3].Visible = false;

            grdPerRabUslDetals.Columns[3].Width = grdPerRabUslDetals.Width / 7;
            grdPerRabUslDetals.Columns[4].Width = grdPerRabUslDetals.Width / 8;
            grdPerRabUslDetals.Columns[5].Width = grdPerRabUslDetals.Width / 8;
            grdPerRabUslDetals.Columns[6].Width = grdPerRabUslDetals.Width / 7;
            grdPerRabUslDetals.Columns[7].Width = grdPerRabUslDetals.Width / 7;
            grdPerRabUslDetals.Columns[8].Width = grdPerRabUslDetals.Width / 7;
            grdPerRabUslDetals.Columns[9].Width = grdPerRabUslDetals.Width / 7;
        }

        private void grdPerRabUsl_SelectionChanged(object sender, EventArgs e)
        {
            if (grdPerRabUsl.CurrentRow != null)
            {
                this.currPerechID = (int)grdPerRabUsl.CurrentRow.Cells[0].Value;
                label1.Text = this.currPerechID.ToString();

                grdPerRabUslDetals.DataSource = perechRabUslDetailsAdapter.GetDataBySelectedRabUsl(this.currPerechID, ActiveAudit.ID, ActiveAudit.ID_Company); 
            }
        }

        private void btnPerRabUslDetails_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                IDataObject iData = Clipboard.GetDataObject();

                if (iData.GetDataPresent(DataFormats.Html))
                {
                    string h = ((String)iData.GetData(DataFormats.Html));
                    //Можно получить GUID дома
                }

                if (iData.GetDataPresent(DataFormats.UnicodeText)) //получим массив строк
                {
                    string cliptxt = (String)iData.GetData(DataFormats.UnicodeText);
                    string[] cliparr = cliptxt.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                    string[] data = cliparr.Skip(1).ToArray();

                    foreach (string s in data) {
                        perechRabUslDetailsAdapter.Insert(
                            this.currPerechID,
                             ActiveAudit.ID,
                              ActiveAudit.ID_Company,
                              s.Split('\t')[0], //Наименование
                              s.Split('\t')[1], //код
                              s.Split('\t')[2], //вид работ
                              s.Split('\t')[3], //цена
                              s.Split('\t')[4],//Объем
                              s.Split('\t')[5], // Кол-во
                              s.Split('\t')[6] //Стоимость
                            );
                    }
                    grdPerRabUslDetals.DataSource = perechRabUslDetailsAdapter.GetDataBySelectedRabUsl(this.currPerechID, ActiveAudit.ID, ActiveAudit.ID_Company);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ActiveAudit.ID != 0)
            {
                if (MessageBox.Show("Удалить перечень работ и услуг?",
                                     "Перечень работ и услуг",
                                      MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    pereschRabUslAdapter.DeleteCurrentsPerech(ActiveAudit.ID, ActiveAudit.ID_Company);

                    pereschRabUslAdapter.FillByActiveAudit(ds.PerechRabUslug, ActiveAudit.ID, ActiveAudit.ID_Company);
                    grdPerRabUsl.DataSource = pereschRabUslAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);

                    perechRabUslDetailsAdapter.FillBySelectedRabUsl(ds.PerechRabUslugDetails, this.currPerechID, ActiveAudit.ID, ActiveAudit.ID_Company);
                    grdPerRabUslDetals.DataSource = perechRabUslDetailsAdapter.GetDataBySelectedRabUsl(this.currPerechID, ActiveAudit.ID, ActiveAudit.ID_Company);
                }
            }
        }

        private void PerechRabUslug_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
    }
}
