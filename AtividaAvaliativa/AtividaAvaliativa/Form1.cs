﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividaAvaliativa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234") 

                { 
                Form2 form2 = new Form2();
            form2.Show();
             }
            else
            {
                MessageBox.Show("Senha Incorreta", "Erro" , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const String token = "1234";

        }
    }
}
