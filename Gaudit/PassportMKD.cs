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
    public partial class PassportMKD : Form
    {

        Func<string, string> HouseAtrValue = delegate (string line)
        {
            string[] linearr = line.Trim('\t', ' ').Split('\t');

            if (linearr.Count() == 2)
            {
                return ""; //  linearr[1];
            }
            else if (linearr.Count() == 3)
            {
                return linearr[2]; ;
            }
            else
            {
                return "??";
            }
        };

        int selectedHouseID = 0;
        int selectedPorchID = 0;

        DataSet1 ds;
        ElHouseTableAdapter elHouseAdapter;
        ElHouseParamsTableAdapter elHouseParamAdapter;

        // ElHouseFlatsTableAdapter elHouseFlatsAdapter;
        // ElHouseNoflatsTableAdapter elHouseNoflatsAdapter;

        PorchTableAdapter porchAdapter;
        PomeschenieTableAdapter pomeschAdapter;

        public PassportMKD()
        {
            InitializeComponent();

            ds = new DataSet1();

            elHouseAdapter = new ElHouseTableAdapter();
            elHouseParamAdapter = new ElHouseParamsTableAdapter();
            // elHouseFlatsAdapter = new ElHouseFlatsTableAdapter();
            //  elHouseNoflatsAdapter = new ElHouseNoflatsTableAdapter();

            porchAdapter = new PorchTableAdapter();
            pomeschAdapter = new PomeschenieTableAdapter();
        }

        private void btnGetClipBoard_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string[] cliparr = ActiveAudit.GetClipBoard("//my.dom.gosuslugi.ru/organization-cabinet/#!/passport/");

                if (cliparr == null) return;

                elHouseAdapter.Insert(ActiveAudit.ID, ActiveAudit.ID_Company,
                    (from s in cliparr where s.Contains("1. Дата формирования электронного паспорта") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.1. Адрес многоквартирного дома") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.2. Кадастровый номер") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.3. Ранее присвоенный государственный") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.4. Год ввода в эксплуатацию") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.5. Год постройки") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.6. Стадия жизненного цикла") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.7. Год проведения реконструкции") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.8. Серия, тип проекта здания") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.9.1. Количество этажей") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.9.2. Количество подземных этажей") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.10. Количество подъездов") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.11. Наличие приспособлений") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.12. Количество лифтов") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.13. Количество жилых помещений") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.14. Количество нежилых помещений") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.15. Площадь здания (многоквартирного дома)") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.15.1. Общая площадь жилых") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.15.2. Общая площадь нежилых помещений") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.15.3. Общая площадь помещений общего") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.16. Количество балконов") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.17. Количество лоджий") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.18. Наличие статуса объекта культурного") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.19.1. Основание признания многоквартирного дома") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.19.2. Дата документа, содержащего решение") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.19.3. Номер документа, содержащего решение") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.20. Класс энергетической эффективности") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.21. Дата проведения энергетического") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.22. Дата приватизации первого жилого") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.23. Общий износ здания") select HouseAtrValue(s)).First(),
                    (from s in cliparr where s.Contains("2.24. Дата, на которую установлен износ") select HouseAtrValue(s)).First()
                    );

                DataSet1.ElHouseDataTable elh = elHouseAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);
                int lastID = ((DataSet1.ElHouseRow)elh.Rows[elh.Rows.Count - 1]).ID_ElHouse;
                grdElHouse.DataSource = elh;


                //параметры дома
                //string[] houseparams = cliparr.Where( s=> rgx1.IsMatch(s,0) || rgx1.IsMatch(s,1)).ToArray<string>() ;

                string[] houseparams = cliparr.Skip(35).Where(s => !(s.IndexOf("17.") == 0 || s.IndexOf("17.") == 1 || s.IndexOf("17.") == 2 || s.IndexOf("17.") == 3)
                                       && !(s.IndexOf("18.") == 0 || s.IndexOf("18.") == 1 || s.IndexOf("18.") == 2 || s.IndexOf("18.") == 3)).ToArray();

                foreach (string par in houseparams)
                {
                    elHouseParamAdapter.Insert(
                        lastID,
                         ActiveAudit.ID, ActiveAudit.ID_Company,
                        ParVal(par)[0],
                        ParVal(par)[1]
                        );
                }


                /// показать пераметры паспорта
                grdElHouse.ClearSelection();//If you want
                int nRows = grdElHouse.Rows.Count - 1;
                grdElHouse.Rows[nRows].Selected = true;
                //In case if you want to scroll down as well.
                grdElHouse.FirstDisplayedScrollingRowIndex = nRows;

                int currID = (int)grdElHouse.CurrentRow.Cells[0].Value;
                grdParams.DataSource = elHouseParamAdapter.GetDataByCurrentHouse(ActiveAudit.ID, ActiveAudit.ID_Company, currID);
                /////////



                /*
                //Flats
                //string[] flats1 = cliparr.Where(a => System.Text.RegularExpressions.Regex.IsMatch(a, @"^(\t17)")).ToArray();

                string[] flats = cliparr.Where(c => c.Trim('\t').IndexOf("17.") == 3 ||
                c.Trim('\t').IndexOf("17.") == 2).ToArray();

                //System.Text.RegularExpressions.MatchCollection collection= System.Text.RegularExpressions.Regex.Matches(cliparr, @"17", System.Text.RegularExpressions.RegexOptions.Compiled)

                int skipf = 0;
                string[] x;
                while ((x = flats.Skip(skipf).Take(11).ToArray()).Count() != 0)
                {
                    skipf += 11;

                    elHouseFlatsAdapter.Insert(
                        lastID,
                         ActiveAudit.ID,
                         ActiveAudit.ID_Company,
                         x[0].Split('\t')[x[0].Split('\t').Count() - 1],
                         x[1].Split('\t')[x[1].Split('\t').Count() - 1],
                         x[2].Split('\t')[x[2].Split('\t').Count() - 1],
                         x[3].Split('\t')[x[3].Split('\t').Count() - 1],
                         x[4].Split('\t')[x[4].Split('\t').Count() - 1],
                         x[5].Split('\t')[x[5].Split('\t').Count() - 1],
                         x[6].Split('\t')[x[6].Split('\t').Count() - 1],
                         x[7].Split('\t')[x[7].Split('\t').Count() - 1],
                         x[8].Split('\t')[x[8].Split('\t').Count() - 1],
                         x[9].Split('\t')[x[9].Split('\t').Count() - 1],
                         x[10].Split('\t')[x[10].Split('\t').Count() - 1]);
                }

                //string[] noflats = cliparr.Where(s => s.Contains("\t18.")).ToArray();

                string[] noflats = cliparr.Where(c => c.Trim('\t').IndexOf("18.") == 3 ||
                c.Trim('\t').IndexOf("18.") == 2).ToArray();


                int skipn = 0;
                string[] z;
                while ((z = noflats.Skip(skipn).Take(5).ToArray()).Count() != 0)
                {
                    skipn += 5;
                    elHouseNoflatsAdapter.Insert(lastID,
                         ActiveAudit.ID,
                         ActiveAudit.ID_Company,
                         NoflatVal(z[0]),
                         NoflatVal(z[1]),
                         NoflatVal(z[2]),
                         NoflatVal(z[3]),
                         NoflatVal(z[4])
                         );
                }
                Cursor.Current = Cursors.Default;
                */
                // }

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

        private string[] ParVal(string s)
        {//возвращает массив параметр-значение для эл. паспорта дома
            string[] linearr = s.Trim('\t', ' ').Split('\t');

            return new string[] { linearr[0], linearr.Count() == 2 ? "" : linearr[linearr.Count() - 1] };
        }

        private string NoflatVal(string s)
        {//значения для нежилых помещений
            string[] linearr = s.Trim('\t', ' ').Split('\t');
            if (linearr.Count() == 3)
            {
                return linearr[2];
            }
            else
            {
                return "";
            }
        }

        private void grdElHouse_SelectionChanged(object sender, EventArgs e)
        {//смена строки в паспорте
            if (grdElHouse.CurrentRow != null)
            {
                int currID = (int)grdElHouse.CurrentRow.Cells[0].Value;

                this.selectedHouseID = currID; //все привязать к этой переменной!!!
                label5.Text = this.selectedHouseID.ToString();

                if (currID != 0)
                {
                    DataRow[] drsPars = elHouseParamAdapter.GetData().Where(r => r.ID_ElHouse == currID).ToArray();
                    //   DataRow[] drsFlats = elHouseFlatsAdapter.GetData().Where(r => r.ID_ElHouse == currID).ToArray();
                    //   DataRow[] drsNoFlats = elHouseNoflatsAdapter.GetData().Where(r => r.ID_ElHouse == currID).ToArray();

                    grdParams.DataSource = drsPars;
                    //гасим странные поля
                    grdParams.Columns[6].Visible = false;
                    grdParams.Columns[7].Visible = false;
                    grdParams.Columns[8].Visible = false;
                    grdParams.Columns[9].Visible = false;
                    grdParams.Columns[10].Visible = false;

                    porchAdapter.FillBySelectedHouse(ds.Porch, currID, ActiveAudit.ID, ActiveAudit.ID_Company);
                    grdPorch.DataSource = porchAdapter.GetDataByFillBySelectedHouse(currID, ActiveAudit.ID, ActiveAudit.ID_Company);


                    int currPorchId = 0;
                    if(grdPorch.CurrentRow !=null)
                    {
                        currPorchId = (int)grdPorch.CurrentRow.Cells[0].Value;
                    }

                    // grdPomesch.DataSource = porchAdapter.GetDataByFillBySelectedHouse(currID, ActiveAudit.ID, ActiveAudit.ID_Company);

                    pomeschAdapter.FillBySelectedPorch(ds.Pomeschenie, currPorchId, ActiveAudit.ID, ActiveAudit.ID_Company);

                    grdPomesch.DataSource = pomeschAdapter.GetDataBySelectedPorch(currPorchId, ActiveAudit.ID, ActiveAudit.ID_Company);
                }
            }
        }


        private void grdParams_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            MessageBox.Show("Error happened " + anError.Context.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {//удаляем выбранный паспорт
            if (ActiveAudit.ID != 0)
            {
                if (MessageBox.Show("Удалить паспорт МКД?",
                                     "Электронный паспорт дома",
                                      MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    elHouseAdapter.DeleteSelectedPassport(this.selectedHouseID, ActiveAudit.ID, ActiveAudit.ID_Company);

                    elHouseAdapter.FillByActiveAudit(ds.ElHouse, ActiveAudit.ID, ActiveAudit.ID_Company);
                    grdElHouse.DataSource = elHouseAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);

                    ///?????!!
                    porchAdapter.FillBySelectedHouse(ds.Porch, this.selectedHouseID, ActiveAudit.ID, ActiveAudit.ID_Company);
                    grdPorch.DataSource = porchAdapter.GetDataByFillBySelectedHouse(this.selectedHouseID, ActiveAudit.ID, ActiveAudit.ID_Company);
                }
            }
        }


        private void PassportMKD_Load(object sender, EventArgs e)
        {
            try
            {
                elHouseAdapter.FillByActiveAudit(ds.ElHouse, ActiveAudit.ID, ActiveAudit.ID_Company);
                grdElHouse.DataSource = elHouseAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);

                int currID = 0;
                if (grdElHouse.CurrentRow != null)
                {
                    currID = (int)grdElHouse.CurrentRow.Cells[0].Value;
                }

                elHouseParamAdapter.FillByCurrentHouse(ds.ElHouseParams, ActiveAudit.ID, ActiveAudit.ID_Company, currID);
                grdParams.DataSource = elHouseParamAdapter.GetDataByCurrentHouse(ActiveAudit.ID, ActiveAudit.ID_Company, currID);


                porchAdapter.FillBySelectedHouse(ds.Porch, this.selectedHouseID, ActiveAudit.ID, ActiveAudit.ID_Company);
                grdPorch.DataSource = porchAdapter.GetDataByFillBySelectedHouse(currID, ActiveAudit.ID, ActiveAudit.ID_Company); //this.selectedHouseID,

                pomeschAdapter.FillBySelectedPorch(ds.Pomeschenie, this.selectedPorchID, ActiveAudit.ID, ActiveAudit.ID_Company);
                grdPomesch.DataSource = pomeschAdapter.GetDataBySelectedPorch(this.selectedPorchID, ActiveAudit.ID, ActiveAudit.ID_Company);


                //elHouseFlatsAdapter.FillByCurrentHouse(ds.ElHouseFlats, ActiveAudit.ID, ActiveAudit.ID_Company, currID);
                //grdFlats.DataSource = elHouseFlatsAdapter.GetDataByCurrentHouse(ActiveAudit.ID, ActiveAudit.ID_Company, currID);

                //elHouseNoflatsAdapter.FillByCurrentHouse(ds.ElHouseNoflats, ActiveAudit.ID, ActiveAudit.ID_Company, currID);
                //grdNoflats.DataSource = elHouseNoflatsAdapter.GetDataByCurrentHouse(ActiveAudit.ID, ActiveAudit.ID_Company, currID);


                grdElHouse.Columns[0].Visible = false;
                grdElHouse.Columns[1].Visible = false;
                grdElHouse.Columns[2].Visible = false;

                grdParams.Columns[0].Visible = false;
                grdParams.Columns[1].Visible = false;
                grdParams.Columns[2].Visible = false;
                grdParams.Columns[3].Visible = false;

                grdParams.Columns[4].HeaderText = "Параметр";
                grdParams.Columns[5].HeaderText = "Значение";

                grdParams.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                grdParams.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;


                grdParams.Columns[4].Width = grdParams.Width / 2;
                grdParams.Columns[5].Width = grdParams.Width / 2;


                grdPorch.Columns[0].Visible = false;
                grdPorch.Columns[1].Visible = false;
                grdPorch.Columns[2].Visible = false;
                grdPorch.Columns[3].Visible = false;

                grdPorch.Columns[4].Width = grdPorch.Width / 5;
                grdPorch.Columns[5].Width = grdPorch.Width / 4;
                grdPorch.Columns[6].Width = grdPorch.Width / 4;
                grdPorch.Columns[7].Width = grdPorch.Width / 4;


                grdPomesch.Columns[0].Visible = false;
                grdPomesch.Columns[1].Visible = false;
                grdPomesch.Columns[2].Visible = false;
                grdPomesch.Columns[3].Visible = false;

                grdPomesch.Columns[4].Width = grdPomesch.Width / 10;
                grdPomesch.Columns[5].Width = grdPomesch.Width / 7;
                grdPomesch.Columns[6].Width = grdPomesch.Width / 7;
                grdPomesch.Columns[7].Width = grdPomesch.Width / 7;
                grdPomesch.Columns[8].Width = grdPomesch.Width / 7;
                grdPomesch.Columns[9].Width = grdPomesch.Width / 7;
                grdPomesch.Columns[10].Width = grdPomesch.Width / 7;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PassportMKD_Resize(object sender, EventArgs e)
        {
            tabControl1.Left = (this.ClientSize.Width - tabControl1.Width) / 2;
            tabControl1.Top = (this.ClientSize.Height - tabControl1.Height) / 2;
        }

        private void btnGetPorch_Click(object sender, EventArgs e)
        {//все подъезды по выбранному дому

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string[] clparr = ActiveAudit.GetClipBoard("//my.dom.gosuslugi.ru/organization-cabinet/#!/house/card?");

                if (clparr == null) return;

                int skip = 0;
                string[] strarr;

                if (clparr.Count() % 4 != 0)
                {
                    MessageBox.Show("Данные подъездов скопированы некорректно.");
                    return;
                }

                while ((strarr = clparr.Skip(skip).Take(4).ToArray()).Count() != 0)
                {
                    skip += 4;
                    porchAdapter.Insert(
                        this.selectedHouseID,
                        ActiveAudit.ID_Company,
                        ActiveAudit.ID,
                        strarr[0].Split(' ')[strarr[0].Split(' ').Length - 1], //Номер
                        strarr[1].Split(' ')[strarr[1].Split(' ').Length - 1], //Количество ЛС
                        strarr[2].Split(' ')[strarr[2].Split(' ').Length - 1], // Этажность
                        strarr[3].Split(' ')[strarr[3].Split(' ').Length - 1]  //Год постройки
                        );
                }

                grdPorch.DataSource = porchAdapter.GetDataByFillBySelectedHouse(this.selectedHouseID, ActiveAudit.ID, ActiveAudit.ID_Company);

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

        private void grdPorch_SelectionChanged(object sender, EventArgs e)
        {
            if (grdPorch.CurrentRow != null)
            {
                this.selectedPorchID = (int)grdPorch.CurrentRow.Cells[0].Value;

                pomeschAdapter.FillBySelectedPorch(ds.Pomeschenie, selectedPorchID, ActiveAudit.ID, ActiveAudit.ID_Company);
                grdPomesch.DataSource = pomeschAdapter.GetDataBySelectedPorch(this.selectedPorchID, ActiveAudit.ID, ActiveAudit.ID_Company);
            }
        }

        private void btnGetPomesch_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string[] clparr = ActiveAudit.GetClipBoard("//my.dom.gosuslugi.ru/organization-cabinet/#!/house/card?");
                if (clparr == null) return;

                int selPorchId = (int)grdPorch.CurrentRow.Cells[0].Value; //временно на всякий случай

                string[] pdata = clparr.Where(s => !s.Contains("ПУ")).ToArray();

                if (pdata.Count() % 7 != 0)
                {
                    MessageBox.Show("Данные помещений скопированы некорректно.");
                    return;
                }

                int skip = 0;
                string[] arr;

                while ((arr = pdata.Skip(skip).Take(7).ToArray()).Count() != 0)
                {
                    skip += 7;

                    pomeschAdapter.Insert(
                        selPorchId,
                        ActiveAudit.ID,
                        ActiveAudit.ID_Company,
                        arr[0].Split('№')[arr[0].Split('№').Length - 1], //Номер
                        arr[1].Split('\t')[arr[1].Split('\t').Length - 1], //категория
                        arr[2].Split('\t')[arr[2].Split('\t').Length - 1].Split(' ')[0], //Общая пл-дь
                        arr[3].Split('\t')[arr[3].Split('\t').Length - 1].Split(' ')[0], //жилая пл-дь
                        arr[4].Split('\t')[arr[1].Split('\t').Length - 1],//Кадастр
                        arr[5].Split(':')[1], //хар-ка
                        arr[6].Split('\t')[1]
                        );
                }

                grdPomesch.DataSource = pomeschAdapter.GetDataBySelectedPorch(selPorchId, ActiveAudit.ID, ActiveAudit.ID_Company);

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

        private void btnDeletePorch_Click(object sender, EventArgs e)
        {
            if (ActiveAudit.ID != 0)
            {
                if (MessageBox.Show("Удалить выбранный подъезд?",
                                     "Электронный паспорт дома",
                                      MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.selectedPorchID = (int)grdPorch.CurrentRow.Cells[0].Value;
                    porchAdapter.DeleteSelectedPorch(this.selectedPorchID, ActiveAudit.ID, ActiveAudit.ID_Company);

                    porchAdapter.FillBySelectedHouse(ds.Porch, this.selectedHouseID, ActiveAudit.ID, ActiveAudit.ID_Company);
                    grdPorch.DataSource = porchAdapter.GetDataByFillBySelectedHouse(this.selectedHouseID, ActiveAudit.ID, ActiveAudit.ID_Company);
                }
            }
        }

        private void grdParams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //    ^(?<=)\d{1,2}\.

         
        }

        private void grdParams_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Regex rgx = new Regex(@"^(?<=)\d{1,2}\.\s");   //так точнее ->  ^(?<=)\d{1,2}\.\s|^(?<=)\d{1,2}\.\d{1,2}\. 

            if (e.ColumnIndex == 4)
            {
                if (rgx.IsMatch(grdParams.Rows[e.RowIndex].Cells[4].Value.ToString()))
                {
                    grdParams.Rows[e.RowIndex].Cells[4].Style.ForeColor = Color.Blue;
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //https://docs.microsoft.com/ru-ru/sql/reporting-services/report-design/expression-uses-in-reports-report-builder-and-ssrs?view=sql-server-2017
            //FormTest frm = new FormTest();
            //frm.Show();

           // elHouseAdapter.FillByActiveAudit(ds.ElHouse, ActiveAudit.ID, ActiveAudit.ID_Company);
            //elHouseAdapter.FillByActiveAudit((DataSet1.ElHouseDataTable)ds.ElHouse, ActiveAudit.ID, ActiveAudit.ID_Company);

          
            /* !!!

            elHouseParamAdapter.Fill(ds.ElHouseParams);//!!!необходимо   FillByCurrentHouse(ds.ElHouseParams, ActiveAudit.ID, ActiveAudit.ID_Company,)

            int poms = pomeschAdapter.GetDataByActiveAudit(ActiveAudit.ID).Count();

            //int pomsByHouse = pomeschAdapter.GetDataByCurrentElHouse (ActiveAudit.ID,20).Count();


            foreach (DataSet1.ElHouseRow rr in ds.ElHouse.Rows)
            {
                DataSet1.ElHouseRow row = rr;

                Console.WriteLine(pomeschAdapter.GetDataByCurrentElHouse(ActiveAudit.ID, rr.ID_ElHouse).Count());

                Console.WriteLine(row.GetChildRows("ElHouseElHouseParams").Count());
            }

            //row.GetChildRows("ElHouseElHouseParams").Where(r=>r["ParamValue"] != "").Count()

    */

            //DataRowCollection drCollection = elHouseAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company).Rows;
            //foreach (DataSet1.ElHouseRow dr in drCollection)
            //{
            //    DataRow[] childDR = dr.GetChildRows("ElHouseElHouseParams");
            //    Console.WriteLine(childDR);
            //    DataSet1.ElHouseParamsRow[] childDR1 = dr.GetElHouseParamsRows();// ElHouseElHouseParams  GetChildRows("ElHouseElHouseParams");
            //}

        }
    }
}
 