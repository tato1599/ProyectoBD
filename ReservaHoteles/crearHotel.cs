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
    public partial class crearHotel : Form
    {
      
        List<string> list = new List<string>();
        byte[] imagen = null;
        byte[] imagenBytes = null;
        public crearHotel()
        {
            InitializeComponent();
            list.Add("1 estrella");
            list.Add("2 estrellas");
            list.Add("3 estrellas");
            list.Add("4 estrellas");
            list.Add("5 estrellas");
            cb_categoria.DataSource = list;

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

            private void btn_guardar_Click(object sender, EventArgs e)
        {
            //guardar en la base datos los datos del hotel y la imagen
            string con = conexion.getConexion();
            
            //obtener datos del formulario
            string nombre = tb_nombre.Text;
            string direccion = tb_direccion.Text;
            string telefono = tb_telefono.Text;
            string categoria = cb_categoria.SelectedItem.ToString();
            string descripcion = tb_descripcion.Text;
            //guardar datos en la base de datos
            string query = "INSERT INTO hotel (nombre, direccion, telefono, categoria, descripcion, imagen) VALUES (@nombre, @direccion, @telefono, @categoria, @descripcion, @imagen)";

            MySqlConnection conexiondb = new MySqlConnection(con);
            MySqlCommand comando = new MySqlCommand(query, conexiondb);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@imagen", imagenBytes);
            conexiondb.Open();
            comando.ExecuteNonQuery();


            //mostrar mensaje de confirmación
            MessageBox.Show("Hotel guardado con éxito");
            //limpiar campos
            tb_nombre.Text = "";
            tb_direccion.Text = "";
            tb_telefono.Text = "";
            cb_categoria.SelectedIndex = 0;
            tb_descripcion.Text = "";
            pb_imagen.Image = null;
            

        }

        private void pb_imagen_Click(object sender, EventArgs e)
        {
            //abrir open file dialopg para seleccionar una imagen que no exceda los 650 kb y que sea jpg, png o gif, sacar el binario y guardarlo en la base de datos


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

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            //regresar al menú principal
            this.Hide();
            menuPrincipal menu = new menuPrincipal();
            menu.Show();
        }
    }
}
