using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using test;

namespace PR12
{
    public partial class help : Form
    {
        int asv = 0;
        public help()
        {
            InitializeComponent();
        }

        private void help_Load(object sender, EventArgs e)
        {
            for (; asv < task.Allqu.Count;)
            {
                test.Singlrtest p = task.Allqu[asv];

                textBox1.Text = p.Que;
                if (asv == 0) textBox2.Text = p.Ans[2];
                else if (asv == 1) textBox2.Text = p.Ans[0];
                else if(asv == 2) textBox2.Text = p.Ans[2];
                else if(asv == 3) textBox2.Text = p.Ans[0];
                else if(asv == 4) textBox2.Text = p.Ans[2];
                break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            asv++;
            if (asv == 5) asv = 0;
                test.Singlrtest p = task.Allqu[asv];

            textBox1.Text = p.Que;
            if (asv == 0) textBox2.Text = p.Ans[2];
            else if (asv == 1) textBox2.Text = p.Ans[0];
            else if (asv == 2) textBox2.Text = p.Ans[2];
            else if (asv == 3) textBox2.Text = p.Ans[0];
            else if (asv == 4) textBox2.Text = p.Ans[2];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            asv--;
            if (asv == 0) asv = 4;
            test.Singlrtest p = task.Allqu[asv];

            textBox1.Text = p.Que;
            if (asv == 0) textBox2.Text = p.Ans[2];
            else if (asv == 1) textBox2.Text = p.Ans[0];
            else if (asv == 2) textBox2.Text = p.Ans[2];
            else if (asv == 3) textBox2.Text = p.Ans[0];
            else if (asv == 4) textBox2.Text = p.Ans[2];
        }
    }
}
