using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR12
{
    public partial class F_Start : Form
    {
        public F_Start()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mytest = new Form1();
            this.Hide();
            mytest.Show();

        }
    }
}
