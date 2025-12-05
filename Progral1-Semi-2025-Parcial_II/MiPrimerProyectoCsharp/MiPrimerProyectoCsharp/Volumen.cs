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
    public partial class Volumen : Form
    {
        public Volumen()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtVolumen.Text))
            {
                MessageBox.Show("Por favor, ingresa una cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtVolumen.Text, out double cantidad))
            {
                MessageBox.Show("Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string unidadOrigen = ObtenerUnidadSeleccionada(gbOrigen);

            string unidadDestino = ObtenerUnidadSeleccionada(gbDestino);
           
            double resultado = ConvertirVolumen(cantidad, unidadOrigen, unidadDestino);
           
            lblResultado.Text = resultado.ToString("N4"); 
        }

        private string ObtenerUnidadSeleccionada(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return string.Empty;
        }

        private double ConvertirVolumen(double cantidad, string unidadOrigen, string unidadDestino)
        {
           
            double cantidadEnLitros = ConvertirA_Litros(cantidad, unidadOrigen);

            double resultado = ConvertirDe_Litros(cantidadEnLitros, unidadDestino);

            return resultado;
        }

        private double ConvertirA_Litros(double cantidad, string unidad)
        {
            switch (unidad)
            {
                case "Litro":
                    return cantidad;
                case "Mililitro":
                    return cantidad / 1000;
                case "Metro Cúbico":
                    return cantidad * 1000;
                case "Centímetro cúbico":
                    return cantidad / 1000;
                case "Galón":
                    return cantidad * 3.78541;
                case "Pinta":
                    return cantidad * 0.473176;
                case "Taza":
                    return cantidad * 0.24;
                case "Onza Líquida":
                    return cantidad * 0.0295735;
                case "Pie Cúbico":
                    return cantidad * 28.3168;
                case "Barril":
                    return cantidad * 158.987;
                default:
                    return 0;
            }
        }

        private double ConvertirDe_Litros(double cantidadEnLitros, string unidad)
        {
            switch (unidad)
            {
                case "Litro":
                    return cantidadEnLitros;
                case "Mililitro":
                    return cantidadEnLitros * 1000;
                case "Metro Cúbico":
                    return cantidadEnLitros / 1000;
                case "Centímetro cúbico":
                    return cantidadEnLitros * 1000;
                case "Galón":
                    return cantidadEnLitros / 3.78541;
                case "Pinta":
                    return cantidadEnLitros / 0.473176;
                case "Taza":
                    return cantidadEnLitros / 0.24;
                case "Onza Líquida":
                    return cantidadEnLitros / 0.0295735;
                case "Pie Cúbico":
                    return cantidadEnLitros / 28.3168;
                case "Barril":
                    return cantidadEnLitros / 158.987;
                default:
                    return 0;
            }
        }
    }
}