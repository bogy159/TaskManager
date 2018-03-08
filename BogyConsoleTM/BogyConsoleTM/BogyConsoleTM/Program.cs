using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BogyConsoleTM.View;

namespace BogyConsoleTM
{
    class Program
    {
        static void Main(string[] args)
        {
            Index loginView = new Index();
            loginView.Show();

           MainMenu menuView = new MainMenu();
           menuView.Show();

        }
    }
}
