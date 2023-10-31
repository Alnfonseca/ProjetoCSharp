
namespace LStreetwear
{
    partial class frmAvaliacao
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
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.lblQualidadeAtend = new System.Windows.Forms.Label();
            this.lblValorComissao = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.txtValorComissao = new System.Windows.Forms.TextBox();
            this.cbbQualidadeAtend = new System.Windows.Forms.ComboBox();
            this.btnCalcularComiss = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDataCompra = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(107, 30);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(119, 18);
            this.lblNomeCliente.TabIndex = 0;
            this.lblNomeCliente.Text = "Nome do Cliente";
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFunc.Location = new System.Drawing.Point(107, 84);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(152, 18);
            this.lblNomeFunc.TabIndex = 1;
            this.lblNomeFunc.Text = "Nome do Funcionário";
            // 
            // lblQualidadeAtend
            // 
            this.lblQualidadeAtend.AutoSize = true;
            this.lblQualidadeAtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualidadeAtend.Location = new System.Drawing.Point(134, 229);
            this.lblQualidadeAtend.Name = "lblQualidadeAtend";
            this.lblQualidadeAtend.Size = new System.Drawing.Size(181, 18);
            this.lblQualidadeAtend.TabIndex = 2;
            this.lblQualidadeAtend.Text = "Qualidade do Atendimento";
            // 
            // lblValorComissao
            // 
            this.lblValorComissao.AutoSize = true;
            this.lblValorComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorComissao.Location = new System.Drawing.Point(180, 332);
            this.lblValorComissao.Name = "lblValorComissao";
            this.lblValorComissao.Size = new System.Drawing.Size(135, 18);
            this.lblValorComissao.TabIndex = 3;
            this.lblValorComissao.Text = "Valor da Comissão";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(294, 35);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(422, 20);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(294, 85);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(422, 20);
            this.txtNomeFunc.TabIndex = 2;
            // 
            // txtValorComissao
            // 
            this.txtValorComissao.Location = new System.Drawing.Point(367, 337);
            this.txtValorComissao.Name = "txtValorComissao";
            this.txtValorComissao.Size = new System.Drawing.Size(209, 20);
            this.txtValorComissao.TabIndex = 5;
            // 
            // cbbQualidadeAtend
            // 
            this.cbbQualidadeAtend.FormattingEnabled = true;
            this.cbbQualidadeAtend.ItemHeight = 13;
            this.cbbQualidadeAtend.Items.AddRange(new object[] {
            "Excelente  - 10%",
            "Ótimo - 8%",
            "Bom - 5%",
            "Ruim - 2%"});
            this.cbbQualidadeAtend.Location = new System.Drawing.Point(367, 226);
            this.cbbQualidadeAtend.Name = "cbbQualidadeAtend";
            this.cbbQualidadeAtend.Size = new System.Drawing.Size(209, 21);
            this.cbbQualidadeAtend.TabIndex = 4;
            // 
            // btnCalcularComiss
            // 
            this.btnCalcularComiss.Location = new System.Drawing.Point(367, 373);
            this.btnCalcularComiss.Name = "btnCalcularComiss";
            this.btnCalcularComiss.Size = new System.Drawing.Size(206, 54);
            this.btnCalcularComiss.TabIndex = 7;
            this.btnCalcularComiss.Text = "Calcular Comissão";
            this.btnCalcularComiss.UseVisualStyleBackColor = true;
            this.btnCalcularComiss.Click += new System.EventHandler(this.btnCalcularComiss_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(665, 387);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(111, 40);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(294, 131);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(80, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lblDataCompra
            // 
            this.lblDataCompra.AutoSize = true;
            this.lblDataCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCompra.Location = new System.Drawing.Point(107, 131);
            this.lblDataCompra.Name = "lblDataCompra";
            this.lblDataCompra.Size = new System.Drawing.Size(117, 18);
            this.lblDataCompra.TabIndex = 19;
            this.lblDataCompra.Text = "Data da Compra";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(367, 283);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(209, 20);
            this.txtValorTotal.TabIndex = 21;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(180, 278);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(79, 18);
            this.lblValorTotal.TabIndex = 20;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // frmAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDataCompra);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCalcularComiss);
            this.Controls.Add(this.cbbQualidadeAtend);
            this.Controls.Add(this.txtValorComissao);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.lblValorComissao);
            this.Controls.Add(this.lblQualidadeAtend);
            this.Controls.Add(this.lblNomeFunc);
            this.Controls.Add(this.lblNomeCliente);
            this.Name = "frmAvaliacao";
            this.Text = "LStreetwear - Avaliação do Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Label lblQualidadeAtend;
        private System.Windows.Forms.Label lblValorComissao;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.TextBox txtValorComissao;
        private System.Windows.Forms.ComboBox cbbQualidadeAtend;
        private System.Windows.Forms.Button btnCalcularComiss;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDataCompra;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
    }
}