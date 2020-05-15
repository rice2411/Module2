using System;
using System.Collections.Generic;
using System.Text;

namespace ReadJSonFile
{
    class PhysicalScore
    {
        public int score1 { get; set; }
        public int score2 { get; set; }
        public int score3 { get; set; }
        public int total { get; set; }
        public override string ToString()
        {
            return $"Score1 : {score1}, " +
                 $"Score2: {score2}, " +
                 $"Score3: {score3} ";

        }
        public string Multiple()
        {

            return $"Score1 : {score1 * 2}, " +
                 $"Score2: {score2 * 2}, " +
                $"Score3: {score3 * 2} ";
        }
        public int ToTal()
        {
            return total = score3 + score2 + score1;
        }
    }
}
