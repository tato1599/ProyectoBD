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
    public partial class crearFactura : Form
    {
        public crearFactura()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            //regresar al menuPrincipal
            this.Hide();
            menuPrincipal menu = new menuPrincipal();
            menu.Show();

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            double precioNoche = 0;
            string con = conexion.getConexion();
            //buscar reserva por id de cliente
            string query = "SELECT * FROM reserva WHERE reserva_id = '" + tb_buscar.Text + "'";
            MySqlConnection conexiondb = new MySqlConnection(con);
            MySqlCommand comando = new MySqlCommand(query, conexiondb);
            MySqlDataReader reader;
            conexiondb.Open();
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                tb_habitacion.Text = reader.GetString("habitacion_id");
                //sacar diferencia de dias de fecha_check_in y fecha_check_out
                DateTime fecha1 = reader.GetDateTime("fecha_check_in");
                DateTime fecha2 = reader.GetDateTime("fecha_check_out");
                TimeSpan dif = fecha2 - fecha1;
                int dias = dif.Days;
                tb_noches.Text = dias.ToString();    
                //conusltar precio por noche de habitacion por su id en la base de datos
                string con2 = conexion.getConexion();
                string habitacionId = reader.GetString("habitacion_id");
                string query2 = "SELECT * FROM habitacion WHERE habitacion_id = '" + habitacionId + "'";
                MySqlConnection conexiondb2 = new MySqlConnection(con2);
                MySqlCommand comando2 = new MySqlCommand(query2, conexiondb2);
                MySqlDataReader reader2;
                conexiondb2.Open();
                reader2 = comando2.ExecuteReader();
                while (reader2.Read())
                {
                    precioNoche = reader2.GetDouble("precio_noche");
                }




                //multiplicar dias por precio de habitacion
                double precio = dias * precioNoche;
                tb_total.Text = precio.ToString();
                




            }
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            //guardar factura en base de datos
            string con = conexion.getConexion();
            string query = "INSERT INTO factura (reserva_id,fecha_emision,  total_pago) VALUES ('" + tb_buscar.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + tb_total.Text + "')";
            MySqlConnection conexiondb = new MySqlConnection(con);
            MySqlCommand comando = new MySqlCommand(query, conexiondb);
            MySqlDataReader reader;
            conexiondb.Open();
            reader = comando.ExecuteReader();
            MessageBox.Show("Factura generada");
            conexiondb.Close();


        }
    }
}
