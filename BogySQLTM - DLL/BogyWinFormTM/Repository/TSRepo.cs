using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BogyWinFormTM.Entity;

namespace BogyWinFormTM.Repository
{
   public class TSRepo
    {
       private readonly string filepath;

        public TSRepo(string filepath)
        {
            this.filepath = filepath;
        }

        private int GetNextTSId()
        {
            int id = 1;
            FileStream fs = new FileStream(this.filepath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            try
            {
                while (!sr.EndOfStream)
                {
                    TimeSpent time = new TimeSpent();
                    time.TSId = Convert.ToInt32(sr.ReadLine());
                    time.TheAssi = Convert.ToInt32(sr.ReadLine());
                    time.TheTask = Convert.ToInt32(sr.ReadLine());
                    time.FinTime = Convert.ToDateTime(sr.ReadLine());
                    time.Hours = Convert.ToInt32(sr.ReadLine());

                    if (id <= time.TSId)
                    {
                        id = time.TSId + 1;
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

        private void Add(TimeSpent item)
        {
            item.TSId = GetNextTSId();
            FileStream fs = new FileStream(filepath, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            try
            {
                sw.WriteLine(item.TSId);
                sw.WriteLine(item.TheAssi);
                sw.WriteLine(item.TheTask);
                sw.WriteLine(item.FinTime);
                sw.WriteLine(item.Hours);
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }

        public void Save(TimeSpent time)
        {
            if (time.TSId > 0)
            {
               // Edit(time);
            }
            else
            {
                Add(time);
            }
        }

        public List<TimeSpent> GetAll()
        {
            List<TimeSpent> result = new List<TimeSpent>();

            FileStream fs = new FileStream(this.filepath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            try
            {
                while (!sr.EndOfStream)
                {
                    TimeSpent user = new TimeSpent();
                    user.TSId = Convert.ToInt32(sr.ReadLine());
                    user.TheAssi = Convert.ToInt32(sr.ReadLine());
                    user.TheTask = Convert.ToInt32(sr.ReadLine());
                    user.FinTime = Convert.ToDateTime(sr.ReadLine());
                    user.Hours = Convert.ToInt32(sr.ReadLine());

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

        public List<TimeSpent> GetByTaskId(int id)
        {
            List<TimeSpent> result = new List<TimeSpent>();
            FileStream fs = new FileStream(this.filepath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            try
            {
                while (!sr.EndOfStream)
                {
                    TimeSpent time = new TimeSpent();
                    time.TSId = Convert.ToInt32(sr.ReadLine());
                    time.TheAssi = Convert.ToInt32(sr.ReadLine());
                    time.TheTask = Convert.ToInt32(sr.ReadLine());
                    time.FinTime = Convert.ToDateTime(sr.ReadLine());
                    time.Hours = Convert.ToInt32(sr.ReadLine());

                    if (time.TheTask == id)
                    {
                        result.Add(time);
                        //return time;
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

        public void Delete(TimeSpent item)
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
                    TimeSpent time = new TimeSpent();
                    time.TSId = Convert.ToInt32(sr.ReadLine());
                    time.TheAssi = Convert.ToInt32(sr.ReadLine());
                    time.TheTask = Convert.ToInt32(sr.ReadLine());
                    time.FinTime = Convert.ToDateTime(sr.ReadLine());
                    time.Hours = Convert.ToInt32(sr.ReadLine());

                    if (time.TSId != item.TSId)
                    {
                        sw.WriteLine(time.TSId);
                        sw.WriteLine(time.TheAssi);
                        sw.WriteLine(time.TheTask);
                        sw.WriteLine(time.FinTime);
                        sw.WriteLine(time.Hours);
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



    }
}
