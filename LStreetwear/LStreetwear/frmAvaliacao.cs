using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LStreetwear
{
    public partial class frmAvaliacao : Form
    {
        public frmAvaliacao()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }

        private void btnCalcularComiss_Click(object sender, EventArgs e)
        {
            calcularComissao();
        }
        //calculando comissão
        public void calcularComissao()
        {
            double comissao, total;

            try
            {
                comissao = Convert.ToDouble(txtValorComissao);
                total = Convert.ToDouble(txtValorTotal);

                if(cbbQualidadeAtend.SelectedItem == "Excelente - 10%")
                {
                    comissao = total*0.10/100;
                   
                }

            }
            catch (Exception)
            {

               MessageBox.Show("conta incorreta!", "mensagem do sistema");
            }
            // arrumar
            
          
        }
    }
}
