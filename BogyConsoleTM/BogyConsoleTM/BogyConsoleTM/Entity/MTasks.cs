using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogyConsoleTM.Entity
{
   public class MTasks
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Creator { get; set; }
        public int EstTime { get; set; }
        public int Assigned { get; set; }
        public DateTime CreTime { get; set; }
    }
}
