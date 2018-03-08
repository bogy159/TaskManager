using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using BogyWinFormTM.Authentication;
using BogyWinFormTM.Entity;
using BogyWinFormTM.Repository;


namespace BogyWinFormTM.View
{
    public partial class Index : Form
    {
        private void Index_Load(object sender, EventArgs e)
        {

        }

        private IDbConnection conn = null;

        #region Constructors


        public Index()
        {
            InitializeComponent();
            this.conn = new OleDbConnection();
            this.conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=users.accdb;";
        }

        #endregion

        #region Repositoy

        public Users GetByUsernameAndPassword(string username, string password)
        {
            Users user = new Users();

            IDbCommand cmd = this.conn.CreateCommand();
            cmd.Connection = this.conn;
            cmd.CommandText = @"
SELECT
  userid,
  username,
  pass,
  fname,
  lname
FROM
  Users
";
            try
            {
                this.conn.Open();

                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    user = (new Users()
                    {
                        UserId = Convert.ToInt32(reader["userid"]),
                        Username = Convert.ToString(reader["username"]),
                        Pass = Convert.ToString(reader["pass"]),
                        FName = Convert.ToString(reader["fname"]),
                        LName = Convert.ToString(reader["lname"])
                    });
                    if (user.Username == username && user.Pass == password)
                    {
                       // Login.LoggedUser = user;
                        return user;
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Database operation Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1);
            }
            finally
            {
                this.conn.Close();
            }
            return null;

        }

        #endregion

        #region OLD

        private void button1_Click(object sender, EventArgs e)
        {


            Login.AuthenticateUser(textBox1.Text, textBox2.Text);

            if (Login.LoggedUser != null)
            {
                this.DialogResult = DialogResult.OK;
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Show();
                textBox1.Hide();
                textBox2.Hide();
                button1.Hide();
                menuStrip1.Show();
                menuStrip1.Enabled = true;

            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }


        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            label4.Hide();
            ListUsers newMDIChild = new ListUsers();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Hide();
            ListTasks newMDIChild = new ListTasks();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void findUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Hide();
            ListTimes newMDIChild = new ListTimes();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
