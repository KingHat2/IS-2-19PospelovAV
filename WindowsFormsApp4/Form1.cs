﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 Form5= new Form5();
            Form5.ShowDialog();
            //не знаю как фиксить
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 Form6 = new Form6();
            Form6.ShowDialog();
        }
    }
}
