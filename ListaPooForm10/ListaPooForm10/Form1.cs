using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPooForm10
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

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            double peso, altura, resultado;

            altura = double.Parse(tbx_altura.Text);
            peso = double.Parse(tbx_peso.Text);

            resultado = peso / Math.Pow(altura, 2);

            if (resultado <= 20)
            {
                lbl_resultado.Text = "Abaixo do IMC " + resultado.ToString();
            }
            else if (resultado < 25)
            {
                lbl_resultado.Text = "Peso ideal do IMC " + resultado.ToString();
            }
            else if (resultado >= 25)
            {
                lbl_resultado.Text = "Acima do Peso IMC " + resultado.ToString();
            }
            lbl_resultado.Visible = true;
        }
    }
}
