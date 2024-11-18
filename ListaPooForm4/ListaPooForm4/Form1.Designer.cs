namespace ListaPooForm4
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
            this.tbx_base = new System.Windows.Forms.TextBox();
            this.tbx_altura = new System.Windows.Forms.TextBox();
            this.lbl_base = new System.Windows.Forms.Label();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_resultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_base
            // 
            this.tbx_base.Location = new System.Drawing.Point(92, 131);
            this.tbx_base.Name = "tbx_base";
            this.tbx_base.Size = new System.Drawing.Size(100, 20);
            this.tbx_base.TabIndex = 0;
            // 
            // tbx_altura
            // 
            this.tbx_altura.Location = new System.Drawing.Point(92, 177);
            this.tbx_altura.Name = "tbx_altura";
            this.tbx_altura.Size = new System.Drawing.Size(100, 20);
            this.tbx_altura.TabIndex = 1;
            // 
            // lbl_base
            // 
            this.lbl_base.AutoSize = true;
            this.lbl_base.Location = new System.Drawing.Point(78, 105);
            this.lbl_base.Name = "lbl_base";
            this.lbl_base.Size = new System.Drawing.Size(130, 13);
            this.lbl_base.TabIndex = 2;
            this.lbl_base.Text = "Digite a base do triangulo:";
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(75, 161);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(133, 13);
            this.lbl_altura.TabIndex = 3;
            this.lbl_altura.Text = "Digite a altura do triangulo:";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(225, 161);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(55, 13);
            this.lbl_resultado.TabIndex = 4;
            this.lbl_resultado.Text = "Resultado";
            this.lbl_resultado.Visible = false;
            // 
            // btn_resultado
            // 
            this.btn_resultado.Location = new System.Drawing.Point(103, 213);
            this.btn_resultado.Name = "btn_resultado";
            this.btn_resultado.Size = new System.Drawing.Size(75, 23);
            this.btn_resultado.TabIndex = 5;
            this.btn_resultado.Text = "Calcular";
            this.btn_resultado.UseVisualStyleBackColor = true;
            this.btn_resultado.Click += new System.EventHandler(this.btn_resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_resultado);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.lbl_base);
            this.Controls.Add(this.tbx_altura);
            this.Controls.Add(this.tbx_base);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_base;
        private System.Windows.Forms.TextBox tbx_altura;
        private System.Windows.Forms.Label lbl_base;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btn_resultado;
    }
}

