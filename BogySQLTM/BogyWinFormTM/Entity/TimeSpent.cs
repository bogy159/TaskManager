using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BogyWinFormTM.Entity
{
   public class TimeSpent
    {
      [Key]
        public int TSId { get; set; }
        public int TheAssi { get; set; }
        public int TheTask { get; set; }
        public DateTime FinTime { get; set; }
        public int Hours { get; set; }

        public virtual List<MTasks> Posts { get; set; }

    }
}
