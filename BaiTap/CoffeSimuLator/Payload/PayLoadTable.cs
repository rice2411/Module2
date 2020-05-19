using CoffeSimuLator.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeSimuLator.Payload
{
    class PayLoadTable
    {
        public List<Table> tables { get; set; }
        public bool CheckTable(int id)
        {
            foreach (var table in tables)
            {
                if(id.Equals(table.id))
                {
                    return true;
                }
            }
            return false;
        }
      
    }
}
