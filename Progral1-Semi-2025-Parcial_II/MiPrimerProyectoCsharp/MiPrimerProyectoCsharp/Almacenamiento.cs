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
    public partial class Almacenamiento : Form
    {

        public Almacenamiento()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(txtAlmacenamiento.Text, out double cantidad))
            {
                MessageBox.Show("Por favor, ingrese una cantidad numérica válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            string unidadOrigen = ObtenerUnidadSeleccionada(gbSeleccionar); 
            string unidadDestino = ObtenerUnidadSeleccionada(gbDestino); 

            double cantidadEnBytes = ConvertirABytes(cantidad, unidadOrigen);

            double resultado = ConvertirDesdeBytes(cantidadEnBytes, unidadDestino);

            lblResultado.Text = resultado.ToString("N4") + " " + unidadDestino;
        }


        private string ObtenerUnidadSeleccionada(GroupBox gb)
        {
            foreach (Control control in gb.Controls)
            {
                if (control is RadioButton rb && rb.Checked)
                {
                    return rb.Text;
                }
            }
            return string.Empty;
        }

        private double ConvertirABytes(double cantidad, string unidadOrigen)
        {
            switch (unidadOrigen)
            {
                case "Bit":
                    return cantidad / 8;
                case "Byte":
                    return cantidad;
                case "Kilobyte":
                    return cantidad * Math.Pow(1024, 1);
                case "Megabyte":
                    return cantidad * Math.Pow(1024, 2);
                case "Gigabyte":
                    return cantidad * Math.Pow(1024, 3);
                case "Terabyte":
                    return cantidad * Math.Pow(1024, 4);
                case "Petabyte":
                    return cantidad * Math.Pow(1024, 5);
                case "Exabyte":
                    return cantidad * Math.Pow(1024, 6);
                case "Zettabyte":
                    return cantidad * Math.Pow(1024, 7);
                case "Yottabyte":
                    return cantidad * Math.Pow(1024, 8);
                default:
                    return 0;
            }
        }

        private double ConvertirDesdeBytes(double cantidadEnBytes, string unidadDestino)
        {
            switch (unidadDestino)
            {
                case "Bit":
                    return cantidadEnBytes * 8;
                case "Byte":
                    return cantidadEnBytes;
                case "Kilobyte":
                    return cantidadEnBytes / Math.Pow(1024, 1);
                case "Megabyte":
                    return cantidadEnBytes / Math.Pow(1024, 2);
                case "Gigabyte":
                    return cantidadEnBytes / Math.Pow(1024, 3);
                case "Terabyte":
                    return cantidadEnBytes / Math.Pow(1024, 4);
                case "Petabyte":
                    return cantidadEnBytes / Math.Pow(1024, 5);
                case "Exabyte":
                    return cantidadEnBytes / Math.Pow(1024, 6);
                case "Zettabyte":
                    return cantidadEnBytes / Math.Pow(1024, 7);
                case "Yottabyte":
                    return cantidadEnBytes / Math.Pow(1024, 8);
                default:
                    return 0;
            }
        }
    }
}
