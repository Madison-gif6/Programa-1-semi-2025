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
    public partial class Serie : Form
    {
        public Serie()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String[] serie = txtSerie.Text.Split(','); //5,10,15 => ["5","10","15"] -> String[] m = new String[] { "5", "10", "15" };

            int suma = 0;
            for (int i = 0; i < serie.Length; i++)
            {
                suma = suma + int.Parse(serie[i]);
            }
            lblSuma.Text = "Suma: " + suma;
            //lblSuma.Text = "Suma: " + serie.Sum();
        }
    }
}
