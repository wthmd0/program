using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            masuv();
        }

        private void masuv()
        {
            dataGridView1.ColumnCount = 10;
            dataGridView1.RowCount = 10;
            
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Columns[i].Width = 41;
            }
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows[i].Height = 41;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[i].Style.BackColor = Color.Pink;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = i + 1; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Pink;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.RowCount - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Pink;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[dataGridView1.ColumnCount - i - 1].Style.BackColor = Color.Pink;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    dataGridView1.Rows[j].Cells[i - j - 1].Style.BackColor = Color.Pink;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - i; j++)
                {
                    dataGridView1.Rows[j + i].Cells[dataGridView1.ColumnCount - j - 1].Style.BackColor = Color.Pink;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount / 2; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Pink;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = dataGridView1.ColumnCount / 2; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Pink;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount / 2; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Pink;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.RowCount / 2; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Pink;
                }
            }
        }
    }
}

