﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Denemeleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
         



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                comboBox1.Items.Add(i);
            }

            for (int j = 0; j <60; j++)
            {
                comboBox2.Items.Add(j);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.Hour.ToString();
            label4.Text = DateTime.Now.Minute.ToString();

            if (comboBox2.Text==label4.Text)
            {
                timer1.Enabled = false;
                MessageBox.Show("Uyanma Zamanı...");
                axWindowsMediaPlayer1.URL = @"C:\Users\Alikaan\source\repos\Alert\mp3\opening-titles.mp3";
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
