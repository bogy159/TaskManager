using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BogyWinFormTM.View
{
    public partial class EditTime : Form
    {
        public EditTime()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Hide();
            label7.Show();
            textBox1.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Hide();
            label6.Show();
        }
    }
}
