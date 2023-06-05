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
    public partial class verReservacion : Form
    {
        public verReservacion()
        {
            InitializeComponent();
        }

        private void verReservacion_Load(object sender, EventArgs e)
        {
            //agregar columnas al dgv\
            dgv_verReservaciones.ColumnCount = 4;
            dgv_verReservaciones.Columns[0].Name = "Fecha de Inicio";
            dgv_verReservaciones.Columns[1].Name = "Fecha de Finalizacion";
            dgv_verReservaciones.Columns[2].Name = "Cliente";
            dgv_verReservaciones.Columns[3].Name = "Habitacion";


            
            string con = conexion.getConexion();
            string query = "SELECT * FROM reserva";
            MySqlConnection conexiondb = new MySqlConnection(con);
            MySqlCommand comando = new MySqlCommand(query, conexiondb);
            MySqlDataReader reader;
            conexiondb.Open();
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                string fechaInicio = reader.GetString("fecha_check_in");
                string fechaFinal = reader.GetString("fecha_check_out");
                string cliente = reader.GetString("cliente_id");
                string habitacion = reader.GetString("habitacion_id");
                dgv_verReservaciones.Rows.Add(fechaInicio, fechaFinal, cliente, habitacion);
            }





        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            //regresar al menuPrincipal
            this.Hide();
            menuPrincipal menu = new menuPrincipal();
            menu.Show();
            
        }
    }
}
