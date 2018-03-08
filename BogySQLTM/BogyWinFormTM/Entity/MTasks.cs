using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BogyWinFormTM.Entity
{
   public class MTasks
    {
       [Key]
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Creator { get; set; }
        public int EstTime { get; set; }
        public int Assigned { get; set; }
        public DateTime CreTime { get; set; }
        public bool Final { get; set; }

        public virtual List<TimeSpent> TimeSpentL { get; set; }

       // public override String ToString()
       // {
       //     return this.Title + " " + this.Description;
       // }


    }
}
