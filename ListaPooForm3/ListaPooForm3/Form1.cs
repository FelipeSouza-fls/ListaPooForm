using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPooForm3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_diagonal_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double diagonal, resultado;

            diagonal = double.Parse(tbx_diagonal.Text);

            resultado = diagonal * diagonal / 2;

            lbl_resultado.Text = "Area do quadrado é: " + resultado.ToString();

            lbl_resultado.Visible = true;
        }
    }
}
