namespace ReservaHoteles
{
    partial class crearEmpleado
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_telefono = new System.Windows.Forms.TextBox();
            this.tb_direccion = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cb_puesto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_hotel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 69;
            this.label4.Text = "Puesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 68;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 67;
            this.label2.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 66;
            this.label1.Text = "Nombre";
            // 
            // tb_telefono
            // 
            this.tb_telefono.Location = new System.Drawing.Point(105, 105);
            this.tb_telefono.Name = "tb_telefono";
            this.tb_telefono.Size = new System.Drawing.Size(264, 23);
            this.tb_telefono.TabIndex = 64;
            // 
            // tb_direccion
            // 
            this.tb_direccion.Location = new System.Drawing.Point(105, 76);
            this.tb_direccion.Name = "tb_direccion";
            this.tb_direccion.Size = new System.Drawing.Size(264, 23);
            this.tb_direccion.TabIndex = 63;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(105, 47);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(264, 23);
            this.tb_nombre.TabIndex = 62;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 61;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(68, 241);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 60;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // cb_puesto
            // 
            this.cb_puesto.FormattingEnabled = true;
            this.cb_puesto.Location = new System.Drawing.Point(105, 139);
            this.cb_puesto.Name = "cb_puesto";
            this.cb_puesto.Size = new System.Drawing.Size(264, 23);
            this.cb_puesto.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 71;
            this.label5.Text = "Hotel";
            // 
            // tb_hotel
            // 
            this.tb_hotel.Location = new System.Drawing.Point(110, 184);
            this.tb_hotel.Name = "tb_hotel";
            this.tb_hotel.Size = new System.Drawing.Size(259, 23);
            this.tb_hotel.TabIndex = 72;
            // 
            // crearEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 301);
            this.Controls.Add(this.tb_hotel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_puesto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_telefono);
            this.Controls.Add(this.tb_direccion);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_guardar);
            this.Name = "crearEmpleado";
            this.Text = "crearEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_telefono;
        private TextBox tb_direccion;
        private TextBox tb_nombre;
        private Button button2;
        private Button btn_guardar;
        private ComboBox cb_puesto;
        private Label label5;
        private TextBox tb_hotel;
    }
}