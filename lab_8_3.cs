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
    public partial class lab_8_3 : Form
    {

        public lab_8_3()
        {
            InitializeComponent();
        }

        double[] prob_interval;
        int[] prob_stat;
        int N;

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

        private void btn_full_auto_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(1, nud_prob_1.Value);
            chart1.Series[0].Points.AddXY(2, nud_prob_2.Value);
            chart1.Series[0].Points.AddXY(3, nud_prob_3.Value);
            chart1.Series[0].Points.AddXY(4, nud_prob_4.Value);
            chart1.Series[0].Points.AddXY(5, nud_prob_5.Value);
            
            Random rnd = new Random();
            int random_prob = 1001;
            nud_prob_1.Value = (decimal)rnd.Next(random_prob) / 1000;
            random_prob = random_prob - (int)(nud_prob_1.Value * 1000);
            nud_prob_2.Value = (decimal)rnd.Next(random_prob) / 1000;
            random_prob = random_prob - (int)(nud_prob_2.Value * 1000);
            nud_prob_3.Value = (decimal)rnd.Next(random_prob) / 1000;
            random_prob = random_prob - (int)(nud_prob_3.Value * 1000);
            nud_prob_4.Value = (decimal)rnd.Next(random_prob) / 1000;
            random_prob = random_prob - (int)(nud_prob_4.Value * 1000) - 1;
            nud_prob_5.Value = (decimal)random_prob / 1000;
        }

        private void nud_prob_1_ValueChanged(object sender, EventArgs e)
        {
            chart1.Series[0].Points[0].SetValueY(nud_prob_1.Value);
        }

        private void nud_prob_2_ValueChanged(object sender, EventArgs e)
        {
            //chart1.Series[0].Points.AddXY(2, nud_prob_2.Value);
            chart1.Series[0].Points[1].SetValueY(nud_prob_2.Value);
        }

        private void nud_prob_3_ValueChanged(object sender, EventArgs e)
        {
            //chart1.Series[0].Points.AddXY(3, nud_prob_3.Value);
            chart1.Series[0].Points[2].SetValueY(nud_prob_3.Value);
        }

        private void nud_prob_4_ValueChanged(object sender, EventArgs e)
        {
            //chart1.Series[0].Points.AddXY(4, nud_prob_4.Value);
            chart1.Series[0].Points[3].SetValueY(nud_prob_4.Value);
        }

        private void nud_prob_5_ValueChanged(object sender, EventArgs e)
        {
            //chart1.Series[0].Points.AddXY(5, nud_prob_5.Value);
            chart1.Series[0].Points[4].SetValueY(nud_prob_5.Value);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            prob_interval = new double[5];
            prob_stat = new int[5];
            N = (int)nud_N.Value;
            Random rnd = new Random();
            double alpha;

            prob_interval[0] = (double)nud_prob_1.Value;
            prob_interval[1] = (double)nud_prob_2.Value;
            prob_interval[2] = (double)nud_prob_3.Value;
            prob_interval[3] = (double)nud_prob_4.Value;
            prob_interval[4] = (double)nud_prob_5.Value;

            for (int i = 0; i < N; i++)
            {
                alpha = rnd.NextDouble();
                double sum = 0;

                for (int k = 0; k < 5; k++)
                {
                    sum += prob_interval[k];

                    if (alpha <= sum)
                    {
                        prob_stat[k]++;
                        break;
                    }
                }
            }

            chart2.Series[0].Points.Clear();
            chart2.Series[0].Points.AddXY(1, prob_stat[0]);
            chart2.Series[0].Points.AddXY(2, prob_stat[1]);
            chart2.Series[0].Points.AddXY(3, prob_stat[2]);
            chart2.Series[0].Points.AddXY(4, prob_stat[3]);
            chart2.Series[0].Points.AddXY(5, prob_stat[4]);

            dataGridView1.Rows.Add(N, prob_stat[0], prob_stat[1], prob_stat[2], prob_stat[3], prob_stat[4]);
        }
    }
}
