using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPooForm5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_km_Click(object sender, EventArgs e)
        {

        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            double milha, resultado;

            milha = double.Parse(tbx_milha.Text);

            resultado = milha * 1.852;

            lbl_resultado.Text = "O valor de " + milha.ToString() + " milhas para km é: " + resultado.ToString();

            lbl_resultado.Visible = true;
        }
    }
}
