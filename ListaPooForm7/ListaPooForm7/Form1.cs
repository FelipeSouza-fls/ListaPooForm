using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPooForm7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            double val1, val2;

            val1 = double.Parse(tbx_val1.Text);
            val2 = double.Parse(tbx_val2.Text);

            {
                if (val1 > val2)
                {
                    lbl_resultado.Text = "O primeiro valor é maior, sendo ele " + val1.ToString();
                }
                else if (val1 < val2)
                {
                    lbl_resultado.Text = " O segundo valor é maior, sendo ele " + val2.ToString();
                }
                else if (val1 == val2)
                {
                    lbl_resultado.Text = " Os valores são iguais a " + val1.ToString();
                }

                lbl_resultado.Visible = true;

            }

            }
    }
}
