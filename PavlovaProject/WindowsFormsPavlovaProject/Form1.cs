using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WikipediaNET;
using HtmlAgilityPack;


namespace WindowsFormsPavlovaProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Wikipedia wikipedia = new Wikipedia();
       
        private void  SearchButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            wikipedia.Limit = 1;
            WikipediaNET.Objects.QueryResult results = wikipedia.Search(SearchText.Text);
            WikipediaNET.Objects.Search link = results.Search[0];
            
            string html = link.Url.OriginalString;
            HtmlAgilityPack.HtmlDocument HD = new HtmlAgilityPack.HtmlDocument();
            var web = new HtmlWeb
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8,
            };
            HD = web.Load(html);                    //Скачиваем всю HTML страницу

            HtmlNodeCollection NoAltElements;
            NoAltElements = HD.DocumentNode.SelectNodes("//div[@class='mw-content-ltr']/p");
                                                                                             

            string outputText = "";
            // проверка на наличие найденных узлов
            if (NoAltElements != null)
            {
                foreach (HtmlNode HN in NoAltElements)
                {
                    //Получаем строчки
                    outputText = HN.InnerText;
                    textBox1.AppendText(outputText);
                }
          
            }
            
        }

        private void SearchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchButton_Click(this, new EventArgs());
            }
        }

        private void RussianSearchButton_Click(object sender, EventArgs e)
        {
            wikipedia.Language = WikipediaNET.Enums.Language.Russian;
            SearchText.Text = "Введите запрос (Русскоязычный поиск)";
        }

        private void EnglishSearchButton_Click(object sender, EventArgs e)
        {
            wikipedia.Language = WikipediaNET.Enums.Language.English;
            SearchText.Text = "Введите запрос (Анголязычный поиск)";
        }

       
    }
}
