using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using BogyWinFormTM.Authentication;
using BogyWinFormTM.Entity;
using BogyWinFormTM.Repository;
using BogyWinFormTM.View;


namespace BogyWinFormTM.Authentication
{
    public static class Login
    {
        public static Users LoggedUser { get; set; }

        public static void AuthenticateUser(string username, string password)
        {
            Index userRepo = new Index();
            Login.LoggedUser =  userRepo.GetByUsernameAndPassword(username, password);

        }

    }
}