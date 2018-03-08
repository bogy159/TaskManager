using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BogyWinFormTM.Entity;

namespace BogyWinFormTM.Repository
{
  public  class TaskRepo
    {
       private readonly string filepath;

        public TaskRepo(string filepath)
        {
            this.filepath = filepath;
        }

        private int GetNextTaskId()
        {
            int id = 1;
            FileStream fs = new FileStream(this.filepath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            try
            {
                while (!sr.EndOfStream)
                {
                    MTasks user = new MTasks();
                    user.TaskId = Convert.ToInt32(sr.ReadLine());
                    user.Title = sr.ReadLine();
                    user.Description = sr.ReadLine();
                    user.Creator = Convert.ToInt32(sr.ReadLine());
                    user.EstTime = Convert.ToInt32(sr.ReadLine());
                    user.Assigned = Convert.ToInt32(sr.ReadLine());
                    user.CreTime = Convert.ToDateTime(sr.ReadLine());
                    user.Final = Convert.ToBoolean(sr.ReadLine());

                    if (id <= user.TaskId)
                    {
                        id = user.TaskId + 1;
                    }
                }
                return id;
            }
            finally
            {
                sr.Close();
                fs.Close();
            }
        }

        private void Add(MTasks item)
        {
            item.TaskId = GetNextTaskId();
            FileStream fs = new FileStream(filepath, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            try
            {
                    sw.WriteLine(item.TaskId);
                    sw.WriteLine(item.Title);
                    sw.WriteLine(item.Description);
                    sw.WriteLine(item.Creator);
                    sw.WriteLine(item.EstTime);
                    sw.WriteLine(item.Assigned);
                    sw.WriteLine(item.CreTime);
                    sw.WriteLine(item.Final);
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }

        private void Edit(MTasks item)
        {
            string tempFilePath = "temp." + filepath;

            FileStream ifs = new FileStream(filepath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(ifs);

            FileStream ofs = new FileStream(tempFilePath, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(ofs);

            try
            {
                while (!sr.EndOfStream)
                {
                    MTasks user = new MTasks();
                    user.TaskId = Convert.ToInt32(sr.ReadLine());
                    user.Title = sr.ReadLine();
                    user.Description = sr.ReadLine();
                    user.Creator = Convert.ToInt32(sr.ReadLine());
                    user.EstTime = Convert.ToInt32(sr.ReadLine());
                    user.Assigned = Convert.ToInt32(sr.ReadLine());
                    user.CreTime = Convert.ToDateTime(sr.ReadLine());
                    user.Final = Convert.ToBoolean(sr.ReadLine());

                    if (user.TaskId != item.TaskId)
                    {
                        sw.WriteLine(user.TaskId);
                        sw.WriteLine(user.Title);
                        sw.WriteLine(user.Description);
                        sw.WriteLine(user.Creator);
                        sw.WriteLine(user.EstTime);
                        sw.WriteLine(user.Assigned);
                        sw.WriteLine(user.CreTime);
                        sw.WriteLine(user.Final);
                    }
                    else
                    {
                        sw.WriteLine(item.TaskId);
                        sw.WriteLine(item.Title);
                        sw.WriteLine(item.Description);
                        sw.WriteLine(item.Creator);
                        sw.WriteLine(item.EstTime);
                        sw.WriteLine(item.Assigned);
                        sw.WriteLine(item.CreTime);
                        sw.WriteLine(item.Final);
                    }
                }
            }
            finally
            {
                sw.Close();
                ofs.Close();
                sr.Close();
                ifs.Close();
            }

            File.Delete(filepath);
            File.Move(tempFilePath, filepath);
        }

        public void Delete(MTasks item)
        {
            string tempFilePath = "temp." + filepath;

            FileStream ifs = new FileStream(filepath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(ifs);

            FileStream ofs = new FileStream(tempFilePath, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(ofs);

            try
            {
                while (!sr.EndOfStream)
                {
                    MTasks user = new MTasks();
                    user.TaskId = Convert.ToInt32(sr.ReadLine());
                    user.Title = sr.ReadLine();
                    user.Description = sr.ReadLine();
                    user.Creator = Convert.ToInt32(sr.ReadLine());
                    user.EstTime = Convert.ToInt32(sr.ReadLine());
                    user.Assigned = Convert.ToInt32(sr.ReadLine());
                    user.CreTime = Convert.ToDateTime(sr.ReadLine());
                    user.Final = Convert.ToBoolean(sr.ReadLine());

                    if (user.TaskId != item.TaskId)
                    {
                        sw.WriteLine(user.TaskId);
                        sw.WriteLine(user.Title);
                        sw.WriteLine(user.Description);
                        sw.WriteLine(user.Creator);
                        sw.WriteLine(user.EstTime);
                        sw.WriteLine(user.Assigned);
                        sw.WriteLine(user.CreTime);
                        sw.WriteLine(user.Final);
                    }
                }
            }
            finally
            {
                sw.Close();
                ofs.Close();
                sr.Close();
                ifs.Close();
            }

            File.Delete(filepath);
            File.Move(tempFilePath, filepath);
        }

        public void Save(MTasks task)
        {
            if (task.TaskId > 0)
            {
                Edit(task);
            }
            else
            {
                Add(task);
            }
        }

        public MTasks GetByTaskId(int id)
        {
            FileStream fs = new FileStream(this.filepath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            try
            {
                while (!sr.EndOfStream)
                {
                    MTasks user = new MTasks();
                    user.TaskId = Convert.ToInt32(sr.ReadLine());
                    user.Title = sr.ReadLine();
                    user.Description = sr.ReadLine();
                    user.Creator = Convert.ToInt32(sr.ReadLine());
                    user.EstTime = Convert.ToInt32(sr.ReadLine());
                    user.Assigned = Convert.ToInt32(sr.ReadLine());
                    user.CreTime = Convert.ToDateTime(sr.ReadLine());
                    user.Final = Convert.ToBoolean(sr.ReadLine());

                    if (user.TaskId == id)
                    {
                        return user;
                    }
                }
            }
            finally
            {
                sr.Close();
                fs.Close();
            }

            return null;
        }

        public List<MTasks> GetAll()
        {
            List<MTasks> result = new List<MTasks>();

            FileStream fs = new FileStream(this.filepath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            try
            {
                while (!sr.EndOfStream)
                {
                    MTasks user = new MTasks();
                    user.TaskId = Convert.ToInt32(sr.ReadLine());
                    user.Title = sr.ReadLine();
                    user.Description = sr.ReadLine();
                    user.Creator = Convert.ToInt32(sr.ReadLine());
                    user.EstTime = Convert.ToInt32(sr.ReadLine());
                    user.Assigned = Convert.ToInt32(sr.ReadLine());
                    user.CreTime = Convert.ToDateTime(sr.ReadLine());
                    user.Final = Convert.ToBoolean(sr.ReadLine());

                    result.Add(user);
                }
            }
            finally
            {
                sr.Close();
                fs.Close();
            }

            return result;
        }

        public List<MTasks> GetAllNF()
        {
            List<MTasks> result = new List<MTasks>();

            FileStream fs = new FileStream(this.filepath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            try
            {
                while (!sr.EndOfStream)
                {
                    MTasks user = new MTasks();
                    user.TaskId = Convert.ToInt32(sr.ReadLine());
                    user.Title = sr.ReadLine();
                    user.Description = sr.ReadLine();
                    user.Creator = Convert.ToInt32(sr.ReadLine());
                    user.EstTime = Convert.ToInt32(sr.ReadLine());
                    user.Assigned = Convert.ToInt32(sr.ReadLine());
                    user.CreTime = Convert.ToDateTime(sr.ReadLine());
                    user.Final = Convert.ToBoolean(sr.ReadLine());

                    if(user.Final == false)
                    {
                    result.Add(user);
                
                    }
                }
            }
            finally
            {
                sr.Close();
                fs.Close();
            }

            return result;
        }




    }
}
