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
    public partial class verCliente : Form
    {
        public verCliente()
        {
            InitializeComponent();
        }

        private void verCliente_Load(object sender, EventArgs e)
        {
            //agregar columnas al dgv
            dgv_verClientes.ColumnCount = 5;
            dgv_verClientes.Columns[0].Name = "ID";
            dgv_verClientes.Columns[1].Name = "Nombre";
            dgv_verClientes.Columns[2].Name = "Direccion";
            dgv_verClientes.Columns[3].Name = "Telefono";
            dgv_verClientes.Columns[4].Name = "Correo";

            string con = conexion.getConexion();
            string query = "SELECT * FROM cliente";
            MySqlConnection conexiondb = new MySqlConnection(con);
            MySqlCommand comando = new MySqlCommand(query, conexiondb);
            MySqlDataReader reader;
            conexiondb.Open();
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                string nombre = reader.GetString("nombre");
                string telefono = reader.GetString("telefono");
                string correo = reader.GetString("correo");
                string direccion = reader.GetString("direccion");
                string id = reader.GetString("cliente_id");
                dgv_verClientes.Rows.Add(id, nombre, direccion, telefono, correo);
            }


        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            //regresar al menuPrincipal
            this.Hide();
            menuPrincipal menu = new menuPrincipal();
            menu.Show();

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            //seleccionar fila y eliminarla de la base de datos y del dgv 
            int fila = dgv_verClientes.CurrentRow.Index;
            if(fila >= 0) { 
            
            
            
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro de eliminar este cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo);
            
            
            if (dialogResult == DialogResult.Yes)
            {
                string con = conexion.getConexion();
                string query = "DELETE FROM cliente WHERE cliente_id = @id";
                MySqlConnection conexiondb = new MySqlConnection(con);
                MySqlCommand comando = new MySqlCommand(query, conexiondb);
                comando.Parameters.AddWithValue("@id", dgv_verClientes.CurrentRow.Cells[fila].Value.ToString());
                MySqlDataReader reader;
                conexiondb.Open();
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                }
                dgv_verClientes.Rows.RemoveAt(dgv_verClientes.CurrentRow.Index);
            }
            else if (dialogResult == DialogResult.No)
                {
                //do something else
                }
            }
        }
    }
}
