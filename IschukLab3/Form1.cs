using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Homework5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CycleDoubleLinkedList list = new CycleDoubleLinkedList();
        DoubleNode head;


       



        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "�� ������������� ������ �����?";
            const string caption = "����� �� ���������";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && list.head == null)
            {
                string input = textBox2.Text;
                string[] strNumbers = input.Split();
                int[] numbers = new int[strNumbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                    if (!int.TryParse(strNumbers[i], out numbers[i]))
                    {
                        MessageBox.Show("������ �����!");
                    }


                    else
                        numbers[i] = int.Parse(strNumbers[i]);
                list.CreateList(numbers);
                list.DisplayList(listBox1);





            }
            else
            {
                MessageBox.Show("������� �������� ��� ���������� ����� ��������� ��� ������ ��� ������!");
            }


        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.DestroyList();
            list.DisplayList(listBox1);


        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.head != null)
            {
                int N;
                if (!int.TryParse(textBox2.Text, out N))
                {
                    MessageBox.Show("������ �����!");
                }
                else
                {
                    list.AddFirst(N);
                    list.DisplayList(listBox1);

                }

            }
            else
            {
                MessageBox.Show("������ �� ����������!");
            }
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.head != null)
            {
                int N;
                if (!int.TryParse(textBox2.Text, out N))
                {
                    MessageBox.Show("������ �����!");
                }
                else
                {
                    list.AddLast(N);
                    list.DisplayList(listBox1);
                }

            }
            else
            {
                MessageBox.Show("������ �� ����������!");
            }


        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.RemoveFirst();
            list.DisplayList(listBox1);
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.RemoveLast();
            list.DisplayList(listBox1);

        }

        private void �������������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int N;
            if (!int.TryParse(textBox2.Text, out N))
            {
                MessageBox.Show("������ �����!");
            }
            else
            {
                list.RemoveAt(N,head);
                list.DisplayList(listBox1);

            }

        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form1 = new Form2();
            form1.ShowDialog();
            if(form1.DialogResult == DialogResult.OK)
            {
                list.AddNode(form1._s1, form1._s);
                list.DisplayList(listBox1);

            }
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
            if(form4.DialogResult == DialogResult.OK)
            {
                list.RemoveRange(form4._s, form4._s1);
                list.DisplayList(listBox1);
            }
        }

        private void �ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            list.ClearList(list.head);
            list.DisplayList(listBox1);

        }
    }
}
