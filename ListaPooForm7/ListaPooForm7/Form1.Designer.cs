namespace ListaPooForm7
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
            this.tbx_val1 = new System.Windows.Forms.TextBox();
            this.tbx_val2 = new System.Windows.Forms.TextBox();
            this.lbl_val1 = new System.Windows.Forms.Label();
            this.lbl_val2 = new System.Windows.Forms.Label();
            this.btn_resultado = new System.Windows.Forms.Button();
            this.lbl_Explicação = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_val1
            // 
            this.tbx_val1.Location = new System.Drawing.Point(350, 168);
            this.tbx_val1.Name = "tbx_val1";
            this.tbx_val1.Size = new System.Drawing.Size(100, 20);
            this.tbx_val1.TabIndex = 0;
            // 
            // tbx_val2
            // 
            this.tbx_val2.Location = new System.Drawing.Point(350, 224);
            this.tbx_val2.Name = "tbx_val2";
            this.tbx_val2.Size = new System.Drawing.Size(100, 20);
            this.tbx_val2.TabIndex = 1;
            // 
            // lbl_val1
            // 
            this.lbl_val1.AutoSize = true;
            this.lbl_val1.Location = new System.Drawing.Point(347, 141);
            this.lbl_val1.Name = "lbl_val1";
            this.lbl_val1.Size = new System.Drawing.Size(112, 13);
            this.lbl_val1.TabIndex = 2;
            this.lbl_val1.Text = "Digite o Primeiro valor:";
            // 
            // lbl_val2
            // 
            this.lbl_val2.AutoSize = true;
            this.lbl_val2.Location = new System.Drawing.Point(347, 199);
            this.lbl_val2.Name = "lbl_val2";
            this.lbl_val2.Size = new System.Drawing.Size(118, 13);
            this.lbl_val2.TabIndex = 3;
            this.lbl_val2.Text = "Digite o Segundo valor:";
            // 
            // btn_resultado
            // 
            this.btn_resultado.Location = new System.Drawing.Point(364, 259);
            this.btn_resultado.Name = "btn_resultado";
            this.btn_resultado.Size = new System.Drawing.Size(75, 23);
            this.btn_resultado.TabIndex = 4;
            this.btn_resultado.Text = "Comparar";
            this.btn_resultado.UseVisualStyleBackColor = true;
            this.btn_resultado.Click += new System.EventHandler(this.btn_resultado_Click);
            // 
            // lbl_Explicação
            // 
            this.lbl_Explicação.AutoSize = true;
            this.lbl_Explicação.Location = new System.Drawing.Point(256, 36);
            this.lbl_Explicação.Name = "lbl_Explicação";
            this.lbl_Explicação.Size = new System.Drawing.Size(308, 13);
            this.lbl_Explicação.TabIndex = 5;
            this.lbl_Explicação.Text = "Os valores abaixo serão comparados entre maior, menor e igual.";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(322, 305);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(73, 13);
            this.lbl_resultado.TabIndex = 6;
            this.lbl_resultado.Text = "O resultado é:";
            this.lbl_resultado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_Explicação);
            this.Controls.Add(this.btn_resultado);
            this.Controls.Add(this.lbl_val2);
            this.Controls.Add(this.lbl_val1);
            this.Controls.Add(this.tbx_val2);
            this.Controls.Add(this.tbx_val1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_val1;
        private System.Windows.Forms.TextBox tbx_val2;
        private System.Windows.Forms.Label lbl_val1;
        private System.Windows.Forms.Label lbl_val2;
        private System.Windows.Forms.Button btn_resultado;
        private System.Windows.Forms.Label lbl_Explicação;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

