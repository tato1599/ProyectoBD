using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaHoteles
{
    public partial class crearHabitacion : Form
    {
        byte[] imagenBytes = null;
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
        public crearHabitacion()
        {
            InitializeComponent();
            ConfigurarAutocompletado();
        }
        public Image ComprimirImagen(Image imagenOriginal)
        {
            // Establecer la calidad de compresión deseada
            Byte calidadDeseada = 004; // En KB

            // Obtener el códec de compresión JPEG
            ImageCodecInfo jpegCodec = GetImageEncoderInfo(ImageFormat.Jpeg);

            // Establecer los parámetros de compresión
            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, calidadDeseada);

            // Crear una nueva imagen con la calidad de compresión reducida
            Image imagenComprimida = new Bitmap(imagenOriginal);



            return imagenComprimida;
        }

        private ImageCodecInfo GetImageEncoderInfo(ImageFormat formato)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == formato.Guid)
                {
                    return codec;
                }
            }
            return null;
        }


        private void btn_regresar_Click(object sender, EventArgs e)
        {
            //regresar al menuPrincipal
            this.Hide();
            menuPrincipal menu = new menuPrincipal();
            menu.Show();

        }

        private void pb_imagen_Click(object sender, EventArgs e)
        {

            //abrir open file dialog
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            //si se selecciona una imagen
            if (open.ShowDialog() == DialogResult.OK)
            {
                //mostrar imagen en picture box
                pb_imagen.Image = new Bitmap(open.FileName);

                //obtener ruta de la imagen
                string ruta = open.FileName;

                //obtener tamaño de la imagen
                FileInfo file = new FileInfo(ruta);
                long size = file.Length;
                //si el tamaño de la imagen es mayor a 650 kb
                if (size > 650000)
                {
                    //mostrar mensaje de error
                    MessageBox.Show("La imagen no puede exceder los 650 kb");
                    //limpiar picture box
                    pb_imagen.Image = null;
                }
                else
                {

                    // Si el tamaño de la imagen es menor a 650 kb
                    // Comprimir imagen
                    Image imagenComprimida = ComprimirImagen(pb_imagen.Image);

                    // Convertir la imagen comprimida a bytes

                    using (MemoryStream ms = new MemoryStream())
                    {
                        imagenComprimida.Save(ms, ImageFormat.Jpeg); // Guardar como JPEG
                        imagenBytes = ms.ToArray();
                    }
                    //obtener blob de la imagen

                    //guardar binario en la base de datos
                    //...
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //obtener id a partir del nombre del hotel
            string con = conexion.getConexion();
            string query = "SELECT hotel_id FROM hotel WHERE nombre = '" + tb_hotel.Text + "'";
            int idHotel = 0;

            using (MySqlConnection conexiondb2 = new MySqlConnection(con))
            {
                using (MySqlCommand comando2 = new MySqlCommand(query, conexiondb2))
                {
                    conexiondb2.Open();
                    using (MySqlDataReader reader2 = comando2.ExecuteReader())
                    {
                        while (reader2.Read())
                        {
                            idHotel = reader2.GetInt32("hotel_id");
                        }
                    }
                }
            }
            
            string con2 = conexion.getConexion();
            
            string tipo = tb_tipo.Text;
            int capacidad = int.Parse(nud_capacidad.Text);
            double precio = double.Parse(tb_precio.Text);


            //insertar datos ne la base de datos
            string query2 = "INSERT INTO habitacion (tipo, capacidad, precio_noche, hotel_id, imagen) VALUES (@tipo , @capacidad, @precio_noche, @hotel_id, @imagen )";
            MySqlConnection conexiondb = new MySqlConnection(con);
            MySqlCommand comando = new MySqlCommand(query2, conexiondb);
            comando.Parameters.AddWithValue("@tipo", tipo);
            comando.Parameters.AddWithValue("@capacidad", capacidad);
            comando.Parameters.AddWithValue("@precio_noche", precio);
            comando.Parameters.AddWithValue("@hotel_id", idHotel);
            comando.Parameters.AddWithValue("@imagen", imagenBytes);
            conexiondb.Open();
            comando.ExecuteNonQuery();


            //mostrar mensaje de confirmación
            MessageBox.Show("Hotel guardado con éxito");
            //limpiar campos
            tb_tipo.Text = "";
            tb_hotel.Text = "";
            tb_precio.Text = "";
            pb_imagen.Image = null;

            conexiondb.Close();
            
        }
            
            

            
        }
    }

