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
    public partial class Masa : Form
    {
        public Masa()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMasa.Text))
            {
                MessageBox.Show("Por favor, ingrese una cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtMasa.Text, out double cantidad))
            {
                MessageBox.Show("Cantidad inválida. Por favor, ingrese un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string unidadOrigen = ObtenerUnidadSeleccionada(gbOrigen);
            string unidadDestino = ObtenerUnidadSeleccionada(gbDestino);

            if (string.IsNullOrEmpty(unidadOrigen) || string.IsNullOrEmpty(unidadDestino))
            {
                MessageBox.Show("Por favor, seleccione las unidades de origen y destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double resultado = ConvertirMasa(cantidad, unidadOrigen, unidadDestino);
            lblResultado.Text = $"Resultado: {resultado.ToString("N4")}"; 
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
            return null;
        }

        private double ConvertirMasa(double cantidad, string origen, string destino)
        {
            double enKilogramos = 0;

            
            switch (origen)
            {
                case "Kilogramo":
                    enKilogramos = cantidad;
                    break;
                case "Gramo":
                    enKilogramos = cantidad / 1000.0;
                    break;
                case "Miligramo":
                    enKilogramos = cantidad / 1000000.0;
                    break;
                case "Tonelada Métrica":
                    enKilogramos = cantidad * 1000.0;
                    break;
                case "Libra":
                    enKilogramos = cantidad * 0.45359237;
                    break;
                case "Onza":
                    enKilogramos = cantidad * 0.028349523125;
                    break;
                case "Stone":
                    enKilogramos = cantidad * 6.35029318;
                    break;
                case "Microgramo":
                    enKilogramos = cantidad / 1000000000.0;
                    break;
                case "Kilate":
                    enKilogramos = cantidad * 0.0002;
                    break;
                case "Tonelada Corta":
                    enKilogramos = cantidad * 907.18474;
                    break;
            }

            
            switch (destino)
            {
                case "Kilogramo":
                    return enKilogramos;
                case "Gramo":
                    return enKilogramos * 1000.0;
                case "Miligramo":
                    return enKilogramos * 1000000.0;
                case "Tonelada Métrica":
                    return enKilogramos / 1000.0;
                case "Libra":
                    return enKilogramos / 0.45359237;
                case "Onza":
                    return enKilogramos / 0.028349523125;
                case "Stone":
                    return enKilogramos / 6.35029318;
                case "Microgramo":
                    return enKilogramos * 1000000000.0;
                case "Kilate":
                    return enKilogramos / 0.0002;
                case "Tonelada Corta":
                    return enKilogramos / 907.18474;
            }

            return 0; 
        }
    }
}
