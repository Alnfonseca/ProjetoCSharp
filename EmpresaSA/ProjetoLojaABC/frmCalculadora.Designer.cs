
namespace ProjetoLojaABC
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.gpbOperador = new System.Windows.Forms.GroupBox();
            this.lblVariavel1 = new System.Windows.Forms.Label();
            this.lblVariável2 = new System.Windows.Forms.Label();
            this.rbtAdicao = new System.Windows.Forms.RadioButton();
            this.rbtSubtracao = new System.Windows.Forms.RadioButton();
            this.rbtMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rbtDivisao = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtVariavel1 = new System.Windows.Forms.TextBox();
            this.txtVariavel2 = new System.Windows.Forms.TextBox();
            this.gpbOperador.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbOperador
            // 
            this.gpbOperador.Controls.Add(this.rbtSubtracao);
            this.gpbOperador.Controls.Add(this.rbtMultiplicacao);
            this.gpbOperador.Controls.Add(this.rbtDivisao);
            this.gpbOperador.Controls.Add(this.rbtAdicao);
            this.gpbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOperador.Location = new System.Drawing.Point(198, 281);
            this.gpbOperador.Name = "gpbOperador";
            this.gpbOperador.Size = new System.Drawing.Size(265, 199);
            this.gpbOperador.TabIndex = 3;
            this.gpbOperador.TabStop = false;
            this.gpbOperador.Text = "Operador";
            // 
            // lblVariavel1
            // 
            this.lblVariavel1.AutoSize = true;
            this.lblVariavel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariavel1.Location = new System.Drawing.Point(45, 57);
            this.lblVariavel1.Name = "lblVariavel1";
            this.lblVariavel1.Size = new System.Drawing.Size(71, 18);
            this.lblVariavel1.TabIndex = 1;
            this.lblVariavel1.Text = "Variável 1";
            // 
            // lblVariável2
            // 
            this.lblVariável2.AutoSize = true;
            this.lblVariável2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariável2.Location = new System.Drawing.Point(45, 104);
            this.lblVariável2.Name = "lblVariável2";
            this.lblVariável2.Size = new System.Drawing.Size(71, 18);
            this.lblVariável2.TabIndex = 2;
            this.lblVariável2.Text = "Variável 2";
            // 
            // rbtAdicao
            // 
            this.rbtAdicao.AutoSize = true;
            this.rbtAdicao.Location = new System.Drawing.Point(6, 35);
            this.rbtAdicao.Name = "rbtAdicao";
            this.rbtAdicao.Size = new System.Drawing.Size(94, 22);
            this.rbtAdicao.TabIndex = 3;
            this.rbtAdicao.TabStop = true;
            this.rbtAdicao.Text = "Adição (+)";
            this.rbtAdicao.UseVisualStyleBackColor = true;
            // 
            // rbtSubtracao
            // 
            this.rbtSubtracao.AutoSize = true;
            this.rbtSubtracao.Location = new System.Drawing.Point(6, 75);
            this.rbtSubtracao.Name = "rbtSubtracao";
            this.rbtSubtracao.Size = new System.Drawing.Size(113, 22);
            this.rbtSubtracao.TabIndex = 4;
            this.rbtSubtracao.TabStop = true;
            this.rbtSubtracao.Text = "Subtração (-)";
            this.rbtSubtracao.UseVisualStyleBackColor = true;
            // 
            // rbtMultiplicacao
            // 
            this.rbtMultiplicacao.AutoSize = true;
            this.rbtMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMultiplicacao.Location = new System.Drawing.Point(6, 121);
            this.rbtMultiplicacao.Name = "rbtMultiplicacao";
            this.rbtMultiplicacao.Size = new System.Drawing.Size(132, 22);
            this.rbtMultiplicacao.TabIndex = 5;
            this.rbtMultiplicacao.TabStop = true;
            this.rbtMultiplicacao.Text = "Multiplicação (*)";
            this.rbtMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rbtDivisao
            // 
            this.rbtDivisao.AutoSize = true;
            this.rbtDivisao.Location = new System.Drawing.Point(7, 163);
            this.rbtDivisao.Name = "rbtDivisao";
            this.rbtDivisao.Size = new System.Drawing.Size(93, 22);
            this.rbtDivisao.TabIndex = 6;
            this.rbtDivisao.TabStop = true;
            this.rbtDivisao.Text = "Divisão (/)";
            this.rbtDivisao.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(602, 300);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(149, 49);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(602, 375);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(149, 49);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(602, 461);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(149, 49);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(599, 92);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(75, 18);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(590, 110);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(140, 51);
            this.lblTotal.TabIndex = 7;
            // 
            // txtVariavel1
            // 
            this.txtVariavel1.Location = new System.Drawing.Point(140, 57);
            this.txtVariavel1.Name = "txtVariavel1";
            this.txtVariavel1.Size = new System.Drawing.Size(100, 20);
            this.txtVariavel1.TabIndex = 1;
            // 
            // txtVariavel2
            // 
            this.txtVariavel2.Location = new System.Drawing.Point(140, 105);
            this.txtVariavel2.Name = "txtVariavel2";
            this.txtVariavel2.Size = new System.Drawing.Size(100, 20);
            this.txtVariavel2.TabIndex = 2;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtVariavel2);
            this.Controls.Add(this.txtVariavel1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblVariável2);
            this.Controls.Add(this.lblVariavel1);
            this.Controls.Add(this.gpbOperador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.gpbOperador.ResumeLayout(false);
            this.gpbOperador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbOperador;
        private System.Windows.Forms.RadioButton rbtSubtracao;
        private System.Windows.Forms.RadioButton rbtMultiplicacao;
        private System.Windows.Forms.RadioButton rbtDivisao;
        private System.Windows.Forms.RadioButton rbtAdicao;
        private System.Windows.Forms.Label lblVariavel1;
        private System.Windows.Forms.Label lblVariável2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtVariavel1;
        private System.Windows.Forms.TextBox txtVariavel2;
    }
}