namespace ListaPooForm2
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
            this.lbl_aresta = new System.Windows.Forms.Label();
            this.lbl_areadoquadrado1 = new System.Windows.Forms.Label();
            this.tbx_aresta = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_aresta
            // 
            this.lbl_aresta.AutoSize = true;
            this.lbl_aresta.Location = new System.Drawing.Point(116, 151);
            this.lbl_aresta.Name = "lbl_aresta";
            this.lbl_aresta.Size = new System.Drawing.Size(78, 13);
            this.lbl_aresta.TabIndex = 0;
            this.lbl_aresta.Text = "Valor da aresta";
            this.lbl_aresta.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_areadoquadrado1
            // 
            this.lbl_areadoquadrado1.AutoSize = true;
            this.lbl_areadoquadrado1.Location = new System.Drawing.Point(215, 170);
            this.lbl_areadoquadrado1.Name = "lbl_areadoquadrado1";
            this.lbl_areadoquadrado1.Size = new System.Drawing.Size(64, 13);
            this.lbl_areadoquadrado1.TabIndex = 1;
            this.lbl_areadoquadrado1.Text = "= Resultado";
            this.lbl_areadoquadrado1.Click += new System.EventHandler(this.lbl_areadoquadrado1_Click);
            // 
            // tbx_aresta
            // 
            this.tbx_aresta.Location = new System.Drawing.Point(109, 167);
            this.tbx_aresta.Name = "tbx_aresta";
            this.tbx_aresta.Size = new System.Drawing.Size(100, 20);
            this.tbx_aresta.TabIndex = 6;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(119, 202);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 7;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.tbx_aresta);
            this.Controls.Add(this.lbl_areadoquadrado1);
            this.Controls.Add(this.lbl_aresta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_aresta;
        private System.Windows.Forms.Label lbl_areadoquadrado1;
        private System.Windows.Forms.TextBox tbx_aresta;
        private System.Windows.Forms.Button btn_calcular;
    }
}

