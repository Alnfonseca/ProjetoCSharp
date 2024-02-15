using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datagreadview
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nome = txtNome.Text;
            string autoriza = "Não";
            if (cbxAutoriza.Checked)
            {
                autoriza = "Sim";
            }
            dgvDados.Rows.Add(codigo, nome, autoriza);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNome.Clear();
            cbxAutoriza.Checked = false;
        }
    }
}
