﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            ToyFactory toyFactory = new ToyFactory(textBox_Toys);
            Random rnd = new Random();
            rnd.Next(10);
            for(int i = 0;)
            {

            }
            toyFactory.ProduceToys();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            ToyFactory toyFactory = new ToyFactory(textBox_Toys);
            while (true)
            {
                toyFactory.SimulateRandomEvent();
            }
        }
    }
}
