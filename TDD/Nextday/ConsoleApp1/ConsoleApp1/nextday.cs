using System;

namespace nextday
{
   public class Nextday
    {
        private int ADMIN_DAY = 31;
        private int ADMIN_DAY1 = 30;
        private int SPECIAL_MONTH = 2;
        private int SPECIAL_DAY_OF_MONTH = 28;
        private int SPECIAL_DAY_OF_MONTH1 = 29;
        private int ADMIN_MOTNH = 12;
       
         
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        
        public string WhatIsTheNextDay(DateTime today)
        {
            day = today.Day;
            month = today.Month;
            year = today.Year;
            if (day == ADMIN_DAY && month == ADMIN_MOTNH)
            {
                day = 1;
                month = 1;
                year = today.Year + 1;

            }
            
           else if (day == ADMIN_DAY && month == 1 || day == ADMIN_DAY && month == 3 || day == ADMIN_DAY && month == 5 || day == ADMIN_DAY && month == 7 || day == ADMIN_DAY && month == 8 || day == ADMIN_DAY && month == 10)
            {
                
                
                
                    day = 1;
                    month = today.Month + 1;
                    year = today.Year;

                
            }
           else if (day == ADMIN_DAY1 && month == 4 || day == ADMIN_DAY1 && month == 6 || day == ADMIN_DAY1 && month == 9 || day == ADMIN_DAY1 &&  month == 11 )
            {
                day = 1;
                month = today.Month + 1; 
            }
            else if(month == SPECIAL_MONTH && isLeapYear(year))
            {
                if(day == SPECIAL_DAY_OF_MONTH )
                {
                    day = today.Day + 1;    
                } else 
                {
                    day = 1;
                    month = today.Month+1;
                }
            }
            else if(month == SPECIAL_MONTH && !isLeapYear(year))
            {
                day = 1;
                month = today.Month + 1;
            }
           else
                {
                day = today.Day + 1;
              
            }
            return $"{day}/{ month}/{year}";
        }
        private static bool isLeapYear(int yea)
        {
            if (yea % 4 == 0)
            {
                if (yea % 100 == 0)
                {
                    if (yea % 400 == 0)
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        public  bool check(DateTime day)
        {
            if (day.Month < 0 || day.Month > 12 || day.Day < 0 || day.Day > 31)
                return false;
            return true;
        }
    }
}
