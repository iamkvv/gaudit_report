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
    public partial class DogUpravl : Form
    {
        DataSet1 ds;
        DogUpravlTableAdapter dogUpravlAdapter;
        DogUprUslugiTableAdapter dogUprUslAdapter;

        int currDogID = 0;

        public DogUpravl()
        {
            InitializeComponent();

            ds = new DataSet1();
            dogUpravlAdapter = new DogUpravlTableAdapter();
            dogUprUslAdapter = new DogUprUslugiTableAdapter();
        }

        private void btnClipBoard_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string[] cliparr = ActiveAudit.GetClipBoard("//my.dom.gosuslugi.ru/organization-cabinet/#!/agreements");

                if (cliparr == null) return;

                int skip = 0;
                string[] z;
                //string[] data = cliparr.Skip(0).ToArray();

               string[] data = cliparr.Where(s => !s.Contains("Срок действия договора истекает")).ToArray(); 


                while ((z = data.Skip(skip).Take(13).ToArray()).Count() != 0)
                {
                    skip += 13;
                    cnt++;

                    dogUpravlAdapter.Insert(
                        ActiveAudit.ID,
                        ActiveAudit.ID_Company,
                        z[0],
                        z[1].Split('\t')[1], //идент
                        z[2].Split('\t')[1], // закл
                        z[3].Split('\t')[1], // вступ
                        z[4].Split('\t')[1], // срок
                        z[5].Split('\t').Length == 2  ?  z[5].Split('\t')[1] : "", //статус
                        z[6].Split('\t')[1], //версия
                        z[7].Split('\t')[1], //основание
                        z[8].Split('\t')[1], // первая
                        z[9].Split('\t')[1], //вторая
                        z[12]
                        );
                }

                grdDogUpravl.DataSource = dogUpravlAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);

            }
            catch (Exception ex)
            {
                MessageBox.Show(cnt.ToString() +" -- "+  ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Clipboard.Clear();
            }

        }

        private void DogUpravl_Load(object sender, EventArgs e)
        {
            dogUpravlAdapter.FillByActiveAudit(ds.DogUpravl, ActiveAudit.ID, ActiveAudit.ID_Company); //??
            dogUprUslAdapter.FillByDogovor(ds.DogUprUslugi, ActiveAudit.ID, ActiveAudit.ID_Company, this.currDogID);

            grdDogUpravl.DataSource = dogUpravlAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);
            grdUslugi.DataSource = dogUprUslAdapter.GetDataByDogovor( ActiveAudit.ID, ActiveAudit.ID_Company, this.currDogID);

            lblCurrDogovor.Text = this.currDogID.ToString();

            grdDogUpravl.Columns[0].Visible = false;
            grdDogUpravl.Columns[1].Visible = false;
            grdDogUpravl.Columns[2].Visible = false;

            grdDogUpravl.Columns[3].Width = grdDogUpravl.Width / 12;
            grdDogUpravl.Columns[4].Width = grdDogUpravl.Width / 12;
            grdDogUpravl.Columns[5].Width = grdDogUpravl.Width / 11;
            grdDogUpravl.Columns[6].Width = grdDogUpravl.Width / 11;
            grdDogUpravl.Columns[7].Width = grdDogUpravl.Width / 11;

            grdDogUpravl.Columns[8].Width = grdDogUpravl.Width / 12;
            grdDogUpravl.Columns[9].Width = grdDogUpravl.Width / 12;
            grdDogUpravl.Columns[10].Width = grdDogUpravl.Width / 11;
            grdDogUpravl.Columns[11].Width = grdDogUpravl.Width / 11;
            grdDogUpravl.Columns[12].Width = grdDogUpravl.Width / 11;
            grdDogUpravl.Columns[13].Width = grdDogUpravl.Width / 11;

            grdUslugi.Columns[0].Visible = false;
            grdUslugi.Columns[1].Visible = false;
            grdUslugi.Columns[2].Visible = false;
            grdUslugi.Columns[3].Visible = false;

            grdUslugi.Columns[4].Width = grdUslugi.Width / 3;
            grdUslugi.Columns[5].Width = grdUslugi.Width / 4;
            grdUslugi.Columns[6].Width = grdUslugi.Width / 3;
        }


        private void grdDogUpravl_SelectionChanged(object sender, EventArgs e)
        {
            if (grdDogUpravl.CurrentRow != null)
            {
                this.currDogID = (int)grdDogUpravl.CurrentRow.Cells[0].Value;
                lblCurrDogovor.Text = this.currDogID.ToString();

                grdUslugi.DataSource = dogUprUslAdapter.GetDataByDogovor(ActiveAudit.ID, ActiveAudit.ID_Company, this.currDogID);

            }
        }

        private void btnPerech_Click(object sender, EventArgs e)
        {//перечень услуг
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string[] cliparr = ActiveAudit.GetClipBoard("//my.dom.gosuslugi.ru/organization-cabinet/#!/agreements/contract/");

                if (cliparr == null) return;

                string[] data = cliparr.Where(s => !s.Contains("Вид коммунальных услуг") &&
                !s.Contains("Дополнительные услуги") && !s.Contains("Услуги отсутствуют") &&
                !s.Contains("Наименование")).ToArray();

                if(data.Count() % 3 != 0)
                {
                    MessageBox.Show("Похоже, данные скопированы некорректно");
                    return;
                }


                int skip = 0;
                string[] z;

                while ((z = data.Skip(skip).Take(3).ToArray()).Count() != 0)
                {
                    skip += 3;
                    dogUprUslAdapter.Insert(this.currDogID,
                        ActiveAudit.ID,
                        ActiveAudit.ID_Company,
                        z[0],
                        z[1].Split('\t')[0] + " - " + z[1].Split('\t')[1],
                        z[2]);
                }

                grdUslugi.DataSource = dogUprUslAdapter.GetDataByDogovor(ActiveAudit.ID, ActiveAudit.ID_Company, this.currDogID);

            }
            catch (Exception ex)
            {
                Clipboard.Clear();
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
            if (MessageBox.Show("Удалить договоры управления?",
                                   "Договоры управления",
                                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dogUpravlAdapter.DeleteByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);

                dogUpravlAdapter.FillByActiveAudit(ds.DogUpravl, ActiveAudit.ID, ActiveAudit.ID_Company); //??
                dogUprUslAdapter.FillByDogovor(ds.DogUprUslugi,  ActiveAudit.ID, ActiveAudit.ID_Company, this.currDogID );

                grdDogUpravl.DataSource = dogUpravlAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);
                grdUslugi.DataSource = dogUprUslAdapter.GetDataByDogovor( ActiveAudit.ID, ActiveAudit.ID_Company, this.currDogID); 
            }
        }

        private void DogUpravl_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

    }
}
