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
    public partial class Tiempo : Form
    {
        public Tiempo()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
           
            if (!double.TryParse(txtTiempo.Text, out double valor_origen))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.");
                return;
            }

            double valor_en_segundos = 0;

            
            if (radioButton10.Checked)
            {
                valor_en_segundos = valor_origen;
            }
            else if (radioButton9.Checked)
            {
                valor_en_segundos = valor_origen * 60;
            }
            else if (radioButton8.Checked)
            {
                valor_en_segundos = valor_origen * 3600;
            }
            else if (radioButton7.Checked)
            {
                valor_en_segundos = valor_origen * 86400;
            }
            else if (radioButton6.Checked)
            {
                valor_en_segundos = valor_origen * 604800;
            }
            else if (radioButton5.Checked)
            {
                valor_en_segundos = valor_origen * 2629743;
            }
            else if (radioButton4.Checked)
            {
                valor_en_segundos = valor_origen * 31536000;
            }
            else if (radioButton3.Checked)
            {
                valor_en_segundos = valor_origen * 315360000;
            }
            else if (radioButton2.Checked)
            {
                valor_en_segundos = valor_origen * 3153600000;
            }
            else if (radioButton1.Checked)
            {
                valor_en_segundos = valor_origen * 31536000000;
            }

            double resultado = 0;
            if (optSegundo.Checked)
            {
                resultado = valor_en_segundos;
            }
            else if (optMinuto.Checked)
            {
                resultado = valor_en_segundos / 60;
            }
            else if (optHora.Checked)
            {
                resultado = valor_en_segundos / 3600;
            }
            else if (optDía.Checked)
            {
                resultado = valor_en_segundos / 86400;
            }
            else if (optSemana.Checked)
            {
                resultado = valor_en_segundos / 604800;
            }
            else if (optMes.Checked)
            {
                
                resultado = valor_en_segundos / 2629743;
            }
            else if (optAño.Checked)
            {
                resultado = valor_en_segundos / 31536000;
            }
            else if (optDécada.Checked)
            {
                resultado = valor_en_segundos / 315360000;
            }
            else if (optSiglo.Checked)
            {
                resultado = valor_en_segundos / 3153600000;
            }
            else if (optMilenio.Checked)
            {
                resultado = valor_en_segundos / 31536000000;
            }

            
            lblResultado.Text = resultado.ToString();
        }
    }
}
