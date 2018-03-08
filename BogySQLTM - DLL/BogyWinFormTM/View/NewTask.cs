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
using BogyWinFormTM.Authentication;
using BogyWinFormTM.View;
using LibrarySQL.Entiry;
using LibrarySQL.Repository;

namespace BogyWinFormTM.View
{
    public partial class NewTask : Form
    {
        private MTasks item;

        private void SetDataSources()
        {
            UserRepo frm = new UserRepo();
            comboBox1.DataSource = frm.GetAll();
        }

        public NewTask(MTasks task)
        {
            InitializeComponent();
            this.item = task;
            SetDataSources();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || richTextBox1.Text == "")
            {
                MessageBox.Show("Can not leave empty spaces");
                return;
            }
            else 
            {
                item.Title = this.textBox1.Text;
                item.Description = this.richTextBox1.Text;
                item.EstTime = Convert.ToInt32(this.textBox2.Text);
                item.Creator = Login.LoggedUser.UserId;
                item.Assigned = Convert.ToInt32(this.comboBox1.SelectedValue);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void usersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
