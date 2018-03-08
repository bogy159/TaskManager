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
//using System.Data;
using System.Data.OleDb;
//using BogyWinFormTM.Repository;
//using BogyWinFormTM.Enumerations;
//using BogyWinFormTM.Entity;
using LibraryADO.Repository;
using LibraryADO.Entity;

namespace BogyWinFormTM.View
{
    public partial class ListUsers : Form
    {
      //  private IDbConnection conn = null;

        public ListUsers()  
        {
            InitializeComponent();
            SetDataSources();
        //    this.conn = new OleDbConnection();
        //    this.conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=users.accdb;";
        }

//        #region Functional Methods

//        public List<Users> GetAllUsers()
//        {
//            List<Users> resultSet = new List<Users>();

//            IDbCommand cmd = this.conn.CreateCommand();
//            cmd.Connection = this.conn;
//            cmd.CommandText = @"
//SELECT
//  userid,
//  username,
//  pass,
//  fname,
//  lname 
//FROM
//  Users
//";
//            try
//            {
//                this.conn.Open();

//                IDataReader reader = cmd.ExecuteReader();
//                while (reader.Read())
//                    resultSet.Add(new Users()
//                    {
//                        UserId = Convert.ToInt32(reader["userid"]),
//                        Username = Convert.ToString(reader["username"]),
//                        Pass = Convert.ToString(reader["pass"]),
//                        FName = Convert.ToString(reader["fname"]),
//                        LName = Convert.ToString(reader["lname"]),
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

//        private void NewUser(Users user)
//        {
//            IDbCommand cmd = this.conn.CreateCommand();
//            cmd.CommandText = @"
//INSERT INTO Users 
//(
//  username,
//  pass,
//  fname,
//  lname
//)
//VALUES
//(
//  @username,
//  @pass,
//  @fname,
//  @lname
//)
//";
//            IDbDataParameter param = cmd.CreateParameter();
//            param.ParameterName = "@username";
//            param.Value = user.Username;
//            cmd.Parameters.Add(param);

//            param = cmd.CreateParameter();
//            param.ParameterName = "@pass";
//            param.Value = user.Pass;
//            cmd.Parameters.Add(param);

//            param = cmd.CreateParameter();
//            param.ParameterName = "@fname";
//            param.Value = user.FName;
//            cmd.Parameters.Add(param);

//            param = cmd.CreateParameter();
//            param.ParameterName = "@lname";
//            param.Value = user.LName;
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

//        private void EditUser(Users user)
//        {
//        IDbCommand cmd = this.conn.CreateCommand();
//            cmd.CommandText = @"
//UPDATE Users SET
//  username = @username,
//  pass = @pass,
//  fname = @fname,
//  lname = @lname
//WHERE
//  userid = @userid
//";
//            IDbDataParameter param = cmd.CreateParameter();
//            param.ParameterName = "@username";
//            param.Value = user.Username;
//            cmd.Parameters.Add(param);

//            param = cmd.CreateParameter();
//            param.ParameterName = "@pass";
//            param.Value = user.Pass;
//            cmd.Parameters.Add(param);

//            param = cmd.CreateParameter();
//            param.ParameterName = "@fname";
//            param.Value = user.FName;
//            cmd.Parameters.Add(param);

//            param = cmd.CreateParameter();
//            param.ParameterName = "@lname";
//            param.Value = user.LName;
//            cmd.Parameters.Add(param);

//            param = cmd.CreateParameter();
//            param.ParameterName = "@userid";
//            param.Value = user.UserId;
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
//    }

//        private void DeleteUser(Users user)
//        {
//            IDbCommand cmd = this.conn.CreateCommand();
//            cmd.CommandText = @"
//DELETE FROM Users
//WHERE
//  userid = @userid
//";
//            IDbDataParameter param = cmd.CreateParameter();
//            param.ParameterName = "@userid";
//            param.Value = user.UserId;
//            cmd.Parameters.Add(param);

//            try
//            {
//                this.conn.Open();
//                cmd.ExecuteNonQuery();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("User was NOT deleted correctly." + Environment.NewLine + ex.Message, "Delete failed!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
            this.dataGridView1.Refresh();
            UsersRepo frm = new UsersRepo();
            usersBindingSource.DataSource = frm.GetAll();
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
                UsersRepo frm = new UsersRepo();
                frm.Save(item);
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
                    UsersRepo frm = new UsersRepo();
                    frm.Save(user);
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
                  UsersRepo frm = new UsersRepo();
                  frm.Delete(user);
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
