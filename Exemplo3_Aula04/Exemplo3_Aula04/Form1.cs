﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo3_Aula04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String curso = "";
            short serie = 0;

            if (radioButton1.Checked) curso = "Desenvolvimento de Sistemas";
            else if (radioButton2.Checked) curso = "Edificaçõe";
            else if (radioButton3.Checked) curso = "Geodésia e Cartografia";

            if (radioButton4.Checked) serie = 1;
            else if (radioButton5.Checked) serie = 2;
            else if (radioButton6.Checked) serie = 3;

            if (!(String.IsNullOrEmpty(curso)) && (serie != 0))
            {
                label1.Text = "O aluno faz o curso " + curso + " e está na " + serie + "ª série";
            }
            else MessageBox.Show("Escolha um curso e uma série");
        }
    }
}
