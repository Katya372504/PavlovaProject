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
    /// <summary>
    /// Форма программы "Незнайка".
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Объект для работы с поиском.
        /// </summary>
        Wikipedia wikipedia = new Wikipedia();
       /// <summary>
       /// Нажатие кнопки "Найти". Поиск результата.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void  SearchButton_Click(object sender, EventArgs e)
        {
            //Очистить поле вывода от предыдущего результата.
            TextBox.Clear();
            //Задаем количество искомых ссылок.
            wikipedia.Limit = 1;
            //Формируем объект, содержащий результаты поиска.
            WikipediaNET.Objects.QueryResult results = wikipedia.Search(SearchText.Text);
            //Формируем список ссылок.
            WikipediaNET.Objects.Search link = results.Search[0];
            
            string html = link.Url.OriginalString;

            //Создаем объект для работы со страницей HTML (Библиотека HtmlAgilityPack)
            HtmlAgilityPack.HtmlDocument HD = new HtmlAgilityPack.HtmlDocument();

            var web = new HtmlWeb
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8,
            };
            HD = web.Load(html);                    //Скачиваем всю HTML страницу

            //Выбор по наличию блока, содержащего класс "mw-content-ltr" (класс содержащий текст статьи в разметке HTML)
            HtmlNodeCollection NoAltElements;
            NoAltElements = HD.DocumentNode.SelectNodes("//div[@class='mw-content-ltr']/p"); 


            //Пустая строка для записи текста.
            string outputText = string.Empty; 

            // проверка на наличие найденных узлов
            if (NoAltElements != null)
            {
                foreach (HtmlNode HN in NoAltElements)
                {
                    //Получаем строчки из HTML-файла.
                    outputText = HN.InnerText;
                    //Добавляем строчки в TextBox.
                    TextBox.AppendText(outputText);
                }
          
            }
            
        }
        /// <summary>
        /// Включение поиска по нажатию Enter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchButton_Click(this, new EventArgs());
            }
        }
        /// <summary>
        /// Кнопка смены языка поиска (русский язык).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RussianSearchButton_Click(object sender, EventArgs e)
        {
            wikipedia.Language = WikipediaNET.Enums.Language.Russian;  //Смена языка поиска на русский (Wikipedia.Net библиотека).
            SearchText.Text = "Введите запрос (Русскоязычный поиск)";
        }
        /// <summary>
        /// Кнопка смены языка поиска (английский язык).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnglishSearchButton_Click(object sender, EventArgs e)
        {
            wikipedia.Language = WikipediaNET.Enums.Language.English; //Смена языка поиска на английский (Wikipedia.Net библиотека).
            SearchText.Text = "Введите запрос (Анголязычный поиск)";
        }
        /// <summary>
        /// Поиск по тексту первого совпадения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox.Select(TextBox.Find(SearchBox.Text), SearchBox.Text.Length); //Выбор нужного фрагмента из всего текста.
                TextBox.SelectionBackColor = Color.Green; //Изменить цвет заднего фона по умолчанию.
            }

            catch
            {

            }
        }
        /// <summary>
        /// Перезагрузка поиска.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetSearchButton_Click(object sender, EventArgs e)
        {
            TextBox.Select(TextBox.SelectionStart, TextBox.SelectionLength); //Выбрать закрашеного фрагмента.
            TextBox.SelectionBackColor = Color.White; // Вернуть цвет заднего фона по умолчанию.
        }
        

       
    }
} 