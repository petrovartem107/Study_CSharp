using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexStudy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 1. Кнопки

        //Пример с string.Replace
        private void bt2_Click(object sender, EventArgs e)
        {
            string str = tb2.Text;
            tb3.Text = str.Replace("рт", "т");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            CountColletction();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            RegexReplace();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ParseWebClientDollarMatchCollection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ParseWebClientDollarMatch();
        }

        /// <summary>
        /// IP XML
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            string result = "";
            string parsedSite = "";
            string path = $"http://ipwhois.app/xml/{tbIP.Text}";

            // Записали всю инфу с сайта
            using (WebClient wc = new WebClient())
            {
                parsedSite = wc.DownloadString(path);
            }


            // Создаем маску
            Regex regex = new Regex("<continent>(.*?)</continent>(.*?)<country_phone>(.*?)</country_phone>");

            //Создаем единственный экземпляр совпадения
            Match match = regex.Match(parsedSite);

            result = $"Континент: {match.Groups[1].Value}; Код телефона: {match.Groups[3].ToString()}";

            tbResult.Text = result;
        }
        
        /// <summary>
        /// IP JSON
        /// </summary>
        private void button6_Click(object sender, EventArgs e)
        {
            string result = "";
            string parsedSite = "";
            string path = $"http://ipwhois.app/json/{tbIP.Text}";

            // Записали всю инфу с сайта
            using (WebClient wc = new WebClient())
            {
                parsedSite = wc.DownloadString(path);
            }

            // Создаем маску
            Regex regex = new Regex("\"city\":\"(.*?)\",(.*?)\"currency\":\"(.*?)\",");

            //Создаем единственный экземпляр совпадения
            Match match = regex.Match(parsedSite);

            result = $"Город: {match.Groups[1].Value}; Валюта: {match.Groups[3].ToString()}";

            tbResult.Text = result;
        }
        #endregion

        #region 2. Событие на изменение текста
        private void tbIP_TextChanged(object sender, EventArgs e)
        {
            // Создаем маску
            Regex regex = new Regex("[^0-9-.]");

            bool isHave = regex.IsMatch(tbIP.Text);

            if (isHave)
            {
                MessageBox.Show("Только цифры и точка!","Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbIP.Text = tbIP.Text.Remove(tbIP.Text.Length - 1);
                tbIP.SelectionStart = tbIP.Text.Length;
            }

        } 
        #endregion


        #region 3. Методы

        /// <summary>
        /// Узнаём чё по доллару.
        /// </summary>
        private void ParseWebClientDollarMatch()
        {
            string result = "";
            string parsedSite = "";
            string path = tbPath.Text;

            // Записали всю инфу с сайта
            using (WebClient wc = new WebClient())
            {
                parsedSite = wc.DownloadString(path);
            }


            // Создаем маску
            Regex regex = new Regex("<Name>Доллар США</Name><Value>(.*?)</Value>");

            //Создаем единственный экземпляр совпадения
            Match match = regex.Match(parsedSite);

            result = match.Groups[1].Value;


            tbResult.Text = result;
        }

        /// <summary>
        /// Создаем коллекцию из сайта с АПИ по всем валютам. Используем Group
        /// </summary>
        private void ParseWebClientDollarMatchCollection()
        {
            string result = "";
            string parsedSite = "";
            string path = tbPath.Text;

            // Записали всю инфу с сайта
            using (WebClient wc = new WebClient())
            {
                parsedSite = wc.DownloadString(path);
            }


            // Создаем маску
            Regex regex = new Regex("<NumCode>(.*?)</NumCode><CharCode>(.*?)</CharCode><Nominal>(.*?)</Nominal><Name>(.*?)</Name><Value>(.*?)</Value>");

            //Создаем коллекцию, в которой есть совпадения по маске
            MatchCollection matches = regex.Matches(parsedSite);

            foreach (Match item in matches)
            {
                result += item.Groups[1].ToString() + " ";
                result += item.Groups[2].ToString() + " ";
                result += item.Groups[3].ToString() + " ";
                result += item.Groups[4].ToString() + " ";
                result += item.Groups[5].ToString() + " ";
                result += Environment.NewLine;

            }

            tbResult.Text = result;
        }

        /// <summary>
        /// Меняем овердохуя пробелов на 1 пробел
        /// </summary>
        private void RegexReplace()
        {
            string line = textBox1.Text;

            // Создаем маску
            string maska = @"\s+";
            Regex regex = new Regex(maska);

            tbResult.Text = regex.Replace(line, " ");

            //Короткая форма
            //label1.Text = new Regex(maska).Replace(line, @"\s+");
        }

        /// <summary>
        /// Выводим на экран кол-во совпадений
        /// </summary>
        private void CountColletction()
        {
            // Маска шаблон
            Regex regex = new Regex("текст");
            // Успешная коллекция
            MatchCollection matches = regex.Matches(textBox1.Text);
            // Выводим на экран кол-во совпадений
            tbResult.Text = matches.Count.ToString();
        }




        #endregion

    }
}
