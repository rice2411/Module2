using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIO
{
    class DirectoryDemo
    {
        public static string path = @"D:\CodeGym\Module2\Baitap\BaiTap\FileIO\File\output.txt";
    
        static void Main(string[] args)
        {

            /*     Directory.CreateDirectory($@"{path}\A\B");

                 *//*Directory.Delete($@"{path}\A");*//*
                 Directory.Move($@"{path}\A", $@"{path}\C");*/

            FileInfo fileinfo = new FileInfo(path);
            using(StreamReader sr = fileinfo.OpenText())
            {
                string line = "";
                while((line = sr.ReadLine())!= null)
                {
                    Console.WriteLine(line);
                }
            };
        }
    }
}
 