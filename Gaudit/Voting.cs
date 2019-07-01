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
    public partial class Voting : Form
    {

        VotingTableAdapter votingAdapter;
        DataSet1 ds;
        public Voting()
        {
            InitializeComponent();
            ds = new DataSet1();
            votingAdapter = new VotingTableAdapter();
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
                       // htmlarr.Count() < 5 ||
                       !htmlarr[5].Split(':')[2].Contains("my.dom.gosuslugi.ru/organization-cabinet/#!/voting/search"))
                    {
                        MessageBox.Show("Для работы с голосованиями перейдите на страницу \n\r" +
                            "https://my.dom.gosuslugi.ru/organization-cabinet/#!/voting/search \n\r" +
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

                    while ((z = data.Skip(skip).Take(2).ToArray()).Count() != 0)
                    {
                        skip += 2;
                        votingAdapter.Insert(
                           ActiveAudit.ID,
                           ActiveAudit.ID_Company,
                           z[0],
                           z[1].Split('\t')[0],
                           z[1].Split('\t')[1],
                           z[1].Split('\t')[2],
                           z[1].Split('\t')[3],
                           z[1].Split('\t')[4],
                           z[1].Split('\t')[5]
                           );
                    }

                    grdVoting.DataSource = votingAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);
                
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

        private void Voting_Load(object sender, EventArgs e)
        {
            votingAdapter.FillByActiveAudit(ds.Voting, ActiveAudit.ID, ActiveAudit.ID_Company);
            grdVoting.DataSource = votingAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);

            grdVoting.Columns[0].Visible = false;
            grdVoting.Columns[1].Visible = false;
            grdVoting.Columns[2].Visible = false;

            grdVoting.Columns[3].Width = grdVoting.Width / 7;
            grdVoting.Columns[4].Width = grdVoting.Width / 7;
            grdVoting.Columns[5].Width = grdVoting.Width / 7;
            grdVoting.Columns[6].Width = grdVoting.Width / 7;
            grdVoting.Columns[7].Width = grdVoting.Width / 8;
            grdVoting.Columns[8].Width = grdVoting.Width / 8;
            grdVoting.Columns[9].Width = grdVoting.Width / 8;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ActiveAudit.ID != 0)
            {
                if (MessageBox.Show("Удалить данные голосований?",
                                     "Голосования",
                                      MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    votingAdapter.DeleteCurrents(ActiveAudit.ID, ActiveAudit.ID_Company);

                    votingAdapter.FillByActiveAudit(ds.Voting, ActiveAudit.ID, ActiveAudit.ID_Company);
                    grdVoting.DataSource = votingAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);
                }
            }
        }

        private void Voting_Resize(object sender, EventArgs e)
        {
            splitContainer1.Left = (this.ClientSize.Width - splitContainer1.Width) / 2;
            splitContainer1.Top = (this.ClientSize.Height - splitContainer1.Height) / 2;
        }
    }
}
