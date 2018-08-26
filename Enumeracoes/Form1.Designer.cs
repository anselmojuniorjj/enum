namespace Enumeracoes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Cima = new System.Windows.Forms.Button();
            this.btn_Direita = new System.Windows.Forms.Button();
            this.btn_Baixo = new System.Windows.Forms.Button();
            this.btn_Esquerda = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cima
            // 
            this.btn_Cima.Location = new System.Drawing.Point(107, 26);
            this.btn_Cima.Name = "btn_Cima";
            this.btn_Cima.Size = new System.Drawing.Size(75, 23);
            this.btn_Cima.TabIndex = 0;
            this.btn_Cima.Text = "Cima";
            this.btn_Cima.UseVisualStyleBackColor = true;
            this.btn_Cima.Click += new System.EventHandler(this.btn_Cima_Click);
            // 
            // btn_Direita
            // 
            this.btn_Direita.Location = new System.Drawing.Point(188, 68);
            this.btn_Direita.Name = "btn_Direita";
            this.btn_Direita.Size = new System.Drawing.Size(75, 23);
            this.btn_Direita.TabIndex = 1;
            this.btn_Direita.Text = "Direita";
            this.btn_Direita.UseVisualStyleBackColor = true;
            this.btn_Direita.Click += new System.EventHandler(this.btn_Direita_Click);
            // 
            // btn_Baixo
            // 
            this.btn_Baixo.Location = new System.Drawing.Point(107, 111);
            this.btn_Baixo.Name = "btn_Baixo";
            this.btn_Baixo.Size = new System.Drawing.Size(75, 23);
            this.btn_Baixo.TabIndex = 2;
            this.btn_Baixo.Text = "Baixo";
            this.btn_Baixo.UseVisualStyleBackColor = true;
            this.btn_Baixo.Click += new System.EventHandler(this.btn_Baixo_Click);
            // 
            // btn_Esquerda
            // 
            this.btn_Esquerda.Location = new System.Drawing.Point(25, 68);
            this.btn_Esquerda.Name = "btn_Esquerda";
            this.btn_Esquerda.Size = new System.Drawing.Size(75, 23);
            this.btn_Esquerda.TabIndex = 3;
            this.btn_Esquerda.Text = "Esquerda";
            this.btn_Esquerda.UseVisualStyleBackColor = true;
            this.btn_Esquerda.Click += new System.EventHandler(this.btn_Esquerda_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(12, 201);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 4;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 236);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Esquerda);
            this.Controls.Add(this.btn_Baixo);
            this.Controls.Add(this.btn_Direita);
            this.Controls.Add(this.btn_Cima);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cima;
        private System.Windows.Forms.Button btn_Direita;
        private System.Windows.Forms.Button btn_Baixo;
        private System.Windows.Forms.Button btn_Esquerda;
        private System.Windows.Forms.Button btn_Sair;
    }
}

