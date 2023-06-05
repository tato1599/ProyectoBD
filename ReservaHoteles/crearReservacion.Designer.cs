namespace ReservaHoteles
{
    partial class crearReservacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtp_fechaCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechaCheckOut = new System.Windows.Forms.DateTimePicker();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.tb_hotel = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_habitacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_precio = new System.Windows.Forms.TextBox();
            this.tb_capacidad = new System.Windows.Forms.TextBox();
            this.tb_tipo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtp_fechaCheckIn
            // 
            this.dtp_fechaCheckIn.Location = new System.Drawing.Point(117, 41);
            this.dtp_fechaCheckIn.Name = "dtp_fechaCheckIn";
            this.dtp_fechaCheckIn.Size = new System.Drawing.Size(229, 23);
            this.dtp_fechaCheckIn.TabIndex = 0;
            // 
            // dtp_fechaCheckOut
            // 
            this.dtp_fechaCheckOut.Location = new System.Drawing.Point(117, 86);
            this.dtp_fechaCheckOut.Name = "dtp_fechaCheckOut";
            this.dtp_fechaCheckOut.Size = new System.Drawing.Size(229, 23);
            this.dtp_fechaCheckOut.TabIndex = 1;
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Location = new System.Drawing.Point(117, 135);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(121, 23);
            this.cb_estado.TabIndex = 2;
            // 
            // tb_cliente
            // 
            this.tb_cliente.Location = new System.Drawing.Point(117, 184);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.Size = new System.Drawing.Size(200, 23);
            this.tb_cliente.TabIndex = 3;
            // 
            // tb_hotel
            // 
            this.tb_hotel.Location = new System.Drawing.Point(117, 232);
            this.tb_hotel.Name = "tb_hotel";
            this.tb_hotel.Size = new System.Drawing.Size(200, 23);
            this.tb_hotel.TabIndex = 4;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(38, 470);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(242, 470);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(75, 23);
            this.btn_regresar.TabIndex = 6;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha check-in";
            // 
            // tb_habitacion
            // 
            this.tb_habitacion.FormattingEnabled = true;
            this.tb_habitacion.Location = new System.Drawing.Point(117, 280);
            this.tb_habitacion.Name = "tb_habitacion";
            this.tb_habitacion.Size = new System.Drawing.Size(121, 23);
            this.tb_habitacion.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Capacidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha check-out";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Hotel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Habitacion";
            // 
            // tb_precio
            // 
            this.tb_precio.Location = new System.Drawing.Point(25, 366);
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.Size = new System.Drawing.Size(80, 23);
            this.tb_precio.TabIndex = 17;
            // 
            // tb_capacidad
            // 
            this.tb_capacidad.Location = new System.Drawing.Point(134, 366);
            this.tb_capacidad.Name = "tb_capacidad";
            this.tb_capacidad.Size = new System.Drawing.Size(86, 23);
            this.tb_capacidad.TabIndex = 18;
            // 
            // tb_tipo
            // 
            this.tb_tipo.Location = new System.Drawing.Point(260, 366);
            this.tb_tipo.Name = "tb_tipo";
            this.tb_tipo.Size = new System.Drawing.Size(86, 23);
            this.tb_tipo.TabIndex = 19;
            // 
            // crearReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 544);
            this.Controls.Add(this.tb_tipo);
            this.Controls.Add(this.tb_capacidad);
            this.Controls.Add(this.tb_precio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_habitacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.tb_hotel);
            this.Controls.Add(this.tb_cliente);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.dtp_fechaCheckOut);
            this.Controls.Add(this.dtp_fechaCheckIn);
            this.Name = "crearReservacion";
            this.Text = "Crear Reservacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtp_fechaCheckIn;
        private DateTimePicker dtp_fechaCheckOut;
        private ComboBox cb_estado;
        private TextBox tb_cliente;
        private TextBox tb_hotel;
        private Button btn_guardar;
        private Button btn_regresar;
        private Label label1;
        private ComboBox tb_habitacion;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tb_precio;
        private TextBox tb_capacidad;
        private TextBox tb_tipo;
    }
}