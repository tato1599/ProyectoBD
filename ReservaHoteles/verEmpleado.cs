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
    public partial class verEmpleado : Form
    {
        public verEmpleado()
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

        private void verEmpleado_Load(object sender, EventArgs e)
        {
            //agregar columnas
            dgv_verEmpleado.ColumnCount = 6;
            dgv_verEmpleado.Columns[0].Name = "ID";
            dgv_verEmpleado.Columns[1].Name = "Nombre";
            dgv_verEmpleado.Columns[2].Name = "Telefono";
            dgv_verEmpleado.Columns[3].Name = "Puesto";
            dgv_verEmpleado.Columns[4].Name = "Direccion";
            dgv_verEmpleado.Columns[5].Name = "Hotel";


            string con = conexion.getConexion();
            string query = "SELECT * FROM empleado";
            MySqlConnection conexiondb = new MySqlConnection(con);
            MySqlCommand comando = new MySqlCommand(query, conexiondb);
            MySqlDataReader reader;
            conexiondb.Open();
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                string nombre = reader.GetString("nombre");
                string telefono = reader.GetString("telefono");
                string puesto = reader.GetString("puesto");
                string direccion = reader.GetString("direccion");
                string id = reader.GetString("empleado_id");
                string hotel_id = reader.GetString("hotel_id");
                
                //buscar nombre del hotel con el id
                string query2 = "SELECT nombre FROM hotel WHERE hotel_id = '" + hotel_id + "'";
                MySqlConnection conexiondb2 = new MySqlConnection(con);
                MySqlCommand comando2 = new MySqlCommand(query2, conexiondb2);
                MySqlDataReader reader2;
                conexiondb2.Open();
                reader2 = comando2.ExecuteReader();
                string hotel = "";
                while (reader2.Read())
                {
                    hotel = reader2.GetString("nombre");
                }
                

                dgv_verEmpleado.Rows.Add(id, nombre, direccion, telefono, puesto,hotel);
            }
            

        }
    }
}
