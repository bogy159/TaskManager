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
using LibraryADO.Entity;
using LibraryADO.Repository;

namespace BogyWinFormTM.View
{
    public partial class ListTimes : Form
    {
       // private IDbConnection conn = null;

        public ListTimes()
        {
            InitializeComponent();
            //this.conn = new OleDbConnection();
            //this.conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=users.accdb;";
            SetDataSources();
        }

//        #region Functional Methods

//        private List<TimeSpent> GetAllTime()
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
//";
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

//        public void NewTime(TimeSpent time)
//        {
//            IDbCommand cmd = this.conn.CreateCommand();
//            cmd.CommandText = @"
//INSERT INTO TimeSpent 
//(
//  theassi,
//  thetask,
//  fintime,
//  hours
//)
//VALUES
//(
//  @theassi,
//  @thetask,
//  @fintime,
//  @hours
//)
//";
//            IDbDataParameter param = cmd.CreateParameter();
//            param.ParameterName = "@theassi";
//            param.Value = time.TheAssi;
//            cmd.Parameters.Add(param);

//            param = cmd.CreateParameter();
//            param.ParameterName = "@thetask";
//            param.Value = time.TheTask;
//            cmd.Parameters.Add(param);

//            param = cmd.CreateParameter();
//            param.ParameterName = "@fintime";
//            param.Value = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
//            cmd.Parameters.Add(param);

//            param = cmd.CreateParameter();
//            param.ParameterName = "@hours";
//            param.Value = time.Hours;
//            cmd.Parameters.Add(param);

//            try
//            {
//                this.conn.Open();
//                cmd.ExecuteNonQuery();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Time info was NOT persisted correctly." + Environment.NewLine + ex.Message, "Persistance failed!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
//            }
//            finally
//            {
//                this.conn.Close();
//            }


//        }

//        public void DeleteTime(TimeSpent time)
//        {
//            IDbCommand cmd = this.conn.CreateCommand();
//            cmd.CommandText = @"
//DELETE FROM TimeSpent
//WHERE
//  tsid = @tsid
//";
//            IDbDataParameter param = cmd.CreateParameter();
//            param.ParameterName = "@tsid";
//            param.Value = time.TSId;
//            cmd.Parameters.Add(param);

//            try
//            {
//                this.conn.Open();
//                cmd.ExecuteNonQuery();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Time info was NOT deleted correctly." + Environment.NewLine + ex.Message, "Delete failed!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
            TimesRepo frm = new TimesRepo();
            timeBindingSource.DataSource = frm.GetAll();
            dataGridView1.DataSource = timeBindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void usersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tsMainNew_Click(object sender, EventArgs e)
        {
            TimeSpent item = new TimeSpent();
            NewTime newTime = new NewTime(item);

            if (newTime.ShowDialog() == DialogResult.OK)
            {
                TimesRepo frm = new TimesRepo();
                frm.New(item);
                SetDataSources();
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
                    TimeSpent time = (TimeSpent)timeBindingSource.Current;
                    TimesRepo frm = new TimesRepo();
                    frm.Delete(time);
                    SetDataSources();

                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion
    }
}
