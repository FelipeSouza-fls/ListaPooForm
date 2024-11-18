using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPooForm4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            double basee, altura, resultado;

            basee = double.Parse(tbx_base.Text);
            altura = double.Parse(tbx_altura.Text);

            resultado = basee * altura / 2;

            lbl_resultado.Text = "Area do trinangulo é: " + resultado.ToString();

            lbl_resultado.Visible = true;


        }
    }
}
