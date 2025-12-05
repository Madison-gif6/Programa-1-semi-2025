using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Esta es la libreria que me permite usar comando para trabajar con Bases de Datos
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates; //Esta libreria me permite trabajar con SQL Server

namespace MiPrimerProyectoCsharp
{
    internal class Conexion_Base_Datos
    {
        //Definir los mienbros de la clase, atributos y metodos.
        public SqlConnection objConexion = new SqlConnection(); //Conectarme a la BD.
        public SqlCommand objComando = new SqlCommand(); //Ejecutar SQL en la BD. Lectura, Actualizacion, Eliminacion, Insercion.
        public SqlDataAdapter objAdaptador = new SqlDataAdapter(); //Un puente entre la BD y la aplicación
        DataSet objDs = new DataSet(); //Es una representación de la arquitectura de la BD en memoria.

        public Conexion_Base_Datos()
        { //Constructor. inicializador de los atributos
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); //Abrir la conexion a la BD
        }

        public DataSet obtenerDatos()
        {
            objDs.Clear(); //Limpiar el DataSet
            objComando.Connection = objConexion; //Establecer la conexion para ejecutar los comandos.

            objAdaptador.SelectCommand = objComando; //Establecer el comando de seleccion
            objComando.CommandText = "SELECT * FROM Materias";
            objAdaptador.Fill(objDs, "Materias");

            objComando.CommandText = "SELECT * FROM Docentes";
            objAdaptador.Fill(objDs, "Docentes");

            objComando.CommandText = "SELECT * FROM alumnos";
            objAdaptador.Fill(objDs, "alumnos");//Tomando los datos de la BD y llenando el DataSet

            objComando.CommandText = "SELECT * FROM usuarios";
            objAdaptador.Fill(objDs, "usuarios");//Tomando los datos de la BD y llenando el DataSet

            return objDs;
        }

        public string administrarDatosAlumnos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO alumnos(codigo,nombre,direccion,telefono) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE alumnos SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', direccion='" + datos[3] + "', telefono='" + datos[4] + "' WHERE idAlumno='" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM alumnos WHERE idAlumno='" + datos[0] + "'";
            }
            return ejecutarSQL(sql);
        }

        public string administrarDatosDocentes(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO docentes(nombre,apellido,especialidad,direccion,telefono) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "','" + datos[5] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE docentes SET nombre='" + datos[1] + "', apellido='" + datos[2] + "', especialidad='" + datos[3] + "', direccion='" + datos[4] + "', telefono='" + datos[5] + "' WHERE idAlumno='" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM docentes WHERE idDocnete='" + datos[0] + "'";
            }
            return ejecutarSQL(sql);
        }

        public string administrarDatosMaterias(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO materias(codigo,nombre,uv) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE materias SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', uv='" + datos[3] + "' WHERE idMateria='" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM materias WHERE idMateria='" + datos[0] + "'";
            }
            return ejecutarSQL(sql);
        }
        public string Mantenimiento_usuarios(String[] datos, String accion)  {
            String sql = "";
            if (accion == "nuevo") {
                sql = "INSERT INTO usuarios(usuario,clave,nombre,direccion,telefono) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "','" + datos[5] + "')";
            } else if (accion == "modificar")  {
                sql = "UPDATE usuarios SET usuario='" + datos[1] + "', clave='" + datos[2] + "', nombre='" + datos[3] + "', direccion='" + datos[4] + "', telefono='" + datos[5] + "' WHERE IdUsuario='" + datos[0] + "'";
            } else if (accion == "eliminar") {
                sql = "DELETE FROM usuarios WHERE IdUsuario='" + datos[0] + "'";
            }
            return ejecutarSQL(sql);
        }

        public String ejecutarSQL(String sql)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;
                return objComando.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int verificarCredenciales(String usuario, String clave) {
            try {

                objComando.CommandText = "SELECT COUNT(*) FROM usuarios WHERE usuario = @user AND clave = @pass";

                objComando.Parameters.Clear(); 
                objComando.Parameters.AddWithValue("@user", usuario);
                objComando.Parameters.AddWithValue("@pass", clave);
                objComando.Connection = objConexion;

                return (int)objComando.ExecuteScalar();
            }
            catch (Exception) {
                return 0; 
            }
        }
    }
    }




