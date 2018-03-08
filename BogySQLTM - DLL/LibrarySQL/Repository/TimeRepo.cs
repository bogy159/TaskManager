using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using LibrarySQL.Entiry;

namespace LibrarySQL.Repository
{
    public class TimeRepo
    {

        #region Functional Methods

        public List<TimeSpent> GetAll()
        {
            using (var db = new BloggingContext())
            {
                var result =
                   (from t in db.TimeSpent
                    select t).ToList();
                return result;
            }
        }

        public void New(TimeSpent item)
        {
            using (var db = new BloggingContext())
            {
                var now = DateTime.Now;
                var time = new TimeSpent { TheAssi = item.TheAssi, TheTask = item.TheTask, FinTime = now, Hours = item.Hours };
                db.TimeSpent.Add(time);
                db.SaveChanges();
            }
        }

        public void Delete(TimeSpent item)
        {
            using (var db = new BloggingContext())
            {
                var time =
                       (from t in db.TimeSpent
                        where t.TSId == item.TSId
                        select t).First();
                db.TimeSpent.Remove(time);
                db.SaveChanges();
            }
        }

        #endregion

    }
}
