using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPooForm6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            double dolar, resultado;

            dolar = double.Parse(tbx_dolar.Text);

            resultado = dolar * 5.79;

            lbl_resultado.Text = " O valor de " + dolar.ToString() + " dolares para reais é: " + resultado.ToString() + " Reais";

            lbl_resultado.Visible = true;
        }
    }
}
