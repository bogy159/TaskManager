using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Entity;
//using System.Data;
using System.Data.OleDb;
using BogyWinFormTM.Repository;
using BogyWinFormTM.Enumerations;
using BogyWinFormTM.Entity;

namespace BogyWinFormTM.View
{
    public partial class ListUsers : Form
    {
        #region Constructors

        public ListUsers()  
        {
            InitializeComponent();
        }

        #endregion

        #region Functional Methods

        public List<Users> GetAllUsers()
        {
            using (var db = new Index.BloggingContext())
            {
                var result =
                   (from u in db.Users
                    select u).ToList();
                return result;
            }
        }

        private void NewUser(Users obj)
        {
            using (var db = new Index.BloggingContext())
            {
                var item = new Users { Username = obj.Username, Pass=obj.Pass, FName=obj.FName, LName=obj.LName};
                db.Users.Add(item);
                db.SaveChanges();
            }
        }

        private void EditUser(Users user)
        { 
         using (var db = new Index.BloggingContext())
         {
             var item =
                       (from u in db.Users
                        where u.UserId == user.UserId
                        select u).First();
             db.Database.ExecuteSqlCommand("UPDATE Users" +
                                            " SET Username={0},Pass={1},FName={2},LName={3}" +
                                             " WHERE UserId={4}", user.Username, user.Pass, user.FName,
                                             user.LName, user.UserId);
             db.SaveChanges();
         }
        }

        private void DeleteUser(Users user)
        {
            using (var db = new Index.BloggingContext())
            {
                var item =
                       (from u in db.Users
                        where u.UserId == user.UserId
                        select u).First();
                db.Users.Remove(item);
                db.SaveChanges();
            }
        }

        #endregion

        #region Old
        private void SetDataSources()
        {
            this.dataGridView1.Refresh();
            usersBindingSource.DataSource = this.GetAllUsers();
            dataGridView1.DataSource = usersBindingSource;
            this.dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void usersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsMainNew_Click(object sender, EventArgs e)
        {
            Users item = new Users();
            NewUser newUser = new NewUser(item);

            if (newUser.ShowDialog() == DialogResult.OK)
            {
                this.NewUser(item);
                SetDataSources();
            }

        }

        private void tsMainEdit_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                Users user = (Users)usersBindingSource.Current;
                EditUser editUser = new EditUser(user);

                if (editUser.ShowDialog() == DialogResult.OK)
                {
                    this.EditUser(user);
                    SetDataSources();
                }
            }
        }

        private void tsMainDelete_Click(object sender, EventArgs e)
        {

             Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
             if (selectedRowCount > 0)
             {

                 DialogResult result = MessageBox.Show("Are you sure you want to delete this item", "Delete item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 if (result == DialogResult.Yes)
                 {
                  Users user = (Users)usersBindingSource.Current;
                  this.DeleteUser(user);
                  SetDataSources();
                 
                 }
             }
        }

        private void ListUsers_Load(object sender, EventArgs e)
        {
            SetDataSources();
        }
    }
        #endregion
}
