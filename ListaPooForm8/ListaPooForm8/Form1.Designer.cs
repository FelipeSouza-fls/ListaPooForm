namespace ListaPooForm8
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbx_val1 = new System.Windows.Forms.TextBox();
            this.tbx_val2 = new System.Windows.Forms.TextBox();
            this.lbl_val1 = new System.Windows.Forms.Label();
            this.lbl_val2 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.tbn_resultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tbx_val1
            // 
            this.tbx_val1.Location = new System.Drawing.Point(317, 148);
            this.tbx_val1.Name = "tbx_val1";
            this.tbx_val1.Size = new System.Drawing.Size(100, 20);
            this.tbx_val1.TabIndex = 0;
            // 
            // tbx_val2
            // 
            this.tbx_val2.Location = new System.Drawing.Point(317, 195);
            this.tbx_val2.Name = "tbx_val2";
            this.tbx_val2.Size = new System.Drawing.Size(100, 20);
            this.tbx_val2.TabIndex = 1;
            // 
            // lbl_val1
            // 
            this.lbl_val1.AutoSize = true;
            this.lbl_val1.Location = new System.Drawing.Point(347, 123);
            this.lbl_val1.Name = "lbl_val1";
            this.lbl_val1.Size = new System.Drawing.Size(39, 13);
            this.lbl_val1.TabIndex = 2;
            this.lbl_val1.Text = "valor 1";
            // 
            // lbl_val2
            // 
            this.lbl_val2.AutoSize = true;
            this.lbl_val2.Location = new System.Drawing.Point(347, 179);
            this.lbl_val2.Name = "lbl_val2";
            this.lbl_val2.Size = new System.Drawing.Size(39, 13);
            this.lbl_val2.TabIndex = 3;
            this.lbl_val2.Text = "valor 2";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(331, 271);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(55, 13);
            this.lbl_resultado.TabIndex = 4;
            this.lbl_resultado.Text = "Resultado";
            this.lbl_resultado.Visible = false;
            // 
            // tbn_resultado
            // 
            this.tbn_resultado.Location = new System.Drawing.Point(329, 230);
            this.tbn_resultado.Name = "tbn_resultado";
            this.tbn_resultado.Size = new System.Drawing.Size(75, 23);
            this.tbn_resultado.TabIndex = 5;
            this.tbn_resultado.Text = "Comparar";
            this.tbn_resultado.UseVisualStyleBackColor = true;
            this.tbn_resultado.Click += new System.EventHandler(this.tbn_resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbn_resultado);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_val2);
            this.Controls.Add(this.lbl_val1);
            this.Controls.Add(this.tbx_val2);
            this.Controls.Add(this.tbx_val1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbx_val1;
        private System.Windows.Forms.TextBox tbx_val2;
        private System.Windows.Forms.Label lbl_val1;
        private System.Windows.Forms.Label lbl_val2;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button tbn_resultado;
    }
}

