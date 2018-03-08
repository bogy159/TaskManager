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
    public partial class ListTimes : Form
    {
        

        public ListTimes()
        {
            InitializeComponent();
            SetDataSources();
        }

        #region Functional Methods

        //private List<TimeSpent> GetAllTime()
        //{
        //    using (var db = new Index.BloggingContext())
        //    {
        //        var result =
        //           (from t in db.TimeSpent
        //            select t).ToList();
        //        return result;
        //    }
        //}

        //public void NewTime(TimeSpent time)
        //{
        //using (var db = new Index.BloggingContext())
               
        //    {
        //        var now = DateTime.Now;
        //        var item = new TimeSpent { TheAssi=time.TheAssi, TheTask=time.TheTask, FinTime=now, Hours=time.Hours };
        //        db.TimeSpent.Add(item);
        //        db.SaveChanges();
        //    }
        //}

        //public void DeleteTime(TimeSpent time)
        //{
        //    using (var db = new Index.BloggingContext())
        //    {
        //        var item =
        //               (from t in db.TimeSpent
        //                where t.TSId == time.TSId
        //                select t).First();
        //        db.TimeSpent.Remove(item);
        //        db.SaveChanges();
        //    }
        //}

        #endregion

        #region Old

        private void SetDataSources()
        {
            TimeRepo frm = new TimeRepo();
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
                TimeRepo cre = new TimeRepo();
                cre.New(item);
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
                    TimeRepo del = new TimeRepo();
                    TimeSpent time = (TimeSpent)timeBindingSource.Current;
                    del.Delete(time);
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
