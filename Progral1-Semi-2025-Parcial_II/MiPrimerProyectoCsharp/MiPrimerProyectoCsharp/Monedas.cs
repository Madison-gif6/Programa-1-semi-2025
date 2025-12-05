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
    public partial class Monedas : Form
    {

        public Monedas()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtMonedas.Text) || !double.TryParse(txtMonedas.Text, out double cantidadDolar))
            {
                lblResultado.Text = "Por favor, ingrese una cantidad válida.";
                lblResultado.ForeColor = System.Drawing.Color.Red;
                return; 
            }

            double resultado;
            double tasaConversion = 0; 

            
            if (optQuetzal.Checked)
            {
                tasaConversion = 7.66; 
            }
            else if (optLempira.Checked)
            {
                tasaConversion = 26.30; 
            }
            else if (optCórdoba.Checked)
            {
                tasaConversion = 36.80; 
            }
            else if (optEuro.Checked)
            {
                tasaConversion = 0.86; 
            }
            else if (optPesoMexicano.Checked)
            {
                tasaConversion = 18.84; 
            }
            else if (optPesoArgentino.Checked)
            {
                tasaConversion = 1291.50; 
            }
            else if (optPesoColombiano.Checked)
            {
                tasaConversion = 4041.50; 
            }
            else if (optColónCostarricense.Checked)
            {
                tasaConversion = 505.28; 
            }
            else if (optSolPeruano.Checked)
            {
                tasaConversion = 3.54; 
            }
            else if (optYenJapones.Checked)
            {
                tasaConversion = 147.50; 
            }
            else
            {
                
                lblResultado.Text = "Por favor, seleccione una moneda.";
                lblResultado.ForeColor = System.Drawing.Color.Red;
                return;
            }

            resultado = cantidadDolar * tasaConversion;

           
            lblResultado.Text = resultado.ToString("F2"); 
            lblResultado.ForeColor = System.Drawing.Color.Black; 
        }
    }
}