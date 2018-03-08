using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using BogyWinFormTM.Entity;
//using BogyWinFormTM.Repository;
//using BogyWinFormTM.Enumerations;
using LibrarySQL.Entiry;
using LibrarySQL.Repository;

namespace BogyWinFormTM.View
{
    public partial class NewUser : Form
    {
        private Users item;
        public bool AStat = false;

        public NewUser(Users user)
        {
            InitializeComponent();
            this.item = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Can not leave empty spaces");
                return;
            }
            else
            {
                item.Username = this.textBox1.Text;
                item.Pass = this.textBox2.Text;
                item.FName = this.textBox3.Text;
                item.LName = this.textBox4.Text;
            }

            this.DialogResult = DialogResult.OK;

        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }
    }
}
