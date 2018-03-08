using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogyWinFormTM.Entity
{
  public  class TimeSpent
    {
        public int TSId { get; set; }
        public int TheAssi { get; set; }
        public int TheTask { get; set; }
        public DateTime FinTime { get; set; }
        public int Hours { get; set; }
    }
}
