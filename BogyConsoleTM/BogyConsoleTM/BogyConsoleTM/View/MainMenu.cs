using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BogyConsoleTM.Entity;
using BogyConsoleTM.Repository;
using BogyConsoleTM.Authintication;
using BogyConsoleTM.Enumerations;


namespace BogyConsoleTM.View
{
  public  class MainMenu
  {
      string filepath = "users.txt";
      public void Show()
      {
          while (true)
          {
              MainMenuEnum choice = RenderMenu();

              try
              {
                  switch (choice)
                  {
                      case MainMenuEnum.Select:
                          {
                              ListAll();
                              break;
                          }
                      case MainMenuEnum.View:
                          {
                              View();
                              break;
                          }
                      case MainMenuEnum.Add:
                          {
                              Add();
                              break;
                          }
                      case MainMenuEnum.Tasks:
                          {
                              Tasks();
                              break;
                          }
                      case MainMenuEnum.Edit:
                          {
                              Edit();
                              break;
                          }
                      case MainMenuEnum.Delete:
                          {
                              Delete();
                              break;
                          }
                      case MainMenuEnum.Exit:
                          {
                              return;
                          }
                  }
              }
              catch (Exception ex)
              {
                  Console.Clear();
                  Console.WriteLine(ex.Message);
                  Console.ReadKey(true);
              }
          }
      }

      private MainMenuEnum RenderMenu()
      {
          while (true)
          {
              Console.Clear();
              Console.WriteLine("Напишете число и Enter за да продължите");
              Console.WriteLine("Добави акаунт - 1");
              Console.WriteLine("Поправи акаунт - 2");
              Console.WriteLine("Изтрий акаунт - 3");
              Console.WriteLine("Намери акаунт - 4");
              Console.WriteLine("Виж всички акаунти - 5");
              Console.WriteLine("Разгледай задачите - 8");
              Console.WriteLine("Излез - 0");

              string choice = Console.ReadLine();
              switch (choice.ToUpper())
              {
                  case "5":
                      {
                          return MainMenuEnum.Select;
                      }
                  case "4":
                      {
                          return MainMenuEnum.View;
                      }
                  case "1":
                      {
                          return MainMenuEnum.Add;
                      }
                  case "2":
                      {
                          return MainMenuEnum.Edit;
                      }
                  case "3":
                      {
                          return MainMenuEnum.Delete;
                      }
                  case "8":
                      {
                          return MainMenuEnum.Tasks;
                      }
                  case "0":
                      {
                          return MainMenuEnum.Exit;
                      }
                  default:
                      {
                          Console.WriteLine("Invalid choice.");
                          Console.ReadKey(true);
                          break;
                      }
              }
          }
      }

      private void Add()
      {
          Console.Clear();
          Users user = new Users();
          try
          {
              Console.WriteLine("Add new user");
              Console.Write("+Username: ");
              user.Username = Console.ReadLine();
              Console.Write("+Password: ");
              user.Pass = Console.ReadLine();
              Console.Write("+First name: ");
              user.FName = Console.ReadLine();
              Console.Write("+Last name: ");
              user.LName = Console.ReadLine();
              Console.WriteLine();
          }
          catch (Exception ex)
          {
              Console.Clear();
              Console.WriteLine(ex.Message);
              Console.ReadKey(true);
          }

          UserRepo userRepository = new UserRepo(filepath);
          userRepository.Save(user);

          Console.WriteLine("User added successfully");
          Console.ReadKey(true);

      }

      private List<Users> GetUsersInfo()
      {
          UserRepo userRepo = new UserRepo(filepath);
          List<Users> usersList = new List<Users>();
          usersList = userRepo.GetAll();
          return usersList;

      }

      private bool CheckForUser(int id)
      {
          bool result = false;
          Users user = new Users();
          UserRepo userRepo = new UserRepo(filepath);
          user = userRepo.GetById(id);
          if (user.UserId > 0)
          {
              result = true;
          }
          return result;
      }


      private void Edit()
      {
          Console.Clear();
          List<Users> list = new List<Users>();
          list = GetUsersInfo();
          foreach (var user in list)
          {
              Console.WriteLine("Username: {0} | ID: {1}", user.Username, user.UserId);
          }
          Console.WriteLine();
          Console.Write("Input user id: ");
          int id = Convert.ToInt32(Console.ReadLine());
          bool check = CheckForUser(id);
          if (check == false)
          {
              Console.Clear();
              Console.WriteLine("User not found,\nTry again !");
              Console.ReadKey(true);
              return;
          }
          else
          {
              UserRepo userRepository = new UserRepo(filepath);
              Users user = userRepository.GetById(id);
              Console.Clear();
              Console.WriteLine("Editing user: ");
              Console.WriteLine();
              Console.WriteLine("-User id: " + user.UserId);
              Console.WriteLine("-Username: " + user.Username);
              Console.WriteLine("-Password: " + user.Pass);
              Console.WriteLine("-First name: " + user.FName);
              Console.WriteLine("-Last name: " + user.LName);
              Console.WriteLine();
              Console.Write("+Input new username: ");
              string newUserName = Console.ReadLine();
              Console.Write("+Input password: ");
              string newPass = Console.ReadLine();
              Console.Write("+Input new first name: ");
              string firstName = Console.ReadLine();
              Console.Write("+Input new last name: ");
              string lastName = Console.ReadLine();

              if (!string.IsNullOrEmpty(newUserName))
              {
                  user.Username = newUserName;
              }
              if (!string.IsNullOrEmpty(firstName))
              {
                  user.Pass = newPass;
              }
              if (!string.IsNullOrEmpty(firstName))
              {
                  user.FName = firstName;
              }
              if (!string.IsNullOrEmpty(lastName))
              {
                  user.LName = lastName;
              }
              Console.WriteLine();
              userRepository.Save(user);
              Console.WriteLine("User edited successfully");
              Console.ReadKey(true);
          }
      }
      private void Delete()
      {
          Console.Clear();

          List<Users> list = new List<Users>();
          list = GetUsersInfo();
          foreach (var user in list)
          {
              Console.WriteLine("Username: {0} | ID: {1}", user.Username, user.UserId);
          }
          Console.WriteLine();
          Console.Write("+Input id: ");
          int id = Convert.ToInt32(Console.ReadLine());
          bool check = CheckForUser(id);

          if (check == false)
          {
              Console.Clear();
              Console.WriteLine("User not found,\nTry again !");
              Console.ReadKey(true);
              return;
          }
          else
          {

              UserRepo userRepo = new UserRepo(filepath);
              Users user = userRepo.GetById(id);
              userRepo.Delete(user);
              Console.WriteLine();
              Console.WriteLine("User " + user.Username + " deleted successfully !");
              Console.ReadKey(true);
          }
      }

      private void ListAll()
      {
          Console.Clear();

          UserRepo userRepository = new UserRepo(filepath);
          List<Users> users = userRepository.GetAll();

          foreach (Users user in users)
          {
              Console.WriteLine();
              Console.WriteLine("User id: " + user.UserId);
              Console.WriteLine("Username: " + user.Username);
              Console.WriteLine("User pass: " + user.Pass);
              Console.WriteLine("User's first name: " + user.FName);
              Console.WriteLine("User's last name " + user.LName);
              Console.WriteLine("------------------------------------------------------");
          }

          Console.ReadKey(true);
      }
      private void View()
      {
          Console.Clear();

          List<Users> list = new List<Users>();
          list = GetUsersInfo();
          foreach (var user in list)
          {
              Console.WriteLine("Username: {0} | ID: {1}", user.Username, user.UserId);
          }
          Console.WriteLine();
          Console.Write("Input id: ");
          int id = Convert.ToInt32(Console.ReadLine());
          bool check = CheckForUser(id);

          if (check == false)
          {
              Console.Clear();
              Console.WriteLine("User not found,\nTry again !");
              Console.ReadKey(true);
              return;
          }
          else
          {
              Users user = new Users();
              UserRepo userRepo = new UserRepo(filepath);
              user = userRepo.GetById(id);
              Console.WriteLine();
              Console.WriteLine("ID: " + user.UserId);
              Console.WriteLine("Username: " + user.Username);
              Console.WriteLine("Userpassword: " + user.Pass);
              Console.WriteLine("First name: " + user.FName);
              Console.WriteLine("Last name: " + user.LName);
              Console.ReadKey(true);
              return;
          }
      }
      public void Tasks()
      {
          MTasks user = new MTasks();
          TasksMenu taskView = new TasksMenu(user);
          taskView.ShowTM();
      }


  }
}
