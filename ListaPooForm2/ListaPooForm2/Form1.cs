using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPooForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int aresta, resultado;

            aresta = int.Parse(tbx_aresta.Text);

            resultado = aresta * aresta;

            lbl_areadoquadrado1.Text = "Area do quadrado é: " + resultado.ToString();

        }

        private void lbl_areadoquadrado1_Click(object sender, EventArgs e)
        {

        }
    }
}
