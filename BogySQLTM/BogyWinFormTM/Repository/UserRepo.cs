using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BogyWinFormTM.Entity;

namespace BogyWinFormTM.Repository
{
   public class UserRepo
    {
       private readonly string filepath;

        public UserRepo(string filepath)
        {
            this.filepath = filepath;
        }

        private int GetNextUserId()
        {
            int id = 1;
            FileStream fs = new FileStream(this.filepath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            try
            {
                while (!sr.EndOfStream)
                {
                    Users user = new Users();
                    user.UserId = Convert.ToInt32(sr.ReadLine());
                    user.Username = sr.ReadLine();
                    user.Pass = sr.ReadLine();
                    user.FName = sr.ReadLine();
                    user.LName = sr.ReadLine();

                    if (id <= user.UserId)
                    {
                        id = user.UserId + 1;
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

        private void Add(Users item)
        {
            item.UserId = GetNextUserId();
            FileStream fs = new FileStream(filepath, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            try
            {
                    sw.WriteLine(item.UserId);
                    sw.WriteLine(item.Username);
                    sw.WriteLine(item.Pass);
                    sw.WriteLine(item.FName);
                    sw.WriteLine(item.LName);
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }

        public Users GetByUsernameAndPassword(string username, string password)
        {
            FileStream fs = new FileStream(this.filepath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            try
            {
                while (!sr.EndOfStream)
                {
                    Users user = new Users();
                    user.UserId = Convert.ToInt32(sr.ReadLine());
                    user.Username = sr.ReadLine();
                    user.Pass = sr.ReadLine();
                    user.FName = sr.ReadLine();
                    user.LName = sr.ReadLine();

                    if (user.Username == username && user.Pass == password)
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

        private void Edit(Users item)
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
                    Users user = new Users();
                    user.UserId = Convert.ToInt32(sr.ReadLine());
                    user.Username = sr.ReadLine();
                    user.Pass = sr.ReadLine();
                    user.FName = sr.ReadLine();
                    user.LName = sr.ReadLine();

                    if (user.UserId != item.UserId)
                    {
                        sw.WriteLine(user.UserId);
                        sw.WriteLine(user.Username);
                        sw.WriteLine(user.Pass);
                        sw.WriteLine(user.FName);
                        sw.WriteLine(user.LName);
                    }
                    else
                    {
                        sw.WriteLine(item.UserId);
                        sw.WriteLine(item.Username);
                        sw.WriteLine(item.Pass);
                        sw.WriteLine(item.FName);
                        sw.WriteLine(item.LName);
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

        public void Delete(Users item)
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
                    Users user = new Users();
                    user.UserId = Convert.ToInt32(sr.ReadLine());
                    user.Username = sr.ReadLine();
                    user.Pass = sr.ReadLine();
                    user.FName = sr.ReadLine();
                    user.LName = sr.ReadLine();

                    if (user.UserId != item.UserId)
                    {
                        sw.WriteLine(user.UserId);
                        sw.WriteLine(user.Username);
                        sw.WriteLine(user.Pass);
                        sw.WriteLine(user.FName);
                        sw.WriteLine(user.LName);
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

        public void Save(Users item)
        {
            if (item.UserId > 0)
            {
                Edit(item);
            }
            else
            {
                Add(item);
            }
        }

        public Users GetById(int id)
        {
            FileStream fs = new FileStream(this.filepath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            try
            {
                while (!sr.EndOfStream)
                {
                    Users user = new Users();
                    user.UserId = Convert.ToInt32(sr.ReadLine());
                    user.Username = sr.ReadLine();
                    user.Pass = sr.ReadLine();
                    user.FName = sr.ReadLine();
                    user.LName = sr.ReadLine();

                    if (user.UserId == id)
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

        public List<Users> GetAll()
        {
            List<Users> result = new List<Users>();

            FileStream fs = new FileStream(this.filepath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            try
            {
                while (!sr.EndOfStream)
                {
                    Users user = new Users();
                    user.UserId = Convert.ToInt32(sr.ReadLine());
                    user.Username = sr.ReadLine();
                    user.Pass = sr.ReadLine();
                    user.FName = sr.ReadLine();
                    user.LName = sr.ReadLine();

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

    }
}
