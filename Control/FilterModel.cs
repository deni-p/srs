using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.DeskApp
{
   public class FilterModel
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
   public class FilterPrint
   {
       public int From { get; set; }
       public int To { get; set; }
   }
}
