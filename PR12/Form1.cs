using answ;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR12
{
    public partial class Form1 : Form
    {
        int asv = 1;
        int sumball = 0;
        int ans = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            test.Singlrtest p = task.Allqu[0];

            textBox2.Text = p.Que;
            radioButton1.Text = p.Ans[0];
            radioButton2.Text = p.Ans[1];
            radioButton3.Text = p.Ans[2];
            radioButton4.Text = p.Ans[3];
        }

        private void button1_Click(object sender, EventArgs e)
        {

                for (; asv < task.Allqu.Count+1; )
                {
                if (radioButton1.Checked) ans = 0;
                else if (radioButton2.Checked) ans = 1;
                else if (radioButton3.Checked) ans = 2;
                else if (radioButton4.Checked) ans = 3;
                else
                {
                    MessageBox.Show("Введите ответ!", "Ошибка");
                    break;
                }
                if (asv < task.Allqu.Count)
                {
                    test.Singlrtest p = task.Allqu[asv];
                    textBox2.Text = p.Que;
                    radioButton1.Text = p.Ans[0];
                    radioButton2.Text = p.Ans[1];
                    radioButton3.Text = p.Ans[2];
                    radioButton4.Text = p.Ans[3];
                }
                break;
            }
            test.Singlrtest pp = task.Allqu[asv - 1];
            sumball += pp.Bns[ans];
            asv++;
            progressBar1.Value += 20;
            if (asv == 6)
            {
                string mes = "";
                if (sumball <= 0) mes = baal.Mess[0];
                else if (sumball <= 3) mes = baal.Mess[1];
                else if (sumball == 4) mes = baal.Mess[2];
                else mes = baal.Mess[3];
                MessageBox.Show(mes, "Вывод!");
                var help = new help();
                help.Close();
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var help = new help();
            help.Show();
        }
    }
}
