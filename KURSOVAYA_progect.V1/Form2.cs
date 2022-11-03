using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSOVAYA_progect.V1
{
    public partial class Form2 : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        static public string str;
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Form6 f6 = new Form6();
            while (Form6.pruv == 0)
            {
                ofd.ShowDialog();
                if (ofd.FileName != "")
                {
                    str = ofd.FileName;
                    Form6.pruv = 1;
                }
                else { f6.ShowDialog(); }
            }
        }
    }
}
