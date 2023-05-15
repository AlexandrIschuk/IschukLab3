using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework5
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int s;
        public int _s
        {
            get { return s; }
            set { s = value; }
        }
        int s1;
        public int _s1
        {
            get { return s1; }
            set { s1 = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox5.Text, out s))
            {
                MessageBox.Show("Ошибка ввода!");
            }
            else
            {
                if (!int.TryParse(textBox4.Text, out s1))
                {
                    MessageBox.Show("Ошибка ввода!");
                }
                else
                {
                    this.Close();
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
