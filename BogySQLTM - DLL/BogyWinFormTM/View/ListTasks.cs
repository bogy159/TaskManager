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
using System.Data.OleDb;
//using BogyWinFormTM.Repository;
//using BogyWinFormTM.Enumerations;
//using BogyWinFormTM.Entity;
using LibrarySQL.Entiry;
using LibrarySQL.Repository;

namespace BogyWinFormTM.View
{
    public partial class ListTasks : Form
    {

        public ListTasks()
        {
            InitializeComponent();
            SetDataSources();
            //SetUserSources();
            SetTimeSources();
        }

        #region Functional Methods

        //private List<MTasks> GetAllTasks()
        //{
        //    using (var db = new Index.BloggingContext())
        //    {
        //        var result =
        //           (from m in db.MTasks
        //            select m).ToList();
        //        return result;
        //    }
        //}

        //public List<MTasks> GetAllNF()
        //{
        //    using (var db = new Index.BloggingContext())
        //    {
        //        var result =
        //           (from m in db.MTasks
        //            where m.Final == false
        //            select m).ToList();
        //        return result;
        //    }
        //}

        //private List<TimeSpent> GetTTime()
        //{
        //    using (var db = new Index.BloggingContext())
        //    {
        //        MTasks user = (MTasks)tasksBindingSource1.Current;
        //        var result =
        //           (from t in db.TimeSpent
        //            where t.TheTask == user.TaskId
        //            select t).ToList();
        //        return result;
        //    }
        //}

        //private void NewTask(MTasks task)
        //{
        //    using (var db = new Index.BloggingContext())
        //    {
        //        var now = DateTime.Now;//.ToString("MM/dd/yyyy HH:mm:ss");
        //        var item = new MTasks { Title=task.Title, Description=task.Description, Creator=task.Creator, EstTime=task.EstTime, Assigned=task.Assigned, CreTime=now, Final=false };
        //        db.MTasks.Add(item);
        //        db.SaveChanges();
        //    }
        //}

        //private void EditTask(MTasks task)
        //{
        //    using (var db = new Index.BloggingContext())
        //    {
        //        var item =
        //                  (from m in db.MTasks
        //                   where m.TaskId == task.TaskId
        //                   select m).First();
        //        db.Database.ExecuteSqlCommand("UPDATE MTasks" +
        //                                       " SET Title={0},Description={1},EstTime={2},Assigned={3},Final={4}" +
        //                                        " WHERE TaskId={5}", task.Title, task.Description,
        //                                        task.EstTime, task.Assigned, task.Final, task.TaskId);
        //        db.SaveChanges();
        //    }
        //}

        //private void DeleteTask(MTasks task)
        //{
        //    using (var db = new Index.BloggingContext())
        //    {
        //        var item =
        //               (from m in db.MTasks
        //                where m.TaskId == task.TaskId
        //                select m).First();
        //        db.MTasks.Remove(item);
        //        db.SaveChanges();
        //    }
        //}

        //private void FinishTask(MTasks task)
        //{
        //    using (var db = new Index.BloggingContext())
        //    {
        //        var item =
        //                  (from m in db.MTasks
        //                   where m.TaskId == task.TaskId
        //                   select m).First();
        //        db.Database.ExecuteSqlCommand("UPDATE MTasks" +
        //                                       " SET Final={0}" +
        //                                        " WHERE TaskId={1}", true, task.TaskId);
        //        db.SaveChanges();
        //    }
        //}

        #endregion

        #region Old

        private void SetDataSources()
        {
            TaskRepo gat = new TaskRepo();
            tasksBindingSource1.DataSource = gat.GetAll();
            dataGridView1.DataSource = tasksBindingSource1;

            UserRepo frm = new UserRepo();
            DataGridViewComboBoxColumn columnCreatedyBy = (DataGridViewComboBoxColumn)dataGridView1.Columns[4];
            columnCreatedyBy.DataSource = frm.GetAll();

            DataGridViewComboBoxColumn columnExecutive = (DataGridViewComboBoxColumn)dataGridView1.Columns[5];
            columnExecutive.DataSource = frm.GetAll();
        }

        private void SetTimeSources()
        {

            MTasks user = (MTasks)tasksBindingSource1.Current;
            TaskRepo gat = new TaskRepo();
            timeBindingSource.DataSource = gat.GetTTime(user);
            dataGridView2.DataSource = timeBindingSource;

            //timeBindingSource.DataSource = this.GetTTime();
            //dataGridView2.DataSource = timeBindingSource;

        }

        private void SetUserSources()
        {
            //UserRepo userRepo = new UserRepo("users.txt");
            //usersBindingSource.DataSource = userRepo.GetById(2);
            //dataGridView1.DataSource = usersBindingSource;

        }

        private void ListTasks_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsMainNew_Click(object sender, EventArgs e)
        {
            MTasks item = new MTasks();
            NewTask newTask = new NewTask(item);

            if (newTask.ShowDialog() == DialogResult.OK)
            {
                TaskRepo edd = new TaskRepo();
                edd.Save(item);
                SetDataSources();
            }
        }

        private void tsMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsMainDelete_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {

                DialogResult result = MessageBox.Show("Are you sure you want to delete this item", "Delete item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    TaskRepo edd = new TaskRepo();
                    MTasks user = (MTasks)tasksBindingSource1.Current;
                    edd.Delete(user);
                    SetDataSources();

                }
            }
        }

        private void tsMainEdit_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                MTasks task = (MTasks)tasksBindingSource1.Current;
                EditTask editTask = new EditTask(task);

                if (editTask.ShowDialog() == DialogResult.OK)
                {
                    TaskRepo edd = new TaskRepo();
                    edd.Save(task);
                    SetDataSources();
                }
            }
        }

        private void usersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TimeSpent item = new TimeSpent();
            NewTime newTime = new NewTime(item);

            if (newTime.ShowDialog() == DialogResult.OK)
            {
                TimeRepo cre = new TimeRepo();
                cre.New(item);
                SetTimeSources();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetTimeSources();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView2.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {

                DialogResult result = MessageBox.Show("Are you sure you want to delete this item", "Delete item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    TimeSpent time = (TimeSpent)timeBindingSource.Current;
                    TimeRepo del = new TimeRepo();
                    del.Delete(time);
                    SetTimeSources();

                }
            }
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                MTasks task = (MTasks)tasksBindingSource1.Current;
                TaskRepo edd = new TaskRepo();
                task.Final = Convert.ToBoolean(true);
                edd.Save(task);
                SetDataSources();

            }
        }
    }

        #endregion
}