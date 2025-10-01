using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerProyectoenCshar
{
    public partial class Saludar : Form
    {
        public Saludar()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            lblHola.Text = "¡Hola, " + txtNombre.Text + "!";    
        }
    }
}
