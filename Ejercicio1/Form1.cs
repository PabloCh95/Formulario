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

namespace Ejercicio1
{

    public partial class DataTabla : Form
    {
        private int idClient;
        public DataTabla()
        {
            idClient = 0;
            InitializeComponent();
            reseteo();
        }
        private class Cliente
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Fecha_Nac { get; set; }
            public string Direccion { get; set; }
        }
        //Conexion a la base de datos
        SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-KDSB1AM\\SQLEXPRESS;Initial Catalog=Taller;Integrated Security=true;");
        //Campo de Texto de Nombre
        private void NombreText_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Campo de texto de fecha de nacimiento
        private void Fecha_De_Nacimiento_ValueChanged(object sender, EventArgs e)
        {

        }
        //Campo de texto de direccion
        private void DireccionText_TextChanged(object sender, EventArgs e)
        {

        }
        //Campo de texto de apellido
        private void ApellidoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            idClient = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            NombreText.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            ApellidoText.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);

            Fecha_De_Nacimiento.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
            DireccionText.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);

            GuardarBoton.Text = "Guardar";
        }
        //Boton de guardar
        private void GuardarBoton_Click(object sender, EventArgs e)
        {
            string strNombre, strApellido, strFechaNacimiento, strDireccion;
            strNombre = NombreText.Text;
            strApellido = ApellidoText.Text;
            strFechaNacimiento = Fecha_De_Nacimiento.Value.Year.ToString() + '/' + Fecha_De_Nacimiento.Value.Month.ToString() + '/' + Fecha_De_Nacimiento.Value.Day.ToString();
            strDireccion = DireccionText.Text;
            if (idClient.Equals(0)) 
            {
                List<Cliente> Cliente = new List<Cliente>();
                string Consulta = string.Format("Insert into clientes (Nombre,Apellido,Fecha_Nacimiento,Direccion)values ('{0}','{1}','{2}','{3}')",
                    strNombre,strApellido,strFechaNacimiento,strDireccion);
                SqlCommand comando = new SqlCommand(Consulta, conectar);
                conectar.Open();
                comando.ExecuteNonQuery();
                conectar.Close();

                MessageBox.Show("Cliente " + NombreText.Text + " " + ApellidoText.Text + " registrado con exito", "Registro Exitoso");

            }
            else 
            {

               string consulta = string.Format("Update clientes set Nombre = '{0}', Apellido =  '{1}' , Fecha_Nacimiento =  '{2}', Direccion = '{3}' where IDCliente =  '{4}'",
               strNombre, strApellido, strFechaNacimiento, strDireccion, idClient);

                SqlCommand comando = new SqlCommand(consulta, conectar);

                conectar.Open();
                comando.ExecuteNonQuery();
                conectar.Close();

                MessageBox.Show("Cliente " + NombreText.Text + " " + ApellidoText.Text + " modificado con exito", "Modificación Exitosa");

            }

            reseteo();
        }

        private void Boton_Eliminar_Click(object sender, EventArgs e)
        {
            if (idClient.Equals(0))
            {
                //No se selecciono ningun cliente
                MessageBox.Show("Seleccione un cliente", "Atención");
            }
            else
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    String consulta = "DELETE from clientes where IDCliente= '" + idClient + "'";
                    SqlCommand comando = new SqlCommand(consulta, conectar);

                    conectar.Open();
                    comando.ExecuteNonQuery();
                    conectar.Close();

                    reseteo();
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //METODOS
        public void reseteo()
        {
            NombreText.Text = "";
            ApellidoText.Text = "";
            Fecha_De_Nacimiento.Value = System.DateTime.Today;
            DireccionText.Text = "";
            idClient = 0;
            GuardarBoton.Text = "Guardar";

            mostrar();
        }
        private void mostrar()
        {
            List<Cliente> lista = new List<Cliente>();

            String consulta = "SELECT IDCliente, Nombre, Apellido, Fecha_Nacimiento, Direccion FROM clientes";
            SqlCommand comando = new SqlCommand(consulta, conectar);

            conectar.Open();
            SqlDataReader reader = comando.ExecuteReader(); //Se lee una unica vez

            while (reader.Read()) //Consulta la primer linea para leer
            {
                Cliente pCliente = new Cliente();
                pCliente.Id = reader.GetInt32(0);
                pCliente.Nombre = reader.GetString(1);
                pCliente.Apellido = reader.GetString(2);
                pCliente.Fecha_Nac = reader.GetString(3);
                pCliente.Direccion = reader.GetString(4);


                lista.Add(pCliente);
            }

            conectar.Close();
            dataGridView1.DataSource = lista;

        }
        
    }

}

