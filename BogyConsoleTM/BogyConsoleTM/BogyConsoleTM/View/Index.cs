using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BogyConsoleTM.Repository;
using BogyConsoleTM.Entity;
using BogyConsoleTM.Authintication;
namespace BogyConsoleTM.View
{
    public class Index
    {
        public void Show()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Добре дошли!");
                Console.WriteLine("");
                Console.Write("Моля въведете Username и  натиснете Enter: ");
                string username = Console.ReadLine();

                Console.Write("Моля въведете парола и  натиснете Enter: ");
                string password = Console.ReadLine();

                Login.AuthenticateUser(username, password);

               if (Login.LoggedUser != null)
                {
                    Console.WriteLine("Здравейте " + Login.LoggedUser.FName +" "+ Login.LoggedUser.LName + "!");
                    Console.ReadKey(true);
                    break;
                }
                else
                {
                    Console.WriteLine("Моля натиснете бутон,за да опитате отново!");
                    Console.ReadKey(true);
                }
            }

        }
    }
}