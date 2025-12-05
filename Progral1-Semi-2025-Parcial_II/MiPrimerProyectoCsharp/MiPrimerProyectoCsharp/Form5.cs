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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Conexion_Base_Datos objCOnexion = new Conexion_Base_Datos();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        private void ActualizarDs()  {
            objDs.Clear(); //Limpiar el DataSet
            objDs = objCOnexion.obtenerDatos();
            objDt = objDs.Tables["Docentes"];
            objDt.PrimaryKey = new DataColumn   [] { objDt.Columns["idDocente"] };

            grdDocentes.DataSource = objDt.DefaultView;
            mostrarDatos();

            foreach (DataTable table in objDs.Tables)
            {
                Console.WriteLine(table.TableName);
            }
        }

        private void mostrarDatos() {
            if (objDt.Rows.Count > 0)
            {
                idDocente.Text = objDt.Rows[posicion]["idDocente"].ToString();
                txtNombreDocente.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtApellidoDocente.Text = objDt.Rows[posicion]["apellido"].ToString();
                txtEspecialidadDocente.Text = objDt.Rows[posicion]["especialidad"].ToString();
                txtDireccionDocente.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoDocente.Text = objDt.Rows[posicion]["telefono"].ToString();

                lblnRegistrosDocente.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }
        private void Form5_Load(object sender, EventArgs e) {
            ActualizarDs();
        }

        private void btnSiguienteDocente_Click(object sender, EventArgs e) {
            if (posicion < objDt.Rows.Count - 1) {
                posicion++;// posicion=posicion+1
                mostrarDatos();
            } else {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorDocente_Click(object sender, EventArgs e) {
            if (posicion > 0) {
                posicion--;// posicion=posicion-1
                mostrarDatos();
            } else {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoDocente_Click(object sender, EventArgs e) {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnPrimeroDocente_Click(object sender, EventArgs e) {
            posicion = 0;
            mostrarDatos();
        }

        private void estadoControles(Boolean estado) {
            grbDatosDocente.Enabled = estado;
            grbNavegacionDocente.Enabled = !estado;
            btnEliminarDocente.Enabled = !estado;
        }

        private void limpiarControles()  {
            idDocente.Text = "";
            txtNombreDocente.Text = "";
            txtApellidoDocente.Text = "";
            txtEspecialidadDocente.Text = "";
            txtDireccionDocente.Text = "";
            txtTelefonoDocente.Text = "";
        }

        private void btnAgregarDocente_Click(object sender, EventArgs e)  {
            if (btnAgregarDocente.Text == "Nuevo") {
                btnAgregarDocente.Text = "Guardar";
                btnModificarDocente.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();

            } else {//Guardar
                String[] alumnos = {
                    idDocente.Text, txtNombreDocente.Text, txtApellidoDocente.Text, txtEspecialidadDocente.Text,
                    txtDireccionDocente.Text, txtTelefonoDocente.Text
                };
                String respuesta = objCOnexion.administrarDatosAlumnos(alumnos, accion);
                if (respuesta != "1") {
                    MessageBox.Show(respuesta, "Error al guardar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {

                    estadoControles(false);
                    btnAgregarDocente.Text = "Nuevo";
                    btnModificarDocente.Text = "Modificar";
                    ActualizarDs();
                }
            }
        }

        private void btnModificarDocente_Click(object sender, EventArgs e) {
            if (btnModificarDocente.Text == "Modificar") {
                btnAgregarDocente.Text = "Guardar";
                btnModificarDocente.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";

            } else {//Cancelar
                mostrarDatos();
                estadoControles(false);
                btnAgregarDocente.Text = "Nuevo";
                btnModificarDocente.Text = "Modificar";
            }
        }

        private void btnEliminarDocente_Click(object sender, EventArgs e)  {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreDocente.Text,
              "Eliminando Docentes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)  {
                String respuesta = objCOnexion.administrarDatosDocentes(
                    new String[] { idDocente.Text, "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar docentes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    ActualizarDs();
                }
            }
        }

        private void txtBuscarAlumnos_KeyUp(object sender, KeyEventArgs e) {
            filtrarDatos(txtBuscarDocentes.Text);
        }
        private void filtrarDatos(String valor) {
            DataView objDv = objDt.DefaultView;
            objDv.RowFilter = "nombre like '%" + valor + "%' OR apellido like '%" + valor + "%'";
            grdDocentes.DataSource = objDv;
            seleccionarDocente();
        }
        private void seleccionarDocente() {
            posicion = objDt.Rows.IndexOf(objDt.Rows.Find(grdDocentes.CurrentRow.Cells["id"].Value));
            mostrarDatos();
        }

        private void grdDocentes_CellClick(object sender, DataGridViewCellEventArgs e) {
            seleccionarDocente();
        }

        private void lblnRegistrosDocente_Click(object sender, EventArgs e)
        {

        }
    }
}


