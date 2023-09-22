namespace AppExemplo4
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
            this.btCadastrarPessoas = new System.Windows.Forms.Button();
            this.btConsultarPessoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadastrarPessoas
            // 
            this.btCadastrarPessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarPessoas.Location = new System.Drawing.Point(309, 30);
            this.btCadastrarPessoas.Name = "btCadastrarPessoas";
            this.btCadastrarPessoas.Size = new System.Drawing.Size(174, 51);
            this.btCadastrarPessoas.TabIndex = 0;
            this.btCadastrarPessoas.Text = "Cadastrar Pessoas";
            this.btCadastrarPessoas.UseVisualStyleBackColor = true;
            this.btCadastrarPessoas.Click += new System.EventHandler(this.btCadastrarPessoas_Click);
            // 
            // btConsultarPessoa
            // 
            this.btConsultarPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarPessoa.Location = new System.Drawing.Point(309, 107);
            this.btConsultarPessoa.Name = "btConsultarPessoa";
            this.btConsultarPessoa.Size = new System.Drawing.Size(174, 51);
            this.btConsultarPessoa.TabIndex = 1;
            this.btConsultarPessoa.Text = "Consultar Pessoas";
            this.btConsultarPessoa.UseVisualStyleBackColor = true;
            this.btConsultarPessoa.Click += new System.EventHandler(this.btConsultarPessoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btConsultarPessoa);
            this.Controls.Add(this.btCadastrarPessoas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCadastrarPessoas;
        private System.Windows.Forms.Button btConsultarPessoa;
    }
}

