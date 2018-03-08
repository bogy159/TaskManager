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
using BogyWinFormTM.View;
using LibrarySQL.Entiry;
using LibrarySQL.Repository;

namespace BogyWinFormTM.View
{
    public partial class NewTime : Form
    {
        private TimeSpent item;

        public NewTime(TimeSpent time)
        {
            InitializeComponent();
            this.item = time;
            SetDataSources();
        }

        private void SetDataSources()
        {

            TaskRepo tasksid = new TaskRepo();
            comboBox1.DataSource = tasksid.GetAllNF();
            comboBox2.DataSource = tasksid.GetAllNF();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Can not leave empty spaces");
                return;
            }
            else 
            {
                item.Hours = Convert.ToInt32(this.textBox1.Text);
                item.TheTask = Convert.ToInt32(this.comboBox1.SelectedValue);
                item.TheAssi = Convert.ToInt32(this.comboBox2.SelectedValue);

                this.DialogResult = DialogResult.OK;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mTasksBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewTime_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = comboBox2.FindStringExact(comboBox1.Text);
        }
    }
}
