using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using LibrarySQL.Entiry;

namespace LibrarySQL.Repository
{
    public class UserRepo
    {
        public Users GetByUsernameAndPassword(string username, string password)
        {
            using (var db = new  BloggingContext())
            {
                    Users user = new Users();

                    var result =
                       (from u in db.Users
                        where u.Username == username && u.Pass == password
                        select u).FirstOrDefault();
                    //Login.LoggedUser = result;
                    return result;
               // return null;

            }
        }

        #region Functional Methods

        public List<Users> GetAll()
        {
            using (var db = new BloggingContext())
            {
                var result =
                   (from u in db.Users
                    select u).ToList();
                return result;
            }
        }

        private void New(Users item)
        {
            using (var db = new BloggingContext())
            {
                var user = new Users { Username = item.Username, Pass = item.Pass, FName = item.FName, LName = item.LName };
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        private void Edit(Users item)
        {
            using (var db = new BloggingContext())
            {
                var user =
                          (from u in db.Users
                           where u.UserId == item.UserId
                           select u).First();
                db.Database.ExecuteSqlCommand("UPDATE Users" +
                                               " SET Username={0},Pass={1},FName={2},LName={3}" +
                                                " WHERE UserId={4}", item.Username, item.Pass, item.FName,
                                                item.LName, item.UserId);
                db.SaveChanges();
            }
        }

        public void Delete(Users item)
        {
            using (var db = new BloggingContext())
            {
                var user =
                       (from u in db.Users
                        where u.UserId == item.UserId
                        select u).First();
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }

        public void Save(Users item)
        {
            if (item.UserId > 0)
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
