using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp2gojaniuk
{
    public partial class Form1 : Form
    {
        public class ReverseComparer : IComparer
        {
            public int Compare(Object x, Object y)
            {
                return (new CaseInsensitiveComparer()).Compare(y, x);
            }
        }
        double[] myArr;
        int value ,k ;
        public Form1()
        {  
            InitializeComponent();
            

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            IComparer revComparer = new ReverseComparer();

            double sum = 0;
            k = (int)(numericUpDown2.Value);

            for (int i = 0; i < myArr.Length; i++)
            {
                if (i % 2 == 0 && myArr[i] > 0)
                {
                    sum += myArr[i];
                }

            }
            textBox1.Text = sum.ToString();

            Array.Sort(myArr, value - k , k, revComparer);
            for (int i = 0; i < myArr.Length; i++)
            {
                dataGridView1[i, 0].Value = myArr[i];
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            value = (int)(numericUpDown1.Value);
            
            myArr = new double[value];
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = value;
            Random ran = new Random();
            // Ініціалізуєм масив
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = ran.Next(-15000, 20000) / 100.0;
                dataGridView1[i, 0].Value = myArr[i];
                dataGridView1.Columns[i].HeaderText = i.ToString();
            }

            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
