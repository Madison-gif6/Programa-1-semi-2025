using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerProyectoCsharp
{
    public partial class Longitud : Form
    {
        public Longitud()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
           
            if (!double.TryParse(txtLongitud.Text, out double cantidad))
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double valorEnMetros = 0;

            if (radioButton10.Checked)
            {
                valorEnMetros = cantidad;
            }
            else if (radioButton9.Checked)
            {
                valorEnMetros = cantidad * 1000;
            }
            else if (radioButton8.Checked)
            {
                valorEnMetros = cantidad / 100;
            }
            else if (radioButton7.Checked)
            {
                valorEnMetros = cantidad / 1000;
            }
            else if (radioButton6.Checked)
            {
                valorEnMetros = cantidad * 1609.34;
            }
            else if (radioButton5.Checked)
            {
                valorEnMetros = cantidad * 0.9144;
            }
            else if (radioButton4.Checked)
            {
                valorEnMetros = cantidad * 0.3048;
            }
            else if (radioButton3.Checked)
            {
                valorEnMetros = cantidad * 0.0254;
            }
            else if (radioButton2.Checked)
            {
                valorEnMetros = cantidad * 0.000001;
            }
            else if (radioButton1.Checked)
            {
                valorEnMetros = cantidad * 0.000000001;
            }

            double resultado = 0;

            
            if (optMetro.Checked)
            {
                resultado = valorEnMetros;
            }
            else if (optKilómetro.Checked)
            {
                resultado = valorEnMetros / 1000;
            }
            else if (optCentímetro.Checked)
            {
                resultado = valorEnMetros * 100;
            }
            else if (optMilímetro.Checked)
            {
                resultado = valorEnMetros * 1000;
            }
            else if (optMilla.Checked)
            {
                resultado = valorEnMetros / 1609.34;
            }
            else if (optYarda.Checked)
            {
                resultado = valorEnMetros / 0.9144;
            }
            else if (optPie.Checked)
            {
                resultado = valorEnMetros / 0.3048;
            }
            else if (optPulgada.Checked)
            {
                resultado = valorEnMetros / 0.0254;
            }
            else if (optMicrómetro.Checked)
            {
                resultado = valorEnMetros / 0.000001;
            }
            else if (optNanómetro.Checked)
            {
                resultado = valorEnMetros / 0.000000001;
            }

            
            lblResultado.Text = resultado.ToString();
        
        }
    }
}

