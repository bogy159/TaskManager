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
using System.Data.Entity;


namespace BogyWinFormTM.View
{
    public partial class Index : Form
    {

        public class BloggingContext : DbContext
        {
            public DbSet<Users> Users { get; set; }
            public DbSet<MTasks> MTasks { get; set; }
            public DbSet<TimeSpent> TimeSpent { get; set; }
        }

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
            using (var db = new Index.BloggingContext())
            {
                try
                {
                    Users user = new Users();

                    var result =
                       (from u in db.Users
                        where u.Username == username && u.Pass == password
                        select u).FirstOrDefault();
                    Login.LoggedUser = result;
                    return result;
                   
                }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Database operation Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1);
            }
                return null;

            }
        }

        #endregion

        #region OLD
        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new BloggingContext())
            {
               
            } 
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
                menuStrip1.Enabled=true;
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

        #endregion
    }
}
