using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaHoteles
{
    public partial class verHabitacion : Form
    {
        public verHabitacion()
        {
            InitializeComponent();
        }

        private void verHabitacion_Load(object sender, EventArgs e)
        {

            // Crear columna de imagen
            DataGridViewImageColumn columnaImagen = new DataGridViewImageColumn();
            columnaImagen.HeaderText = "Imagen";
            columnaImagen.Name = "Imagen";
            dgv_habitacion.ColumnCount = 5;
            dgv_habitacion.Columns[0].Name = "ID";
            dgv_habitacion.Columns[1].Name = "Hotel";
            dgv_habitacion.Columns[2].Name = "Tipo";
            dgv_habitacion.Columns[3].Name = "Capacidad";
            dgv_habitacion.Columns[4].Name = "Precio por noche";

            dgv_habitacion.Columns.Add(columnaImagen);

            string con = conexion.getConexion();
            string query = "SELECT * FROM habitacion";
            MySqlConnection conexiondb = new MySqlConnection(con);
            MySqlCommand comando = new MySqlCommand(query, conexiondb);
            MySqlDataReader reader;
            conexiondb.Open();
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                string id = reader.GetString("habitacion_id");
                string nombre = reader.GetString("hotel_id");
                string direccion = reader.GetString("tipo");
                string telefono = reader.GetString("capacidad");
                string categoria = reader.GetString("precio_noche");
                byte[] imagenBytes = (byte[])reader["imagen"];

                // Convertir de bytes a imagen
                using (MemoryStream ms = new MemoryStream(imagenBytes))
                {
                    Image imagen = Image.FromStream(ms);
                    dgv_habitacion.Rows.Add(id, nombre, direccion, telefono, categoria, imagen);
                }
            }


            // Ajustar el ancho de las filas
            foreach (DataGridViewRow fila in dgv_habitacion.Rows)
            {
                fila.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Permitir envoltura de texto en la celda
                fila.Height = 60; // Establecer la altura deseada para las filas
            }

           ((DataGridViewImageColumn)dgv_habitacion.Columns["Imagen"]).ImageLayout = DataGridViewImageCellLayout.Stretch;


        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            //regresar al menu principal
            this.Hide();
            menuPrincipal menuPrincipal = new menuPrincipal();
            menuPrincipal.Show();
        }
    }
}
