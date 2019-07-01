using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaudit
{
    /// <summary>
    /// Электронный паспорт (отчет)
    /// </summary>
    public class repElHouse
    {
        public int ID { get; set; } //Id дома в эл паспорте 
        public string Address { get; set; } // Адрес в эл паспорте
        public int quantParams { get; set; } //кол-во параметров дома в эл паспорте
        public int quantFilledParams { get; set; } //кол-во заполненных параметров дома в эл паспорте
        public int quantFlats { get; set; } //кол-во квартир в  доме по эл паспорту
        public int quantNoFlats { get; set; } //кол-во нежил. помещ-й в доме по эл паспорту
    }

    /// <summary>
    /// Объекты жилого фонда (отчет)
    /// </summary>
    public class repGilFondObj
    {
        public int ID_GilFondObject { get; set; } //Id дома 
        public int ID_Audit { get; set; } // 
        public int ID_Company { get; set; } //

        public string Company { get; set; } // Адрес

        public string Address { get; set; } // Адрес
        public int quantGilPom { get; set; } //кол-во жил пом-й
        public int quantNoGilPom { get; set; } //кол-во нежил пом-й
        public int quantLS { get; set; } //кол-во лиц. счетов
        public DateTime? maxDateLS { get; set; } //макс дата вызгузки лиц. счетов
        public int quantVoting { get; set; } //кол-во голосований
        public DateTime? maxDateVoting { get; set; } //макс дата выгрузки голосований

        public string perechRabUsl { get; set; } //Перечень работ и услуг

        public int quantPlatDocsRazm { get;set;} //платежные док-ты со статусом Размещен
        public int quantPlatDocsNoRazm { get; set; } //платежные док-ты со статусом Проект
    }

    public  class AudRep
    {

        public List<repGilFondObj> Data { get; set; }
    }




        public static class ActiveAudit
    {
        public static int ID { get; set; }
        public static string Name { get; set; }
        public static int ID_Company { get; set; }
        public static string Company { get; set; }
        public static DateTime Date { get; set; }

        public static void Clear()
        {
            ID = 0;
            Name = null;
            ID_Company = 0;
            Company = null;
            Date = DateTime.Now;
        }


        public static string[]  GetClipBoard(string adr)
        {
            IDataObject iData = Clipboard.GetDataObject();
            string mess = "В буфере не обнаружены корректные данные.";


            if (iData.GetDataPresent(DataFormats.Html))
            {
                string html = ((String)iData.GetData(DataFormats.Html));

                string[] htmlarr = html.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                if (String.IsNullOrEmpty(html) ||
                    htmlarr.Count() < 5 ||
                    !htmlarr[5].Split(':')[2].Contains(adr))
                {
                    MessageBox.Show("Выбрана некорректная страница.",
                        "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                    return null;
                }
            }
            else
            {
                MessageBox.Show(mess);
                return null;
            }

            if (iData.GetDataPresent(DataFormats.UnicodeText)) //получим массив строк
            {
                string clpbrd = (String)iData.GetData(DataFormats.UnicodeText);
                string[] clparr = clpbrd.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                return clparr;
            }
            else
            {
                MessageBox.Show(mess);
                return null;
            }
        }
    }
}
