using MySql.Data.MySqlClient;
using System;
using System.Buffers.Text;
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
    public partial class verHotel : Form
    {
        public verHotel()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            //regresar al menu principal
            this.Hide();
            menuPrincipal menuPrincipal = new menuPrincipal();
            menuPrincipal.Show();
        }

        private void dgv_hoteles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void verHotel_Load(object sender, EventArgs e)
        {

            // Crear columna de imagen
            DataGridViewImageColumn columnaImagen = new DataGridViewImageColumn();
            columnaImagen.HeaderText = "Imagen";
            columnaImagen.Name = "Imagen";
            dgv_hoteles.ColumnCount = 6;
            dgv_hoteles.Columns[0].Name = "ID";
            dgv_hoteles.Columns[1].Name = "Nombre";
            dgv_hoteles.Columns[2].Name = "Direccion";
            dgv_hoteles.Columns[3].Name = "Telefono";
            dgv_hoteles.Columns[4].Name = "Categoria";
            dgv_hoteles.Columns[5].Name = "Descripcion";

            dgv_hoteles.Columns.Add(columnaImagen);

            string con = conexion.getConexion();
            string query = "SELECT * FROM hotel";
            MySqlConnection conexiondb = new MySqlConnection(con);
            MySqlCommand comando = new MySqlCommand(query, conexiondb);
            MySqlDataReader reader;
            conexiondb.Open();
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                string id = reader.GetString("hotel_id");
                string nombre = reader.GetString("nombre");
                string direccion = reader.GetString("direccion");
                string telefono = reader.GetString("telefono");
                string categoria = reader.GetString("categoria");
                string descripcion = reader.GetString("descripcion");
                byte[] imagenBytes = (byte[])reader["imagen"];

                // Convertir de bytes a imagen
                using (MemoryStream ms = new MemoryStream(imagenBytes))
                {
                    Image imagen = Image.FromStream(ms);
                    dgv_hoteles.Rows.Add(id, nombre, direccion, telefono, categoria, descripcion, imagen);
                }
            }

            
            // Ajustar el ancho de las filas
            foreach (DataGridViewRow fila in dgv_hoteles.Rows)
            {
                fila.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Permitir envoltura de texto en la celda
                fila.Height = 60; // Establecer la altura deseada para las filas
            }

           ((DataGridViewImageColumn)dgv_hoteles.Columns["Imagen"]).ImageLayout = DataGridViewImageCellLayout.Stretch;

        }
    }
}
