using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPooForm9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbn_resultado_Click(object sender, EventArgs e)

        {
            double basee, altura, area;

            basee = double.Parse(tbx_base.Text);
            altura = double.Parse(tbx_altura.Text);

            area = basee * altura;

            if (area >= 100)
            {
                lbl_resultado.Text = "Terreno Grande";
            }
            else if (basee < 100)
            {
                lbl_resultado.Text = "Terreno Pequeno";
            }
            
            lbl_resultado.Visible = true;

            }
    }
}
