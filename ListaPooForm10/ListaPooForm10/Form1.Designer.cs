namespace ListaPooForm10
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
            this.lbl_peso = new System.Windows.Forms.Label();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.tbx_peso = new System.Windows.Forms.TextBox();
            this.tbx_altura = new System.Windows.Forms.TextBox();
            this.btn_resultado = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.lbl_ajuda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(315, 114);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(111, 13);
            this.lbl_peso.TabIndex = 0;
            this.lbl_peso.Text = "Digite o valor do Peso";
            this.lbl_peso.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(312, 177);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(114, 13);
            this.lbl_altura.TabIndex = 1;
            this.lbl_altura.Text = "Digite o valor da Altura";
            // 
            // tbx_peso
            // 
            this.tbx_peso.Location = new System.Drawing.Point(318, 139);
            this.tbx_peso.Name = "tbx_peso";
            this.tbx_peso.Size = new System.Drawing.Size(100, 20);
            this.tbx_peso.TabIndex = 2;
            // 
            // tbx_altura
            // 
            this.tbx_altura.Location = new System.Drawing.Point(318, 202);
            this.tbx_altura.Name = "tbx_altura";
            this.tbx_altura.Size = new System.Drawing.Size(100, 20);
            this.tbx_altura.TabIndex = 3;
            // 
            // btn_resultado
            // 
            this.btn_resultado.Location = new System.Drawing.Point(330, 241);
            this.btn_resultado.Name = "btn_resultado";
            this.btn_resultado.Size = new System.Drawing.Size(75, 23);
            this.btn_resultado.TabIndex = 4;
            this.btn_resultado.Text = "Calcular";
            this.btn_resultado.UseVisualStyleBackColor = true;
            this.btn_resultado.Click += new System.EventHandler(this.btn_resultado_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(338, 283);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(55, 13);
            this.lbl_resultado.TabIndex = 5;
            this.lbl_resultado.Text = "Resultado";
            this.lbl_resultado.UseWaitCursor = true;
            this.lbl_resultado.Visible = false;
            // 
            // lbl_ajuda
            // 
            this.lbl_ajuda.AutoSize = true;
            this.lbl_ajuda.Location = new System.Drawing.Point(327, 22);
            this.lbl_ajuda.Name = "lbl_ajuda";
            this.lbl_ajuda.Size = new System.Drawing.Size(84, 13);
            this.lbl_ajuda.TabIndex = 6;
            this.lbl_ajuda.Text = "Calcule seu IMC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_ajuda);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_resultado);
            this.Controls.Add(this.tbx_altura);
            this.Controls.Add(this.tbx_peso);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.lbl_peso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.TextBox tbx_peso;
        private System.Windows.Forms.TextBox tbx_altura;
        private System.Windows.Forms.Button btn_resultado;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label lbl_ajuda;
    }
}

