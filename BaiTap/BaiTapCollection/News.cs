﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCollection
{
    class News : INews
    {
        private int id = 1;
        private string title;
        private DateTime publishDate;
        private string author;
        private string content;
        private float averageRate;
        public int[] RateList = new int[3]; 
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
        public DateTime PublishDate
        {
            get => publishDate;
            set => publishDate = value;
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
            Console.WriteLine($"ID: {id}\nTitle: {title}\nPublish Date: {publishDate.ToString("dd/MM/yyyy")}\nAuthor: {author}\nContent: {content}\nAverageRate: {averageRate}"); 
        }
        public float CalculateRate()
        {
            float avg = 0;
            for(int i =0;i < RateList.Length;i++)
            {
                avg += RateList[i];
            }
            averageRate = avg/3;
            return averageRate;
        }

      
    }
}
