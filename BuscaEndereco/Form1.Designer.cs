namespace BuscaEndereco
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCEP = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbCompl = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o CEP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Complemento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Bairro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Estado:";
            // 
            // tbCEP
            // 
            this.tbCEP.Location = new System.Drawing.Point(79, 105);
            this.tbCEP.Name = "tbCEP";
            this.tbCEP.Size = new System.Drawing.Size(100, 20);
            this.tbCEP.TabIndex = 3;
            this.tbCEP.Leave += new System.EventHandler(this.tbCEP_Leave);
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(79, 170);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(341, 20);
            this.tbEndereco.TabIndex = 3;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(460, 170);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(100, 20);
            this.tbNumero.TabIndex = 3;
            // 
            // tbCompl
            // 
            this.tbCompl.Location = new System.Drawing.Point(585, 170);
            this.tbCompl.Name = "tbCompl";
            this.tbCompl.Size = new System.Drawing.Size(203, 20);
            this.tbCompl.TabIndex = 3;
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(79, 247);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(203, 20);
            this.tbBairro.TabIndex = 3;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(79, 325);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(203, 20);
            this.tbCidade.TabIndex = 3;
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(79, 394);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(53, 20);
            this.tbEstado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.tbEstado);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.tbCompl);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.tbCEP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Busca de Endereço";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCEP;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbCompl;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbEstado;
    }
}

