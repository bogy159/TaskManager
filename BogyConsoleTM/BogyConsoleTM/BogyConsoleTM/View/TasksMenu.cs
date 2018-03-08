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
    public class TasksMenu
    {
        
        string filepath = "users.txt";
        string tasksFilepath = "tasks.txt";

        private MTasks user = null;

        public TasksMenu(MTasks user)
        {
            this.user = user;
        }
        public void ShowTM()
        {
            while (true)
            {
                TasksMenuEnum choice = RenderMenu();

                try
                {
                    switch (choice)
                    {
                        case TasksMenuEnum.Select:
                            {
                                ListAll();
                                break;
                            }
                        case TasksMenuEnum.View:
                            {
                            //    View();
                                break;
                            }
                        case TasksMenuEnum.Add:
                            {
                                Add();
                                break;
                            }
                        case TasksMenuEnum.Edit:
                            {
                            //    Edit();
                                break;
                            }
                        case TasksMenuEnum.Delete:
                            {
                             //   Delete();
                                break;
                            }
                        case TasksMenuEnum.Assigned:
                            {
                                break;
                            }
                        case TasksMenuEnum.Exit:
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

        private TasksMenuEnum RenderMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Напишете число и Enter за да продължите");
                Console.WriteLine("Добави задача - 1");
                Console.WriteLine("Поправи задача - 2");
                Console.WriteLine("Изтрий задача - 3");
                Console.WriteLine("Намери задача - 4");
                Console.WriteLine("Виж всички задачи - 5");
                Console.WriteLine("Разгледай времето - 6");
                Console.WriteLine("nazad - 0");

                string choice = Console.ReadLine();
                switch (choice.ToUpper())
                {
                    case "5":
                        {
                            return TasksMenuEnum.Select;
                        }
                    case "4":
                        {
                            return TasksMenuEnum.View;
                        }
                    case "1":
                        {
                            return TasksMenuEnum.Add;
                        }
                    case "2":
                        {
                            return TasksMenuEnum.Edit;
                        }
                    case "3":
                        {
                            return TasksMenuEnum.Delete;
                        }
                    case "6":
                        {
                            return TasksMenuEnum.Assigned;
                        }
                    case "0":
                        {
                            return TasksMenuEnum.Exit;
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
            MTasks user = new MTasks();
            bool Status = false;
            try
            {
                Console.WriteLine("Add new task");
                Console.Write("+Title: ");
                user.Title = Console.ReadLine();
                Console.Write("+Whats the task: ");
                user.Description = Console.ReadLine();
                user.Creator = Login.LoggedUser.UserId;
                Console.Write("+Finish time: ");
                user.EstTime = int.Parse(Console.ReadLine());
                Console.Write("+Assigne to: ");
                user.Assigned = int.Parse(Console.ReadLine());
                DateTime saveNow = DateTime.Now;
                user.CreTime = saveNow;
                Console.WriteLine();
                Status = true;
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.ReadKey(true);
                Status = false;
            }
            Users item = new Users();
            UserRepo userRepo = new UserRepo(filepath);
            item = userRepo.GetById(user.Assigned);
             if (Status == true && item.UserId > 0)
            {
               TaskRepo taskRepository = new TaskRepo(tasksFilepath);
               taskRepository.Save(user);

               Console.WriteLine("Task added successfully");
               Console.ReadKey(true);
            }
            
        }

        private List<MTasks> GetTasksInfo()
        {
            TaskRepo taskRepo = new TaskRepo(tasksFilepath);
            List<MTasks> tasksList = new List<MTasks>();
            tasksList = taskRepo.GetAll();
            return tasksList;

        }

       
        private void ListAll()
        {
            Console.Clear();

            TaskRepo taskRepo = new TaskRepo(tasksFilepath);
            List<MTasks> tasks = taskRepo.GetAll();

            foreach (MTasks task in tasks)
            {
                Console.WriteLine();
                Console.WriteLine("Task id: " + task.TaskId);
                Console.WriteLine("Title: " + task.Title);
                Console.WriteLine("Description: " + task.Description);
                Console.WriteLine("Creators id: " + task.Creator);
                Console.WriteLine("Time for the task: " + task.EstTime);
                Console.WriteLine("Task executive id: " + task.Assigned);
                Console.WriteLine("Creation time: " + task.CreTime);
                Console.WriteLine("------------------------------------------------------");
            }

            Console.ReadKey(true);
        }
       
    }
}
