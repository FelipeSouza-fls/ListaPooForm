namespace ListaPooForm5
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
            this.tbx_milha = new System.Windows.Forms.TextBox();
            this.lbl_quilometro = new System.Windows.Forms.Label();
            this.lbl_km = new System.Windows.Forms.Label();
            this.btn_resultado = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_milha
            // 
            this.tbx_milha.Location = new System.Drawing.Point(333, 168);
            this.tbx_milha.Name = "tbx_milha";
            this.tbx_milha.Size = new System.Drawing.Size(100, 20);
            this.tbx_milha.TabIndex = 1;
            // 
            // lbl_quilometro
            // 
            this.lbl_quilometro.AutoSize = true;
            this.lbl_quilometro.Location = new System.Drawing.Point(362, 152);
            this.lbl_quilometro.Name = "lbl_quilometro";
            this.lbl_quilometro.Size = new System.Drawing.Size(0, 13);
            this.lbl_quilometro.TabIndex = 3;
            // 
            // lbl_km
            // 
            this.lbl_km.AutoSize = true;
            this.lbl_km.Location = new System.Drawing.Point(240, 139);
            this.lbl_km.Name = "lbl_km";
            this.lbl_km.Size = new System.Drawing.Size(307, 13);
            this.lbl_km.TabIndex = 4;
            this.lbl_km.Text = "Digite o valor a ser convertido de milha marítma para Quilimetro:";
            this.lbl_km.Click += new System.EventHandler(this.lbl_km_Click);
            // 
            // btn_resultado
            // 
            this.btn_resultado.Location = new System.Drawing.Point(343, 208);
            this.btn_resultado.Name = "btn_resultado";
            this.btn_resultado.Size = new System.Drawing.Size(75, 23);
            this.btn_resultado.TabIndex = 5;
            this.btn_resultado.Text = "Converter";
            this.btn_resultado.UseVisualStyleBackColor = true;
            this.btn_resultado.Click += new System.EventHandler(this.btn_resultado_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(286, 255);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(58, 13);
            this.lbl_resultado.TabIndex = 6;
            this.lbl_resultado.Text = "Resultado:";
            this.lbl_resultado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_resultado);
            this.Controls.Add(this.lbl_km);
            this.Controls.Add(this.lbl_quilometro);
            this.Controls.Add(this.tbx_milha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbx_milha;
        private System.Windows.Forms.Label lbl_quilometro;
        private System.Windows.Forms.Label lbl_km;
        private System.Windows.Forms.Button btn_resultado;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

