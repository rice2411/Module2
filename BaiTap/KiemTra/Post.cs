using System;
using System.Collections.Generic;
using System.Text;

namespace KiemTra
{
    class Post : IPost
    {
        private int id = 1;
        private string title;
       
        private string author;
        private string content;
        private float averageRate;
        public int[] Rates = new int[3];
        public int ID
        {
            get => id;
            set => id = value;
        }
        public string Title
        {
            get => title;
            set => title = value;
        }
      
        public string Author
        {
            get => author;
            set => author = value;
        }
        public string Content
        {
            get => content;
            set => content = value;
        }
        public float AverageRate
        {
            get => averageRate;
        }
        public void Display()
        {
            Console.WriteLine( $"ID:{id}\nTitle:{title}\nContent:{content}\nAuthor:{author}\nAverageRate:{averageRate}");
        }
        public float CalculatorRate()
        {
            float avg = 0;
            for(int i =0;i<Rates.Length;i++)
            {
                avg += Rates[i];
            }
            averageRate=avg/Rates.Length;
            return averageRate;
        }
    }
}
