﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLojaABC
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // declarando variavel para receber o valor do botão pressionado

            MessageBox.Show("Deseja Sair?", "Mensagem do Sistema", 
                MessageBoxButtons.YesNoCancel, 
                MessageBoxIcon.Information, 
                MessageBoxDefaultButton.Button3);
            
                Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado = 0;
            num1 = Convert.ToDouble (txtVariavel1.Text);
            num2 = Convert.ToDouble(txtVariavel2.Text);
            

            if (rbtAdicao.Checked)
            {
            resultado = num1 + num2;
            }
            if (rbtSubtracao.Checked)
            {
                resultado = num1 - num2;
            }
            if (rbtMultiplicacao.Checked)
            {
                resultado = num1 * num2;
            }
            if (rbtDivisao.Checked)
            {
                if (num2 == 0)
                {
                    MessageBox.Show("Impossivel dividir por 0!", "Mensagem do Sistema",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error,
               MessageBoxDefaultButton.Button1);
                }
                resultado = num1 / num2;
            }
            lblTotal.Text = resultado.ToString();
        }
    }
}
