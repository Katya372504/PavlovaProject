using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using WikipediaNET;
using System.Text.RegularExpressions;
using System.Threading;

namespace PavlovaProjectConsole
{
    /// <summary>
    /// Основная программа.
    /// </summary>
    class ConsoleVersion
    {
        /// <summary>
        /// Поток исполнения программы.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Объект из библиотеки Wikipedia.Net. (https://github.com/Genbox/Wikipedia.Net)
            Wikipedia wikipedia = new Wikipedia();
               
            while (true)
            {
                //Часть ввода.
                Console.Write("Как много ссылок попытаться найти:");

                /// <summary>
                /// Число искомых ссылок.
                /// </summary>
                int count = Convert.ToInt32(Console.ReadLine());
                wikipedia.Limit = count;

                Console.Write("Я хочу знать:");

                /// <summary>
                ///Запрос.
                /// </summary>
                string t = Console.ReadLine();
                

                //Результаты поиска по переданному запросу.
                //Объект из библиотеки Wikipedia.Net. (https://github.com/Genbox/Wikipedia.Net)
                WikipediaNET.Objects.QueryResult results = wikipedia.Search(t);

                Console.WriteLine("Вывод результатов: ...");

                //Цикл вывода результатов.
                foreach (WikipediaNET.Objects.Search s in results.Search)
                    Process.Start(s.Url.ToString());

                //Взаимодействие с пользователем.
                Console.WriteLine("Хотите завершить работу? (Да - нажмите N, иначе любую кнопку.)");

                if (Console.ReadKey(true).Key == ConsoleKey.N)
                {
                    Console.Write("Спасибо за использование.");
                    //Задержка перед выходом.
                    Thread.Sleep(2000);
                    return;
                }
                else
                {
                    //Продолжение работы.
                    Console.ReadKey(true);
                    Console.WriteLine();
                }
            }
        }
    }
}