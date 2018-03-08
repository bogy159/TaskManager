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
    public partial class EditTask : Form
    {
        private MTasks task;

        public EditTask(MTasks task)
        {
            InitializeComponent();
            this.task = task;

            this.textBox1.Text = task.Title;
            this.richTextBox1.Text = task.Description;
            this.textBox2.Text = Convert.ToString(task.EstTime);
            SetDataSources();
            this.comboBox1.SelectedValue = task.Assigned;
        }

        private void SetDataSources()
        {

            ListUsers frm = new ListUsers();
            comboBox1.DataSource = frm.GetAllUsers();

           // UserRepo userRepo = new UserRepo("users.txt");
           // comboBox1.DataSource = userRepo.GetAll();
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || richTextBox1.Text == "")
            {
                MessageBox.Show("Can not leave empty spaces");
                return;
            }
            else
            {
                task.Title = this.textBox1.Text;
                task.Description = this.richTextBox1.Text;
                task.EstTime = Convert.ToInt32(this.textBox2.Text);
                task.Assigned = Convert.ToInt32(this.comboBox1.SelectedValue);
                task.Final = Convert.ToBoolean(this.checkBox1.CheckState);

            }
            this.DialogResult = DialogResult.OK;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
