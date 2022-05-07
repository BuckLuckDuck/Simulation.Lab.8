using System;
using System.Windows.Forms;

namespace Simulation.Lab._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_8_1_Click(object sender, EventArgs e)
        {
            this.Hide();
            lab_8_1 lab_8_1 = new lab_8_1();
            lab_8_1.Show();
        }

        private void btn_8_2_Click(object sender, EventArgs e)
        {
            this.Hide();
            lab_8_2 lab_8_2 = new lab_8_2();
            lab_8_2.Show();
        }

        private void btn_8_3_Click(object sender, EventArgs e)
        {
            this.Hide();
            lab_8_3 lab_8_3 = new lab_8_3();
            lab_8_3.Show();
        }
    }
}
