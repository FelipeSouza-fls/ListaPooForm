namespace ListaPooForm1
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
            this.btn_resultado = new System.Windows.Forms.Button();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.lbl_base = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.tbx_altura = new System.Windows.Forms.TextBox();
            this.tbx_base = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_resultado
            // 
            this.btn_resultado.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_resultado.Location = new System.Drawing.Point(97, 218);
            this.btn_resultado.Name = "btn_resultado";
            this.btn_resultado.Size = new System.Drawing.Size(75, 23);
            this.btn_resultado.TabIndex = 0;
            this.btn_resultado.Text = "Area";
            this.btn_resultado.UseVisualStyleBackColor = true;
            this.btn_resultado.Click += new System.EventHandler(this.btn_resultado_area);
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(116, 115);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(34, 13);
            this.lbl_altura.TabIndex = 1;
            this.lbl_altura.Text = "Altura";
            // 
            // lbl_base
            // 
            this.lbl_base.AutoSize = true;
            this.lbl_base.Location = new System.Drawing.Point(119, 164);
            this.lbl_base.Name = "lbl_base";
            this.lbl_base.Size = new System.Drawing.Size(31, 13);
            this.lbl_base.TabIndex = 2;
            this.lbl_base.Text = "Base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "O valor da area é:";
            this.label3.Visible = false;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(297, 159);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(13, 13);
            this.lbl_resultado.TabIndex = 4;
            this.lbl_resultado.Text = "0";
            this.lbl_resultado.Visible = false;
            // 
            // tbx_altura
            // 
            this.tbx_altura.Location = new System.Drawing.Point(86, 131);
            this.tbx_altura.Name = "tbx_altura";
            this.tbx_altura.Size = new System.Drawing.Size(100, 20);
            this.tbx_altura.TabIndex = 5;
            // 
            // tbx_base
            // 
            this.tbx_base.Location = new System.Drawing.Point(86, 180);
            this.tbx_base.Name = "tbx_base";
            this.tbx_base.Size = new System.Drawing.Size(100, 20);
            this.tbx_base.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 452);
            this.Controls.Add(this.tbx_base);
            this.Controls.Add(this.tbx_altura);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_base);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.btn_resultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_resultado;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.Label lbl_base;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.TextBox tbx_altura;
        private System.Windows.Forms.TextBox tbx_base;
    }
}

