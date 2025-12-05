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
    public partial class frm_login : Form
    {
        public frm_login() {
            InitializeComponent();
            txtClaveLogin.PasswordChar = '*';
        }

        private void btnIngresar_Click(object sender, EventArgs e) {
            Conexion_Base_Datos objConexion = new Conexion_Base_Datos();

            string usuario = txtUsuarioLogin.Text.Trim();
            string clave = txtClaveLogin.Text.Trim();

            int resultado = objConexion.verificarCredenciales(usuario, clave);

            if (resultado == 1)  {
                MessageBox.Show("¡Bienvenido!", "Acceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_usuario frm = new frm_usuario();
                frm.Show();
                this.Hide(); 
            } else {
                MessageBox.Show("Usuario o clave incorrectos. Acceso denegado.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClaveLogin.Clear();
                txtUsuarioLogin.Focus();
            }
        }
    }
}
    
