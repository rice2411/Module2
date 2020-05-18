using System;
using System.Collections.Generic;
using System.Text;



namespace PraticeReadJSonFile
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Level { get; set; }
        public List<Subject> Subjects { get; set; }
        public double Average()
        {
            double total = 0;
            foreach (var subject in Subjects)
            {
                if (subject.Name.ToLower().Equals("math"))
                {
                    total += double.Parse(subject.Score) * 2;
                }
                else
                {
                    total += double.Parse(subject.Score);    
                }
              
            }
            return    Math.Round(Convert.ToDouble(total/4), 2);
        }

        public string Rank()
        {
            double averageScore = Average();
            if (averageScore >=Common.Rank.XuatSac)
            {
                return Common.Rank.ToString(Common.Rank.XuatSac);
            }
            else if (averageScore >= Common.Rank.Gioi)
            {
                return Common.Rank.ToString(Common.Rank.Gioi);
            }
            else if (averageScore >= Common.Rank.Kha)
            {
                return Common.Rank.ToString(Common.Rank.Kha);
            }
            else if (averageScore >= Common.Rank.TBK)
            {
                return Common.Rank.ToString(Common.Rank.TBK);
            }
            else if (averageScore >= Common.Rank.TB)
            {
                return Common.Rank.ToString(Common.Rank.TB);
            }
            else if (averageScore >= Common.Rank.Yeu)
            {
                return Common.Rank.ToString(Common.Rank.Yeu);
            }
            else
            {
                return Common.Rank.ToString();
            }
        }
    }

}

