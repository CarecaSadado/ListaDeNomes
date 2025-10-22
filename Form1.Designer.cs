namespace jubileu
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
            this.valor = new System.Windows.Forms.TextBox();
            this.botao = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(74, 39);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(223, 20);
            this.valor.TabIndex = 0;
         
            // 
            // botao
            // 
            this.botao.Location = new System.Drawing.Point(137, 65);
            this.botao.Name = "botao";
            this.botao.Size = new System.Drawing.Size(110, 50);
            this.botao.TabIndex = 1;
            this.botao.Text = "Colocar na lista";
            this.botao.UseVisualStyleBackColor = true;
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(91, 146);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(206, 186);
            this.Lista.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Informe um nome";
            // 
            // butao
            // 
            this.butao.Location = new System.Drawing.Point(91, 348);
            this.butao.Name = "butao";
            this.butao.Size = new System.Drawing.Size(206, 90);
            this.butao.TabIndex = 4;
            this.butao.Text = "apagar";
            this.butao.UseVisualStyleBackColor = true;
            this.butao.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 524);
            this.Controls.Add(this.butao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.botao);
            this.Controls.Add(this.valor);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.Button botao;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butao;
    }
}

