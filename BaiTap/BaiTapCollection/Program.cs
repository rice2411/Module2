using System;
using System.Collections;

namespace BaiTapCollection
{
    class Program
    {
        public static Hashtable NewList = new Hashtable();
        public static int ID = 1;
        static void Main(string[] args)
        {
            
            Menu();
        }
        static void Menu()
        {
            int choice = -1;
            while (choice < 1 || choice > 4)
            {
                Console.WriteLine("NEWS MANAGEMENT SYSTEM");
                Console.WriteLine("------------------------");
                Console.WriteLine("1. Insert news");
                Console.WriteLine("2. View list new");
                Console.WriteLine("3. Average rate");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Choice(choice);
             
            }
        }
        public static void Choice(int choice)
        {

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    InsertNews();
               
                    break;
                case 2:
                    Console.Clear();
                    ShowNewsList();
               
                    break;
                case 3:
                    Console.Clear();
                    CalculateRate();
                   
                    break;
                case 4:
                    Environment.Exit(Environment.ExitCode);
                    break;
            }
            Menu();
        }
        public static void InsertNews()
        {
            News news = new News();
            Console.Write("Title: ");
            string title = Console.ReadLine();
            DateTime publishDate = DateTime.Now;
            Console.Write("Author: ");
            string author = Console.ReadLine();
            Console.Write("Content: ");
            string content = Console.ReadLine();
            Console.WriteLine("Rating: ");
            for(int i =0;i<news.RateList.Length;i++)
            {
                Console.Write($"Rate {i + 1}: ");
                news.RateList[i] = Convert.ToInt32(Console.ReadLine());
            }
            news.Title = title;
            news.Author = author;
            news.PublishDate = publishDate;
            news.Content = content;
            news.ID = ID;

            ID++;
            NewList.Add(news.ID, news);
        }
        public static void ShowNewsList()
        {
            foreach(News news in NewList.Values)
            {
                news.CalculateRate();
                news.Display();
            }    
        }
        public static void CalculateRate()
        {
            foreach (News news in NewList.Values)
            {
                Console.WriteLine(news.CalculateRate());
            }

            
        }
    }
}
