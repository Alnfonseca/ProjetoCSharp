
namespace LStreetwear
{
    partial class frmPesquisaProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaProd));
            this.rdbCodProd = new System.Windows.Forms.RadioButton();
            this.rdbNomeProd = new System.Windows.Forms.RadioButton();
            this.rdbMarcaProd = new System.Windows.Forms.RadioButton();
            this.cbbMarcas = new System.Windows.Forms.ComboBox();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.ltbListProd = new System.Windows.Forms.ListBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbCodProd
            // 
            this.rdbCodProd.AutoSize = true;
            this.rdbCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCodProd.Location = new System.Drawing.Point(28, 23);
            this.rdbCodProd.Name = "rdbCodProd";
            this.rdbCodProd.Size = new System.Drawing.Size(152, 22);
            this.rdbCodProd.TabIndex = 0;
            this.rdbCodProd.TabStop = true;
            this.rdbCodProd.Text = "Código do Produto";
            this.rdbCodProd.UseVisualStyleBackColor = true;
            this.rdbCodProd.CheckedChanged += new System.EventHandler(this.rbdCodProd_CheckedChanged);
            // 
            // rdbNomeProd
            // 
            this.rdbNomeProd.AutoSize = true;
            this.rdbNomeProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNomeProd.Location = new System.Drawing.Point(223, 23);
            this.rdbNomeProd.Name = "rdbNomeProd";
            this.rdbNomeProd.Size = new System.Drawing.Size(145, 22);
            this.rdbNomeProd.TabIndex = 1;
            this.rdbNomeProd.TabStop = true;
            this.rdbNomeProd.Text = "Nome do Produto";
            this.rdbNomeProd.UseVisualStyleBackColor = true;
            // 
            // rdbMarcaProd
            // 
            this.rdbMarcaProd.AutoSize = true;
            this.rdbMarcaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMarcaProd.Location = new System.Drawing.Point(422, 23);
            this.rdbMarcaProd.Name = "rdbMarcaProd";
            this.rdbMarcaProd.Size = new System.Drawing.Size(146, 22);
            this.rdbMarcaProd.TabIndex = 2;
            this.rdbMarcaProd.TabStop = true;
            this.rdbMarcaProd.Text = "Marca do Produto";
            this.rdbMarcaProd.UseVisualStyleBackColor = true;
            // 
            // cbbMarcas
            // 
            this.cbbMarcas.FormattingEnabled = true;
            this.cbbMarcas.Location = new System.Drawing.Point(28, 73);
            this.cbbMarcas.Name = "cbbMarcas";
            this.cbbMarcas.Size = new System.Drawing.Size(540, 21);
            this.cbbMarcas.TabIndex = 3;
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Location = new System.Drawing.Point(28, 128);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(540, 20);
            this.txtNomeProd.TabIndex = 4;
            // 
            // ltbListProd
            // 
            this.ltbListProd.FormattingEnabled = true;
            this.ltbListProd.Location = new System.Drawing.Point(28, 176);
            this.ltbListProd.Name = "ltbListProd";
            this.ltbListProd.Size = new System.Drawing.Size(540, 134);
            this.ltbListProd.TabIndex = 5;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(641, 35);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(112, 96);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(641, 159);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 96);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(641, 276);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(112, 34);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmPesquisaProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.ltbListProd);
            this.Controls.Add(this.txtNomeProd);
            this.Controls.Add(this.cbbMarcas);
            this.Controls.Add(this.rdbMarcaProd);
            this.Controls.Add(this.rdbNomeProd);
            this.Controls.Add(this.rdbCodProd);
            this.Name = "frmPesquisaProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPesquisaProd";
            this.Load += new System.EventHandler(this.frmPesquisaProd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbCodProd;
        private System.Windows.Forms.RadioButton rdbNomeProd;
        private System.Windows.Forms.RadioButton rdbMarcaProd;
        private System.Windows.Forms.ComboBox cbbMarcas;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.ListBox ltbListProd;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
    }
}