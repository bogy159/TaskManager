using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using LibrarySQL.Entiry;

namespace LibrarySQL.Repository
{
    public class TaskRepo
    {
        #region Functional Methods

        public List<MTasks> GetAll()
        {
            using (var db = new BloggingContext())
            {
                var result =
                   (from m in db.MTasks
                    select m).ToList();
                return result;
            }
        }

        public List<MTasks> GetAllNF()
        {
            using (var db = new BloggingContext())
            {
                var result =
                   (from m in db.MTasks
                    where m.Final == false
                    select m).ToList();
                return result;
            }
        }

        public List<TimeSpent> GetTTime(MTasks item)
        {
            using (var db = new BloggingContext())
            {
               // MTasks user = (MTasks)tasksBindingSource1.Current;
                var result =
                   (from t in db.TimeSpent
                    where t.TheTask == item.TaskId
                    select t).ToList();
                return result;
            }
        }

        private void New(MTasks item)
        {
            using (var db = new BloggingContext())
            {
                var now = DateTime.Now;//.ToString("MM/dd/yyyy HH:mm:ss");
                var task = new MTasks { Title = item.Title, Description = item.Description, Creator = item.Creator, EstTime = item.EstTime, Assigned = item.Assigned, CreTime = now, Final = false };
                db.MTasks.Add(task);
                db.SaveChanges();
            }
        }

        private void Edit(MTasks item)
        {
            using (var db = new BloggingContext())
            {
                var task =
                          (from m in db.MTasks
                           where m.TaskId == item.TaskId
                           select m).First();
                db.Database.ExecuteSqlCommand("UPDATE MTasks" +
                                               " SET Title={0},Description={1},EstTime={2},Assigned={3},Final={4}" +
                                                " WHERE TaskId={5}", item.Title, item.Description,
                                                item.EstTime, item.Assigned, item.Final, item.TaskId);
                db.SaveChanges();
            }
        }

        public void Delete(MTasks item)
        {
            using (var db = new BloggingContext())
            {
                var task =
                       (from m in db.MTasks
                        where m.TaskId == item.TaskId
                        select m).First();
                db.MTasks.Remove(task);
                db.SaveChanges();
            }
        }

        public void FinishTask(MTasks item)
        {
            using (var db = new BloggingContext())
            {
                var task =
                          (from m in db.MTasks
                           where m.TaskId == item.TaskId
                           select m).First();
                db.Database.ExecuteSqlCommand("UPDATE MTasks" +
                                               " SET Final={0}" +
                                                " WHERE TaskId={1}", true, item.TaskId);
                db.SaveChanges();
            }
        }

        public void Save(MTasks item)
        {
            if (item.TaskId > 0)
            {
                Edit(item);
            }
            else
            {
                New(item);
            }
        }

        #endregion

    }
}
