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
using LibraryADO.Repository;
using LibraryADO.Entity;

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

//        #region Functional Methods

//        private List<MTasks> GetAllTasks()
//        {
//            List<MTasks> resultSet = new List<MTasks>();

//            IDbCommand cmd = this.conn.CreateCommand();
//            cmd.Connection = this.conn;
//            cmd.CommandText = @"
//SELECT
//  taskid,
//  title,
//  description,
//  creator,
//  esttime,
//  assigned,
//  cretime,
//  final 
//FROM
//  MTasks
//";
//            try
//            {
//                this.conn.Open();

//                IDataReader reader = cmd.ExecuteReader();
//                while (reader.Read())
//                    resultSet.Add(new MTasks()
//                    {
//                        TaskId = Convert.ToInt32(reader["taskid"]),
//                        Title = Convert.ToString(reader["title"]),
//                        Description = Convert.ToString(reader["description"]),
//                        Creator = Convert.ToInt32(reader["creator"]),
//                        EstTime = Convert.ToInt32(reader["esttime"]),
//                        Assigned = Convert.ToInt32(reader["assigned"]),
//                        CreTime = Convert.ToDateTime(reader["cretime"]),
//                        Final = Convert.ToBoolean(reader["final"]),
//                    });

//                reader.Close();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message,
//                    "Database operation Failed",
//                    MessageBoxButtons.OK,
//                    MessageBoxIcon.Asterisk,
//                    MessageBoxDefaultButton.Button1);
//            }
//            finally
//            {
//                this.conn.Close();
//            }
//            return resultSet;
//        }

//        public List<MTasks> GetAllNF()
//        {
//            List<MTasks> resultSet = new List<MTasks>();

//            IDbCommand cmd = this.conn.CreateCommand();
//            cmd.Connection = this.conn;
//            cmd.CommandText = @"
//SELECT
//  taskid,
//  title,
//  description,
//  creator,
//  esttime,
//  assigned,
//  cretime,
//  final 
//FROM
//  MTasks
//WHERE
//  final = @final
//";

//            IDbDataParameter param = cmd.CreateParameter();
//            param.ParameterName = "@final";
//            param.Value = false;
//            cmd.Parameters.Add(param);

//            try
//            {
//                this.conn.Open();

//                IDataReader reader = cmd.ExecuteReader();
//                while (reader.Read())
//                    resultSet.Add(new MTasks()
//                    {
//                        TaskId = Convert.ToInt32(reader["taskid"]),
//                        Title = Convert.ToString(reader["title"]),
//                        Description = Convert.ToString(reader["description"]),
//                        Creator = Convert.ToInt32(reader["creator"]),
//                        EstTime = Convert.ToInt32(reader["esttime"]),
//                        Assigned = Convert.ToInt32(reader["assigned"]),
//                        CreTime = Convert.ToDateTime(reader["cretime"]),
//                        Final = Convert.ToBoolean(reader["final"]),
//                    });

//                reader.Close();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message,
//                    "Database operation Failed",
//                    MessageBoxButtons.OK,
//                    MessageBoxIcon.Asterisk,
//                    MessageBoxDefaultButton.Button1);
//            }
//            finally
//            {
//                this.conn.Close();
//            }
//            return resultSet;
//        }

//        private List<TimeSpent> GetTTime(MTasks user)
//        {
//            List<TimeSpent> resultSet = new List<TimeSpent>();

//            IDbCommand cmd = this.conn.CreateCommand();
//            cmd.Connection = this.conn;
//            cmd.CommandText = @"
//SELECT
//  tsid,
//  theassi,
//  thetask,
//  fintime,
//  hours 
//FROM
//  TimeSpent
//WHERE
//  thetask = @thetask
//";

//            IDbDataParameter param = cmd.CreateParameter();
//            param.ParameterName = "@thetask";

//            //MTasks user = (MTasks)tasksBindingSource1.Current;

//            param.Value = user.TaskId;
//            cmd.Parameters.Add(param);

//            try
//            {
//                this.conn.Open();

//                IDataReader reader = cmd.ExecuteReader();
//                while (reader.Read())
//                    resultSet.Add(new TimeSpent()
//                    {
//                        TSId = Convert.ToInt32(reader["tsid"]),
//                        TheAssi = Convert.ToInt32(reader["theassi"]),
//                        TheTask = Convert.ToInt32(reader["thetask"]),
//                        FinTime = Convert.ToDateTime(reader["fintime"]),
//                        Hours = Convert.ToInt32(reader["hours"]),
//                    });

//                reader.Close();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message,
//                    "Database operation Failed",
//                    MessageBoxButtons.OK,
//                    MessageBoxIcon.Asterisk,
//                    MessageBoxDefaultButton.Button1);
//            }
//            finally
//            {
//                this.conn.Close();
//            }
//            return resultSet;
//        }

//        private void NewTask(MTasks task)
//        {
//            IDbCommand cmd = this.conn.CreateCommand();
//            cmd.CommandText = @"
//INSERT INTO MTasks 
//(
//  title,    
//  description,
//  creator,
//  esttime,
//  assigned,
//  cretime,
//  final
//)
//VALUES
//(
//  @title,    
//  @description,
//  @creator,
//  @esttime,
//  @assigned,
//  @cretime,
//  @final
//)
//";
//            IDbDataParameter param = cmd.CreateParameter();
//            param.ParameterName = "@title";
//            param.Value = task.Title;
//            cmd.Parameters.Add(param);

//            param = cmd.CreateParameter();
//            param.ParameterName = "@description";
//            param.Value = task.Description;
//            cmd.Parameters.Add(param);

//            param = cmd.CreateParameter();
//            param.ParameterName = "@creator";
//            param.Value = task.Creator;
//            cmd.Parameters.Add(param);

//            param = cmd.CreateParameter();
//            param.ParameterName = "@esttime";
//            param.Value = task.EstTime;
//            cmd.Parameters.Add(param);

//            param = cmd.CreateParameter();
//            param.ParameterName = "@assigned";
//            param.Value = task.Assigned;
//            cmd.Parameters.Add(param);

//            param = cmd.CreateParameter();
//            param.ParameterName = "@cretime";
//            param.Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
//            //param.Value = task.CreTime;
//            cmd.Parameters.Add(param);
//            //DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

//            param = cmd.CreateParameter();
//            param.ParameterName = "@final";
//            param.Value = task.Final;
//            cmd.Parameters.Add(param);

//            try
//            {
//                this.conn.Open();
//                cmd.ExecuteNonQuery();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("User was NOT persisted correctly." + Environment.NewLine + ex.Message, "Persistance failed!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
//            }
//            finally
//            {
//                this.conn.Close();
//            }


//        }

//        private void EditTask(MTasks task)
//        {
//            IDbCommand cmd = this.conn.CreateCommand();
//            cmd.CommandText = @"
//UPDATE MTasks SET
//  title = @title,
//  description = @description,
//  esttime = @esttime,
//  assigned = @assigned,
//  final = @final
//WHERE
//  taskid = @taskid
//";
//            IDbDataParameter param = cmd.CreateParameter();
//            param.ParameterName = "@title";
//            param.Value = task.Title;
//            cmd.Parameters.Add(param);

//            param = cmd.CreateParameter();
//            param.ParameterName = "@description";
//            param.Value = task.Description;
//            cmd.Parameters.Add(param);

//          //  param = cmd.CreateParameter();
//          //  param.ParameterName = "@creator";
//          //  param.Value = task.Creator;//"creator";
//          //  cmd.Parameters.Add(param);

//            param = cmd.CreateParameter();
//            param.ParameterName = "@esttime";
//            param.Value = task.EstTime;
//            cmd.Parameters.Add(param);

//            param = cmd.CreateParameter();
//            param.ParameterName = "@assigned";
//            param.Value = task.Assigned;
//            cmd.Parameters.Add(param);

//           // param = cmd.CreateParameter();
//           // param.ParameterName = "@cretime";
//           // param.Value = task.CreTime;//"cretime";
//           // cmd.Parameters.Add(param);

//            param = cmd.CreateParameter();
//            param.ParameterName = "@final";
//            param.Value = task.Final;
//            cmd.Parameters.Add(param);

//            param = cmd.CreateParameter();
//            param.ParameterName = "@taskid";
//            param.Value = task.TaskId;
//            cmd.Parameters.Add(param);

//            try
//            {
//                this.conn.Open();
//                cmd.ExecuteNonQuery();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Task was NOT persisted correctly." + Environment.NewLine + ex.Message, "Persistance failed!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
//            }
//            finally
//            {
//                this.conn.Close();
//            }
//        }

//        private void DeleteTask(MTasks task)
//        {
//            IDbCommand cmd = this.conn.CreateCommand();
//            cmd.CommandText = @"
//DELETE FROM MTasks
//WHERE
//  taskid = @taskid
//";
//            IDbDataParameter param = cmd.CreateParameter();
//            param.ParameterName = "@taskid";
//            param.Value = task.TaskId;
//            cmd.Parameters.Add(param);

//            try
//            {
//                this.conn.Open();
//                cmd.ExecuteNonQuery();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Task was NOT deleted correctly." + Environment.NewLine + ex.Message, "Delete failed!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
//            }
//            finally
//            {
//                this.conn.Close();
//            }
//        }

//        private void FinishTask(MTasks task)
//        {
//            IDbCommand cmd = this.conn.CreateCommand();
//            cmd.CommandText = @"
//UPDATE MTasks SET
//  final = @final
//WHERE
//  taskid = @taskid
//";
//            IDbDataParameter param = cmd.CreateParameter();
//            param.ParameterName = "@final";
//            param.Value = task.Final;
//            cmd.Parameters.Add(param);

//            param = cmd.CreateParameter();
//            param.ParameterName = "@taskid";
//            param.Value = task.TaskId;
//            cmd.Parameters.Add(param);

//            try
//            {
//                this.conn.Open();
//                cmd.ExecuteNonQuery();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Task was NOT persisted correctly." + Environment.NewLine + ex.Message, "Persistance failed!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
//            }
//            finally
//            {
//                this.conn.Close();
//            }
//        }

//        #endregion

        #region Old

        private void SetDataSources()
        {
            MTasksRepo gat = new MTasksRepo();
            tasksBindingSource1.DataSource = gat.GetAll();
            dataGridView1.DataSource = tasksBindingSource1;

            UsersRepo frm = new UsersRepo();
            DataGridViewComboBoxColumn columnCreatedyBy = (DataGridViewComboBoxColumn)dataGridView1.Columns[4];
            columnCreatedyBy.DataSource = frm.GetAll();

            DataGridViewComboBoxColumn columnExecutive = (DataGridViewComboBoxColumn)dataGridView1.Columns[5];
            columnExecutive.DataSource = frm.GetAll();
        }

        private void SetTimeSources()
        {
            MTasks user = (MTasks)tasksBindingSource1.Current;
            MTasksRepo gat = new MTasksRepo();
            timeBindingSource.DataSource = gat.GetTTime(user);
            dataGridView2.DataSource = timeBindingSource;

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
                MTasksRepo frm = new MTasksRepo();
                frm.Save(item);
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
                    MTasks user = (MTasks)tasksBindingSource1.Current;
                    MTasksRepo frm = new MTasksRepo();
                    frm.Delete(user);
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
                    MTasksRepo frm = new MTasksRepo();
                    frm.Save(task);
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
                TimesRepo create = new TimesRepo();
                create.New(item);
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
                    TimesRepo del = new TimesRepo();
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

                task.Final = Convert.ToBoolean(true);
                MTasksRepo frm = new MTasksRepo();
                frm.FinishTask(task);
                SetDataSources();

            }
        }
    }

        #endregion
}