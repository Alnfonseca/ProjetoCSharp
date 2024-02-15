
namespace Datagreadview
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcCadastro = new System.Windows.Forms.TabControl();
            this.Vendas = new System.Windows.Forms.TabPage();
            this.Cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clientes = new System.Windows.Forms.TabPage();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblAutorizo = new System.Windows.Forms.Label();
            this.cbxAutoriza = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoriza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcCadastro.SuspendLayout();
            this.Vendas.SuspendLayout();
            this.Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcCadastro
            // 
            this.tbcCadastro.Controls.Add(this.Clientes);
            this.tbcCadastro.Controls.Add(this.Vendas);
            this.tbcCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcCadastro.Location = new System.Drawing.Point(191, 94);
            this.tbcCadastro.Name = "tbcCadastro";
            this.tbcCadastro.SelectedIndex = 0;
            this.tbcCadastro.Size = new System.Drawing.Size(620, 383);
            this.tbcCadastro.TabIndex = 0;
            // 
            // Vendas
            // 
            this.Vendas.BackColor = System.Drawing.Color.Wheat;
            this.Vendas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Vendas.Controls.Add(this.dgvDados);
            this.Vendas.Location = new System.Drawing.Point(4, 27);
            this.Vendas.Name = "Vendas";
            this.Vendas.Size = new System.Drawing.Size(612, 352);
            this.Vendas.TabIndex = 2;
            this.Vendas.Text = "Consulta";
            // 
            // Cadastro
            // 
            this.Cadastro.HeaderText = "Nome";
            this.Cadastro.MaxInputLength = 100;
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Width = 250;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.MaxInputLength = 10;
            this.codigo.Name = "codigo";
            // 
            // Clientes
            // 
            this.Clientes.BackColor = System.Drawing.Color.IndianRed;
            this.Clientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Clientes.Controls.Add(this.btnLimpar);
            this.Clientes.Controls.Add(this.btnCadastrar);
            this.Clientes.Controls.Add(this.cbxAutoriza);
            this.Clientes.Controls.Add(this.lblAutorizo);
            this.Clientes.Controls.Add(this.txtNome);
            this.Clientes.Controls.Add(this.lblNome);
            this.Clientes.Controls.Add(this.txtCodigo);
            this.Clientes.Controls.Add(this.lblCodigo);
            this.Clientes.Location = new System.Drawing.Point(4, 27);
            this.Clientes.Name = "Clientes";
            this.Clientes.Padding = new System.Windows.Forms.Padding(3);
            this.Clientes.Size = new System.Drawing.Size(612, 352);
            this.Clientes.TabIndex = 0;
            this.Clientes.Text = "Cadastro";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(37, 50);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(37, 84);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(74, 24);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(37, 127);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(37, 153);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(193, 24);
            this.txtNome.TabIndex = 1;
            // 
            // lblAutorizo
            // 
            this.lblAutorizo.AutoSize = true;
            this.lblAutorizo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorizo.Location = new System.Drawing.Point(35, 237);
            this.lblAutorizo.Name = "lblAutorizo";
            this.lblAutorizo.Size = new System.Drawing.Size(251, 20);
            this.lblAutorizo.TabIndex = 4;
            this.lblAutorizo.Text = "Autoriza o envio de propagandas?";
            // 
            // cbxAutoriza
            // 
            this.cbxAutoriza.AutoSize = true;
            this.cbxAutoriza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAutoriza.Location = new System.Drawing.Point(35, 274);
            this.cbxAutoriza.Name = "cbxAutoriza";
            this.cbxAutoriza.Size = new System.Drawing.Size(81, 22);
            this.cbxAutoriza.TabIndex = 2;
            this.cbxAutoriza.Text = "Autoriza";
            this.cbxAutoriza.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(323, 272);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(91, 34);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(443, 274);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(91, 34);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.nome,
            this.autoriza});
            this.dgvDados.Location = new System.Drawing.Point(64, 82);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(494, 231);
            this.dgvDados.TabIndex = 0;
            // 
            // cod
            // 
            this.cod.HeaderText = "Código";
            this.cod.Name = "cod";
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 250;
            // 
            // autoriza
            // 
            this.autoriza.HeaderText = "Autoriza envio de propagandas?";
            this.autoriza.Name = "autoriza";
            this.autoriza.Width = 110;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 629);
            this.Controls.Add(this.tbcCadastro);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tbcCadastro.ResumeLayout(false);
            this.Vendas.ResumeLayout(false);
            this.Clientes.ResumeLayout(false);
            this.Clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCadastro;
        private System.Windows.Forms.TabPage Vendas;
        private System.Windows.Forms.TabPage Clientes;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.CheckBox cbxAutoriza;
        private System.Windows.Forms.Label lblAutorizo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoriza;
    }
}