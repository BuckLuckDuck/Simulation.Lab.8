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
    public partial class lab_8_2 : Form
    {
        public lab_8_2()
        {
            InitializeComponent();
        }

        private void btn_answer_get_Click(object sender, EventArgs e)
        {
            string[] answer_list = { "Бесспорно", "Предрешено", "Никаких сомнений", "Определённо да", "Можешь быть уверен в этом", "Мне кажется — «да»", "Вероятнее всего", "Хорошие перспективы",
            "Знаки говорят — «да»", "Да", "Пока не ясно, попробуй снова", "Спроси позже", "Лучше не рассказывать", "Сейчас нельзя предсказать", "Сконцентрируйся и спроси опять",
            "Даже не думай", "Мой ответ — «нет»", "По моим данным — «нет»", "Перспективы не очень хорошие", "Весьма сомнительно"};
            double p = 1.0 / (double)answer_list.Length;

            Random rnd = new Random();
            double A = rnd.NextDouble();
            int ans_id = 0;
            A -= p;

            while (A > 0)
            {
                A -= p;
                ans_id++;
            };

            lbl_answer.Text = answer_list[ans_id];
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
