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
    public partial class Form6 : Form {
        public Form6() {
            InitializeComponent();
        }
        Conexion_Base_Datos objCOnexion = new Conexion_Base_Datos();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        private void ActualizarDs() {
            objDs.Clear(); //Limpiar el DataSet
            objDs = objCOnexion.obtenerDatos();
            objDt = objDs.Tables["Materias"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idMaterias"] };

            grdMaterias.DataSource = objDt.DefaultView;
            mostrarDatos();
        }
        private void mostrarDatos()  {
            if (objDt.Rows.Count > 0)
            {
                idMateria.Text = objDt.Rows[posicion]["idMaterias"].ToString();
                txtCodigoMateria.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombreMateria.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtUV.Text = objDt.Rows[posicion]["UV"].ToString();
               
                lblnRegistrosMaterias.Text = (posicion ) + " de " + objDt.Rows.Count;
            }
        }

        private void Form6_Load(object sender, EventArgs e) {
            ActualizarDs();
        }

        private void btnSiguienteMaterias_Click(object sender, EventArgs e) {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;// posicion=posicion+1
                mostrarDatos();
            }  else   {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoMaterias_Click(object sender, EventArgs e) {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnAnteriorMaterias_Click(object sender, EventArgs e) {
            if (posicion > 0) {
                posicion--;// posicion=posicion-1
                mostrarDatos();
            } else  {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrimeroMaterias_Click(object sender, EventArgs e) {
            posicion = 0;
            mostrarDatos();
        }

        private void estadoControles(Boolean estado)  {
            grbDatosMaterias.Enabled = estado;
            grbNavegacionMaterias.Enabled = !estado;
            btnEliminarMaterias.Enabled = !estado;
        }
        private void limpiarControles() {
            idMateria.Text = "";
            txtCodigoMateria.Text = "";
            txtNombreMateria.Text = "";
            txtUV.Text = "";
           
        }
        private void btnAgregarMaterias_Click(object sender, EventArgs e)  {
            if (btnAgregarMateria.Text == "Nuevo")
            {
                btnAgregarMateria.Text = "Guardar";
                btnModificarMateria.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();

            } else {//Guardar
                String[] Materias = {
                    idMateria.Text, txtCodigoMateria.Text, txtNombreMateria.Text, txtUV.Text,
                };
                String respuesta = objCOnexion.administrarDatosMaterias(Materias, accion);
                if (respuesta != "1") {
                    MessageBox.Show(respuesta, "Error al guardar Materia.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  else   {

                    estadoControles(false);
                    btnAgregarMateria.Text = "Nuevo";
                    btnModificarMateria.Text = "Modificar";
                    ActualizarDs();
                }
            }
        }

        private void btnModificarMateria_Click(object sender, EventArgs e) {
            if (btnModificarMateria.Text == "Modificar")  {
                btnAgregarMateria.Text = "Guardar";
                btnModificarMateria.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";

            }  else {//Cancelar
                mostrarDatos();
                estadoControles(false);
                btnAgregarMateria.Text = "Nuevo";
                btnModificarMateria.Text = "Modificar";
            }
        }

        private void btnEliminarMaterias_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreMateria.Text,
               "Eliminando Materia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)  {
                String respuesta = objCOnexion.administrarDatosMaterias (
                    new String[] { idMateria.Text, "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")  {
                    MessageBox.Show(respuesta, "Error al eliminar Materia.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  else  {
                    posicion = 0;
                    ActualizarDs();
                }
            }
        }

        private void txtBuscarMaterias_KeyUp(object sender, KeyEventArgs e) {
            filtrarDatos(txtBuscarMaterias.Text);
        }

        private void filtrarDatos(String valor)  {
            DataView objDv = objDt.DefaultView;
            objDv.RowFilter = "codigo like '%" + valor + "%' OR nombre like '%" + valor + "%'";
            grdMaterias.DataSource = objDv;
            seleccionarAlumno();
        }

        private void seleccionarAlumno()  {
            posicion = objDt.Rows.IndexOf(objDt.Rows.Find(grdMaterias.CurrentRow.Cells["id"].Value));
            if (posicion >= 0)
            {
                mostrarDatos();
            }
        }

        private void grdMaterias_CellClick(object sender, DataGridViewCellEventArgs e) {
            seleccionarAlumno();
        } 
    }
}


