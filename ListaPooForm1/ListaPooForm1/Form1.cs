using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPooForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_resultado_area(object sender, EventArgs e)
        {
            int altura, basee, resultado;

            altura = int.Parse(tbx_altura.Text);
            basee = int.Parse(tbx_base.Text);

            resultado = basee * altura;

            lbl_resultado.Text = resultado.ToString();

            lbl_resultado.Visible = true;
            label3.Visible = true;
        }
    }
}
