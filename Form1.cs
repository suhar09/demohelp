﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21341
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form2(); 
                form.Show(); 
               this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Form3();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
    }
}
