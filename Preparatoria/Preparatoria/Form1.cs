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

namespace Preparatoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            rBeliminar.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //este se usa para que un texbox se desabilite al momento de seleccionar un rabiobutton
            tB1.Enabled = false;
            textnombre.Enabled = true;
            textsemestre.Enabled = true;

        }


        private void btnaceptar_Click(object sender, EventArgs e)
        {
             if (rBagregar.Checked)
            {
                Conexion oConexion = new Conexion();

                List<SqlParameter> enviar = new List<SqlParameter>();

                SqlParameter Nombre = new SqlParameter()
                {
                    ParameterName = "nombreAlumno",
                    Value = textnombre.Text
                };
                enviar.Add(Nombre);
                SqlParameter semestre = new SqlParameter()
                {
                    ParameterName = "semestre",
                    Value = textsemestre.Text
                };
                enviar.Add(semestre);
                //oConexion.EjecutaNonQuery("AgregarAlumno", enviar);
                // 

                // Estas dos líneas me muestran todos los clientes
                //oConexion.EjecutaNonQuery("AgregarAlumno", enviar);

                dGV.DataSource = oConexion.ObtenerDatos("MostrartodoslosAlumnos");
            }
            // si elegimos BUSCAR
            if (rBbuscar.Checked)
            {
                string __Nombre = textnombre.Text;
                Conexion oConexion = new Conexion();
                // data.DataSource = oConexion.ObtenerDatos("mostrarTodosClientes");

                List<SqlParameter> enviar = new List<SqlParameter>();

                SqlParameter Nombre = new SqlParameter()
                {
                    ParameterName = "NombreAlumno",
                    Value = __Nombre 
                };
                enviar.Add(Nombre);                

                dGV.DataSource = oConexion.ObtenerDatosTodos("BuscarMatricula", enviar);
            }
            if (rBeliminar.Checked)
            {
                string __Nombre = textnombre.Text;
                Conexion oConexion = new Conexion();
                // data.DataSource = oConexion.ObtenerDatos("EliminarAlumno");

                string _Semestre = textsemestre.Text;
                //Conexion oConexion = new Conexion();
                // data.DataSource = oConexion. 
                List<SqlParameter> enviar = new List<SqlParameter>();

                SqlParameter Nombre = new SqlParameter()
                {
                    Value = __Nombre,
                    ParameterName = "nombreAlumno"
                };
                enviar.Add(Nombre);
                //row index es para obtener el valor del renglon seleccionado 
                /*MessageBox.Show(data[0, data.CurrentRow.Index].Value.ToString());
                enviar.Add(Nombre);*/
                SqlParameter Semestre = new SqlParameter()
                {
                    Value = _Semestre,
                    ParameterName = "semestre"//data[0, data.CurrentRow.Index].Value.ToString()
                };
                enviar.Add(Semestre);

                oConexion.EjecutaNonQuery("EliminarAlumno", enviar);
                dGV.DataSource = oConexion.ObtenerDatos("MostrartodoslosAlumnos");
                MessageBox.Show("Se ha eliminado correctamente");

                //dGV.(enviar);
            }
        }
         
        private void rBbuscar_CheckedChanged(object sender, EventArgs e)
        {
            tB1.Enabled = true;
            textnombre.Enabled = false;
            textsemestre.Enabled = false;

        }

        private void rBeliminar_CheckedChanged(object sender, EventArgs e)
        {
            Conexion oConexion = new Conexion();
            //dGV.DataSource = oConexion.ObtenerDatos.oConexion
            tB1.Enabled = true;
        }

        private void rBcalificaciones_CheckedChanged(object sender, EventArgs e)
        {
            tB1.Enabled = true;
        }

        private void rBbuscar_CheckedChanged_1(object sender, EventArgs e)
        {
            Conexion oConexion = new Conexion();            
     //       dGV.DataSource = oConexion.ObtenerDatos.oConexion
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
