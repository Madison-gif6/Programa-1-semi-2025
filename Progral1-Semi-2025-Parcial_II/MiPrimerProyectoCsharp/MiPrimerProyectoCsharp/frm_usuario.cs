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
    public partial class frm_usuario : Form
    {
        public frm_usuario()
        {
            InitializeComponent();
        }
        Conexion_Base_Datos objCOnexion = new Conexion_Base_Datos();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";
        private void ActualizarDs()
        {
            objDs.Clear(); //Limpiar el DataSet
            objDs = objCOnexion.obtenerDatos();
            objDt = objDs.Tables["usuarios"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["IdUsuario"] };
        }
        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                txtConfirmarClave.Clear();
                txtConfirmarClave.Enabled = false;
                idUsuario.Text = objDt.Rows[posicion]["IdUsuario"].ToString();
                txtUsuario.Text = objDt.Rows[posicion]["usuario"].ToString();
                txtClaveUsuario.Text = objDt.Rows[posicion]["clave"].ToString();
                txtNombreUsuario.Text = objDt.Rows[posicion]["Nombre"].ToString();
                txtDireccionUsuario.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoUsuario.Text = objDt.Rows[posicion]["telefono"].ToString();


                lblnRegistrosUsuarios.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }
        private void frm_usuario_Load(object sender, EventArgs e)
        {
            ActualizarDs();
            mostrarDatos();
        }
        private void btnSiguienteUsuario_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;// posicion=posicion+1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnAnteriorUsuario_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;// posicion=posicion-1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnUltimoUsuario_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }
        private void btnPrimerUsuario_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }
        private void estadoControles(Boolean estado)
        {
            grbDatosUsuario.Enabled = estado;
            grbNavegacionUsuario.Enabled = !estado;
            btnEliminarUsuario.Enabled = !estado;
        }
        private void limpiarControles()
        {
            idUsuario.Text = "";
            txtUsuario.Text = "";
            txtClaveUsuario.Text = "";
            txtNombreUsuario.Text = "";
            txtDireccionUsuario.Text = "";
            txtTelefonoUsuario.Text = "";
        }
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (btnAgregarUsuario.Text == "Nuevo")
            {
                btnAgregarUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();
                txtConfirmarClave.Clear();
                txtConfirmarClave.Enabled = true;
            }
            else
            {
                string usuario = txtUsuario.Text.Trim();
                string clave = txtClaveUsuario.Text.Trim();
                string confirmacion = txtConfirmarClave.Text.Trim();

                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave) || string.IsNullOrEmpty(confirmacion))
                {
                    MessageBox.Show("Debe llenar usuario, clave y confirmación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (usuario.Length < 6 || usuario.Length > 16)
                {
                    MessageBox.Show("¡Error! El usuario debe tener entre 6 y 16 caracteres, sino no guardar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    return;
                }

                if (clave != confirmacion)
                {
                    MessageBox.Show("¡Error! La clave y la confirmación no coinciden, sino no guardar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveUsuario.Focus();
                    return;
                }
                bool contieneLetra = clave.Any(char.IsLetter);
                bool contieneNumero = clave.Any(char.IsDigit);

                if (!contieneLetra || !contieneNumero)
                {
                    MessageBox.Show("¡Error! La clave debe contener una combinación de letras Y números, sino no guardar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveUsuario.Focus();
                    return;
                }

                String[] usuarios = {
            idUsuario.Text, txtUsuario.Text, txtClaveUsuario.Text, txtNombreUsuario.Text,
            txtDireccionUsuario.Text, txtTelefonoUsuario.Text
        };

                String respuesta = objCOnexion.Mantenimiento_usuarios(usuarios, accion);

                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar usuarios.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtConfirmarClave.Clear();
                    txtConfirmarClave.Enabled = false;

                    estadoControles(false);
                    btnAgregarUsuario.Text = "Nuevo";
                    btnModificarUsuario.Text = "Modificar";
                    ActualizarDs();
                    mostrarDatos();
                }
            }
        }
        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (btnModificarUsuario.Text == "Modificar")
            {
                btnAgregarUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";

                txtConfirmarClave.Clear();
                txtConfirmarClave.Enabled = true;
                txtClaveUsuario.Focus();
            }
            else
            {
                mostrarDatos();
                estadoControles(false);
                btnAgregarUsuario.Text = "Nuevo";
                btnModificarUsuario.Text = "Modificar";

                txtConfirmarClave.Clear();
                txtConfirmarClave.Enabled = false;
            }
        }
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtUsuario.Text,
         "Eliminando Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                String respuesta = objCOnexion.Mantenimiento_usuarios(
                    new String[] { idUsuario.Text, "", "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar usuario.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    ActualizarDs();
                    mostrarDatos();
                }
            }
        }
    }
}