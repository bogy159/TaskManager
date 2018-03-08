using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BogyConsoleTM.Entity;
using BogyConsoleTM.Repository;

namespace BogyConsoleTM.Authintication
{
   public static class Login
    {
       public static Users LoggedUser { get; private set; }

       public static void AuthenticateUser(string username, string password)
       {
           UserRepo userRepo = new UserRepo("users.txt");
           Login.LoggedUser = userRepo.GetByUsernameAndPassword(username, password);
       }
    }
}