﻿// biblioteca do csharp
/*
comentario de bloco
 */
using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

      
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //frmMenuPrincipal abrir = new frmMenuPrincipal();
            // abrir.Show();
            // this.Hide();

            // declaração  de variáveis 
            string Usuario, Senha;
            
            // iniciando as variáveis
            Usuario = txtUsuario.Text;
            Senha = txtSenha.Text;
        }
    }
}
