using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BogyWinFormTM.Entity
{
   public class Users
    {
       [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
    }
}
