﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double v1, v2, R;
        char op;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += 1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += 2;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += 3;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += 4;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += 5;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += 6;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += 7;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += 8;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += 9;
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += 0;
        }

        private void Adicao_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += "+";
            v1 = double.Parse(textBox1.Text);
            op = '+';
        }

        
    }
}
