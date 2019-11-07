using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = " ";
            label6.Font = new Font(Font, FontStyle.Bold) ;
            comboBox1.SelectedIndex = 0;
            label3.Text = "Розиіри вікна: ";
            label3.Font = new Font(Font, FontStyle.Bold);
            label4.Text = "Склопакет:";
            label4.Font = new Font(Font, FontStyle.Bold);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double p = 0;
            double a =0, b = 0;
            Double.TryParse(textBox1.Text, out a);
            Double.TryParse(textBox2.Text, out b);
            double sq = a * b;
            

            if (radioButton1.Checked && comboBox1.SelectedIndex == 0) { p= sq * 0.25; }
            if (radioButton2.Checked && comboBox1.SelectedIndex == 0) { p = sq * 0.30; }
            if (radioButton1.Checked && comboBox1.SelectedIndex == 1) { p = sq * 0.05; }
            if (radioButton2.Checked && comboBox1.SelectedIndex == 1) { p = sq * 0.10; }
            if (radioButton1.Checked && comboBox1.SelectedIndex == 2) { p = sq * 0.25; }
            if (radioButton2.Checked && comboBox1.SelectedIndex == 2) { p = sq * 0.25; }
            if (checkBox1.Checked) { p += 35.0; }

            label6.Text = "Вартість: " + p.ToString();
        }
    }
}
