using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation.Lab._8
{
    public partial class lab_8_1 : Form
    {
        public lab_8_1()
        {
            InitializeComponent();
        }

        private void btn_answer_get_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            double a = rnd.NextDouble();
            if (a < 0.5)
            {
                lbl_answer.Text = "Да";
            }
            else
            {
                lbl_answer.Text = "Нет";
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
