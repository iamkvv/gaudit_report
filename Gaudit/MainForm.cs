using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaudit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void компанииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(Companies));
        }

        private void аудитToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(Audits));
        }

        private void паспортаМКДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(PassportMKD));
        }

        private void приборыУчетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(Pribors));
        }

        private void лицевыеСчетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(LicSchet));
        }

        private void голосованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(Voting));
        }

        private void договорыУправленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveAudit.Company.StartsWith("ТСЖ") || ActiveAudit.Company.StartsWith("ЖСК") || ActiveAudit.Company.StartsWith("ТСН"))
            {
                ShowForm(typeof(TsgUstav));
            }
            else
            {
                ShowForm(typeof(DogUpravl));
            }

        }

        private void работыИУслугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(DictWorkService));
        }

        private void реестрПеречнейРаботИУслугToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(PerechRabUslug));
        }

        private void базаДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(SelectDB));
        }

        private void лицензииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(License));
        }

        private void платежныеДокументыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(PlatDocs));
        }

        private void объектыЖилфондаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(GilFondObjects));
        }

        private void ShowForm(Type frm)
        {
            if (!ExistInParent(frm, out int ChildIndex))
            {
                Form go = (Form)Activator.CreateInstance(frm);
                go.MdiParent = this;
                go.Show();
            }
            else
            {
                MdiChildren[ChildIndex].Activate();
            }
        }

        bool ExistInParent(Type type, out int idx)
        {//открыта ли child-форма
            var f = this.MdiChildren
                .Select((o, i) => new { i, o })
                .Where(t => t.o.GetType() == type)
                .FirstOrDefault();

            if (f != null)
            {
                idx =  f.i;
                return true;
            }
            else
            {
                idx = -1;
                return false;
            }
        }
    }
}
