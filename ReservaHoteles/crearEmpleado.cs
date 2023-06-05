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
    public partial class crearEmpleado : Form
    {
        //lista de puestos
        List<string> puestos = new List<string>() { "Recepcionista", "Gerente", "Cocinero", "Botones", "Mozo", "Limpieza" };
        public crearEmpleado()
        {
            InitializeComponent();
            ConfigurarAutocompletado();
            cb_puesto.DataSource = puestos;
        }

        

        private List<string> ObtenerNombresDeHotelesDesdeBaseDeDatos()
        {
            List<string> nombresHoteles = new List<string>();

            string con = conexion.getConexion();
            string query = "SELECT nombre FROM hotel";

            using (MySqlConnection conexiondb = new MySqlConnection(con))
            {
                using (MySqlCommand comando = new MySqlCommand(query, conexiondb))
                {
                    conexiondb.Open();

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombreHotel = reader.GetString("nombre");
                            nombresHoteles.Add(nombreHotel);
                        }
                    }
                }
            }

            return nombresHoteles;
        }


        private void ConfigurarAutocompletado()
        {
            tb_hotel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tb_hotel.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection source = new AutoCompleteStringCollection();

            // Supongamos que tienes una lista de nombres de hoteles llamada "nombresHoteles"
            List<string> nombresHoteles = ObtenerNombresDeHotelesDesdeBaseDeDatos(); // Función para obtener los nombres de los hoteles

            source.AddRange(nombresHoteles.ToArray());

            tb_hotel.AutoCompleteCustomSource = source;
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //validar campos
            if (tb_nombre.Text == "" || tb_direccion.Text == "" || tb_telefono.Text == "" || tb_hotel.Text == "" || cb_puesto.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }
            //validar telefono
            if (tb_telefono.Text.Length != 10)
            {
                MessageBox.Show("El telefono debe tener 10 digitos");
                return;
            }
            //validar que no se ingresen numeros en el nombre
            if (tb_nombre.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El nombre no puede contener numeros");
                return;
            }
            //validar que no se ingresen letras en el telefono
            if (tb_telefono.Text.Any(char.IsLetter))
            {
                MessageBox.Show("El telefono no puede contener letras");
                return;
            }



            //obtener id a partir del nombre del hotel
            string con = conexion.getConexion();
            string query = "SELECT hotel_id FROM hotel WHERE nombre = '" + tb_hotel.Text + "'";
            int idHotel = 0;

            using (MySqlConnection conexiondb = new MySqlConnection(con))
            {
                using (MySqlCommand comando = new MySqlCommand(query, conexiondb))
                {
                    conexiondb.Open();
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            idHotel = reader.GetInt32("hotel_id");
                        }
                    }
                }
            }

            //insertar empleado
            string query2 = "INSERT INTO empleado (nombre, direccion, telefono, puesto, hotel_id) VALUES ('" + tb_nombre.Text + "', '" + tb_direccion.Text + "', '" + tb_telefono.Text + "', '" + cb_puesto.Text + "', '" + idHotel + "')";
            MySqlConnection conexiondb2 = new MySqlConnection(con);
            conexiondb2.Open();
            MySqlCommand comando2 = new MySqlCommand(query2, conexiondb2);
            comando2.ExecuteNonQuery();
            conexiondb2.Close();
                
            //limpiar campos
            tb_nombre.Text = "";
            tb_direccion.Text = "";
            tb_telefono.Text = "";
            tb_hotel.Text = "";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //abrir ventana menu principal
            this.Hide();
            menuPrincipal menuPrincipal = new menuPrincipal();
            menuPrincipal.Show();

        }
    }
}
