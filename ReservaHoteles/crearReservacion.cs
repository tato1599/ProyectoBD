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
    public partial class crearReservacion : Form
    {
        public static int dias;
        public crearReservacion()
        {
            InitializeComponent();
            ConfigurarAutocompletado();
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
            string con = conexion.getConexion();

            //obtener fecha check in de dtp_fechaCheckIn
            DateTime fechaCheckIn = dtp_fechaCheckIn.Value;
            //obtener fecha check out de dtp_fechaCheckOut
            DateTime fechaCheckOut = dtp_fechaCheckOut.Value;

            
            //obtener id de cliente de txt_idCliente
            string idCliente = tb_cliente.Text;
            //obtener id de habitacion de txt_idHabitacion
            string idHabitacion = tb_habitacion.Text;
            //obtener id de hotel de txt_idHotel
            string idHotel = tb_hotel.Text;
            //obtener estado de la reservacion de cmb_estadoReservacion
            string estadoReservacion = cb_estado.Text;

            //obtener id de habitacion de txt_idHabitacion
            string query = "INSERT INTO reserva (cliente_id, habitacion_id, estado, fecha_check_in, fecha_check_out) VALUES ('" + idCliente + "', '" + idHabitacion + "', '" + estadoReservacion + "', '" + fechaCheckIn.ToString("yyyy-MM-dd") + "', '" + fechaCheckOut.ToString("yyyy-MM-dd") + "');";
            MySqlConnection conexiondb = new MySqlConnection(con);
            MySqlCommand comando = new MySqlCommand(query, conexiondb);

            //verificar si el id del cliente existe en la bae de datos\
            string query2 = "SELECT cliente_id FROM cliente WHERE cliente_id = '" + idCliente + "';";
            MySqlCommand comando2 = new MySqlCommand(query2, conexiondb);
            try
            {
                conexiondb.Open();
                MySqlDataReader reader = comando2.ExecuteReader();
                if (!reader.HasRows)
                {
                    MessageBox.Show("El id del cliente no existe");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiondb.Close();
            }
            


            try
            {
                conexiondb.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Reservación agregada exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiondb.Close();
            }
            

            
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            //regresar al menu principal
            this.Hide();
            menuPrincipal menuPrincipal = new menuPrincipal();
            menuPrincipal.Show();

        }

        private void tb_hotel_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tb_hotel_Leave(object sender, EventArgs e)
        {
            //combobox en blanco 
            tb_habitacion.Text = "";

            //crear  lista null para las habitaciones
            List<string> habitaciones = new List<string>();

            //llenar combobox con habitaciones disponibles del hotel seleccionado en el textbox tb_hotel
            string con = conexion.getConexion();
            string query = "SELECT habitacion_id FROM habitacion WHERE hotel_id = (SELECT hotel_id FROM hotel WHERE nombre = '" + tb_hotel.Text + "');";
            MySqlConnection conexiondb = new MySqlConnection(con);
            MySqlCommand comando = new MySqlCommand(query, conexiondb);
            try
            {
                conexiondb.Open();
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    string idHabitacion = reader.GetString("habitacion_id");
                    //llenar lista de habitaciones
                    habitaciones.Add(idHabitacion);
                }
                //llenar combobox con lista de habitaciones
                tb_habitacion.DataSource = habitaciones;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiondb.Close();
            }
        }

        private void tb_habitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //llenar tb_precio con el precio de la habitacion seleccionada en el combobox tb_habitacion tambien tb_capacidad con la capacidad de la habitacion seleccionada en el combobox tb_habitacion y tb_tipo con el tipo de la habitacion seleccionada en el combobox tb_habitacion
            string con = conexion.getConexion();
            string query = "SELECT precio_noche, capacidad, tipo FROM habitacion WHERE habitacion_id = '" + tb_habitacion.Text + "';";
            MySqlConnection conexiondb = new MySqlConnection(con);
            MySqlCommand comando = new MySqlCommand(query, conexiondb);
            try
            {
                conexiondb.Open();
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    string precio = reader.GetString("precio_noche");
                    string capacidad = reader.GetString("capacidad");
                    string tipo = reader.GetString("tipo");
                    //llenar tb_precio con el precio de la habitacion seleccionada en el combobox tb_habitacion
                    tb_precio.Text = precio;
                    //llenar tb_capacidad con la capacidad de la habitacion seleccionada en el combobox tb_habitacion
                    tb_capacidad.Text = capacidad;
                    //llenar tb_tipo con el tipo de la habitacion seleccionada en el combobox tb_habitacion
                    tb_tipo.Text = tipo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiondb.Close();
            }
        }

        private void crearReservacion_Load(object sender, EventArgs e)
        {

        }
    }
}
