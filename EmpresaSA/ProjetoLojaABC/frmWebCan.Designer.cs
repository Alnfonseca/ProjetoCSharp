﻿
namespace ProjetoLojaABC
{
    partial class frmWebCan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWebCan));
            this.pctCapturaImagem = new System.Windows.Forms.PictureBox();
            this.cbbDispositivo = new System.Windows.Forms.ComboBox();
            this.lblDispositivo = new System.Windows.Forms.Label();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.sfdSalvarImagem = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAbrir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctCapturaImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pctCapturaImagem
            // 
            this.pctCapturaImagem.Location = new System.Drawing.Point(76, 24);
            this.pctCapturaImagem.Name = "pctCapturaImagem";
            this.pctCapturaImagem.Size = new System.Drawing.Size(429, 281);
            this.pctCapturaImagem.TabIndex = 0;
            this.pctCapturaImagem.TabStop = false;
            // 
            // cbbDispositivo
            // 
            this.cbbDispositivo.FormattingEnabled = true;
            this.cbbDispositivo.Location = new System.Drawing.Point(35, 351);
            this.cbbDispositivo.Name = "cbbDispositivo";
            this.cbbDispositivo.Size = new System.Drawing.Size(234, 21);
            this.cbbDispositivo.TabIndex = 1;
            // 
            // lblDispositivo
            // 
            this.lblDispositivo.AutoSize = true;
            this.lblDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispositivo.Location = new System.Drawing.Point(32, 321);
            this.lblDispositivo.Name = "lblDispositivo";
            this.lblDispositivo.Size = new System.Drawing.Size(81, 18);
            this.lblDispositivo.TabIndex = 2;
            this.lblDispositivo.Text = "Dispositivo";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.Location = new System.Drawing.Point(593, 61);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(133, 52);
            this.btnCapturar.TabIndex = 3;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(593, 169);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(133, 52);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(631, 266);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(95, 39);
            this.btnAbrir.TabIndex = 5;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // frmWebCan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.lblDispositivo);
            this.Controls.Add(this.cbbDispositivo);
            this.Controls.Add(this.pctCapturaImagem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWebCan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebCan";
            this.Load += new System.EventHandler(this.frmWebCan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctCapturaImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctCapturaImagem;
        private System.Windows.Forms.ComboBox cbbDispositivo;
        private System.Windows.Forms.Label lblDispositivo;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.SaveFileDialog sfdSalvarImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAbrir;
    }
}