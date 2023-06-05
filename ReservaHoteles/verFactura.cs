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
    public partial class verFactura : Form
    {
        public verFactura()
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

        private void verFactura_Load(object sender, EventArgs e)
        {
            //agregar columnas al dgv
            dgv_verFacturas.Columns.Add("factura_id", "ID");
            dgv_verFacturas.Columns.Add("reserva_id", "Reserva_id");
            dgv_verFacturas.Columns.Add("fecha_emision", "Fecha_Emision");
            dgv_verFacturas.Columns.Add("total_pago", "Total");

            //llenar dgv con datos de la base de datos
            string con = conexion.getConexion();
            string query = "SELECT * FROM factura";
            MySqlConnection conexiondb = new MySqlConnection(con);
            MySqlCommand comando = new MySqlCommand(query, conexiondb);
            MySqlDataReader reader;
            conexiondb.Open();
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                dgv_verFacturas.Rows.Add(reader.GetString("factura_id"), reader.GetString("reserva_id"), reader.GetString("fecha_emision"), reader.GetString("total_pago"));
            }



        }
    }
}
