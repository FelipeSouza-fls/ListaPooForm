namespace ListaPooForm3
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
            this.lbl_diagonal = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.tbx_diagonal = new System.Windows.Forms.TextBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_diagonal
            // 
            this.lbl_diagonal.AutoSize = true;
            this.lbl_diagonal.Location = new System.Drawing.Point(71, 130);
            this.lbl_diagonal.Name = "lbl_diagonal";
            this.lbl_diagonal.Size = new System.Drawing.Size(149, 13);
            this.lbl_diagonal.TabIndex = 0;
            this.lbl_diagonal.Text = "Digite a diagonal do quadrado";
            this.lbl_diagonal.Click += new System.EventHandler(this.lbl_diagonal_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(100, 191);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 2;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // tbx_diagonal
            // 
            this.tbx_diagonal.Location = new System.Drawing.Point(88, 156);
            this.tbx_diagonal.Name = "tbx_diagonal";
            this.tbx_diagonal.Size = new System.Drawing.Size(100, 20);
            this.tbx_diagonal.TabIndex = 3;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(204, 159);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(64, 13);
            this.lbl_resultado.TabIndex = 4;
            this.lbl_resultado.Text = "= Resultado";
            this.lbl_resultado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.tbx_diagonal);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.lbl_diagonal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_diagonal;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox tbx_diagonal;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

