namespace ListaPooForm6
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
            this.tbx_dolar = new System.Windows.Forms.TextBox();
            this.lbl_dolar = new System.Windows.Forms.Label();
            this.btn_resultado = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_dolar
            // 
            this.tbx_dolar.Location = new System.Drawing.Point(316, 185);
            this.tbx_dolar.Name = "tbx_dolar";
            this.tbx_dolar.Size = new System.Drawing.Size(100, 20);
            this.tbx_dolar.TabIndex = 0;
            // 
            // lbl_dolar
            // 
            this.lbl_dolar.AutoSize = true;
            this.lbl_dolar.Location = new System.Drawing.Point(222, 158);
            this.lbl_dolar.Name = "lbl_dolar";
            this.lbl_dolar.Size = new System.Drawing.Size(317, 13);
            this.lbl_dolar.TabIndex = 1;
            this.lbl_dolar.Text = "Sabendo que 1 dolar é 5,79 Reais. Insira o valor a ser convertido:";
            // 
            // btn_resultado
            // 
            this.btn_resultado.Location = new System.Drawing.Point(328, 221);
            this.btn_resultado.Name = "btn_resultado";
            this.btn_resultado.Size = new System.Drawing.Size(75, 23);
            this.btn_resultado.TabIndex = 2;
            this.btn_resultado.Text = "Converter";
            this.btn_resultado.UseVisualStyleBackColor = true;
            this.btn_resultado.Click += new System.EventHandler(this.btn_resultado_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(258, 259);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(104, 13);
            this.lbl_resultado.TabIndex = 3;
            this.lbl_resultado.Text = "o valor convertido é:";
            this.lbl_resultado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_resultado);
            this.Controls.Add(this.lbl_dolar);
            this.Controls.Add(this.tbx_dolar);
            this.Name = "Form1";
            this.Text = "1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_dolar;
        private System.Windows.Forms.Label lbl_dolar;
        private System.Windows.Forms.Button btn_resultado;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

