using MySql.Data.MySqlClient;

namespace ReservaHoteles
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string con = conexion.getConexion();
            
            string user = tb_user.Text;
            string pass = tb_pass.Text;

            //verificar en l abase de datos si existe el usuario y la contraseña
            //si existe, abrir el formulario de reservaciones
            //si no existe, mostrar mensaje de error

            string query = "SELECT * FROM users WHERE user_name = '" + user + "' AND user_password = '" + pass + "'";
            MySqlConnection conexiondb = new MySqlConnection(con);
            MySqlCommand comando = new MySqlCommand(query, conexiondb);
            MySqlDataReader reader;
            conexiondb.Open();
            reader = comando.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                MessageBox.Show("Usuario y contraseña correctos");
                this.Hide();
                menuPrincipal menu = new menuPrincipal();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario y contraseña incorrectos");
            }


        }
    }
}