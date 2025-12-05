using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerProyectoCsharp
{
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta = 0;
            num1 = Double.Parse(txtnum1.Text);

            num2 = double.Parse(txtnum2.Text);

            if (optSuma.Checked)
            {
                respuesta = num1 + num2;
            }
            if (optResta.Checked)
            {
                respuesta = num1 - num2;
            }
            if (optMultiplicación.Checked)
            {
                respuesta = num1 * num2;
            }
            if (optDivisión.Checked)
            {
                respuesta = num1 / num2;
            }
            if (optExponente.Checked)
            {
                respuesta = Math.Pow(num1, num2);
            }
            if (optPorcentaje.Checked)
            {
                respuesta = (num1 / num2) * 100;
            }
            if (optFactorial.Checked)
            {
                respuesta = (int)num1;
                for (int i = (int)num1 - 1; i > 1; i--)
                {
                    respuesta *= i;
                }
            }
            lblrespuesta.Text = "respuesta: " + respuesta;

            if (optPrimo.Checked)
            {
                int i = 1, acum = 0;
                while (i <= num1 && acum<3)  {
                    if (num1%i==0) {
                        acum++;
                    }
                    i++;
                }
                if (acum <= 2)
                {
                    lblrespuesta.Text = "respuesta: " + num1 + "Es +primo";
                }
                else
                {
                    lblrespuesta.Text = "respuesta: " + num1 + "NO es +primo";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta = 0;
            num1 = Double.Parse(txtnum1.Text);

            num2 = double.Parse(txtnum2.Text);

            switch (cboOpciones.SelectedIndex)
            {
                case 0:
                    respuesta = num1 + num2;
                    break;
                case 1:
                    respuesta = num1 - num2;
                    break;
                case 2:
                    respuesta = num1 * num2;
                    break;
                case 3:
                    respuesta = num1 / num2;
                    break;
            }
            lblrespuesta.Text = "respuesta: " + respuesta;
        }
      }
    }

       