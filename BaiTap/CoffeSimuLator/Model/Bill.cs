using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeSimuLator.Model
{
    class Bill
    {
        public int id { get; set; }
        public DateTime timeIn { get; set; }
        public DateTime timeOut { get; set; }
        public int total { get; set; }
        public List<Note> note { get; set; }
        
        public override string ToString()
        {
            return $"Id: {id}\nTime In: {timeIn}\nTime Out:{timeOut}\nTotal: {total}";
        }
    }
}
