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
    public partial class frmPesquisaProd : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmPesquisaProd()
        {
            InitializeComponent();
            desabilitarInicial();
        }

        private void frmPesquisaProd_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
        public void desabilitarInicial()
        {
            cbbMarcas.Enabled = false;
            txtNomeProd.Enabled = false;
            ltbListProd.Enabled = false;
            btnPesquisar.Enabled = false;
            btnLimpar.Enabled = false;
            rdbCodProd.Checked = false;
            rdbMarcaProd.Checked = false;
            rdbNomeProd.Checked = false;
            //arrumar
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmAdministrador abrir = new frmAdministrador();
            abrir.Show();
            this.Hide();

        }
        public void habilitar()
        {
            cbbMarcas.Enabled = true;
            txtNomeProd.Enabled = true;
            ltbListProd.Enabled = true;
            btnPesquisar.Enabled = true;
            btnLimpar.Enabled = true;
        }
        public void pesquisaCodigo(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codUsu from tbProdutos where codProd = @codProd;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codUsu",MySqlDbType.Int32).Value = codigo;
            comm.Connection = Conexao.conectar();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            ltbListProd.Items.Add(DR.GetInt32(0));


            Conexao.desconectar();
        }

        private void rbdCodProd_CheckedChanged(object sender, EventArgs e)
        {
            habilitar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
           //arrumar
        }
    }
    
}
