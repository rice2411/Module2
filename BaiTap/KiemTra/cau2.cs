using System;

namespace KiemTra
{
    class Cau2
    {
        public static int ID = 1;
        public static Forum forum = new Forum();
        static void Main(string[] args)
        {
         /* Post posttest = new Post();
            posttest.ID = 2;
            posttest.Title = "a";
            posttest.Content = "a";
            posttest.Author = "a";
            forum.Add(posttest.ID, posttest);*/
            Menu();
        }
        static void Menu()
        {
            int choice = -1;
            while (choice < 1 || choice >5)
            {
                Console.WriteLine("FORUM SYSTEM");
                Console.WriteLine("------------------------");
                Console.WriteLine("1. Create new post");
                Console.WriteLine("2. Update post");
                Console.WriteLine("3. Remove post");
                Console.WriteLine("4. Show all post");
                Console.WriteLine("5. Exit");
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
                    CreatePost();
                    break;
                case 2:
                    Console.Clear();
                    UpdatePost();

                    break;
                case 3:
                    Console.Clear();
                    RemovePost();
                    break;
                case 4:
                    Console.Clear();
                    ShowAllPost();
                    break;

                case 5:
                    Environment.Exit(Environment.ExitCode);
                    break;
            }
            Menu();
        }
        public static void CreatePost()
        {
            Post post = new Post();
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Content: ");
            string content = Console.ReadLine();
            Console.Write("Author: ");
            string author = Console.ReadLine();
            for(int i =0; i<post.Rates.Length;i++)
            {
                Console.Write($"Rate{i + 1}: ");
                post.Rates[i] = Convert.ToInt32(Console.ReadLine());
            }
            post.Title = title;
            post.Content = content;
            post.Author = author;
            post.CalculatorRate();
            forum.Add(ID, post);
        }
        public static void UpdatePost()
        {
            Console.Write("Input ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if(check(id))
            {
                Console.Write("Input content:" );
                string content = Console.ReadLine();
                forum.posts[id].Content = content;
            }
            else
            {
                Console.WriteLine("Cannot find the key");
            }

        }
        public static void RemovePost()
        {

            Console.Write("Input ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (check(id))
            {

                forum.posts.Remove(id);
            } else
            {
                Console.WriteLine("Cannot find the key");
            }                
        }
        public static void ShowAllPost()
        {
            forum.ShowAll();
        }
        public static bool check(int id)
        {
            foreach(var key in forum.posts.Keys)
            {
                if(forum.posts.ContainsKey(id))
                {
                    return true;
                }    
            }
            return false;
        }
    }
}
