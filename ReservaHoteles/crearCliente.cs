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
    public partial class crearCliente : Form
    {
        public crearCliente()
        {
            InitializeComponent();
        }

        private void crearCliente_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string con = conexion.getConexion();
            string nombre = tb_nombre.Text;
            string telefono = tb_telefono.Text;
            string correo = tb_correo.Text;
            string direccion = tb_direccion.Text;

            //validar datos vacios 
            if (nombre == "" || telefono == "" || correo == "" || direccion == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            }
           
            //validar que el correo sea valido
            if (!correo.Contains("@"))
            {
                MessageBox.Show("El correo debe ser valido");
                return;
            }
            //validar que no se pongan numeros en el nombre
            if (nombre.Any(char.IsDigit))
            {
                MessageBox.Show("El nombre no debe contener numeros");
                return;
            }
            
            

            //insertar en la base de datos
            string query = "INSERT INTO cliente (nombre, telefono, direccion ,correo) VALUES ('" + nombre + "', '" + telefono + "', '" + direccion + "', '" + correo + "')";
            MySqlConnection conexiondb = new MySqlConnection(con);
            MySqlCommand comando = new MySqlCommand(query, conexiondb);
            MySqlDataReader reader;
            conexiondb.Open();
            reader = comando.ExecuteReader();
            MessageBox.Show("Cliente creado correctamente");

            //limpiar los textbox
            tb_nombre.Text = "";
            tb_telefono.Text = "";
            tb_correo.Text = "";
            tb_direccion.Text = "";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //regresar al menuPrincipal
            this.Hide();
            menuPrincipal menu = new menuPrincipal();
            menu.Show();

        }
    }
}
