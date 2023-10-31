using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace LStreetwear
{
    public partial class frmAdministrador : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmAdministrador()
        {
            InitializeComponent();
            desabilitarInicial();
            codigoUsuario();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }

        
        private void frmAdministrador_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
        public void habilitar()
        {
            btnAdicionar.Enabled = true;
            btnAlterar.Enabled = true;
            btnPesquisar.Enabled = true;
            btnDeletar.Enabled = false;
            txtCodProd.Enabled = false;
            txtNomeProd.Enabled = true;
            txtMarca.Enabled = true;
            txtQuant.Enabled = true;
            txtTamanho.Enabled = true;
            txtPreco.Enabled = true;
        }
        public void desabilitarInicial()
        {
            btnNovo.Enabled = true;
            btnAdicionar.Enabled = false;
            btnAlterar.Enabled = false;
            btnPesquisar.Enabled = false;
            btnDeletar.Enabled = false;
            txtCodProd.Enabled = false;
            txtNomeProd.Enabled = false;
            txtMarca.Enabled = false;
            txtQuant.Enabled = false;
            txtTamanho.Enabled = false;
            txtPreco.Enabled = false;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitar();
            carregarCodigo();
        }
        public int adicionarProd(int codUsu)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbProdutos(nomeProd, marcaProd, quant, tamanho, dataRep, preco, codUsu) values (@nomeProd, @marcaProd, @quant, @tamanho, @dataRep, @preco, @codUsu);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codUsu", MySqlDbType.Int32, 11).Value = codUsu;
            comm.Parameters.Add("@nomeProd", MySqlDbType.VarChar, 100).Value = txtNomeProd.Text;
            comm.Parameters.Add("@marcaProd", MySqlDbType.VarChar, 100).Value = txtMarca.Text;
            comm.Parameters.Add("@quant", MySqlDbType.Int32).Value = txtQuant.Text;
            comm.Parameters.Add("@tamanho", MySqlDbType.VarChar, 2).Value = txtTamanho.Text;
            comm.Parameters.Add("@dataRep", MySqlDbType.Date).Value = Convert.ToDateTime(dtpDataRep.Text);
            comm.Parameters.Add("@preco", MySqlDbType.Decimal, 18).Value = txtPreco.Text;
            

            comm.Connection = Conexao.conectar();
            
            int res = comm.ExecuteNonQuery();
            

            
           
            Conexao.desconectar();

            return res;
        }
        public void codigoUsuario()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codUsu from tbLogin;";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();

            comm.Connection = Conexao.conectar();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodUsu.Text = Convert.ToString(DR.GetInt32(0));

            Conexao.desconectar();
        }
        public void limparCampos()
        {
            txtNomeProd.Clear();
            txtMarca.Clear();
            txtQuant.Clear();
            txtTamanho.Clear();
            txtPreco.Clear();
        }
        public void carregarCodigo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codProd+1 from tbProdutos order by codProd desc;";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();

            comm.Connection = Conexao.conectar();
            
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodProd.Text = Convert.ToString(DR.GetInt32(0));

            Conexao.conectar();
        }
        public int alterarProduto(int codUsu)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update set nomeProd = @nomeProd, marcaProd = @marcaProd, quant = @quant, tamanho = @tamanho, dataRep = @dataRep, preco = @preco, codUsu = @codUsu where codUsu = @codUsu;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codUsu", MySqlDbType.Int32, 11).Value = codUsu;
            comm.Parameters.Add("@nomeProd", MySqlDbType.VarChar, 100).Value = txtNomeProd.Text;
            comm.Parameters.Add("@marcaProd", MySqlDbType.VarChar, 100).Value = txtMarca.Text;
            comm.Parameters.Add("@quant", MySqlDbType.Int32).Value = txtQuant.Text;
            comm.Parameters.Add("@tamanho", MySqlDbType.VarChar, 2).Value = txtTamanho.Text;
            comm.Parameters.Add("@dataRep", MySqlDbType.Date).Value = Convert.ToDateTime(dtpDataRep.Text);
            comm.Parameters.Add("@preco", MySqlDbType.Decimal, 18).Value = txtPreco.Text;
            comm.Connection = Conexao.conectar();

            int res = comm.ExecuteNonQuery();
           
            return res;

            Conexao.desconectar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
            if (txtNomeProd.Text.Equals("") || txtMarca.Text.Equals("") || txtQuant.Text.Equals("")
                || txtTamanho.Text.Equals("") || txtPreco.Text.Equals(""))
            {
                MessageBox.Show("Preencha o campo que falta!", "Mensagem do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (adicionarProd(Convert.ToInt32(txtCodUsu.Text)) == 1)
                {
                    MessageBox.Show("Cadastrado com Sucesso!!", "Mensagem do Sistema",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            limparCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtCodUsu.Text) == 1)
            {
                MessageBox.Show("Produto alterado com Sucesso!!", "Mensagem do Sistema",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não Foi Possivel Alterar!!", "Mensagem do Sistema",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaProd abrir = new frmPesquisaProd();
            abrir.Show();
            this.Hide();
        }
    }
}
