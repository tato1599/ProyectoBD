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
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_crearCliente_Click(object sender, EventArgs e)
        {
            //abrir ventana crearCliente
            this.Hide();
            crearCliente crearCliente = new crearCliente();
            crearCliente.Show();

        }

        private void btn_verCliente_Click(object sender, EventArgs e)
        {
            //abrir ventana ver cliente
            this.Hide();
            verCliente verCliente = new verCliente();
            verCliente.Show();
        }

        private void btn_crearEmpleado_Click(object sender, EventArgs e)
        {
            //abrir ventana crearEmpleado
            this.Hide();
            crearEmpleado crearEmpleado = new crearEmpleado();
            crearEmpleado.Show();

        }

        private void btn_verEmpleado_Click(object sender, EventArgs e)
        {
            //abrir ventana verEmpleado
            this.Hide();
            verEmpleado verEmpleado = new verEmpleado();
            verEmpleado.Show();
        }

        private void btn_crearFactura_Click(object sender, EventArgs e)
        {

        }

        private void btn_verFactura_Click(object sender, EventArgs e)
        {

        }

        private void btn_crearHabitacion_Click(object sender, EventArgs e)
        {
            //abrir ventana crearHabitacion
            this.Hide();
            crearHabitacion crearHabitacion = new crearHabitacion();
            crearHabitacion.Show();
        }

        private void btn_verHabitacion_Click(object sender, EventArgs e)
        {
            //abrir ventana verHabitacion
            this.Hide();
            verHabitacion verHabitacion = new verHabitacion();
            verHabitacion.Show();
        }


        private void btn_crearHotel_Click(object sender, EventArgs e)
        {
            //abrir ventana crearHotel
            this.Hide();
            crearHotel crearHotel = new crearHotel();
            crearHotel.Show();

        }

        private void btn_verHotel_Click(object sender, EventArgs e)
        {
            //abrir ventana verHotel
            this.Hide();
            verHotel verHotel = new verHotel();
            verHotel.Show();

        }

        private void btn_crearReserva_Click(object sender, EventArgs e)
        {

        }

        private void btn_verReserva_Click(object sender, EventArgs e)
        {

        }
    }
}
