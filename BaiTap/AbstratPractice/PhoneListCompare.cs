using System;
using System.Collections.Generic;
namespace AbstratPractice
{
   public class PhoneListComparator : IComparer<Contact>
    {
        public int Compare(Contact a, Contact b)
        {
            return a.Name.CompareTo(b.Name);
        }
    }
}
