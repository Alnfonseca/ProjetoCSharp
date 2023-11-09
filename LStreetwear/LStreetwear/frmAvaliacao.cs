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
            desabilitarInicial();
        }
        public void desabilitarInicial()
        {
            txtValorComissao.Enabled = false;
        }
        public void limparTudo()
        {
            txtNomeCliente.Clear();
            txtNomeFunc.Clear();
            txtValorCompra.Clear();
            txtValorComissao.Clear();
            txtValorTotal.Clear();
        }
        public int  avaliacao(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbAvaliacoes (codFunc, nome, dataCompra, qualidadeAtend, valorComiss, valortotal) values (@codFunc, @nome, @dataCompra, @qualidadeAtend, @valorComiss, @valortotal);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codFunc",MySqlDbType.Int32).Value = codigo;
            comm.Parameters.Add("@nome",MySqlDbType.VarChar, 100).Value = txtNomeFunc.Text;
            comm.Parameters.Add("@dataCompra", MySqlDbType.Date).Value = Convert.ToDateTime(dtpDataCompra.Text);
            comm.Parameters.Add("@qualidadeAtend",MySqlDbType.VarChar, 10).Value = cbbQualidadeAtend.Text;
            comm.Parameters.Add("@valorComiss",MySqlDbType.Int32).Value = txtValorComissao.Text;
            comm.Parameters.Add("@valorTotal",MySqlDbType.Int32).Value = txtValorTotal.Text;


            comm.Connection = Conexao.conectar();

            int res = comm.ExecuteNonQuery();
            Conexao.desconectar();
            return res;
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
            double total = 0,valor = 0, comissao = 0;
            int indice = 0;

            try
            {
                comissao = Convert.ToDouble(cbbQualidadeAtend.SelectedIndex);
                valor = Convert.ToDouble(txtValorCompra.Text);

               if(indice == 0)
                {
                    comissao = valor * 10 / 100;
                    total = comissao + valor;
                }
                if (indice == 1)
                {
                    comissao = valor * 8 / 100;
                    total = comissao + valor;
                }
                if(indice == 2)
                {
                    comissao = valor * 5 / 100;
                    total = comissao + valor;
                }
                if(indice == 3)
                {
                    comissao = valor * 2 / 100;
                    total = comissao + valor;
                }
                txtValorTotal.Text = total.ToString();
                txtValorComissao.Text = comissao.ToString();
                
            }
            catch (Exception)
            {

               MessageBox.Show("conta incorreta!", "mensagem do sistema");
            }
            
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limparTudo();
        }
    }
}
