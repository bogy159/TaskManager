using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BogyWinFormTM.Entity;
using BogyWinFormTM.Repository;

namespace BogyWinFormTM.View
{
    public partial class EditUser : Form
    {
        private Users user;

        public EditUser(Users user)
        {
            InitializeComponent();

            this.user = user;

            this.textBox1.Text = user.Username;
            this.textBox2.Text = user.Pass;
            this.textBox3.Text = user.FName;
            this.textBox4.Text = user.LName;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Can not leave empty spaces");
                return;
            }
            else
            {
                user.Username = this.textBox1.Text;
                user.Pass = this.textBox2.Text;
                user.FName = this.textBox3.Text;
                user.LName = this.textBox4.Text;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {

        }
    }
}
