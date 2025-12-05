using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerProyectoCsharp
{
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }
        Conexion_Base_Datos objConexion = new Conexion_Base_Datos();
        DataSet objNotas = new DataSet();

        private void actualizarDs()
        {
            int idMateria = int.Parse(cboMateria.SelectedValue?.ToString() ?? "1");
            int idPeriodo = int.Parse(cboPeriodos.SelectedValue?.ToString() ?? "1");

            //MessageBox.Show("Materia: " + idMateria + " Periodo: " + idPeriodo);

            objNotas.Clear(); //Limpiar el DataSet

            objConexion.objAdaptador = new SqlDataAdapter("SELECT alumnos.nombre, dnotas.IdDetalle, dnotas.idnotas, dnotas.IdMaterias, " +
                 "dnotas.lab1, dnotas.lab2, dnotas.parcial, (dnotas.lab1*0.3 + dnotas.lab2*0.3 + dnotas.parcial*0.4) AS nf " +
                 "FROM dnotas INNER JOIN notas ON(notas.IdNotas=dnotas.idnotas) INNER JOIN alumnos ON(alumnos.IdAlumno=notas.IdAlumnos) " +
                 "WHERE notas.idPeriodo=" + idPeriodo + " AND dnotas.IdMaterias=" + idMateria, objConexion.objConexion);

            objConexion.objAdaptador.Fill(objNotas, "notasAlumnos");
        }
        private void actualizarGrid()
        {
            actualizarDs();
            dnotasDataGridView.DataSource = objNotas;
            dnotasDataGridView.DataMember = "notasAlumnos";
        }
       
        private void frmNotas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_academicaDataSet.Periodos' Puede moverla o quitarla según sea necesario.
            this.periodosTableAdapter.Fill(this.db_academicaDataSet.Periodos);
            // TODO: esta línea de código carga datos en la tabla 'db_academicaDataSet.Materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter.Fill(this.db_academicaDataSet.Materias);
            // TODO: esta línea de código carga datos en la tabla 'db_academicaDataSet.dnotas' Puede moverla o quitarla según sea necesario.
            this.dnotasTableAdapter.dnotas(this.db_academicaDataSet.dnotas);
            // TODO: esta línea de código carga datos en la tabla 'db_academicaDataSet.notas' Puede moverla o quitarla según sea necesario.
            this.notasTableAdapter.Notas(this.db_academicaDataSet.notas);

            actualizarGrid();
        }

        private void cboMateria_SelectedValueChanged(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int nFilas = dnotasDataGridView.Rows.Count;
            for (int i = 0; i < nFilas; i++)
            {
                double lab1 = 0, lab2 = 0, parcial = 0;
                int idDetalle = int.Parse(dnotasDataGridView.Rows[i].Cells["idDetalle"]?.Value?.ToString() ?? "0");

                lab1 = double.Parse(dnotasDataGridView.Rows[i].Cells["lab1"]?.Value?.ToString() ?? "0");
                lab2 = double.Parse(dnotasDataGridView.Rows[i].Cells["lab2"]?.Value?.ToString() ?? "0");
                parcial = double.Parse(dnotasDataGridView.Rows[i].Cells["parcial"]?.Value?.ToString() ?? "0");

                string sql = "UPDATE dnotas SET lab1='" + lab1 + "', lab2='" + lab2 + "', parcial='" + parcial +
                    "' WHERE idDetalle='" + idDetalle + "'";
                String resp = objConexion.ejecutarSQL(sql);
                if (resp != "1")
                {
                    MessageBox.Show(resp, "Error al actualizar notas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                actualizarGrid();
            }
            
        }

        private void cboPeriodos_SelectedValueChanged(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }

        private void cboMateria_SelectedValueChanged_1(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void cboPeriodos_SelectedValueChanged_1(object sender, EventArgs e)
        {
            actualizarGrid();
        }
    }
    }

