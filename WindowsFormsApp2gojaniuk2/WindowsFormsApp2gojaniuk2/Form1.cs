using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2gojaniuk2
{
    public partial class Form1 : Form
    {
        double[,] Arr;
        public Form1()
        {
            InitializeComponent();
        }

        private void DomainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void DomainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int value1 = (int)(numericUpDown1.Value);
            int value2 = (int)(numericUpDown1.Value);
            dataGridView1.RowCount = value1;
            dataGridView1.ColumnCount = value2;
            Arr = new double[value1, value2];

            Random random = new Random();
            for (int i = 0; i < value1; i++)
            {
                for (int j = 0; j < value2; j++)
                {
                    Arr[i, j] = random.Next(-29, 603) / 10;
                    dataGridView1[i, j].Value = Arr[i, j];
                    dataGridView1.Columns[i].HeaderText = i.ToString();

                    Console.Write("{0,4}", Arr[i, j]);
                }
            }
        }
    }
}
