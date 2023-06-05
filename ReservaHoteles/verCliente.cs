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

        private void dgv_verClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            //validar que no se dejen campos vacios al editar un cliente
            int fila = dgv_verClientes.CurrentRow.Index;
            if (fila >= 0)
            {
                if (dgv_verClientes.CurrentRow.Cells[1].Value.ToString() == "" || dgv_verClientes.CurrentRow.Cells[2].Value.ToString() == "" || dgv_verClientes.CurrentRow.Cells[3].Value.ToString() == "" || dgv_verClientes.CurrentRow.Cells[4].Value.ToString() == "")
                {
                    MessageBox.Show("No se pueden dejar campos vacios");
                }
                if (dgv_verClientes.CurrentRow.Cells[3].Value.ToString().Length != 10)
                {
                    MessageBox.Show("El telefono debe tener 10 digitos");
                }
                if (dgv_verClientes.CurrentRow.Cells[4].Value.ToString().Contains("@") == false)
                {
                    MessageBox.Show("El correo debe contener un @");
                }
                if (dgv_verClientes.CurrentRow.Cells[4].Value.ToString().Contains(".com") == false)
                {
                    MessageBox.Show("El correo debe contener .com");
                }
                //validar que en el nombre no se ingresen numeros
                if (dgv_verClientes.CurrentRow.Cells[1].Value.ToString().Any(char.IsDigit))
                {
                    MessageBox.Show("El nombre no debe contener numeros");
                }
                else
                {
                    //editar los datos cambiados en el dgv y actualizarlos en la base de datos
                    string con = conexion.getConexion();
                    string query = "UPDATE cliente SET nombre = @nombre, direccion = @direccion, telefono = @telefono, correo = @correo WHERE cliente_id = @id";
                    MySqlConnection conexiondb = new MySqlConnection(con);
                    MySqlCommand comando = new MySqlCommand(query, conexiondb);
                    comando.Parameters.AddWithValue("@id", dgv_verClientes.CurrentRow.Cells[0].Value.ToString());
                    comando.Parameters.AddWithValue("@nombre", dgv_verClientes.CurrentRow.Cells[1].Value.ToString());
                    comando.Parameters.AddWithValue("@direccion", dgv_verClientes.CurrentRow.Cells[2].Value.ToString());
                    comando.Parameters.AddWithValue("@telefono", dgv_verClientes.CurrentRow.Cells[3].Value.ToString());
                    comando.Parameters.AddWithValue("@correo", dgv_verClientes.CurrentRow.Cells[4].Value.ToString());
                    MySqlDataReader reader;
                    conexiondb.Open();
                    reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                    }
                    MessageBox.Show("Cliente actualizado");
                }
            }

          

        }
    }
}
